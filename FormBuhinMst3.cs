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
    public partial class FormBuhinMst3 : Form
    {

        private string constr = @Properties.Settings.Default.ConnectStr;

        private DataSet ds = new DataSet();
        private DataTable dtKako = new DataTable();
        private DataTable dtNut = new DataTable();


        public FormBuhinMst3()
        {
            InitializeComponent();
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

        private void DisplayKakou(string kanriCode)
        {
            //加工作業を表示
            //データテーブル初期化
            ds.Tables["加工"].Rows.Clear();

            if (kanriCode != "")
            {
                //サーバー接続
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                try
                {
                    //テーブルへ行を追加
                    //string meiSql = "SELECT * FROM 加工　WHERE 管理コード = " + kanriCode + " ORDER BY 順番";
                    string meiSql = "SELECT 加工.Id, 加工.加工管理コード, 加工.管理コード, 加工.製品コード, 加工.部品コード, 加工.加工コード, 加工.順番, " +
                                    "加工.加工種コード, 加工.機械コード, 加工.作業内容, 加工.作業詳細, 加工.NC管理コード, 加工.プログラム番号, 加工.NC取り数, " +
                                    "加工.参照画像1, 加工.参照画像2, 加工.参照画像3, 加工.最終入力日, 加工種.加工種, 機械.機械 " +
                                    "FROM 加工 LEFT OUTER JOIN " +
                                    "機械 ON 加工.機械コード = 機械.機械コード LEFT OUTER JOIN " +
                                    "加工種 ON 加工.加工種コード = 加工種.加工種コード " +
                                    "WHERE 加工.管理コード = '" + kanriCode +
                                    "' ORDER BY 加工.順番";

                    SqlCommand comBuhin = new SqlCommand(meiSql, con);
                    SqlDataReader sdrBuhin = comBuhin.ExecuteReader();

                    while (sdrBuhin.Read())
                    {
                        DataRow row = ds.Tables["加工"].NewRow();

                        row["加工管理コード"] = (string)sdrBuhin["加工管理コード"];
                        row["加工コード"] = (string)sdrBuhin["加工コード"];
                        row["順番"] = (int)sdrBuhin["順番"];
                        row["加工種コード"] = (string)sdrBuhin["加工種コード"];
                        row["加工種"] = (sdrBuhin["加工種"] == DBNull.Value ? "":(string)sdrBuhin["加工種"]);
                        row["機械コード"] = (string)sdrBuhin["機械コード"];
                        row["機械"] = (sdrBuhin["機械"] == DBNull.Value ? "":(string)sdrBuhin["機械"]);
                        row["作業内容"] = (string)sdrBuhin["作業内容"];
                        row["作業詳細"] = (string)sdrBuhin["作業詳細"];
                        row["NC管理コード"] = (string)sdrBuhin["NC管理コード"];
                        row["プログラム番号"] = (sdrBuhin["プログラム番号"] == DBNull.Value ? 0 : (int)sdrBuhin["プログラム番号"]);
                        row["NC取り数"] = (sdrBuhin["NC取り数"] == DBNull.Value ? 0 : (decimal)sdrBuhin["NC取り数"]);
                        row["参照画像1"] = (string)sdrBuhin["参照画像1"];
                        row["参照画像2"] = (string)sdrBuhin["参照画像2"];
                        row["参照画像3"] = (string)sdrBuhin["参照画像3"];
                        ds.Tables["加工"].Rows.Add(row);

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


        private void DisplayNut(string kanriCode)
        {
            //加工作業を表示
            //データテーブル初期化
            ds.Tables["金物"].Rows.Clear();

            if (kanriCode != "")
            {
                //サーバー接続
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                try
                {
                    //テーブルへ行を追加
                    //string meiSql = "SELECT * FROM 金物　WHERE 管理コード = " + kanriCode + " ORDER BY 金物コード";
                    string meiSql = "SELECT 金物.Id, 金物.金物管理コード, 金物.管理コード, 金物.製品コード, 金物.部品コード, 金物.金物コード, " +
                                    "金物.金物名, 金物.数量, 金物マスタ.単価, 金物マスタ.下穴等 " +
                                    "FROM 金物 LEFT OUTER JOIN " +
                                    "金物マスタ ON 金物.金物コード = 金物マスタ.金物コード " +
                                    "WHERE 金物.管理コード = '" + kanriCode +
                                    "' ORDER BY 金物.金物コード";

                    SqlCommand comBuhin = new SqlCommand(meiSql, con);
                    SqlDataReader sdrBuhin = comBuhin.ExecuteReader();

                    while (sdrBuhin.Read())
                    {
                        DataRow row = ds.Tables["金物"].NewRow();

                        decimal suryo = (decimal)sdrBuhin["数量"];
                        decimal tanka = (decimal)sdrBuhin["単価"];
                        row["金物管理コード"] = (string)sdrBuhin["金物管理コード"];
                        row["金物コード"] = (string)sdrBuhin["金物コード"];
                        row["金物名"] = (string)sdrBuhin["金物名"];
                        row["数量"] = suryo.ToString("#,#0.#");
                        row["単価"] = tanka.ToString("#,#0.#");
                        row["下穴等"] = (string)sdrBuhin["下穴等"];
                        ds.Tables["金物"].Rows.Add(row);
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

        private void FormBuhinMst3_Load(object sender, EventArgs e)
        {
            //加工データテーブルの準備
            dtKako.TableName = "加工";
            dtKako.Columns.Add("加工管理コード");
            dtKako.Columns.Add("管理コード");
            dtKako.Columns.Add("製品コード");
            dtKako.Columns.Add("部品コード");
            dtKako.Columns.Add("加工コード");
            dtKako.Columns.Add("順番", Type.GetType("System.Int32"));
            dtKako.Columns.Add("加工種コード");
            dtKako.Columns.Add("加工種");
            dtKako.Columns.Add("機械コード");
            dtKako.Columns.Add("機械");
            dtKako.Columns.Add("作業内容");
            dtKako.Columns.Add("作業詳細");
            dtKako.Columns.Add("NC管理コード");
            dtKako.Columns.Add("プログラム番号", Type.GetType("System.Int32"));
            dtKako.Columns.Add("NC取り数", Type.GetType("System.Int32"));
            dtKako.Columns.Add("参照画像1");
            dtKako.Columns.Add("参照画像2");
            dtKako.Columns.Add("参照画像3");

            ds.Tables.Add(dtKako);

            dataGridViewKako.AutoGenerateColumns = false;
            dataGridViewKako.DataSource = ds.Tables["加工"];
            dataGridViewKako.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //金物
            dtNut.TableName = "金物";
            dtNut.Columns.Add("金物管理コード");
            dtNut.Columns.Add("管理コード");
            dtNut.Columns.Add("製品コード");
            dtNut.Columns.Add("部品コード");
            dtNut.Columns.Add("金物コード");
            dtNut.Columns.Add("金物名");
            dtNut.Columns.Add("数量", Type.GetType("System.Decimal"));
            dtNut.Columns.Add("単価", Type.GetType("System.Decimal"));
            dtNut.Columns.Add("下穴等");

            ds.Tables.Add(dtNut);

            dataGridViewNut.AutoGenerateColumns = false;
            dataGridViewNut.DataSource = ds.Tables["金物"];
            dataGridViewNut.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            //管理コードが空白なら処理しない
            string scd = toolSSLabelKanriCode.Text;

            if (scd != "")
            {
                //サーバー接続
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                try
                {
                    //管理コードで部品を検索
                    string sqlstr = "SELECT 部品マスタ.*, 材種.名称 AS ZaisyuMei " +
                        "FROM 部品マスタ LEFT OUTER JOIN 材種 ON 部品マスタ.材種 = 材種.ID " +
                        "WHERE 管理コード = '" + scd + "'";

                    SqlCommand com = new SqlCommand(sqlstr, con);
                    SqlDataReader sdr = com.ExecuteReader();

                    //見つかった場合のみ処理を行う
                    //部品情報を表示する
                    if (sdr.Read() == true)
                    {
                        string code = (string)sdr["部品コード"];
                        string siyoTaisyo = (string)sdr["使用対象"];
                        string zaisyuMei = (string)sdr["ZaisyuMei"];
                        double thickness = (double)sdr["厚さ"];
                        double width = (double)sdr["巾"];
                        double length = (double)sdr["長さ"];
                        decimal suryo = (decimal)sdr["数量"];
                        string tekiyo = Convert.ToString(sdr["摘要"]);
                        bool oinoFL = (bool)sdr["大井野FL"];
                        bool ncFL = (bool)sdr["NCFL"];
                        bool kyotuFL = (bool)sdr["共通FL"];
                        bool zaikoFL = (bool)sdr["在庫FL"];
                        bool betunoFL = (bool)sdr["別納FL"];

                        textBoxBuhinCode.Text = code;
                        textBoxSiyoTaisyo .Text = siyoTaisyo;
                        textBoxZaisyu.Text = zaisyuMei;
                        textBoxThickness.Text = thickness.ToString("#,#0.#");
                        textBoxWidth.Text = width.ToString("#,#0.#");
                        textBoxLength.Text = length.ToString("#,#0.#");
                        textBoxSuryo.Text = suryo.ToString("#,#0.#");
                        textBoxTekiyo.Text = tekiyo;
                        checkBoxOino.Checked = oinoFL;
                        checkBoxNC.Checked = ncFL;
                        checkBoxKyotu.Checked = kyotuFL;
                        checkBoxZaiko.Checked = zaikoFL;
                        checkBoxKyotu.Checked = betunoFL;

                    }

                    sdr.Close();

                }
                finally
                {
                    //サーバー切断
                    con.Close();
                }

                //加工表示
                DisplayKakou(scd);

                //金物表示
                DisplayNut(scd);
            }

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            FormKakou frmKakou = new FormKakou();

            frmKakou.labelTokuisaki.Text = textBoxTokuisaki.Text;
            frmKakou.labelSeihinCode.Text = textBoxSeihinCode.Text;
            frmKakou.labelSeihinMei.Text = textBoxSeihinMei.Text;
            frmKakou.labelBuhinCode.Text = textBoxBuhinCode.Text;
            frmKakou.labelBuhin.Text = textBoxSiyoTaisyo.Text + " " +
                                        textBoxThickness.Text + "T x " +
                                        textBoxWidth.Text + " x " +
                                        textBoxLength.Text;
            frmKakou.labelSuryo.Text = "数量 " + textBoxSuryo.Text;
            frmKakou.toolSSLabelKanriCode.Text = this.toolSSLabelKanriCode.Text;
            frmKakou.toolSSLabelKakouKanriCode.Text = "";
            frmKakou.toolSSLabelSeries.Text = this.toolSSLabelSeries.Text;

            //新しい行番号を取得
            int rowCnt = 0;
            int rowNo;
            rowCnt = dataGridViewKako.BindingContext[dataGridViewKako.DataSource, dataGridViewKako.DataMember].Count;
            rowNo = rowCnt;
            rowCnt++;
            frmKakou.labelJunban.Text = rowCnt.ToString();
            if (frmKakou.ShowDialog() == DialogResult.OK)
            {
                ds.Tables["加工"].Rows.Add(ds.Tables["加工"].NewRow());

                ds.Tables["加工"].Rows[rowNo]["加工管理コード"] = frmKakou.toolSSLabelKakouKanriCode.Text;
                ds.Tables["加工"].Rows[rowNo]["管理コード"] = frmKakou.toolSSLabelKanriCode.Text;
                ds.Tables["加工"].Rows[rowNo]["製品コード"] = frmKakou.labelSeihinCode.Text;
                ds.Tables["加工"].Rows[rowNo]["部品コード"] = frmKakou.labelBuhinCode.Text;

                //順番
                ds.Tables["加工"].Rows[rowNo]["順番"] = frmKakou.labelJunban.Text;
                //加工コード
                ds.Tables["加工"].Rows[rowNo]["加工コード"] = frmKakou.textBoxKakouNo.Text;
                //加工種コード
                ds.Tables["加工"].Rows[rowNo]["加工種コード"] = frmKakou.textBoxKakouSyubetuCode.Text;
                //加工種
                ds.Tables["加工"].Rows[rowNo]["加工種"] = frmKakou.textBoxKakouSyubetu.Text;
                //機械コード 
                ds.Tables["加工"].Rows[rowNo]["機械コード"] = frmKakou.textBoxKikaiCode.Text;
                //機械
                ds.Tables["加工"].Rows[rowNo]["機械"] = frmKakou.textBoxKikai.Text;
                // 作業内容
                ds.Tables["加工"].Rows[rowNo]["作業内容"] = frmKakou.textBoxNaiyoS.Text;
                // 作業詳細
                ds.Tables["加工"].Rows[rowNo]["作業詳細"] = frmKakou.textBoxNaiyoL.Text;
                // NC管理コード
                ds.Tables["加工"].Rows[rowNo]["NC管理コード"] = frmKakou.textBoxNcCode.Text;
                // NCプログラム番号
                int pn;
                ds.Tables["加工"].Rows[rowNo]["プログラム番号"] = frmKakou.textBoxNCProgramNo.Text;
                // NC取り数
                ds.Tables["加工"].Rows[rowNo]["NC取り数"] = frmKakou.textBoxNCTorisu.Text;
                // 参照画像1
                ds.Tables["加工"].Rows[rowNo]["参照画像1"] = frmKakou.textBoxGazo1.Text;
                // 参照画像2
                ds.Tables["加工"].Rows[rowNo]["参照画像2"] = frmKakou.textBoxGazo2.Text;
                // 参照画像3
                ds.Tables["加工"].Rows[rowNo]["参照画像3"] = frmKakou.textBoxGazo3.Text;
                //DisplayKakou(toolSSLabelKanriCode.Text);
            }

        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            int rowNo = dataGridViewKako.CurrentCellAddress.Y;


            FormKakou frmKakou = new FormKakou();

            frmKakou.labelTokuisaki.Text = textBoxTokuisaki.Text;
            frmKakou.labelSeihinCode.Text = textBoxSeihinCode.Text;
            frmKakou.labelSeihinMei.Text = textBoxSeihinMei.Text;
            frmKakou.labelBuhinCode.Text = textBoxBuhinCode.Text;
            frmKakou.labelBuhin.Text = textBoxSiyoTaisyo.Text + " " +
                                        textBoxThickness.Text + "T x " +
                                        textBoxWidth.Text + " x " +
                                        textBoxLength.Text;
            frmKakou.labelSuryo.Text = "数量 " + textBoxSuryo.Text;
            string editNo = string.Format("{0}-{1}", toolSSLabelKanriCode.Text, (string)ds.Tables["加工"].Rows[rowNo]["加工コード"]);
            frmKakou.toolSSLabelKanriCode.Text = this.toolSSLabelKanriCode.Text;
            frmKakou.toolSSLabelKakouKanriCode.Text = editNo;
            frmKakou.toolSSLabelSeries.Text = this.toolSSLabelSeries.Text;

            //順番
            frmKakou.labelJunban.Text = (string)ds.Tables["加工"].Rows[rowNo]["順番"].ToString();
            //加工コード
            frmKakou.textBoxKakouNo.Text = (string)ds.Tables["加工"].Rows[rowNo]["加工コード"];
            //加工種コード
            frmKakou.textBoxKakouSyubetuCode.Text = (string)ds.Tables["加工"].Rows[rowNo]["加工種コード"];
            //加工種
            frmKakou.textBoxKakouSyubetu.Text = (string)ds.Tables["加工"].Rows[rowNo]["加工種"];
            //機械コード 
            frmKakou.textBoxKikaiCode.Text = (string)ds.Tables["加工"].Rows[rowNo]["機械コード"];
            //機械
            frmKakou.textBoxKikai.Text = (string)ds.Tables["加工"].Rows[rowNo]["機械"];
            // 作業内容
            frmKakou.textBoxNaiyoS.Text = (string)ds.Tables["加工"].Rows[rowNo]["作業内容"];
            // 作業詳細
            frmKakou.textBoxNaiyoL.Text = (string)ds.Tables["加工"].Rows[rowNo]["作業詳細"];
            // NC管理コード
            frmKakou.textBoxNcCode.Text = (string)ds.Tables["加工"].Rows[rowNo]["NC管理コード"].ToString();
            // NCプログラム番号
            frmKakou.textBoxNCProgramNo.Text = (string)ds.Tables["加工"].Rows[rowNo]["プログラム番号"].ToString();
            // NC取り数
            frmKakou.textBoxNCTorisu.Text = (string)ds.Tables["加工"].Rows[rowNo]["NC取り数"].ToString();
            // 参照画像1
            frmKakou.textBoxGazo1.Text = (string)ds.Tables["加工"].Rows[rowNo]["参照画像1"];
            frmKakou.pictureBox1.ImageLocation = frmKakou.textBoxGazo1.Text;
            // 参照画像2
            frmKakou.textBoxGazo2.Text = (string)ds.Tables["加工"].Rows[rowNo]["参照画像2"];
            frmKakou.pictureBox2.ImageLocation = frmKakou.textBoxGazo2.Text;
            // 参照画像3
            frmKakou.textBoxGazo3.Text = (string)ds.Tables["加工"].Rows[rowNo]["参照画像3"];
            frmKakou.pictureBox3.ImageLocation = frmKakou.textBoxGazo3.Text;

            if (frmKakou.ShowDialog() == DialogResult.OK)
            {
                //順番
                ds.Tables["加工"].Rows[rowNo]["順番"] = frmKakou.labelJunban.Text;
                //加工コード
                ds.Tables["加工"].Rows[rowNo]["加工コード"] = frmKakou.textBoxKakouNo.Text;
                //加工種コード
                ds.Tables["加工"].Rows[rowNo]["加工種コード"] = frmKakou.textBoxKakouSyubetuCode.Text;
                //加工種
                ds.Tables["加工"].Rows[rowNo]["加工種"] = frmKakou.textBoxKakouSyubetu.Text;
                //機械コード 
                ds.Tables["加工"].Rows[rowNo]["機械コード"] = frmKakou.textBoxKikaiCode.Text;
                //機械
                ds.Tables["加工"].Rows[rowNo]["機械"] = frmKakou.textBoxKikai.Text;
                // 作業内容
                ds.Tables["加工"].Rows[rowNo]["作業内容"] = frmKakou.textBoxNaiyoS.Text;
                // 作業詳細
                ds.Tables["加工"].Rows[rowNo]["作業詳細"] = frmKakou.textBoxNaiyoL.Text;
                // NC管理コード
                ds.Tables["加工"].Rows[rowNo]["NC管理コード"] = frmKakou.textBoxNcCode.Text;
                // NCプログラム番号
                ds.Tables["加工"].Rows[rowNo]["プログラム番号"] = frmKakou.textBoxNCProgramNo.Text;
                // NC取り数
                ds.Tables["加工"].Rows[rowNo]["NC取り数"] = frmKakou.textBoxNCTorisu.Text;
                // 参照画像1
                ds.Tables["加工"].Rows[rowNo]["参照画像1"] = frmKakou.textBoxGazo1.Text;
                // 参照画像2
                ds.Tables["加工"].Rows[rowNo]["参照画像2"] = frmKakou.textBoxGazo2.Text;
                // 参照画像3
                ds.Tables["加工"].Rows[rowNo]["参照画像3"] = frmKakou.textBoxGazo3.Text;

                //DisplayKakou(toolSSLabelKanriCode.Text);
            }

        }

        //
        //加工作業　削除
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DataTable ddt = ds.Tables["加工"];
            //現在のアクティブな行を取得 0～
            int rowNo = dataGridViewKako.CurrentCellAddress.Y;

            //選択されていなければなにもしない
            if (rowNo == -1) return;

            if (MessageBox.Show((string)ddt.Rows[rowNo]["加工管理コード"] + "\r\n" + 
                                (string)ddt.Rows[rowNo]["加工種"] + "\r\n" +
                                (string)ddt.Rows[rowNo]["機械"] + "\r\n" + 
                                (string)ddt.Rows[rowNo]["作業内容"] + "\r\n" +
                                        " を削除します。\r\n" +
                                        "よろしいですか？",
                                        "部品マスタ　加工",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                //サーバーに接続
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                try
                {
                    DataTable dtb = ds.Tables["加工"];
                    DataRowCollection mrows = dtb.Rows;

                    using (var transaction = con.BeginTransaction())
                    using (var mcom = new SqlCommand() { Connection = con, Transaction = transaction })
                    {
                        try
                        {
                            mcom.CommandText = "DELETE FROM 加工 WHERE 加工管理コード = '" + (string)ddt.Rows[rowNo]["加工管理コード"] + "'";
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

                buttonSave.PerformClick();
            }

        }

        private void ButtonAddNut_Click(object sender, EventArgs e)
        {
            FormNut frmNut = new FormNut();

            frmNut.labelTokuisaki.Text = textBoxTokuisaki.Text;
            frmNut.labelSeihinCode.Text = textBoxSeihinCode.Text;
            frmNut.labelSeihinMei.Text = textBoxSeihinMei.Text;
            frmNut.labelBuhinCode.Text = textBoxBuhinCode.Text;
            frmNut.labelBuhin.Text = textBoxSiyoTaisyo.Text + " " +
                                        textBoxThickness.Text + "T x " +
                                        textBoxWidth.Text + " x " +
                                        textBoxLength.Text;
            frmNut.labelSuryo.Text = "数量 " + textBoxSuryo.Text;
            frmNut.labelKanriCode.Text = toolSSLabelKanriCode.Text;
            frmNut.labelKakouKanriCode.Text = "";

            if (frmNut.ShowDialog() == DialogResult.OK)
            {
                DisplayNut(toolSSLabelKanriCode.Text);
            }

        }

        private void ButtonNutEdit_Click(object sender, EventArgs e)
        {
            int rowNo = dataGridViewKako.CurrentCellAddress.Y;


            FormNut frmNut = new FormNut();

            frmNut.labelTokuisaki.Text = textBoxTokuisaki.Text;
            frmNut.labelSeihinCode.Text = textBoxSeihinCode.Text;
            frmNut.labelSeihinMei.Text = textBoxSeihinMei.Text;
            frmNut.labelBuhinCode.Text = textBoxBuhinCode.Text;
            frmNut.labelBuhin.Text = textBoxSiyoTaisyo.Text + " " +
                                        textBoxThickness.Text + "T x " +
                                        textBoxWidth.Text + " x " +
                                        textBoxLength.Text;
            frmNut.labelSuryo.Text = "数量 " + textBoxSuryo.Text;
            frmNut.labelKanriCode.Text = toolSSLabelKanriCode.Text;
            string editNo = string.Format("{0}-{1}", toolSSLabelKanriCode.Text, (string)ds.Tables["金物"].Rows[rowNo]["金物コード"]);
            frmNut.labelKakouKanriCode.Text = editNo;
            //金物コード
            frmNut.textBoxNutCode.Text = (string)ds.Tables["金物"].Rows[rowNo]["金物コード"].ToString();
            //金物名
            frmNut.textBoxNut.Text = (string)ds.Tables["金物"].Rows[rowNo]["金物名"];
            //数量
            decimal suryo = (decimal)ds.Tables["金物"].Rows[rowNo]["数量"];
            frmNut.textBoxSuryo.Text = suryo.ToString("#,#0.#");

            if (frmNut.ShowDialog() == DialogResult.OK)
            {
                DisplayNut(toolSSLabelKanriCode.Text);
            }

        }

        private void ButtonUp_Click(object sender, EventArgs e)
        {
            if (dataGridViewKako.CurrentCell == null) return;
            if (dataGridViewKako.CurrentCell.RowIndex == 0) return;
            object[] obj = ds.Tables["加工"].Rows[dataGridViewKako.CurrentCell.RowIndex].ItemArray;
            object[] obj2 = ds.Tables["加工"].Rows[dataGridViewKako.CurrentCell.RowIndex - 1].ItemArray;
            ds.Tables["加工"].Rows[dataGridViewKako.CurrentCell.RowIndex].ItemArray = obj2;
            ds.Tables["加工"].Rows[dataGridViewKako.CurrentCell.RowIndex - 1].ItemArray = obj;
            dataGridViewKako.CurrentCell = dataGridViewKako.Rows[dataGridViewKako.CurrentCell.RowIndex - 1].Cells[0];

            buttonAdd.Enabled = false;
            buttonEdit.Enabled = false;

        }

        private void ButtonDown_Click(object sender, EventArgs e)
        {
            if (dataGridViewKako.CurrentCell == null) return;
            if (dataGridViewKako.CurrentCell.RowIndex == dataGridViewKako.Rows.Count - 1) return;
            object[] obj = ds.Tables["加工"].Rows[dataGridViewKako.CurrentCell.RowIndex + 1].ItemArray;
            object[] obj2 = ds.Tables["加工"].Rows[dataGridViewKako.CurrentCell.RowIndex].ItemArray;
            ds.Tables["加工"].Rows[dataGridViewKako.CurrentCell.RowIndex].ItemArray = obj;
            ds.Tables["加工"].Rows[dataGridViewKako.CurrentCell.RowIndex + 1].ItemArray = obj2;
            dataGridViewKako.CurrentCell = dataGridViewKako.Rows[dataGridViewKako.CurrentCell.RowIndex + 1].Cells[0];

            buttonAdd.Enabled = false;
            buttonEdit.Enabled = false;

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            //行を削除したり並び替えたりしたときに保存する
            //
            //サーバーに接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {

                //データセットの行数を取得 B
                int dgvCnt = 0;
                dgvCnt = dataGridViewKako.BindingContext[dataGridViewKako.DataSource, dataGridViewKako.DataMember].Count;

                DataTable dtb = ds.Tables["加工"];
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
                            mcom.CommandText = "UPDATE 加工 SET" +
                                " 順番 = " + rowNo.ToString() +
                                " WHERE 加工管理コード = '" + (string)mrows[i]["加工管理コード"] + "'";
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
            string scd = toolSSLabelKanriCode.Text;
            DisplayKakou(scd);

        }

        private void ButtonDeleteNut_Click(object sender, EventArgs e)
        {
            //ナット　削除
            DataTable ddt = ds.Tables["金物"];
            //現在のアクティブな行を取得 0～
            int rowNo = dataGridViewNut.CurrentCellAddress.Y;

            //選択されていなければなにもしない
            if (rowNo == -1) return;

            if (MessageBox.Show((string)ddt.Rows[rowNo]["金物コード"] + "\r\n" +
                                (string)ddt.Rows[rowNo]["金物名"] + "\r\n" +
                                        " を削除します。\r\n" +
                                        "よろしいですか？",
                                        "部品マスタ　金物（ナット)",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                //サーバーに接続
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                try
                {
                    DataTable dtb = ds.Tables["金物"];
                    DataRowCollection mrows = dtb.Rows;

                    using (var transaction = con.BeginTransaction())
                    using (var mcom = new SqlCommand() { Connection = con, Transaction = transaction })
                    {
                        try
                        {
                            mcom.CommandText = "DELETE FROM 金物 WHERE 金物管理コード = '" + (string)ddt.Rows[rowNo]["金物管理コード"] + "'";
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
    }
}
