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
    public partial class FormSeihinMast : Form
    {
        public FormSeihinMast()
        {
            InitializeComponent();
        }

        //SQLサーバー接続文字
        private string constr = @Properties.Settings.Default.ConnectStr;

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

        //リストボックス初期化
        //得意先コードを基に絞り込んで表示
        private void ListIni()
        {
            //リスト全消去
            listBoxSeihin.Items.Clear();

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

                    listBoxSeihin.Items.Add(string.Format("{0:s} : {1:s}", code.PadRight(13), name));

                }

            }
            finally
            {
                //サーバー切断
                con.Close();
            }

        }

        private void FormSeihinMast_Load(object sender, EventArgs e)
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

                    //製品コードで検索
                    string sqlstr = "select * from 製品マスタ where 製品コード=" + codestr;
                    SqlCommand com = new SqlCommand(sqlstr, con);
                    SqlDataReader sdr = com.ExecuteReader();

                    //見つかった場合のみ処理を行う
                    if (sdr.Read() == true)
                    {
                        string code = (string)sdr["製品コード"];
                        string name = (string)sdr["製品名"];
                        string tokuCode = (string)sdr["得意先コード"];
                        decimal tanka = (decimal)sdr["単価"];
                        string tekiyo = Convert.ToString(sdr["摘要"]);
                        string ID = sdr["id"].ToString();
                        bool kyotuFL = (bool)sdr["共通FL"];
                        string series = (sdr["シリーズ"] == DBNull.Value ? "" : (string)sdr["シリーズ"]);
                        DateTime dateTime = Convert.ToDateTime(sdr["最終入力日"]);

                        textBoxSeihinCode.Text = code;
                        textBoxSeihinMei.Text = name;
                        textBoxTanka.Text = tanka.ToString("#######0");
                        textBoxTekiyo.Text = tekiyo;
                        textBoxSeries.Text = series;
                        checkBoxKyotu.Checked = kyotuFL;
                        labelDayTime.Text = dateTime.ToShortDateString() + "  "+ dateTime.ToShortTimeString();
                        labelID.Text = ID;

                        string tokuComboCode;
                        if (comboBoxTokuisaki.SelectedIndex == -1)
                        {
                            tokuComboCode = "";
                        }
                        else
                        {
                            string tokuListStr = comboBoxTokuisaki.SelectedItem.ToString();
                             tokuComboCode = tokuListStr.Substring(0, 13).Trim();

                        }
                        if (tokuComboCode != tokuCode)
                        {
                            int lstindex = comboBoxTokuisaki.FindString(tokuCode);
                            if (lstindex >= 0)
                            {
                                //見つかったらリストを選択状態にする
                                comboBoxTokuisaki.SelectedIndex = lstindex;
                            }

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

        //閉じるボタン
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //追加ボタン
        private void buttonNew_Click(object sender, EventArgs e)
        {
            //画面初期化
            textBoxSeihinCode.Text = "";
            textBoxSeihinMei.Text = "";
            textBoxTanka.Text = "";
            textBoxSeries.Text = "";
            textBoxTekiyo.Text = "";
            labelID.Text = "";
            checkBoxKyotu.Checked = false;
            labelDayTime.Text = "";
            buttonSave.Text = "登録";

            //得意先コード欄にフォーカス移動
            textBoxSeihinCode.Focus();
            //リストの選択を解除
            listBoxSeihin.ClearSelected();

            //得意先未選択
            if (comboBoxTokuisaki.SelectedIndex == -1)
            {
                MessageBox.Show("最初に得意先を指定してください。", "商品マスタ");
                
            }

        }

        private void comboBoxTokuisaki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTokuisaki.SelectedIndex >=0)
            {
                buttonSave.Enabled = true;
                ListIni();
            }
            else
            {
                buttonSave.Enabled = false;
                listBoxSeihin.Items.Clear();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //保存前チェック
            string errMsgStr = "";
            //商品コードが空白はNG
            if (textBoxSeihinCode.Text.Trim() == "" )
            {
                errMsgStr += "製品コードが入力されていません。\r\n";
            }
            //得意先が選択されてないとNG
            if (comboBoxTokuisaki.SelectedIndex == -1)
            {
                errMsgStr += "得意先を選択してください。\r\n";
            }
            //単価に数字以外の文字が入っていたらNG
            decimal checkTanka = 0;
            if (! decimal.TryParse(textBoxTanka.Text, out checkTanka))
            {
                errMsgStr += "単価の入力が間違っています。";

            }
            if (errMsgStr != "")
            {
                MessageBox.Show(errMsgStr, "製品マスタ");
                return;
            }


            //メッセージ用変数を初期化
            string msgstr = "";
            //サーバー接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                // 得意先コードをコンボボックスから取得
                string tokuListStr = comboBoxTokuisaki.SelectedItem.ToString();
                string tokuCodeStr = tokuListStr.Substring(0, 13).Trim();

                //製品コードをテキストボックスから取得
                string codestr = textBoxSeihinCode.Text.Trim();
                //製品コードで検索
                string sqlstr = "select * from 製品マスタ where 製品コード= '" + codestr + "'";
                SqlCommand com = new SqlCommand(sqlstr, con);
                SqlDataReader sdr = com.ExecuteReader();
                //保存クエリー用の変数
                string saveSqlStr = "";

                if (sdr.Read() == true)
                {
                    //同一コードが見つかった場合
                    //更新
                    saveSqlStr = "UPDATE 製品マスタ " +
                        "SET" +
                        " 製品コード='" + textBoxSeihinCode.Text.Trim() + "'," +
                        " 製品名=N'" + textBoxSeihinMei.Text.Trim() + "'," +
                        " 得意先コード='" + tokuCodeStr + "'," +
                        " 単価=" + textBoxTanka.Text.Trim() + "," +
                        " シリーズ=N'" + textBoxSeries.Text + "'," +
                        " 摘要=N'" + textBoxTekiyo.Text.Trim() + "'," +
                        " 共通FL = '" + checkBoxKyotu.Checked + "'," +
                        " 最終入力日 =  getdate()" +
                        " where 製品コード  = '" + codestr + "'";
                }
                else
                {
                    //同一コードが見つからなかった場合
                    //新規
                       saveSqlStr = "INSERT INTO 製品マスタ (" +
                               "製品コード, 製品名, 得意先コード, 単価, シリーズ, 摘要, 共通FL, 最終入力日" +
                               ") VALUES ('" +
                               textBoxSeihinCode.Text.Trim() + "', " +
                               "N'" + textBoxSeihinMei.Text.Trim() + "', " +
                               "'" + tokuCodeStr + "', " +
                               "N'" + textBoxSeries.Text+ "', " +
                               textBoxTanka.Text.Trim() + ", " +
                               "N'"+textBoxTekiyo.Text.Trim() + "' ," +
                               "'" + checkBoxKyotu.Checked + "' ," + 
                               " getdate())";

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
            MessageBox.Show(msgstr, "製品マスタ");

        }

        // 削除ボタン
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
            DialogResult result = MessageBox.Show(textBoxSeihinCode.Text + " : " + textBoxSeihinMei.Text + " を削除しますか？",
                "商品マスタ",
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
                    sqlstr = "DELETE FROM 製品マスタ " +
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
                //リスト再表示
                ListIni();
                //入力欄クリア
                textBoxSeihinCode.Text = "";
                textBoxSeihinMei.Text = "";
                textBoxTanka.Text = "";
                textBoxSeries.Text = "";
                textBoxTekiyo.Text = "";
                labelID.Text = "";
                //メッセージボックス表示
                MessageBox.Show(msgstr, "製品マスタ　削除");
            }

        }


        private void listBoxSeihin_SelectedIndexChanged(object sender, EventArgs e)
        {
            //リストが選択されているときのみ処理
            if (listBoxSeihin.SelectedIndex >= 0)
            {
                //リストの選択されているところから得意先コードを抽出
                string liststr = listBoxSeihin.SelectedItem.ToString();
                string code = liststr.Substring(0, 8).Trim();
                //レコード表示
                RecordDisp(code);
            }

        }

        private void buttonDisp_Click(object sender, EventArgs e)
        {
            //入力された得意先コードをリストから検索（前方一致)
            string code = textBoxSeihinCode.Text.Trim();

            RecordDisp(code);

            int lstindex = listBoxSeihin.FindString(code);
            if (lstindex >= 0)
            {
                //見つかったらリストを選択状態にする
                listBoxSeihin.SetSelected(lstindex, true);
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
    }
}
