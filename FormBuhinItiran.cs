using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace SeisanKanri
{
    public partial class FormBuhinItiran : Form
    {

        private string constr = @Properties.Settings.Default.ConnectStr;

        private DataSet ds = new DataSet();
        private DataTable dtBuhin = new DataTable();

        public FormBuhinItiran()
        {
            InitializeComponent();
        }

        private string _strRefTokui;

        public string strRefTokui
        {
            get
            {
                return _strRefTokui;
            }
            set
            {
                _strRefTokui = value;
            }
        }

        private string _strRefSeihin;

        public string strRefSeihin
        {
            get
            {
                return _strRefSeihin;
            }
            set
            {
                _strRefSeihin = value;
            }
        }

        //製品コンボボックス初期化
        //得意先コードを基に絞り込んで表示
        private void ListIni()
        {
            //リスト全消去
            comboBoxSeihin.Items.Clear();

            string tokuListStr = "";

            if (comboBoxTokuisaki.SelectedIndex == -1)
            {
                return;
            }
            //リストの選択されているところから得意先コードを抽出
            tokuListStr = comboBoxTokuisaki.SelectedItem.ToString();
            string tokuCodeStr = tokuListStr.Substring(0, 13).Trim();

            //サーバーに接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                //接続成功
                //すべてのレコードをコード昇順で出力
                string sqlstr = "select * from 製品マスタ where 得意先コード = '" + tokuCodeStr + "' ORDER BY 製品コード";
                SqlCommand com = new SqlCommand(sqlstr, con);
                SqlDataReader sdr = com.ExecuteReader();

                //リスト表示
                while (sdr.Read() == true)
                {
                    //書式xxxxxxxxxxxxx : xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
                    string code = (string)sdr["製品コード"];
                    string name = (string)sdr["製品名"];

                    comboBoxSeihin.Items.Add(string.Format("{0:s} : {1:s}", code.PadRight(13), name));

                }

                //選択状態にする
                if (strRefSeihin != "")
                {
                    int cbi = comboBoxSeihin.FindString(strRefSeihin);
                    if (cbi != -1)
                    {
                        comboBoxSeihin.SelectedIndex = cbi;
                        strRefSeihin = "";
                    }
                }


            }
            finally
            {
                //サーバー切断
                con.Close();
            }

        }

        //選択した製品の部品一覧を表示
        private void RecordDisp(string scd)
        {
            //SQL文が空白なら処理しない
            if (scd != "")
            {
                //サーバー接続
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                try
                {

                    //データテーブル初期化
                    ds.Tables["部品マスタ"].Rows.Clear();

                    //テーブルへ行を追加

                    string meiSql = "SELECT 部品マスタ.*, 材種.名称 AS ZaisyuMei " + 
                        "FROM 部品マスタ LEFT OUTER JOIN 材種 ON 部品マスタ.材種 = 材種.ID "+
                        "WHERE 製品コード = " + scd + " ORDER BY 行番号";
                    SqlCommand comBuhin = new SqlCommand(meiSql, con);
                    SqlDataReader sdrBuhin = comBuhin.ExecuteReader();

                    while (sdrBuhin.Read())
                    {
                        DataRow row = ds.Tables["部品マスタ"].NewRow();

                        row["部品コード"] = (string)sdrBuhin["部品コード"];
                        row["製品コード"] = (string)sdrBuhin["製品コード"];
                        row["管理コード"] = (string)sdrBuhin["管理コード"];
                        row["使用対象"] = (string)sdrBuhin["使用対象"];
                        row["材種"] = (int)sdrBuhin["材種"];
                        row["材種名"] = (string)sdrBuhin["ZaisyuMei"];
                        row["厚さ"] = (double)sdrBuhin["厚さ"];
                        row["巾"] = (double)sdrBuhin["巾"];
                        row["長さ"] = (double)sdrBuhin["長さ"];
                        row["数量"] = (decimal)sdrBuhin["数量"];
                        row["摘要"] = (string)sdrBuhin["摘要"];
                        row["大井野FL"] = (bool)sdrBuhin["大井野FL"];
                        row["NCFL"] = (bool)sdrBuhin["NCFL"];
                        row["共通FL"] = (bool)sdrBuhin["共通FL"];
                        row["在庫FL"] = (bool)sdrBuhin["在庫FL"];
                        row["別納FL"] = (bool)sdrBuhin["別納FL"];

                        ds.Tables["部品マスタ"].Rows.Add(row);
                    }
                    
                    sdrBuhin.Close();

                }
                finally
                {
                    //サーバー切断
                    con.Close();
                }

            }
        }

        private string GetSeries(string scd)
        {
            string series = "";

            //コードが空白なら処理しない
            if (scd != "")
            {
                //サーバー接続
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                try
                {
                    //製品コードで検索
                    string sqlstr = "select * from 製品マスタ where 製品コード= " + scd;
                    SqlCommand com = new SqlCommand(sqlstr, con);
                    SqlDataReader sdr = com.ExecuteReader();

                    //見つかった場合のみ処理を行う
                    if (sdr.Read() == true)
                    {
                        series = (sdr["シリーズ"] == DBNull.Value ? "" : (string)sdr["シリーズ"]);
                    }
                }
                finally
                {
                    //サーバー切断
                    con.Close();
                }
            }
            return series;
        }


        private void FormBuhinMst2_Load(object sender, EventArgs e)
        {
            dtBuhin.TableName = "部品マスタ";
            dtBuhin.Columns.Add("製品コード");
            dtBuhin.Columns.Add("部品コード");
            dtBuhin.Columns.Add("管理コード");
            dtBuhin.Columns.Add("使用対象");
            dtBuhin.Columns.Add("材種", Type.GetType("System.Int32"));
            dtBuhin.Columns.Add("材種名");
            dtBuhin.Columns.Add("厚さ", Type.GetType("System.Double"));
            dtBuhin.Columns.Add("巾", Type.GetType("System.Double"));
            dtBuhin.Columns.Add("長さ", Type.GetType("System.Double"));
            dtBuhin.Columns.Add("数量", Type.GetType("System.Decimal"));
            dtBuhin.Columns.Add("摘要");
            dtBuhin.Columns.Add("大井野FL", Type.GetType("System.Boolean"));
            dtBuhin.Columns.Add("NCFL", Type.GetType("System.Boolean"));
            dtBuhin.Columns.Add("共通FL", Type.GetType("System.Boolean"));
            dtBuhin.Columns.Add("在庫FL", Type.GetType("System.Boolean"));
            dtBuhin.Columns.Add("別納FL", Type.GetType("System.Boolean"));

            ds.Tables.Add(dtBuhin);

            dataGridViewBuhin.AutoGenerateColumns = false;
            dataGridViewBuhin.DataSource = ds.Tables["部品マスタ"];
            dataGridViewBuhin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            toolSSLabelSeries.Text = "";

            //コンボボックスに得意先を設定する
            //リスト全消去
            comboBoxTokuisaki.Items.Clear();
            //サーバーに接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                //接続成功
                //すべてのレコードをコード昇順で出力
                string sqlstr = "select * from 得意先マスタ ORDER BY 得意先コード";
                SqlCommand com = new SqlCommand(sqlstr, con);
                SqlDataReader sdr = com.ExecuteReader();

                //リスト表示
                while (sdr.Read() == true)
                {
                    //書式xxxxxxxxxxxxx : xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
                    string code = (string)sdr["得意先コード"];
                    string name = (string)sdr["得意先名"];

                    comboBoxTokuisaki.Items.Add(string.Format("{0:s} : {1:s}", code.PadRight(13), name));

                }
                //非選択状態にする
                comboBoxTokuisaki.SelectedIndex = -1;
            }
            finally
            {
                //サーバー切断
                con.Close();
            }


            //選択状態にする
            if (strRefTokui != "")
            {
                int cbi = comboBoxTokuisaki.FindString(strRefTokui);
                if (cbi != -1)
                {
                    comboBoxTokuisaki.SelectedIndex = cbi;
                }
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            //得意先と製品が未選択ならなにもしない
            if (comboBoxTokuisaki.SelectedIndex == -1) return;
            if (comboBoxSeihin.SelectedIndex == -1) return;

            //新しい行番号を取得
            int rowCnt = 0;
            int rowNo;
            rowCnt = dataGridViewBuhin.BindingContext[dataGridViewBuhin.DataSource, dataGridViewBuhin.DataMember].Count;
            rowNo = rowCnt - 1;
            rowCnt++;

            FormBuhinMst2 frmBuhin2 = new FormBuhinMst2();

            //FormBuhinMst2のコンボボックス用のデータの準備
            frmBuhin2.材種TableAdapter.Fill(frmBuhin2.dataSetZaisyu.材種);

            //得意先
            frmBuhin2.labelTokuisakiCode.Text = (string)comboBoxTokuisaki.SelectedItem;
            //製品コード
            string scd;
            scd = comboBoxSeihin.SelectedItem.ToString();
            string SeihinCodeStr = Program.Left(scd,13).Trim();
            frmBuhin2.labelSeihinCode.Text = SeihinCodeStr;
            //製品名
            frmBuhin2.labelSeihinMei.Text = Program.Mid((string)comboBoxSeihin.SelectedItem, 17);
            //行番号
            frmBuhin2.labelNo.Text = rowCnt.ToString();
            //管理番号
            frmBuhin2.toolSSLabelKanriCode.Text = "";
            //シリーズ
            frmBuhin2.toolSSLabelSeries.Text = this.toolSSLabelSeries.Text;

            if (frmBuhin2.ShowDialog() == DialogResult.OK)
            {
                //得意先
                string tcd;
                tcd = comboBoxTokuisaki.SelectedItem.ToString();
                string TokuisakiCodeStr = Program.Left(tcd, 13).Trim();
                ds.Tables["部品マスタ"].Rows[rowNo]["部品コード"] = TokuisakiCodeStr;
                //製品コード
                ds.Tables["部品マスタ"].Rows[rowNo]["部品コード"] = SeihinCodeStr;
                //行番号
                ds.Tables["部品マスタ"].Rows[rowNo]["部品コード"] = rowCnt.ToString();
                //管理番号
                ds.Tables["部品マスタ"].Rows[rowNo]["部品コード"] = frmBuhin2.toolSSLabelKanriCode.Text;
                //シリーズ
                ds.Tables["部品マスタ"].Rows[rowNo]["部品コード"] = this.toolSSLabelSeries.Text;
                //部品コード
                ds.Tables["部品マスタ"].Rows[rowNo]["部品コード"] = frmBuhin2.textBoxBuhinCode.Text.Trim();
                //使用対象
                ds.Tables["部品マスタ"].Rows[rowNo]["使用対象"] = frmBuhin2.textBoxSiyoTaisyo.Text.Trim();
                //材種 
                ds.Tables["部品マスタ"].Rows[rowNo]["材種"] = frmBuhin2.comboBoxZaisyu.SelectedValue;
                //厚さ
                double thickness;
                ds.Tables["部品マスタ"].Rows[rowNo]["厚さ"] = (double.TryParse(frmBuhin2.textBoxThickness.Text, out thickness) ? thickness : 0);
                // 巾
                double width;
                ds.Tables["部品マスタ"].Rows[rowNo]["巾"] = (double.TryParse(frmBuhin2.textBoxWidth.Text, out width) ? width : 0);
                // 長さ
                double length;
                ds.Tables["部品マスタ"].Rows[rowNo]["長さ"] = (double.TryParse(frmBuhin2.textBoxLength.Text, out length) ? length : 0);
                // 数量
                decimal suryo;
                ds.Tables["部品マスタ"].Rows[rowNo]["数量"] = (decimal.TryParse(frmBuhin2.textBoxSuryo.Text, out suryo) ? suryo : 0);
                // 摘要
                ds.Tables["部品マスタ"].Rows[rowNo]["摘要"] = frmBuhin2.textBoxTekiyo.Text;
                // 大井野FL
                ds.Tables["部品マスタ"].Rows[rowNo]["大井野FL"] = frmBuhin2.checkBoxOoino.Checked;
                // NCFL
                ds.Tables["部品マスタ"].Rows[rowNo]["NCFL"] = frmBuhin2.checkBoxNC.Checked;
                // 共通FL
                ds.Tables["部品マスタ"].Rows[rowNo]["共通FL"] = frmBuhin2.checkBoxKyotu.Checked;
                // 在庫FL
                ds.Tables["部品マスタ"].Rows[rowNo]["在庫FL"] = frmBuhin2.checkBoxZaiko.Checked;
                // 別納FL
                ds.Tables["部品マスタ"].Rows[rowNo]["別納FL"] = frmBuhin2.checkBoxBetuno.Checked;

                //RecordDisp(SeihinCodeStr);
            }



        }

        private void comboBoxTokuisaki_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSave.Enabled = false;
            buttonAdd.Enabled = false;
            buttonDelete.Enabled = false;
            buttonMachining.Enabled = false;
            buttonUp.Enabled = false;
            buttonDown.Enabled = false;
            button1.Enabled = false;

            if (comboBoxTokuisaki.SelectedIndex >= 0)
            {
                ListIni();
            }
            else
            {

                comboBoxSeihin.Items.Clear();
            }
        }

        private void comboBoxSeihin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTokuisaki.SelectedIndex >= 0)
            {
                string scd;
                scd = comboBoxSeihin.SelectedItem.ToString();
                string SeihinCodeStr = scd.Substring(0, 13).Trim();
                //シリーズを取得
                toolSSLabelSeries.Text = GetSeries(SeihinCodeStr);
                //部品データ表示
                RecordDisp(SeihinCodeStr);

                buttonSave.Enabled = true;
                buttonAdd.Enabled = true;
                buttonDelete.Enabled = true;
                buttonMachining.Enabled = true;
                buttonUp.Enabled = true;
                buttonDown.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                buttonSave.Enabled = false;
                buttonAdd.Enabled = false;
                buttonDelete.Enabled = false;
                buttonMachining.Enabled = false;
                buttonUp.Enabled = false;
                buttonDown.Enabled = false;
                button1.Enabled = false;

                comboBoxSeihin.Items.Clear();
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();

          
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //得意先と製品が未選択ならなにもしない
            if (comboBoxTokuisaki.SelectedIndex == -1) return;
            if (comboBoxSeihin.SelectedIndex == -1) return;

            int rowNo = dataGridViewBuhin.CurrentCellAddress.Y;

            
            FormBuhinMst2 frmBuhin2 = new FormBuhinMst2();

            //FormBuhinMst2のコンボボックス用のデータの準備
            frmBuhin2.材種TableAdapter.Fill(frmBuhin2.dataSetZaisyu.材種);
            
            //得意先
            frmBuhin2.labelTokuisakiCode.Text = (string)comboBoxTokuisaki.SelectedItem;
            //製品コード
            string scd;
            scd = comboBoxSeihin.SelectedItem.ToString();
            string SeihinCodeStr = Program.Left(scd, 13).Trim();
            frmBuhin2.labelSeihinCode.Text = SeihinCodeStr;
            //製品名
            frmBuhin2.labelSeihinMei.Text = Program.Mid((string)comboBoxSeihin.SelectedItem, 17);
            //行番号
            frmBuhin2.labelNo.Text = (rowNo +1).ToString();
            //管理番号
            string editNo = string.Format("{0}-{1}", SeihinCodeStr, (string)ds.Tables["部品マスタ"].Rows[rowNo]["部品コード"]);
            frmBuhin2.toolSSLabelKanriCode.Text = editNo;
            //部品コード
            frmBuhin2.textBoxBuhinCode.Text = (string)ds.Tables["部品マスタ"].Rows[rowNo]["部品コード"];
            //使用対象
            frmBuhin2.textBoxSiyoTaisyo.Text= (string)ds.Tables["部品マスタ"].Rows[rowNo]["使用対象"];
            //材種 
            frmBuhin2.comboBoxZaisyu.SelectedValue = ds.Tables["部品マスタ"].Rows[rowNo]["材種"];
            //厚さ
            frmBuhin2.textBoxThickness.Text = (string)ds.Tables["部品マスタ"].Rows[rowNo]["厚さ"].ToString(); 
            // 巾
            frmBuhin2.textBoxWidth.Text = (string)ds.Tables["部品マスタ"].Rows[rowNo]["巾"].ToString();
            // 長さ
            frmBuhin2.textBoxLength.Text = (string)ds.Tables["部品マスタ"].Rows[rowNo]["長さ"].ToString();
            // 数量
            decimal sr;
            sr = (decimal)ds.Tables["部品マスタ"].Rows[rowNo]["数量"];
            frmBuhin2.textBoxSuryo.Text = sr.ToString("#0.#");
            //frmBuhin2.textBoxSuryo.Text = (string)ds.Tables["部品マスタ"].Rows[rowNo]["数量"].ToString();
            // 摘要
            frmBuhin2.textBoxTekiyo.Text = (string)ds.Tables["部品マスタ"].Rows[rowNo]["摘要"];
            // 大井野FL
            frmBuhin2.checkBoxOoino.Checked = (bool)ds.Tables["部品マスタ"].Rows[rowNo]["大井野FL"];
            // NCFL
            frmBuhin2.checkBoxNC.Checked = (bool)ds.Tables["部品マスタ"].Rows[rowNo]["NCFL"];
            // 共通FL
            frmBuhin2.checkBoxKyotu.Checked = (bool)ds.Tables["部品マスタ"].Rows[rowNo]["共通FL"];
            // 在庫FL
            frmBuhin2.checkBoxZaiko.Checked = (bool)ds.Tables["部品マスタ"].Rows[rowNo]["在庫FL"];
            // 別納FL
            frmBuhin2.checkBoxBetuno.Checked = (bool)ds.Tables["部品マスタ"].Rows[rowNo]["別納FL"];
            //シリーズ
            frmBuhin2.toolSSLabelSeries.Text = this.toolSSLabelSeries.Text;

            if (frmBuhin2.ShowDialog() == DialogResult.OK)
            {
                //部品コード
                ds.Tables["部品マスタ"].Rows[rowNo]["部品コード"] = frmBuhin2.textBoxBuhinCode.Text.Trim();
                //使用対象
                ds.Tables["部品マスタ"].Rows[rowNo]["使用対象"] = frmBuhin2.textBoxSiyoTaisyo.Text.Trim();
                //材種 
                ds.Tables["部品マスタ"].Rows[rowNo]["材種"] = frmBuhin2.comboBoxZaisyu.SelectedValue;
                //厚さ
                double thickness;
                ds.Tables["部品マスタ"].Rows[rowNo]["厚さ"] = (double.TryParse(frmBuhin2.textBoxThickness.Text, out thickness) ? thickness : 0);
                // 巾
                double width; 
                ds.Tables["部品マスタ"].Rows[rowNo]["巾"] = (double.TryParse(frmBuhin2.textBoxWidth.Text, out width) ? width : 0) ;
                // 長さ
                double length;
                ds.Tables["部品マスタ"].Rows[rowNo]["長さ"] = (double.TryParse(frmBuhin2.textBoxLength.Text, out length) ? length : 0);
                // 数量
                decimal suryo;
                ds.Tables["部品マスタ"].Rows[rowNo]["数量"] = (decimal.TryParse(frmBuhin2.textBoxSuryo.Text, out suryo) ? suryo : 0);
                // 摘要
                ds.Tables["部品マスタ"].Rows[rowNo]["摘要"] = frmBuhin2.textBoxTekiyo.Text;
                // 大井野FL
                ds.Tables["部品マスタ"].Rows[rowNo]["大井野FL"] = frmBuhin2.checkBoxOoino.Checked;
                // NCFL
                ds.Tables["部品マスタ"].Rows[rowNo]["NCFL"] = frmBuhin2.checkBoxNC.Checked;
                // 共通FL
                ds.Tables["部品マスタ"].Rows[rowNo]["共通FL"] = frmBuhin2.checkBoxKyotu.Checked;
                // 在庫FL
                ds.Tables["部品マスタ"].Rows[rowNo]["在庫FL"] = frmBuhin2.checkBoxZaiko.Checked;
                // 別納FL
                ds.Tables["部品マスタ"].Rows[rowNo]["別納FL"] = frmBuhin2.checkBoxBetuno.Checked;


                //RecordDisp(SeihinCodeStr);
            }

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (dataGridViewBuhin.CurrentCell == null) return;
            //if (dataGridViewBuhin.CurrentCell.RowIndex == 0 || dataGridViewBuhin.CurrentCell.RowIndex == dataGridViewBuhin.Rows.Count - 1) return;
            if (dataGridViewBuhin.CurrentCell.RowIndex == 0 ) return;
            object[] obj = ds.Tables["部品マスタ"].Rows[dataGridViewBuhin.CurrentCell.RowIndex].ItemArray;
            object[] obj2 = ds.Tables["部品マスタ"].Rows[dataGridViewBuhin.CurrentCell.RowIndex - 1].ItemArray;
            ds.Tables["部品マスタ"].Rows[dataGridViewBuhin.CurrentCell.RowIndex].ItemArray = obj2;
            //ds.Tables["部品マスタ"].Rows[dataGridViewBuhin.CurrentCell.RowIndex]["行番号"] = 
            ds.Tables["部品マスタ"].Rows[dataGridViewBuhin.CurrentCell.RowIndex - 1].ItemArray = obj;
            dataGridViewBuhin.CurrentCell = dataGridViewBuhin.Rows[dataGridViewBuhin.CurrentCell.RowIndex - 1].Cells[0];

            buttonAdd.Enabled = false;
            buttonEdit.Enabled = false;

        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (dataGridViewBuhin.CurrentCell == null) return;
            if (dataGridViewBuhin.CurrentCell.RowIndex == dataGridViewBuhin.Rows.Count - 1) return;
            object[] obj = ds.Tables["部品マスタ"].Rows[dataGridViewBuhin.CurrentCell.RowIndex + 1].ItemArray;
            object[] obj2 = ds.Tables["部品マスタ"].Rows[dataGridViewBuhin.CurrentCell.RowIndex].ItemArray;
            ds.Tables["部品マスタ"].Rows[dataGridViewBuhin.CurrentCell.RowIndex].ItemArray = obj;
            //ds.Tables["部品マスタ"].Rows[dataGridViewBuhin.CurrentCell.RowIndex]["行番号"] =
            ds.Tables["部品マスタ"].Rows[dataGridViewBuhin.CurrentCell.RowIndex + 1].ItemArray = obj2;
            dataGridViewBuhin.CurrentCell = dataGridViewBuhin.Rows[dataGridViewBuhin.CurrentCell.RowIndex + 1].Cells[0];

            buttonAdd.Enabled = false;
            buttonEdit.Enabled = false;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //得意先と製品が未選択ならなにもしない
            if (comboBoxTokuisaki.SelectedIndex == -1) return;
            if (comboBoxSeihin.SelectedIndex == -1) return;

            //行を削除したり並び替えたりしたときに保存する
            //
            //サーバーに接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {

                //データセットの行数を取得 B
                int dgvCnt = 0;
                dgvCnt = dataGridViewBuhin.BindingContext[dataGridViewBuhin.DataSource, dataGridViewBuhin.DataMember].Count;

                DataTable dtb = ds.Tables["部品マスタ"];
                DataRowCollection mrows = dtb.Rows;

                using (var transaction = con.BeginTransaction())
                using (var mcom = new SqlCommand() { Connection = con, Transaction = transaction })
                {
                    try
                    {
                        //既存データに上書き
                        int i = 0;
                        int rowNo = 0;
                        while (i < dgvCnt)
                        {
                            rowNo = i + 1;
                            mcom.CommandText = "UPDATE 部品マスタ SET" +
                                " 行番号 = " + rowNo.ToString() +
                                " WHERE 管理コード = '" + (string)mrows[i]["管理コード"] + "'";
                            mcom.ExecuteNonQuery();
                            i++;
                        }

                        transaction.Commit();

                        buttonAdd.Enabled = true;
                        buttonEdit.Enabled = true;

                    }
                    catch (Exception exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show(exception.Message);
                    }
                }
            }
            finally
            {
                //サーバー切断
                con.Close();
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //得意先と製品が未選択ならなにもしない
            if (comboBoxTokuisaki.SelectedIndex == -1) return;
            if (comboBoxSeihin.SelectedIndex == -1) return;

            DataTable ddt = ds.Tables["部品マスタ"];
            //現在のアクティブな行を取得 0～
            int rowNo = dataGridViewBuhin.CurrentCellAddress.Y;

            //選択されていなければなにもしない
            if (rowNo == -1) return;

            if (MessageBox.Show(string.Format("{0} : {1}",
                                (string)ddt.Rows[rowNo]["管理コード"],
                                (string)ddt.Rows[rowNo]["使用対象"]) + "\r\n" + 
                                string.Format(" T{0:#,#0.#} x D{1:#,#0.#} x W{2:#,#0.#}　数量{3:#,#0.#}",
                                (double)ddt.Rows[rowNo]["厚さ"],
                                (double)ddt.Rows[rowNo]["巾"],
                                (double)ddt.Rows[rowNo]["長さ"], 
                                (decimal)ddt.Rows[rowNo]["数量"]) + "\r\n" +
                                        " を削除します。\r\n" +
                                        "よろしいですか？",
                                        "部品一覧",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                //サーバーに接続
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                try
                {
                    DataTable dtb = ds.Tables["部品マスタ"];
                    DataRowCollection mrows = dtb.Rows;

                    using (var transaction = con.BeginTransaction())
                    using (var mcom = new SqlCommand() { Connection = con, Transaction = transaction })
                    {
                        try
                        {
                            mcom.CommandText = "DELETE FROM 部品マスタ WHERE 管理コード = '" + (string)ddt.Rows[rowNo]["管理コード"] + "'";
                            mcom.ExecuteNonQuery();

                            transaction.Commit();
                            ddt.Rows[rowNo].Delete();
                            ddt.AcceptChanges();
                        }
                        catch (Exception exception)
                        {
                            transaction.Rollback();
                            MessageBox.Show(exception.Message);
                        }
                    }
                }
                finally
                {
                    //サーバー切断
                    con.Close();
                }


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //得意先と製品が未選択ならなにもしない
            if (comboBoxTokuisaki.SelectedIndex < 0) return;
            if (comboBoxSeihin.SelectedIndex < 0) return;

            string scd;
            scd = comboBoxSeihin.SelectedItem.ToString();
            string SeihinCodeStr = scd.Substring(0, 13).Trim();

            using (SqlConnection con = new SqlConnection(constr))
            {
                DataSetMst dsm = new DataSetMst();

                con.Open();
                SqlCommand com = con.CreateCommand();
                string sql = "SELECT 部品マスタ.Id, 部品マスタ.部品コード, 部品マスタ.製品コード, 部品マスタ.管理コード, 部品マスタ.行番号, " +
                                      "部品マスタ.使用対象, 部品マスタ.材種, 部品マスタ.厚さ, 部品マスタ.巾, 部品マスタ.長さ, 部品マスタ.数量, " +
                                      "部品マスタ.摘要, 部品マスタ.大井野FL, 部品マスタ.NCFL, 部品マスタ.共通FL, 部品マスタ.在庫FL, " +
                                      "部品マスタ.別納FL, 部品マスタ.最終入力日, 製品マスタ.製品名, 材種.名称 AS 材種名, 得意先マスタ.得意先名 " +
                                      "FROM 部品マスタ INNER JOIN " +
                                      "製品マスタ ON 部品マスタ.製品コード = 製品マスタ.製品コード INNER JOIN " +
                                      "材種 ON 部品マスタ.材種 = 材種.材種 INNER JOIN " +
                                      "得意先マスタ ON 製品マスタ.得意先コード = 得意先マスタ.得意先コード" +
                                      " WHERE 部品マスタ.製品コード = " + SeihinCodeStr + 
                                      " ORDER BY 部品マスタ.行番号" ;

                //データセット作成
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsm.木取り);

                FormReportViewer frmRptViewer = new FormReportViewer();

                frmRptViewer.Text = "木取り表　印刷";
                //レポートセッティング
                frmRptViewer.reportViewer1.Reset();
                frmRptViewer.reportViewer1.ProcessingMode = ProcessingMode.Local;
                //frmRptViewer.reportViewer1.LocalReport.ReportPath = Environment.CurrentDirectory + @"\ReportKidori.rdlc";
                //frmRptViewer.reportViewer1.LocalReport.ReportPath = @"C: \Users\yoshi\source\repos\TakagiMokkou\SeisanKanri" + @"\ReportKidori.rdlc";
                frmRptViewer.reportViewer1.LocalReport.ReportPath = @Properties.Settings.Default.ProFName + @"\ReportKidori.rdlc";
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = dsm.木取り;
                //ReportViewerに表示
                frmRptViewer.reportViewer1.LocalReport.DataSources.Add(rds);
                frmRptViewer.reportViewer1.RefreshReport();

                frmRptViewer.Show();

            }
        }

        private void ButtonMachining_Click(object sender, EventArgs e)
        {
            //得意先と製品が未選択ならなにもしない
            if (comboBoxTokuisaki.SelectedIndex == -1) return;
            if (comboBoxSeihin.SelectedIndex == -1) return;

            int rowNo = dataGridViewBuhin.CurrentCellAddress.Y;

            //加工一覧画面
            FormBuhinMst3 frmBuhinMst3 = new FormBuhinMst3();

            //得意先名
            frmBuhinMst3.textBoxTokuisaki.Text = comboBoxTokuisaki.Text;
            //製品コード
            string scd;
            scd = comboBoxSeihin.SelectedItem.ToString();
            string SeihinCodeStr = Program.Left(scd, 13).Trim();
            string SeihinMeiStr = Program.Mid(scd, 17).Trim();
            frmBuhinMst3.textBoxSeihinCode.Text = SeihinCodeStr;
            frmBuhinMst3.textBoxSeihinMei.Text = SeihinMeiStr;

            //管理番号
            string editNo = string.Format("{0}-{1}", SeihinCodeStr, (string)ds.Tables["部品マスタ"].Rows[rowNo]["部品コード"]);
            frmBuhinMst3.toolSSLabelKanriCode.Text = editNo;

            //シリーズ
            frmBuhinMst3.toolSSLabelSeries.Text = this.toolSSLabelSeries.Text;

            frmBuhinMst3.Show(this);


        }
    }
}
