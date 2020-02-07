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
    public partial class FormNohinHenko : Form
    {
        //SQLサーバー接続文字
        private string constr = @Properties.Settings.Default.ConnectStr;

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        //明細カラム設定
        const int intDgNohinbi = 0;
        const int intDgNohinsu = 1;
        const int intDgTekiyo = 2;
        const int intDgHittyakuFL = 3;
        const int intDgKanryoFL = 4;

        public FormNohinHenko()
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

        private DateTime AddFieldValueDateTime(DataRow row, string fieldName, DateTime defaultDate)
        {
            if (!DBNull.Value.Equals(row[fieldName]))
                return (DateTime)row[fieldName];
            else
                return defaultDate;
        }

        private Int32 AddFieldValueInt(DataRow row, string fieldName)
        {
            if (!DBNull.Value.Equals(row[fieldName]))
                return (Int32)row[fieldName];
            else
                return -1;
        }

        private void FormNohinHenko_Load(object sender, EventArgs e)
        {
            dt.TableName = "納品";

            dt.Columns.Add("Id", Type.GetType("System.Int32"));
            dt.Columns.Add("納品日", Type.GetType("System.DateTime"));
            dt.Columns.Add("納品数", Type.GetType("System.Decimal"));
            dt.Columns.Add("摘要");
            dt.Columns.Add("必着FL", Type.GetType("System.Boolean"));
            dt.Columns.Add("完了FL", Type.GetType("System.Boolean"));
            dt.Columns.Add("削除FL", Type.GetType("System.Boolean"));

            ds.Tables.Add(dt);

            dataGridViewNohin.AutoGenerateColumns = false;
            dataGridViewNohin.DataSource = ds.Tables["納品"];

            Program.CalendarColumn col5 = new Program.CalendarColumn();
            col5.DataPropertyName = "納品日";
            col5.HeaderText = "納品日";
            dataGridViewNohin.Columns.Remove("納品日");
            dataGridViewNohin.Columns.Insert(intDgNohinbi, col5);

            //管理コードが空白なら処理しない
            int scd;
            if (int.TryParse(toolSSLabel1.Text,out scd))
            {
                DisplayNohin(scd);
            }
            

        }
        private void DisplayNohin(int jmId)
        {
            //納品データを表示
            //データテーブル初期化
            ds.Tables["納品"].Rows.Clear();

            int rowCnt = 0;

            if (jmId != -1)
            {
                //サーバー接続
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                try
                {
                    //テーブルへ行を追加
                    string meiSql = "SELECT * " +
                                    "FROM 納品 " +
                                    "WHERE 受注明細ID = " + jmId +
                                    " ORDER BY 行番号";

                    SqlCommand comNohin = new SqlCommand(meiSql, con);
                    SqlDataReader sdrNohin = comNohin.ExecuteReader();

                    while (sdrNohin.Read())
                    {
                        DataRow row = ds.Tables["納品"].NewRow();

                        row["Id"] = (int)sdrNohin["Id"];
                        row["納品日"] = Convert.ToDateTime(sdrNohin["納品日"]);
                        row["納品数"] = (decimal)sdrNohin["納品数"];
                        row["摘要"] = (string)sdrNohin["摘要"];
                        row["必着FL"] = (bool)sdrNohin["必着FL"];
                        row["完了FL"] = (bool)sdrNohin["完了FL"];
                        row["削除FL"] = false;
                        ds.Tables["納品"].Rows.Add(row);
                        rowCnt++;

                    }

                    sdrNohin.Close();
                }
                finally
                {
                    //サーバー切断
                    con.Close();
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewNohin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            //明細行追加ボタン
            ds.Tables["納品"].Rows.Add(ds.Tables["納品"].NewRow());

            int rowNo = ds.Tables["納品"].Rows.Count - 1;
            ds.Tables["納品"].Rows[rowNo]["削除FL"] = false;

            //dataGridViewNohin.CurrentCell = dataGridViewNohin["納品日", rowNo];
            dataGridViewNohin.Focus();

        }

        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            DataTable ddt = ds.Tables["納品"];
            //現在のアクティブな行を取得 0～
            int rowNo = dataGridViewNohin.CurrentCellAddress.Y;
            int mId;

            //選択されていなければなにもしない
            if (rowNo == -1) return;

            //削除フラグ
            //  true
            //      Idに数字が入っていれば取り消し線を表示してフラグＯＮ
            // false
            //      取り消し線の非表示にしてフラグＯＦＦ
            if ((bool)ddt.Rows[rowNo]["削除FL"] == false)
            {
                if (DBNull.Value.Equals(ddt.Rows[rowNo]["Id"]))
                {
                    ddt.Rows.Remove(dt.Rows[rowNo]);
                    return;
                }
                ddt.Rows[rowNo]["削除FL"] = true;
                dataGridViewNohin.Rows[rowNo].DefaultCellStyle.Font = new Font("MS UI Gothic", 9, FontStyle.Strikeout);
            }
            else
            {
                ddt.Rows[rowNo]["削除FL"] = false;
                dataGridViewNohin.Rows[rowNo].DefaultCellStyle.Font = new Font("MS UI Gothic", 9);
            }

        }

        private void buttonInsertRow_Click(object sender, EventArgs e)
        {
            DataRow drIns = dt.NewRow();
            //現在のアクティブな行を取得 0～
            int rowNo = dataGridViewNohin.CurrentCellAddress.Y;

            //選択されていなければなにもしない
            if (rowNo == -1) return;

            ds.Tables["納品"].Rows.InsertAt(drIns, rowNo);
            ds.Tables["納品"].Rows[rowNo]["削除FL"] = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //保存前チェック
            string errMsgStr = "";
            //メッセージ用変数を初期化
            string msgstr = "";
            //保存クエリー用の変数
            string saveSqlStr = "";
            string noSaveSqlStr = "";  //番号保存用

            string editNo = "";
            string sqlStr = "";
            int nId;
            int rowNo = 0;
            if (!int.TryParse(toolSSLabel1.Text, out nId))
            {
                //IDがNULLなら何もしない
                return;
            }

            //サーバー接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                //
                //納品保存

                //データセットの行数分ループ
                int loopCnt = dataGridViewNohin.BindingContext[dataGridViewNohin.DataSource, dataGridViewNohin.DataMember].Count;
                if (loopCnt == 0) return;   //0行なら何もしない




                DataTable dtm = ds.Tables["納品"];
                DataRowCollection mrows = dtm.Rows;

                using (var transaction = con.BeginTransaction())
                using (var mcom = new SqlCommand() { Connection = con, Transaction = transaction })
                {
                    try
                    {
                        int i = 0;

                        int iId;
                        DateTime nouki;
                        while (i < loopCnt)
                        {
                            //データセットの削除フラグをチェック
                            if (AddFieldValueBool(mrows[i], "削除FL"))
                            {
                                //削除フラグ=True
                                //IDをチェック
                                iId = AddFieldValueInt(mrows[i], "Id");
                                if (iId == -1)
                                {
                                    //ID=NULL(新規のデータ)
                                    //何もしない

                                }
                                else
                                {
                                    //ID!=NULL(既にDB上に存在するデータ)
                                    //削除
                                    mcom.CommandText = "DELETE FROM 納品 WHERE ID = " + iId.ToString();

                                    mcom.ExecuteNonQuery();

                                }
                            }
                            else
                            {
                                //削除フラグ=Fasle
                                //IDをチェック
                                rowNo = i + 1;
                                nouki = AddFieldValueDateTime(mrows[i], "納品日", System.DateTime.Today);

                                iId = AddFieldValueInt(mrows[i], "Id");
                                if (iId == -1)
                                {

                                    //ID=NULL
                                    //新規登録
                                    mcom.CommandText = "INSERT INTO 納品 (" +
                                        "受注明細ID,納品日,納品数, 摘要, 必着FL, 完了FL, 行番号)" +
                                        " VALUES (" +
                                        nId.ToString() + ", " +
                                        "'" + nouki + "', " +
                                        AddFieldValueDecimal(mrows[i], "納品数").ToString() + ", " +
                                        "N'" + AddFieldValueString(mrows[i], "摘要") + "', " +
                                        "'" + AddFieldValueBool(mrows[i], "必着FL") + "', " +
                                        "'" + AddFieldValueBool(mrows[i], "完了FL") + "', " +
                                        rowNo.ToString() + ")";
                                    mcom.ExecuteNonQuery();
                                }
                                else
                                {
                                    //ID!=NULL
                                    //上書き
                                    mcom.CommandText = "UPDATE 納品 SET " +
                                        "納品日 = '" + nouki + "', " +
                                        "納品数 = " + AddFieldValueDecimal(mrows[i], "納品数").ToString() + ", " +
                                        "必着FL = '" + AddFieldValueBool(mrows[i], "必着FL") + "', " +
                                        "完了FL = '" + AddFieldValueBool(mrows[i], "完了FL") + "', " +
                                        "摘要 = N'" + AddFieldValueString(mrows[i], "摘要") + "', " +
                                        "行番号 = " + rowNo.ToString() + 
                                        " WHERE Id = " + iId.ToString();
                                    mcom.ExecuteNonQuery();


                                }
                            }
                            i++;

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
                //結果をメッセージボックスで表示
                MessageBox.Show(msgstr, "受注");
            }
            finally
            {
                //サーバー切断
                con.Close();
            }
            //レコードを表示
            if (rowNo>0)
            {
                DisplayNohin(nId);
            }

        }
    }

}
