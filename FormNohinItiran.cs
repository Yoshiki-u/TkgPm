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
    public partial class FormNohinItiran : Form
    {
        //SQLサーバー接続文字
        private string constr = @Properties.Settings.Default.ConnectStr;

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        public FormNohinItiran()
        {
            InitializeComponent();
        }

        private void FormNohinItiran_Load(object sender, EventArgs e)
        {
            dt.TableName = "納品";

            dt.Columns.Add("受注番号", Type.GetType("System.Int32"));
            dt.Columns.Add("行番号", Type.GetType("System.Int32"));
            dt.Columns.Add("製品コード");
            dt.Columns.Add("製品名");
            dt.Columns.Add("数量", Type.GetType("System.Decimal"));
            dt.Columns.Add("納品日", Type.GetType("System.DateTime"));
            dt.Columns.Add("摘要");
            dt.Columns.Add("特注FL", Type.GetType("System.Boolean"));
            dt.Columns.Add("試作FL", Type.GetType("System.Boolean"));
            dt.Columns.Add("必着FL", Type.GetType("System.Boolean"));
            dt.Columns.Add("完了FL", Type.GetType("System.Boolean"));
            dt.Columns.Add("年間番号", Type.GetType("System.Int32"));

            ds.Tables.Add(dt);

            dataGridViewMeisai.AutoGenerateColumns = false;
            dataGridViewMeisai.DataSource = ds.Tables["納品"];


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

                //string meiSql = "SELECT * FROM 受注明細 WHERE 納期 BETWEEN '" + dateTimePickerStart.Value.ToShortDateString() +
                //                                        "' And '" + dateTimePickerEnd.Value.ToShortDateString() +
                //                                        "' ORDER BY 納期,製品名";
                string meiSql = "SELECT 納品.Id, 納品.受注明細ID, 納品.納品日, 納品.納品数, 納品.必着FL, 納品.完了FL, 納品.摘要, 納品.行番号, " +
                                        "受注明細.製品コード, 受注明細.製品名, 受注明細.受注番号, " +
                                        "受注明細.行番号 AS 受注明細行番号, 受注明細.特注FL, 受注明細.試作FL " +
                                "FROM 納品 INNER JOIN 受注明細 ON 納品.受注明細ID = 受注明細.Id " +
                                "WHERE 納品日 BETWEEN '" + dateTimePickerStart.Value.ToShortDateString() +
                                                    "' And '" + dateTimePickerEnd.Value.ToShortDateString() +
                                "ORDER BY 納品.納品日, 受注明細.製品名, 納品.行番号";

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

        private void buttonDisp_Click(object sender, EventArgs e)
        {

        }
    }
}
