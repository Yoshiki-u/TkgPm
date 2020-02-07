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
    public partial class FormTokuisakiMst : Form
    {
        public FormTokuisakiMst()
        {
            InitializeComponent();
        }

        //SQLサーバー接続文字
        //private string constr = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TmDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //private string constr = @Properties.Settings.Default.ConnectStr;
        private string constr = @Properties.Settings.Default.ConnectStr;
        //リストボックス初期化
        private void ListIni()
        {
            //リスト全消去
            listBoxTokuisaki.Items.Clear();
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

                    listBoxTokuisaki.Items.Add(string.Format("{0:s} : {1:s}", code.PadRight(13), name));

                }

            }
            finally
            {
                //サーバー切断
                con.Close();
            }

        }


        //選択レコード画面表示
        private void RecordDisp(string codestr)
        {
            //コードが空白なら処理しない
            if (codestr != "")
            {
                //サーバー接続
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                try
                {

                    //得意先コードで検索
                    string sqlstr = "select * from 得意先マスタ where 得意先コード=" + codestr;
                    SqlCommand com = new SqlCommand(sqlstr, con);
                    SqlDataReader sdr = com.ExecuteReader();

                    //見つかった場合のみ処理を行う
                    if (sdr.Read() == true)
                    {
                        string code = (string)sdr["得意先コード"];
                        string name = (string)sdr["得意先名"];
                        string tel = (string)sdr["TEL"];
                        string fax = (string)sdr["FAX"];
                        string ID = sdr["id"].ToString();

                        textBoxTokuisakiCode.Text = code;
                        textBoxTokuisakiMei.Text = name;
                        textBoxTel.Text = tel;
                        textBoxFax.Text = fax;
                        labelID.Text = ID;

                    }

                }
                finally
                {
                    //サーバー切断
                    con.Close();
                }

            }
        }

        private void FormTokuisakiMst_Load(object sender, EventArgs e)
        {
            //リスト表示
            ListIni();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //閉じるボタン
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //追加ボタン
        private void buttonNew_Click(object sender, EventArgs e)
        {
            //画面初期化
            textBoxTokuisakiCode.Text = "";
            textBoxTokuisakiMei.Text = "";
            textBoxTel.Text = "";
            textBoxFax.Text = "";
            labelID.Text = "";
            buttonSave.Text = "登録";

            //得意先コード欄にフォーカス移動
            textBoxTokuisakiCode.Focus();
            //リストの選択を解除
            listBoxTokuisaki.ClearSelected();
        }

        //リストの選択が変わる毎に処理
        private void listBoxTokuisaki_SelectedIndexChanged(object sender, EventArgs e)
        {
            //リストが選択されているときのみ処理
            if (listBoxTokuisaki.SelectedIndex >= 0)
            {
                //リストの選択されているところから得意先コードを抽出
                string liststr = listBoxTokuisaki.SelectedItem.ToString();
                string code = liststr.Substring(0, 8).Trim();
                //レコード表示
                RecordDisp(code);
            }

        }

        //保存ボタン
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //メッセージ用変数を初期化
            string msgstr = "";
            //サーバー接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                //得意先コードをテキストボックスから取得
                string codestr = textBoxTokuisakiCode.Text.Trim();
                //得意先コードで検索
                string sqlstr = "select * from 得意先マスタ where 得意先コード= '" + codestr + "'";
                SqlCommand com = new SqlCommand(sqlstr, con);
                SqlDataReader sdr = com.ExecuteReader();
                //保存クエリー用の変数
                string saveSqlStr = "";

                if (sdr.Read() == true)
                {
                    //同一コードが見つかった場合
                    //更新
                    saveSqlStr = "UPDATE 得意先マスタ " +
                        "SET" +
                        " 得意先コード='" + textBoxTokuisakiCode.Text.Trim() +
                        "' ,得意先名=N'" + textBoxTokuisakiMei.Text.Trim() +
                        "' ,TEL='" + textBoxTel.Text.Trim() +
                        "' ,FAX='" + textBoxFax.Text.Trim() +
                        "' where 得意先コード  = '" + codestr + "'";
                }
                else
                {
                    //同一コードが見つからなかった場合
                    //新規
                    saveSqlStr = "INSERT INTO 得意先マスタ (" +
                            "得意先コード, 得意先名, TEL, FAX" +
                            ") VALUES ('" +
                            textBoxTokuisakiCode.Text.Trim() + "', N'" +
                            textBoxTokuisakiMei.Text.Trim() + "', '" +
                            textBoxTel.Text.Trim() + "', '" +
                            textBoxFax.Text.Trim() + "')";
                }

                //検索結果を破棄
                sdr.Close();

                //クエリー実行
                SqlCommand saveCom = new SqlCommand(saveSqlStr, con);
                saveCom.ExecuteNonQuery();
                msgstr = "保存しました";


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
            //リスト再表示
            ListIni();
            //レコードを表示
            RecordDisp(textBoxTokuisakiCode.Text.Trim());
            //結果をメッセージボックスで表示
            MessageBox.Show(msgstr, "得意先マスタ");

        }

        //削除ボタン
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //ID取得
            string IDstr = labelID.Text;
            if (IDstr == "")
            {
                //IDが空なら処理しない
                return;
            }

            //メッセージボックスを表示する　Yes,No
            DialogResult result = MessageBox.Show(textBoxTokuisakiCode.Text + " : " + textBoxTokuisakiMei.Text + " を削除しますか？",
                "質問",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            //何が選択されたか調べる
            if (result == DialogResult.Yes)
            {
                // 「はい」の場合
                //　削除実行

                //メッセージ用変数を初期化
                string msgstr = "";
                //サーバー接続
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                try
                {
                    string sqlstr = "";

                    //削除
                    sqlstr = "DELETE FROM 得意先マスタ " +
                        " where id=" + IDstr;
                    SqlCommand com = new SqlCommand(sqlstr, con);
                    com.ExecuteNonQuery();
                    msgstr = "削除しました";

                }
                catch (Exception)
                {
                    //失敗
                    msgstr = "削除に失敗しました";
                }
                finally
                {
                    //サーバー切断
                    con.Close();
                }
                //リスt再表示
                ListIni();
                //入力欄クリア
                textBoxTokuisakiCode.Text = "";
                textBoxTokuisakiMei.Text = "";
                textBoxTel.Text = "";
                textBoxFax.Text = "";
                labelID.Text = "";
                //メッセージボックス表示
                MessageBox.Show(msgstr, "得意先マスタ　削除");
            }
        }

        private void labelID_TextChanged(object sender, EventArgs e)
        {
            //ID非表示かどうか
            if (labelID.Text == "")
            {
                //非表示なら削除ボタンを無効に
                buttonDelete.Enabled = false;
            }
            else
            {
                //表示なら削除ボタンを有効に
                buttonDelete.Enabled = true;
            }


        }

        private void buttonDisp_Click(object sender, EventArgs e)
        {
            //入力された得意先コードをリストから検索（前方一致)
            string code = textBoxTokuisakiCode.Text.Trim();

            int lstindex = listBoxTokuisaki.FindString(code);
            if (lstindex >= 0)
            {
                //見つかったらリストを選択状態にする
                listBoxTokuisaki.SetSelected(lstindex, true);
            }

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

            ////サーバーに接続
            //SqlConnection con = new SqlConnection(constr);
            //con.Open();
            //try
            //{
            //    crTokuisakiItiran trpt = new crTokuisakiItiran();

            //    DataTable dt = new DataTable();
            //    dt = dataSetMst1.Tables["得意先マスタ"];

            //    //接続成功
            //    //すべてのレコードをコード昇順で出力
            //    SqlCommand com = con.CreateCommand();
            //    com.CommandText = @"select * from 得意先マスタ ORDER BY 得意先コード";

            //    SqlDataAdapter pad = new SqlDataAdapter(com);
            //    pad.Fill(dt);

            //    trpt.SetDataSource(dt);



            //    FormCrptViewer frmCV = new FormCrptViewer();
            //    frmCV.crystalReportViewer1.ReportSource = trpt;
            //    frmCV.Text = "得意先マスタ　印刷";


            //    frmCV.Show();

            //}
            //finally
            //{
            //    //サーバー切断
            //    con.Close();
            //}

                FormReportViewer frmRptViewwer = new FormReportViewer();
                frmRptViewwer.Show();



        }
    }
}