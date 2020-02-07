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
    public partial class FormCheckKomoku : Form
    {
        public FormCheckKomoku()
        {
            InitializeComponent();
        }

        //SQLサーバー接続文字
        private string constr = @Properties.Settings.Default.ConnectStr;
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

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

        private void DisplayCheckKomoku(string sqlstr)
        {
            //SQL文が空白なら処理しない
            if (sqlstr != "")
            {
                //サーバー接続
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                try
                {


                    //データテーブル初期化
                    ds.Tables["製品チェック"].Rows.Clear();

                    //テーブルへ行を追加

                    SqlCommand comMei = new SqlCommand(sqlstr, con);
                    SqlDataReader sdrMei = comMei.ExecuteReader();

                    while (sdrMei.Read())
                    {
                        DataRow row = ds.Tables["製品チェック"].NewRow();

                        row["Id"] = (int)sdrMei["Id"];
                        row["グループ"] = (string)sdrMei["グループ"];
                        row["順番"] = (int)sdrMei["順番"];
                        row["項目"] = (string)sdrMei["項目"];
                        row["削除FL"] = false;
                        ds.Tables["製品チェック"].Rows.Add(row);
                    }

                    sdrMei.Close();


                }
                finally
                {
                    //サーバー切断
                    con.Close();
                }

            }
        }


        private void FormCheckKomoku_Load(object sender, EventArgs e)
        {
            dt.TableName = "製品チェック";

            dt.Columns.Add("Id", Type.GetType("System.Int32"));
            dt.Columns.Add("グループ");
            dt.Columns.Add("順番", Type.GetType("System.Int32"));
            dt.Columns.Add("項目");
            dt.Columns.Add("削除FL", Type.GetType("System.Boolean"));

            ds.Tables.Add(dt);

            dataGridViewCheck.AutoGenerateColumns = false;
            dataGridViewCheck.DataSource = ds.Tables["製品チェック"];

            if (labelSeihinCode.Text == "") return;
            string sqlStr = "SELECT * FROM 製品チェック WHERE 製品コード = '" + labelSeihinCode.Text + "' ORDER BY グループ,順番";
            DisplayCheckKomoku(sqlStr);

        }

        private void buttonAddMeisai_Click(object sender, EventArgs e)
        {
            //明細行追加ボタン
            ds.Tables["製品チェック"].Rows.Add(ds.Tables["製品チェック"].NewRow());

            int rowNo = ds.Tables["製品チェック"].Rows.Count - 1;
            ds.Tables["製品チェック"].Rows[rowNo]["削除FL"] = false;

            dataGridViewCheck.CurrentCell = dataGridViewCheck["グループ", rowNo];
            dataGridViewCheck.Focus();

        }

        private void buttonDeleteMeisai_Click(object sender, EventArgs e)
        {
            DataTable ddt = ds.Tables["製品チェック"];
            //現在のアクティブな行を取得 0～
            int rowNo = dataGridViewCheck.CurrentCellAddress.Y;
            int mId;

            //選択されていなければなにもしない
            if (rowNo == -1) return;

            //削除フラグ
            //  true
            //      製品コード、製品名、摘要に文字がなければ行を削除
            //                                      あれば取り消し線を表示してフラグＯＮ
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
                dataGridViewCheck.Rows[rowNo].DefaultCellStyle.Font = new Font("MS UI Gothic", 9, FontStyle.Strikeout);
            }
            else
            {
                ddt.Rows[rowNo]["削除FL"] = false;
                dataGridViewCheck.Rows[rowNo].DefaultCellStyle.Font = new Font("MS UI Gothic", 9);
            }

        }

        private void buttonMeisaiSounyu_Click(object sender, EventArgs e)
        {
            DataRow drIns = dt.NewRow();
            //現在のアクティブな行を取得 0～
            int rowNo = dataGridViewCheck.CurrentCellAddress.Y;

            //選択されていなければなにもしない
            if (rowNo == -1) return;

            ds.Tables["製品チェック"].Rows.InsertAt(drIns, rowNo);
            ds.Tables["製品チェック"].Rows[rowNo]["削除FL"] = false;

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
            string sqlStr;
            if (labelSeihinCode.Text != "")
            { 
                sqlStr = "SELECT * FROM 製品チェック WHERE 製品コード = '" + labelSeihinCode.Text + "' ORDER BY グループ,順番"; 
            }
            else
            {
                return;
            }
            

            //サーバー接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                //保存
                //データセットの行数分ループ
                int loopCnt = dataGridViewCheck.BindingContext[dataGridViewCheck.DataSource, dataGridViewCheck.DataMember].Count;
                if (loopCnt == 0) return;   //0行なら何もしない

                DataTable dtm = ds.Tables["製品チェック"];
                DataRowCollection mrows = dtm.Rows;

                using (var transaction = con.BeginTransaction())
                using (var mcom = new SqlCommand() { Connection = con, Transaction = transaction })
                {
                    try
                    {
                        int i = 0;
                        int rowNo = 0;
                        int iId;
                        msgstr = "保存しました";
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
                                    mcom.CommandText = "DELETE FROM 製品チェック WHERE ID = " + iId.ToString();

                                    mcom.ExecuteNonQuery();

                                }
                            }
                            else
                            {
                                //削除フラグ=Fasle
                                //IDをチェック
                                rowNo ++;

                                iId = AddFieldValueInt(mrows[i], "Id");
                                if (iId == -1)
                                {
                                    //ID=NULL
                                    //新規登録
                                    mcom.CommandText = "INSERT INTO 製品チェック (" +
                                        "製品コード, グループ, 順番, 項目)" +
                                        " VALUES ('" +
                                        labelSeihinCode.Text + "', " +
                                        "N'" + AddFieldValueString(mrows[i], "グループ") + "', " +
                                        rowNo.ToString() + ", " +
                                        "N'" + AddFieldValueString(mrows[i], "項目") + "')";
                                    mcom.ExecuteNonQuery();
                                }
                                else
                                {
                                    //ID!=NULL
                                    //上書き
                                    mcom.CommandText = "UPDATE 製品チェック SET " +
                                        "グループ = N'" + AddFieldValueString(mrows[i], "グループ") + "', " +
                                        "順番 = " + rowNo.ToString() + ", " +
                                        "項目 = N'" + AddFieldValueString(mrows[i], "項目") + "' " +
                                        "WHERE Id = " + iId.ToString();
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
            }
            finally
            {
                //サーバー切断
                con.Close();
            }
            //レコードを表示
            if (sqlStr != "")
            {
                DisplayCheckKomoku(sqlStr);
            }
            //結果をメッセージボックスで表示
            MessageBox.Show(msgstr, "製品　出荷前チェック項目");



        }
    }
}
