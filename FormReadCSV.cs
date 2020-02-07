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
    public partial class FormReadCSV : Form
    {
        //SQLサーバー接続文字
        private string constr = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yoshi\source\repos\TakagiMokkou\TmDB.mdf;Integrated Security = True; Connect Timeout = 30";
        private DataSet ds = new DataSet();

        public FormReadCSV()
        {
            InitializeComponent();
        }



        private void SeihinRead()
        {
            DataTable dt = new DataTable();

            dt.TableName = "製品マスタ";
            dt.Columns.Add("id", Type.GetType("System.Int32"));
            dt.Columns.Add("製品コード");
            ds.Tables.Add(dt);


            DataTable dtCSV = new DataTable();

            dtCSV.TableName = "製品CSV";
            dtCSV.Columns.Add("取引先別コード");
            dtCSV.Columns.Add("取引先別名");
            dtCSV.Columns.Add("製品コード");
            dtCSV.Columns.Add("製品名");
            ds.Tables.Add(dtCSV);


            string delimStr = ",";
            char[] delimiter = delimStr.ToCharArray();
            string[] strData;
            string strLine;

                       
            //保存前チェック
            string errMsgStr = "";



            //CSV読み込み
            string path = textBoxPath.Text;
            bool fileExists = System.IO.File.Exists(path);
            if (!fileExists) return;

            System.IO.StreamReader sr = new System.IO.StreamReader(
                                            path,
                                            System.Text.Encoding.Default);

            while (sr.Peek() >= 0)
            {
                strLine = sr.ReadLine();
                strData = strLine.Split(delimiter);
                DataRow cRow = ds.Tables["製品CSV"].NewRow();
                cRow["取引先別コード"] = strData[0];
                cRow["取引先別名"] = strData[1];
                cRow["製品コード"] = strData[2];
                cRow["製品名"] = strData[3];
                ds.Tables["製品CSV"].Rows.Add(cRow);

            }
            sr.Close();

            //メッセージ用変数を初期化
            string msgstr = "";
            //サーバー接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                //製品を全件読み込み
                string sqlstr = "select id,製品コード from 製品マスタ";
                SqlCommand com = new SqlCommand(sqlstr, con);
                SqlDataReader sdr = com.ExecuteReader();
                //保存クエリー用の変数

                while (sdr.Read() == true)
                {
                    DataRow bRow = ds.Tables["製品マスタ"].NewRow();
                    bRow["id"] = (int)sdr["id"];
                    bRow["製品コード"] = (string)sdr["製品コード"];
                    ds.Tables["製品マスタ"].Rows.Add(bRow);
                }
                sdr.Close();

                int rowCount = ds.Tables["製品CSV"].Rows.Count;
                int rowNo = 0;


                using (var transaction = con.BeginTransaction())
                using (var mcom = new SqlCommand() { Connection = con, Transaction = transaction })
                {
                    DataRow[] targetRow;
                    try
                    {
                        while (rowNo < rowCount)
                        {
                            targetRow = ds.Tables["製品マスタ"].Select("製品コード = '" + ds.Tables["製品CSV"].Rows[rowNo]["製品コード"] + "'");
                            if (targetRow.Count() != 0)
                            {
                                //上書き
                                mcom.CommandText = "UPDATE 製品マスタ " +
                                    "SET" +
                                    " 製品名=N'" + ds.Tables["製品CSV"].Rows[rowNo]["製品名"] + "'," +
                                    " 得意先コード='" + ds.Tables["製品CSV"].Rows[rowNo]["取引先別コード"] + "'," +
                                    " 最終入力日 =  getdate()" +
                                    " where 製品コード  = '" + ds.Tables["製品CSV"].Rows[rowNo]["製品コード"] + "'";
                                mcom.ExecuteNonQuery();

                            }
                            else
                            {
                                //追加
                                mcom.CommandText = "INSERT INTO 製品マスタ (" +
                                        "製品コード, 製品名, 得意先コード, 単価, 摘要, 共通FL, 最終入力日" +
                                        ") VALUES ('" +
                                        ds.Tables["製品CSV"].Rows[rowNo]["製品コード"] + "'," +
                                        " N'" + ds.Tables["製品CSV"].Rows[rowNo]["製品名"] + "'," +
                                        "'" + ds.Tables["製品CSV"].Rows[rowNo]["取引先別コード"] + "', " +
                                        "0," +
                                        " N'' ," +
                                        "'false' ," +
                                        " getdate())";
                                mcom.ExecuteNonQuery();

                            }
                            rowNo++;
                        }

                        transaction.Commit();

                    }
                    catch (Exception exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show(exception.Message);
                    }

                }

            }
            catch (Exception)
            {
                //書き込み失敗
                msgstr = "書き込み失敗";
            }
            finally
            {
                //サーバー切断
                con.Close();
            }
            //結果をメッセージボックスで表示
            MessageBox.Show(msgstr, "製品マスタ");

        }

        private void ButtonRefPath_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                textBoxPath.Text = openFileDialog1.FileName;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SeihinRead();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
