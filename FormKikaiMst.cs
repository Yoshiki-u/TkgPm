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
    public partial class FormKikaiMst : Form
   {
        //SQLサーバー接続文字
        private string constr = @Properties.Settings.Default.ConnectStr;

        public FormKikaiMst()
        {
            InitializeComponent();
        }

        private void ListIni()
        {
            //リスト全消去
            listBoxSeihin.Items.Clear();

            //サーバーに接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                //接続成功
                //すべてのレコードをコード昇順で出力
                string sqlstr = "select * from 機械 ORDER BY 機械コード";
                SqlCommand com = new SqlCommand(sqlstr, con);
                SqlDataReader sdr = com.ExecuteReader();

                //リスト表示
                while (sdr.Read() == true)
                {
                    //書式xxx : xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
                    string code = (string)sdr["機械コード"];
                    string name = (string)sdr["機械"];

                    listBoxSeihin.Items.Add(string.Format("{0:s} : {1:s}", code.PadRight(3), name));

                }

            }
            finally
            {
                //サーバー切断
                con.Close();
            }

        }


        //レコード表示
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

                    //金物コードで検索
                    string sqlstr = "select * from 機械 where 機械コード=" + codestr;
                    SqlCommand com = new SqlCommand(sqlstr, con);
                    SqlDataReader sdr = com.ExecuteReader();

                    //見つかった場合のみ処理を行う
                    if (sdr.Read() == true)
                    {
                        string code = (string)sdr["機械コード"];
                        string name = (string)sdr["機械"];
                        string ID = sdr["id"].ToString();

                        textBoxSeihinCode.Text = code;
                        textBoxSeihinMei.Text = name;
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


        private void FormKikaiMst_Load(object sender, EventArgs e)
        {
            ListIni();
        }

        private void ListBoxSeihin_SelectedIndexChanged(object sender, EventArgs e)
        {
            //リストが選択されているときのみ処理
            if (listBoxSeihin.SelectedIndex >= 0)
            {
                //リストの選択されているところからコードを抽出
                string liststr = listBoxSeihin.SelectedItem.ToString();
                string code = liststr.Substring(0, 3).Trim();
                //レコード表示
                RecordDisp(code);
                buttonDelete.Enabled = true;

            }

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            //保存前チェック
            string errMsgStr = "";
            //商品コードが空白はNG
            if (textBoxSeihinCode.Text.Trim() == "")
            {
                errMsgStr += "機械コードが入力されていません。\r\n";
            }

            //メッセージ用変数を初期化
            string msgstr = "";
            //サーバー接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                //金物コードをテキストボックスから取得
                string codestr = textBoxSeihinCode.Text.Trim();
                //金物コードで検索
                string sqlstr = "select * from 機械 where 機械コード= '" + codestr + "'";
                SqlCommand com = new SqlCommand(sqlstr, con);
                SqlDataReader sdr = com.ExecuteReader();
                //保存クエリー用の変数
                string saveSqlStr = "";

                if (sdr.Read() == true)
                {
                    //同一コードが見つかった場合
                    //更新
                    saveSqlStr = "UPDATE 機械 " +
                        "SET" +
                        " 機械=N'" + textBoxSeihinMei.Text.Trim() + "' " +
                        " where 機械コード  = '" + codestr + "'";
                }
                else
                {
                    //同一コードが見つからなかった場合
                    //新規
                    saveSqlStr = "INSERT INTO 機械 (" +
                            "機械コード, 機械" +
                            ") VALUES ('" +
                            textBoxSeihinCode.Text.Trim() + "'," +
                            " N'" + textBoxSeihinMei.Text.Trim() + "')";
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
            RecordDisp(textBoxSeihinCode.Text.Trim());
            //結果をメッセージボックスで表示
            MessageBox.Show(msgstr, "機械マスタ");

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            //画面初期化
            textBoxSeihinCode.Text = "";
            textBoxSeihinMei.Text = "";
            labelID.Text = "";
            buttonSave.Text = "登録";

            //金物コード欄にフォーカス移動
            textBoxSeihinCode.Focus();
            //リストの選択を解除
            listBoxSeihin.ClearSelected();
            buttonDelete.Enabled = false;


        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            //ID取得
            string IDstr = labelID.Text;
            if (IDstr == "")
            {
                //IDが空なら処理しない
                return;
            }

            //メッセージボックスを表示する　Yes,No
            DialogResult result = MessageBox.Show(textBoxSeihinCode.Text + " : " + textBoxSeihinMei.Text + " を削除しますか？",
                "機械マスタ",
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
                    sqlstr = "DELETE FROM 機械 " +
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
                textBoxSeihinCode.Text = "";
                textBoxSeihinMei.Text = "";
                labelID.Text = "";
                buttonDelete.Enabled = false;

                //メッセージボックス表示
                MessageBox.Show(msgstr, "機械マスタ　削除");
            }

        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            //リストが選択されているときのみ処理
            if (listBoxSeihin.SelectedIndex >= 0)
            {
                //リストの選択されているところから得意先コードを抽出
                string liststr = listBoxSeihin.SelectedItem.ToString();
                string code = liststr.Substring(0, 3).Trim();
                //レコード表示
                RecordDisp(code);
            }

        }

        private void ButtonDisp_Click(object sender, EventArgs e)
        {
            string code = textBoxSeihinCode.Text;

            RecordDisp(code);

            int lstindex = listBoxSeihin.FindString(code);
            if (lstindex >= 0)
            {
                //見つかったらリストを選択状態にする
                listBoxSeihin.SetSelected(lstindex, true);
            }

        }
    }

}
