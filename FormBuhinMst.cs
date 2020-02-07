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

namespace SeisanKanri
{
    public partial class FormBuhinMst : Form
    {

        private string constr = @Properties.Settings.Default.ConnectStr;

        private DataSet ds = new DataSet();
        private DataTable dtBuhin = new DataTable();
        private DataTable dtKanamono = new DataTable();
        private DataTable dtKako = new DataTable();
        private int znm; //材種コンボボックス　初期値

        public FormBuhinMst()
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

        private string AddFieldValueString(DataRow row, string fieldName)
        {
            if (!DBNull.Value.Equals(row[fieldName]))
                return (string)row[fieldName];
            else
                return String.Empty;
        }

        private bool AddFieldValueBool(DataRow row, string fieldName)
        {
            if (!DBNull.Value.Equals(row[fieldName]))
                return (bool)row[fieldName];
            else
                return false;
        }

        private decimal AddFieldValueDecimal(DataRow row, string fieldName)
        {
            if (!DBNull.Value.Equals(row[fieldName]))
                return (decimal)row[fieldName];
            else
                return 0;
        }


        private int AddFieldValueInt(DataRow row, string fieldName)
        {
            if (!DBNull.Value.Equals(row[fieldName]))
                return (int)row[fieldName];
            else
                return 0;
        }

        private double AddFieldValueDouble(DataRow row, string fieldName)
        {
            if (!DBNull.Value.Equals(row[fieldName]))
                return (double)row[fieldName];
            else
                return 0;
        }

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
                        "FROM 部品マスタ LEFT OUTER JOIN 材種 ON 部品マスタ.材種 = 材種.ID " +
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
                        row["シリーズ"] = (sdrBuhin["シリーズ"] == DBNull.Value ? "" : (string)sdrBuhin["シリーズ"]) ;

                        ds.Tables["部品マスタ"].Rows.Add(row);
                    }
                    ds.Tables["部品マスタ"].AcceptChanges();
                    sdrBuhin.Close();
                    if (ds.Tables["部品マスタ"].Rows.Count > 0)
                    {
                        buttonAdd.Enabled = true;
                        buttonDelete.Enabled = true;
                        buttonSave.Enabled = true;
                    }
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
            dtBuhin.Columns.Add("シリーズ");

            ds.Tables.Add(dtBuhin);

            dataGridViewBuhin.AutoGenerateColumns = false;
            dataGridViewBuhin.DataSource = ds.Tables["部品マスタ"];

            buttonAdd.Enabled = false;
            buttonDelete.Enabled = false;
            buttonSave.Enabled = false;

            toolSSLabelSeries.Text = "";

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
        private bool NewBuhinCodeCheck(string code)
        {

            DataRow[] targetRow = ds.Tables["部品マスタ"].Select("部品コード = '" + code + "'");

            if (targetRow.Count() != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void FormBuhinMst_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'dataSetZaisyu.材種' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.材種TableAdapter.Fill(this.dataSetZaisyu.材種);
            
            znm = (int)this.dataSetZaisyu.Tables["材種"].Rows[0]["材種"];
            

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
            finally
            {
                //サーバー切断
                con.Close();
            }
            


        }

        private void buttonKakou_Click(object sender, EventArgs e)
        {
            FormKakou frmKakou = new FormKakou();

            frmKakou.Show();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxTokuisaki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTokuisaki.SelectedIndex >= 0)
            {
                ListIni();
            }
            else
            {
                comboBoxSeihin.Items.Clear();
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //削除ボタン
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

            private void buttonAdd_Click(object sender, EventArgs e)
        {

            //追加ボタン

            int rowCount;

            ds.Tables["部品マスタ"].Rows.Add(ds.Tables["部品マスタ"].NewRow());
            rowCount = ds.Tables["部品マスタ"].Rows.Count;

            ds.Tables["部品マスタ"].Rows[rowCount - 1]["材種"] = znm;

            dataGridViewBuhin.Select();
            dataGridViewBuhin.CurrentCell = dataGridViewBuhin[0, rowCount - 1];


            buttonDelete.Enabled = true;
            buttonSave.Enabled = true;


        }


        //データグリッドビュー（部品）の入力チェック
        private void dataGridViewBuhin_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            //新しく追加されたばかりの行で未編集ならなにもしない
            if (e.RowIndex == dgv.NewRowIndex || !dgv.IsCurrentCellDirty)
            {
                return;
            }

            double t;
            //同じ部品コードが使われていないかチェック
            //厚さ、巾、長さ、数量の欄に数値以外のものが入っていないかチェック
            string cnm = dgv.Columns[e.ColumnIndex].Name;
            switch (cnm)
            {
                case "部品コード":
                    if ((string)e.FormattedValue == "") return;
                    int rowNo = 0;
                    int rowCnt;
                    string ncd = (string)e.FormattedValue; //入力したコード
                    string rowCode = "";

                    //データグリッドビューの行数
                    rowCnt = dataGridViewBuhin.BindingContext[dataGridViewBuhin.DataSource, dataGridViewBuhin.DataMember].Count - 1;
                    while (rowNo < rowCnt)
                    {
                        //DataSetに入っているコード
                        rowCode = AddFieldValueString(ds.Tables["部品マスタ"].Rows[rowNo], "部品コード");
                        //比較（ただし現在入力している行で比較が発生している場合は無視）
                        if (rowCode == ncd && rowNo != e.RowIndex)
                        {
                            //行にエラーテキストを設定
                            dgv.Rows[e.RowIndex].ErrorText = "同じ部品コードがあります。変更してください。";
                            MessageBox.Show(dgv.Rows[e.RowIndex].ErrorText);
                            //入力した値をキャンセルして元に戻すには、次のようにする
                            //dgv.CancelEdit();
                            //キャンセルする
                            e.Cancel = true;
                            return;
                        }
                        rowNo++;
                    }
                    break;

                case "厚さ":
                case "巾":
                case "長さ":
                case "数量":
                    if (double.TryParse(e.FormattedValue.ToString(), out t) == false)
                    {
                        if (e.FormattedValue.ToString().Trim() == "")
                        {
                            ds.Tables["部品マスタ"].Rows[e.RowIndex][cnm] = 0;
                            
                            return;
                        }
                        //行にエラーテキストを設定
                        dgv.Rows[e.RowIndex].ErrorText = "数値が入力されていません。";
                        MessageBox.Show(dgv.Rows[e.RowIndex].ErrorText);
                        //入力した値をキャンセルして元に戻すには、次のようにする
                        //dgv.CancelEdit();
                        //キャンセルする
                        e.Cancel = true;

                    }
                    break;
            }

        }

        private void dataGridViewBuhin_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            //エラーテキストを消す
            dgv.Rows[e.RowIndex].ErrorText = null;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //データチェック
            //部品コード、材種、巾、長さ、数量が空白かDBNullならなにもしない
            foreach(DataRow drow in ds.Tables["部品マスタ"].Rows)
            {
                if ((drow["部品コード"] == DBNull.Value ? string.Empty : (string)drow["部品コード"]) == "")
                {
                    MessageBox.Show("部品コードが入力されていない行があります");
                    return;
                }

                if ((drow["材種"] == DBNull.Value ? -1 : (int)drow["材種"]) == -1)
                {
                    MessageBox.Show("材種が入力されていない行があります");
                    return;
                }

                if ((drow["巾"] == DBNull.Value ? -1 : (double)drow["巾"]) < 0)
                {
                    MessageBox.Show("巾が入力されていない行があります");
                    return;
                }

                if ((drow["長さ"] == DBNull.Value ? -1 : (double)drow["長さ"]) < 0)
                {
                    MessageBox.Show("長さが入力されていない行があります");
                    return;
                }

                if ((drow["数量"] == DBNull.Value ? -1 : (decimal)drow["数量"]) < 0)
                {
                    MessageBox.Show("数量が入力されていない行があります");
                    return;
                }

            }


            //データ保存
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
                string scd;
                scd = comboBoxSeihin.SelectedItem.ToString();
                string seihinCode = scd.Substring(0, 13).Trim();

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
                            switch (mrows[i].RowState)
                            {
                                case DataRowState.Modified:
                                    mcom.CommandText = "UPDATE 部品マスタ " +
                                                        "SET" +
                                                        " 使用対象 = N'" + AddFieldValueString(mrows[i], "使用対象") + "'," +
                                                        " 材種 = " + AddFieldValueInt(mrows[i], "材種").ToString() + "," +
                                                        " 厚さ = " + AddFieldValueDouble(mrows[i], "厚さ").ToString() + "," +
                                                        " 巾 = " + AddFieldValueDouble(mrows[i], "巾").ToString() + "," +
                                                        " 長さ = " + AddFieldValueDouble(mrows[i], "長さ").ToString() + "," +
                                                        " 数量 = " + AddFieldValueDecimal(mrows[i], "数量").ToString() + ", " +
                                                        " 摘要 = N'" + AddFieldValueString(mrows[i],"摘要") + "'," +
                                                        " 大井野FL = '" + AddFieldValueBool(mrows[i],"大井野FL") + "'," +
                                                        " NCFL = '" + AddFieldValueBool(mrows[i],"NCFL") + "'," +
                                                        " 共通FL = '" + AddFieldValueBool(mrows[i],"共通FL") + "'," +
                                                        " 在庫FL = '" + AddFieldValueBool(mrows[i],"在庫FL") + "'," +
                                                        " 別納FL = '" + AddFieldValueBool(mrows[i],"別納FL") + "'," +
                                                        " 行番号 = " + rowNo.ToString() + "," +
                                                        " シリーズ = N'" + toolSSLabelSeries.Text + "'," +
                                                        " 最終入力日 =  getdate()" +
                                                        " where 管理コード  = '" + (string)mrows[i]["管理コード"] + "'";
                                    mcom.ExecuteNonQuery();
                                    break;

                                case DataRowState.Added:
                                    string buhinCode = AddFieldValueString(mrows[i],"部品コード");
                                    string editNo = string.Format("{0}-{1}", seihinCode, buhinCode);

                                    //新規登録
                                    mcom.CommandText = "INSERT INTO 部品マスタ (" +
                                                        "部品コード, 製品コード, 管理コード, 行番号, 使用対象, " +
                                                        " 材種, 厚さ, 巾, 長さ, 数量, 摘要," +
                                                        " 大井野FL, NCFL, 共通FL, 在庫FL, 別納FL, 最終入力日, シリーズ" +
                                                        ") VALUES (" +
                                                        " '" + buhinCode + "'," +
                                                        " '" + seihinCode + "'," +
                                                        "  '" + editNo + "'," +
                                                        rowNo.ToString() + "," +
                                                        " N'" + AddFieldValueString(mrows[i],"使用対象") + "', " +
                                                        AddFieldValueInt(mrows[i],"材種").ToString() + ", " +
                                                        AddFieldValueDouble(mrows[i],"厚さ").ToString() + ", " +
                                                        AddFieldValueDouble(mrows[i],"巾").ToString() + ", " +
                                                        AddFieldValueDouble(mrows[i],"長さ").ToString() + ", " +
                                                        AddFieldValueDecimal(mrows[i],"数量").ToString() + ", " +
                                                        " N'" + AddFieldValueString(mrows[i],"摘要") + "', " +
                                                        "'" + AddFieldValueBool(mrows[i],"大井野FL").ToString() + "', " +
                                                        "'" + AddFieldValueBool(mrows[i],"NCFL").ToString() + "', " +
                                                        "'" + AddFieldValueBool(mrows[i],"共通FL").ToString() + "', " +
                                                        "'" + AddFieldValueBool(mrows[i],"在庫FL").ToString() + "', " +
                                                        "'" + AddFieldValueBool(mrows[i],"別納FL").ToString() + "', " +
                                                        " getdate(), N'" + toolSSLabelSeries.Text + "')";
                                    mcom.ExecuteNonQuery();
                                    break;

                                default:
                                    break; ;

                            }
                            
                            i++;
                        }

                        transaction.Commit();
                        MessageBox.Show("保存しました。", "部品マスタ");
                        buttonAdd.Enabled = true;
                        RecordDisp(seihinCode);
                        

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

        private void dataGridViewBuhin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewBuhin_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void ComboBoxSeihin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string scd;
            scd = comboBoxSeihin.SelectedItem.ToString();
            string SeihinCodeStr = scd.Substring(0, 13).Trim();

            toolSSLabelSeries.Text = GetSeries(SeihinCodeStr);
            RecordDisp(SeihinCodeStr);

            if (comboBoxSeihin.SelectedIndex >=0)
            {
                if (ds.Tables["部品マスタ"].Rows.Count > 0)
                {
                    buttonSave.Enabled = true;
                    buttonDelete.Enabled = true;
                }
                else
                {
                    buttonSave.Enabled = false;
                    buttonDelete.Enabled = false;
                }

                buttonAdd.Enabled = true;
                
            }
            else
            {
                buttonSave.Enabled = false;
                buttonAdd.Enabled = false;
                buttonDelete.Enabled = false;

            }
        }

        private void DataGridViewBuhin_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
