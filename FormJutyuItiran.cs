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
    public partial class FormJutyuItiran : Form
    {
        //SQLサーバー接続文字
        private string constr = @Properties.Settings.Default.ConnectStr;

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();


        public FormJutyuItiran()
        {
            InitializeComponent();
        }


        private void RecordDisp()
        {
            //サーバー接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {

                //データテーブル初期化
                ds.Tables["受注明細"].Rows.Clear();

                //テーブルへ行を追加
                string strWhere = "WHERE 納期 BETWEEN '" + dateTimePickerStart.Value.ToShortDateString() +
                                                        "' And '" + dateTimePickerEnd.Value.ToShortDateString() + "'";
                if (!checkBoxKanryo.Checked)
                    {
                    strWhere += " And 完了FL<>'true'";
                    }

                string meiSql = "SELECT * FROM 受注明細 " + strWhere +
                                                        " ORDER BY 納期,製品コード,製品名";
                SqlCommand comMei = new SqlCommand(meiSql, con);
                SqlDataReader sdrMei = comMei.ExecuteReader();

                while (sdrMei.Read())
                {
                    DataRow row = ds.Tables["受注明細"].NewRow();

                    row["受注番号"] = (Int32)sdrMei["受注番号"];
                    row["行番号"] = (Int32)sdrMei["行番号"];
                    row["製品コード"] = (string)sdrMei["製品コード"];
                    row["製品名"] = (string)sdrMei["製品名"];
                    row["数量"] = (decimal)sdrMei["数量"];
                    row["単価"] = (decimal)sdrMei["単価"];
                    row["金額"] = (decimal)sdrMei["金額"];
                    row["納期"] = Convert.ToDateTime(sdrMei["納期"]);
                    row["生産完了予定日"] = Convert.ToDateTime(sdrMei["生産完了予定日"]);
                    row["特注FL"] = (bool)sdrMei["特注FL"];
                    row["試作FL"] = (bool)sdrMei["試作FL"];
                    row["摘要"] = (string)sdrMei["摘要"];
                    int yNo = (int)sdrMei["受注番号"];
                    string yNoStr = Program.Right(yNo.ToString("000000000"), 5);
                    row["年間番号"] = int.Parse(yNoStr);

                    ds.Tables["受注明細"].Rows.Add(row);
                }

                sdrMei.Close();

                //dataGridViewMeisai.DataSource = ds.Tables["受注明細"];

            }
            finally
            {
                //サーバー切断
                con.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (ds.Tables["受注明細"].Rows.Count <= 0) return;

            int rowNo = dataGridViewMeisai.CurrentCellAddress.Y;

            string criterion = "WHERE 受注明細.受注番号 = " + ds.Tables["受注明細"].Rows[rowNo]["受注番号"].ToString() +
                                    " And 受注明細.行番号 = " + ds.Tables["受注明細"].Rows[rowNo]["行番号"].ToString();


            using (SqlConnection con = new SqlConnection(constr))
            {
                DatasetJutyu dsm = new DatasetJutyu();

                con.Open();
                SqlCommand com = con.CreateCommand();
                string sql = "SELECT 受注明細.受注番号, 受注明細.製品コード, 受注明細.製品名, 受注明細.数量, 受注明細.金額, 受注明細.納期, " +
                                      "受注明細.生産完了予定日, 受注明細.特注FL, 受注明細.試作FL, 受注明細.摘要, 受注.得意先名, 受注.受注日付, " +
                                      "材種.名称 AS 材種名, 部品マスタ.部品コード, 部品マスタ.管理コード, 部品マスタ.行番号, 部品マスタ.使用対象, " +
                                      "部品マスタ.材種, 部品マスタ.厚さ, 部品マスタ.巾, 部品マスタ.長さ, 部品マスタ.数量 AS 部品数量, " +
                                      "部品マスタ.摘要 AS 部品摘要, 部品マスタ.大井野FL, 部品マスタ.NCFL, 部品マスタ.共通FL, 部品マスタ.在庫FL, " +
                                      "部品マスタ.別納FL " +
                                      "FROM 受注明細 INNER JOIN " +
                                      "受注 ON 受注明細.受注番号 = 受注.受注番号 INNER JOIN " +
                                      "部品マスタ ON 受注明細.製品コード = 部品マスタ.製品コード LEFT OUTER JOIN " +
                                      "材種 ON 部品マスタ.材種 = 材種.材種 " +
                                      criterion +
                                      " ORDER BY 部品マスタ.行番号";



                //データセット作成
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsm.木取加工);

                FormReportViewer frmRptViewer = new FormReportViewer();

                frmRptViewer.Text = "木取り表　加工用　印刷";
                //レポートセッティング
                frmRptViewer.reportViewer1.Reset();
                frmRptViewer.reportViewer1.ProcessingMode = ProcessingMode.Local;
                //frmRptViewer.reportViewer1.LocalReport.ReportPath = Environment.CurrentDirectory + @"\ReportKidori.rdlc";
                //frmRptViewer.reportViewer1.LocalReport.ReportPath = @"C: \Users\yoshi\source\repos\TakagiMokkou\SeisanKanri" + @"\ReportKidoriKakou.rdlc";
                frmRptViewer.reportViewer1.LocalReport.ReportPath = @Properties.Settings.Default.ProFName + @"\ReportKidoriKakou.rdlc";
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = dsm.木取加工;
                //ReportViewerに表示
                frmRptViewer.reportViewer1.LocalReport.DataSources.Add(rds);
                frmRptViewer.reportViewer1.RefreshReport();

                frmRptViewer.Show();

            }

        }

        private void ButtonDisp_Click(object sender, EventArgs e)
        {
            RecordDisp();

        }

        private void FormJutyuItiran_Load(object sender, EventArgs e)
        {
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

            dt.TableName = "受注明細";

            dt.Columns.Add("受注番号", Type.GetType("System.Int32"));
            dt.Columns.Add("行番号", Type.GetType("System.Int32"));
            dt.Columns.Add("製品コード");
            dt.Columns.Add("製品名");
            dt.Columns.Add("数量", Type.GetType("System.Decimal"));
            dt.Columns.Add("単価", Type.GetType("System.Decimal"));
            dt.Columns.Add("金額", Type.GetType("System.Decimal"));
            dt.Columns.Add("納期", Type.GetType("System.DateTime"));
            dt.Columns.Add("生産完了予定日", Type.GetType("System.DateTime"));
            dt.Columns.Add("摘要");
            dt.Columns.Add("特注FL", Type.GetType("System.Boolean"));
            dt.Columns.Add("試作FL", Type.GetType("System.Boolean"));
            dt.Columns.Add("年間番号", Type.GetType("System.Int32"));

            ds.Tables.Add(dt);

            dataGridViewMeisai.AutoGenerateColumns = false;
            dataGridViewMeisai.DataSource = ds.Tables["受注明細"];

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (ds.Tables["受注明細"].Rows.Count <= 0) return;

            int rowNo = dataGridViewMeisai.CurrentCellAddress.Y;

            string criterion = "WHERE 受注明細.受注番号 = " + ds.Tables["受注明細"].Rows[rowNo]["受注番号"].ToString() +
                                    " And 受注明細.行番号 = " + ds.Tables["受注明細"].Rows[rowNo]["行番号"].ToString();


            using (SqlConnection con = new SqlConnection(constr))
            {
                DatasetJutyu dsm = new DatasetJutyu();

                con.Open();
                SqlCommand com = con.CreateCommand();

                string sql = "SELECT 受注明細.受注番号, 受注明細.製品コード, 受注明細.製品名, 受注明細.数量, 受注明細.金額, 受注明細.納期, " +
                                      "受注明細.生産完了予定日, 受注明細.特注FL, 受注明細.試作FL, 受注明細.摘要, 受注.得意先名, 受注.受注日付, " +
                                      "材種.名称 AS 材種名, 部品マスタ.部品コード, 部品マスタ.管理コード, 部品マスタ.行番号, 部品マスタ.使用対象, " +
                                      "部品マスタ.材種, 部品マスタ.厚さ, 部品マスタ.巾, 部品マスタ.長さ, 部品マスタ.数量 AS 部品数量, " +
                                      "部品マスタ.摘要 AS 部品摘要, 部品マスタ.大井野FL, 部品マスタ.NCFL, 部品マスタ.共通FL, 部品マスタ.在庫FL, " +
                                      "部品マスタ.別納FL, 加工.順番, 加工.作業内容 " +
                                      "FROM 受注明細 INNER JOIN " +
                                      "受注 ON 受注明細.受注番号 = 受注.受注番号 INNER JOIN " +
                                      "部品マスタ ON 受注明細.製品コード = 部品マスタ.製品コード LEFT OUTER JOIN " +
                                      "加工 ON 部品マスタ.管理コード = 加工.管理コード LEFT OUTER JOIN " +
                                      "材種 ON 部品マスタ.材種 = 材種.材種 " +
                                      criterion +
                                      " ORDER BY 部品マスタ.行番号, 加工.順番";

                //データセット作成
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsm.加工指示);

                FormReportViewer frmRptViewer = new FormReportViewer();

                frmRptViewer.Text = "木取り表　加工用　印刷";
                //レポートセッティング
                frmRptViewer.reportViewer1.Reset();
                frmRptViewer.reportViewer1.ProcessingMode = ProcessingMode.Local;
                //frmRptViewer.reportViewer1.LocalReport.ReportPath = @"C: \Users\yoshi\source\repos\TakagiMokkou\SeisanKanri" + @"\ReportKakouSiji.rdlc";
                frmRptViewer.reportViewer1.LocalReport.ReportPath = @Properties.Settings.Default.ProFName + @"\ReportKakouSiji.rdlc";
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = dsm.加工指示;
                //ReportViewerに表示
                frmRptViewer.reportViewer1.LocalReport.DataSources.Add(rds);
                frmRptViewer.reportViewer1.RefreshReport();

                frmRptViewer.Show();

            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (ds.Tables["受注明細"].Rows.Count <= 0) return;

            int rowNo = dataGridViewMeisai.CurrentCellAddress.Y;

            string criterion = "WHERE 受注明細.受注番号 = " + ds.Tables["受注明細"].Rows[rowNo]["受注番号"].ToString() +
                                    " And 受注明細.行番号 = " + ds.Tables["受注明細"].Rows[rowNo]["行番号"].ToString() +
                                    " And 加工.プログラム番号 <> 0";

            using (SqlConnection con = new SqlConnection(constr))
            {
                DatasetJutyu dsm = new DatasetJutyu();

                con.Open();
                SqlCommand com = con.CreateCommand();

                string sql = "SELECT 受注明細.受注番号, 受注明細.行番号, 受注明細.製品コード, 受注明細.製品名, 受注明細.数量, 受注明細.納期, " +
                                        "受注明細.生産完了予定日, 受注明細.特注FL, 受注明細.試作FL, 受注明細.摘要, 受注明細.加工木取FL, " +
                                        "受注明細.NC木取FL, 受注明細.作業指示FL, 受注.得意先名, 受注.受注日付, 部品マスタ.部品コード, " +
                                        "部品マスタ.使用対象, 部品マスタ.数量 AS 部品数量, 部品マスタ.シリーズ, 加工.NC取り数, " +
                                        "CONVERT(varchar, NC木取.厚さ) + ' x ' + CONVERT(varchar, NC木取.X) + ' x ' + CONVERT(varchar, NC木取.Y) AS サイズ, " +
                                        "NC木取.備考1, NC木取.備考2, 'o' + CONVERT(varchar, 加工.プログラム番号) AS PNo " +
                                        "FROM 加工 INNER JOIN " +
                                        "部品マスタ ON 加工.管理コード = 部品マスタ.管理コード INNER JOIN " +
                                        "受注明細 INNER JOIN " +
                                        "受注 ON 受注明細.受注番号 = 受注.受注番号 ON 部品マスタ.製品コード = 受注明細.製品コード INNER JOIN " +
                                        "NC木取 ON 加工.NC管理コード = NC木取.NC管理コード " + 
                                        criterion +
                                        " ORDER BY  部品マスタ.シリーズ, PNo, サイズ";

                //データセット作成
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsm.木取NC);

                FormReportViewer frmRptViewer = new FormReportViewer();

                frmRptViewer.Text = "木取り表　ＮＣ用　印刷";
                //レポートセッティング
                frmRptViewer.reportViewer1.Reset();
                frmRptViewer.reportViewer1.ProcessingMode = ProcessingMode.Local;
                //frmRptViewer.reportViewer1.LocalReport.ReportPath = @"C: \Users\yoshi\source\repos\TakagiMokkou\SeisanKanri" + @"\ReportKidoriNC.rdlc";
                frmRptViewer.reportViewer1.LocalReport.ReportPath = @Properties.Settings.Default.ProFName + @"\ReportKidoriNC.rdlc";
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = dsm.木取NC;
                //ReportViewerに表示
                frmRptViewer.reportViewer1.LocalReport.DataSources.Add(rds);
                frmRptViewer.reportViewer1.RefreshReport();

                frmRptViewer.Show();



            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (ds.Tables["受注明細"].Rows.Count <= 0) return;

            int rowNo = dataGridViewMeisai.CurrentCellAddress.Y;

            string criterion = "WHERE 納期 BETWEEN '" + dateTimePickerStart.Value.ToShortDateString() +
                                                    "' And '" + dateTimePickerEnd.Value.ToShortDateString() + "'";

            if (!checkBoxKanryo.Checked)
            {
                criterion += " And 完了FL<>'true'";
            }

            string strKikan = dateTimePickerStart.Text + "  -  " + dateTimePickerEnd.Text;
            string strTokuisaki = comboBoxTokuisaki.Text;
            using (SqlConnection con = new SqlConnection(constr))
            {
                DatasetJutyu dsm = new DatasetJutyu();

                con.Open();
                SqlCommand com = con.CreateCommand();
                string sql = "SELECT 受注明細.*, ROW_NUMBER() OVER (ORDER BY 納期,製品名) AS 連番 FROM 受注明細 " +
                                      criterion +
                                      " ORDER BY 受注明細.納期,受注明細.製品コード,受注明細.製品名";



                //データセット作成
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsm.受注明細);

                FormReportViewer frmRptViewer = new FormReportViewer();

                frmRptViewer.Text = "受注一覧　印刷";
                //レポートセッティング
                frmRptViewer.reportViewer1.Reset();
                frmRptViewer.reportViewer1.ProcessingMode = ProcessingMode.Local;
                //frmRptViewer.reportViewer1.LocalReport.ReportPath = @"C: \Users\yoshi\source\repos\TakagiMokkou\SeisanKanri" + @"\ReportJutyuItiran.rdlc";
                frmRptViewer.reportViewer1.LocalReport.ReportPath = @Properties.Settings.Default.ProFName + @"\ReportJutyuItiran.rdlc";
                
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = dsm.受注明細;
                //ReportViewerに表示
                frmRptViewer.reportViewer1.LocalReport.DataSources.Add(rds);

                ReportParameter paramKikan = new ReportParameter("rpKikan", strKikan);
                frmRptViewer.reportViewer1.LocalReport.SetParameters(paramKikan);

                ReportParameter paramTokuisaki = new ReportParameter("rpTokuisaki", strTokuisaki);
                frmRptViewer.reportViewer1.LocalReport.SetParameters(paramTokuisaki);

                frmRptViewer.reportViewer1.RefreshReport();

                frmRptViewer.Show();

            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (ds.Tables["受注明細"].Rows.Count <= 0) return;

            int rowNo = dataGridViewMeisai.CurrentCellAddress.Y;

            string criterion = "WHERE 受注明細.受注番号 = " + ds.Tables["受注明細"].Rows[rowNo]["受注番号"].ToString() +
                                    " And 受注明細.行番号 = " + ds.Tables["受注明細"].Rows[rowNo]["行番号"].ToString();

            decimal dSuryo = (decimal)ds.Tables["受注明細"].Rows[rowNo]["数量"];
            int suryo = (int)dSuryo;

            using (SqlConnection con = new SqlConnection(constr))
            {
                DatasetJutyu dsm = new DatasetJutyu();

                con.Open();
                SqlCommand com = con.CreateCommand();
                string sql = "SELECT 受注明細.Id, 受注明細.受注番号, 受注明細.行番号, 受注明細.製品コード, 受注明細.製品名, 受注明細.数量, " +
                             "受注明細.納期, 受注明細.生産完了予定日, 製品チェック.グループ, 製品チェック.順番, 製品チェック.項目 " +
                             "FROM 受注明細 INNER JOIN " +
                             "製品チェック ON 受注明細.製品コード = 製品チェック.製品コード " +
                             criterion +
                             " ORDER BY 製品チェック.グループ, 製品チェック.順番";
                SqlCommand comMei = new SqlCommand(sql, con);
                SqlDataReader sdrMei = comMei.ExecuteReader();
                int loopCnt;

                while (sdrMei.Read())
                {
                    loopCnt = 1;
                    while (loopCnt <= suryo)
                    {
                        //DataRow row = dsm.Tables["出荷チェック"].NewRow();
                        DataRow row = dsm.出荷前チェック.NewRow();
                        row["受注番号"] = (int)sdrMei["受注番号"];
                        row["行番号"] = (int)sdrMei["行番号"];
                        row["製品コード"] = (string)sdrMei["製品コード"];
                        row["製品名"] = (string)sdrMei["製品名"];
                        row["数量"] = (decimal)sdrMei["数量"];
                        row["納期"] = Convert.ToDateTime(sdrMei["納期"]);
                        row["生産完了予定日"] = Convert.ToDateTime(sdrMei["生産完了予定日"]);
                        row["グループ"] = (string)sdrMei["グループ"];
                        row["順番"] = (int)sdrMei["順番"];
                        row["項目"] = (string)sdrMei["項目"];
                        row["生産番号"] = loopCnt;
                        dsm.出荷前チェック.Rows.Add(row);
                        loopCnt++;
                    }
                }

                sdrMei.Close();

                //データセット作成
                //SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                //            adapter.Fill(dsm.出荷前チェック);

                FormReportViewer frmRptViewer = new FormReportViewer();

                frmRptViewer.Text = "出荷前チェック　印刷";
                //レポートセッティング
                frmRptViewer.reportViewer1.Reset();
                frmRptViewer.reportViewer1.ProcessingMode = ProcessingMode.Local;
                //frmRptViewer.reportViewer1.LocalReport.ReportPath = @"C: \Users\yoshi\source\repos\TakagiMokkou\SeisanKanri" + @"\ReportPreShipmentCheck.rdlc";
                frmRptViewer.reportViewer1.LocalReport.ReportPath = @Properties.Settings.Default.ProFName + @"\ReportPreShipmentCheck.rdlc";
                
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = dsm.Tables["出荷前チェック"];
                //ReportViewerに表示
                frmRptViewer.reportViewer1.LocalReport.DataSources.Add(rds);
                frmRptViewer.reportViewer1.RefreshReport();

                frmRptViewer.Show();


            }
        }

        private void dataGridViewMeisai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }    
}

