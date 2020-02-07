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
    public partial class FormNC : Form
    {
        public FormNC()
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
                comboBoxTokuisaki.SelectedIndex = 0;
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
                string sqlstr = "";
                if (comboBoxTokuisaki.SelectedIndex == 0)
                {
                    sqlstr = "select * from NC木取 ORDER BY シリーズ, NC管理コード";
                }
                else
                {
                    sqlstr = "select * from NC木取 where 得意先コード = '" + tokuCodeStr + "' ORDER BY シリーズ, NC管理コード";
                }
                SqlCommand com = new SqlCommand(sqlstr, con);
                SqlDataReader sdr = com.ExecuteReader();

                //リスト表示
                while (sdr.Read() == true)
                {
                    //書式xxxxxxxxxxxxx : xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
                    string code = (string)sdr["NC管理コード"];
                    string name = (string)sdr["シリーズ"];
                    string name2 = (string)sdr["使用対象"];

                    listBoxSeihin.Items.Add(string.Format("{0:s} : {1:s} - {2:s}", code.PadRight(13), name,name2));

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

                    //製品コードで検索
                    string sqlstr = "select * from NC木取 where NC管理コード= '" + codestr + "'";
                    SqlCommand com = new SqlCommand(sqlstr, con);
                    SqlDataReader sdr = com.ExecuteReader();

                    //見つかった場合のみ処理を行う
                    if (sdr.Read() == true)
                    {
                        string code = (string)sdr["NC管理コード"];
                        string series = (sdr["シリーズ"] == DBNull.Value ? "" : (string)sdr["シリーズ"]);
                        int programNo = (int)sdr["プログラム番号"];
                        string siyou = (string)sdr["使用対象"];
                        string tokuCode = (string)sdr["得意先コード"];
                        double thickness = (double)sdr["厚さ"];
                        double xx = (double)sdr["X"];
                        double yy = (double)sdr["Y"];
                        decimal torisu = (decimal)sdr["取り数"];
                        string tani = (string)sdr["単位"];
                        string biko1 = (string)sdr["備考1"];
                        string biko2 = (string)sdr["備考2"];
                        string ID = sdr["id"].ToString();
                        DateTime dateTime = Convert.ToDateTime(sdr["最終入力日"]);

                        textBoxNcCode.Text = code;
                        textBoxSeries.Text = series;
                        textBoxNcProgram.Text = programNo.ToString("###0");
                        textBoxSiyouTaisyo.Text = siyou;
                        textBoxThickness.Text = thickness.ToString("####0.#");
                        textBoxX.Text = xx.ToString("####0.#");
                        textBoxY.Text = yy.ToString("####0.#");
                        textBoxTorisu.Text = torisu.ToString("#######0");
                        comboBoxTani.Text = tani;
                        textBoxBiko1.Text = biko1;
                        textBoxBiko2.Text = biko2;
                        labelDayTime.Text = dateTime.ToShortDateString() + "  " + dateTime.ToShortTimeString();
                        labelID.Text = ID;
                        comboBoxTokuisakiCode.SelectedIndex = comboBoxTokuisakiCode.FindString(tokuCode);
                        
                    }

                }
                finally
                {
                    //サーバー切断
                    con.Close();
                }

            }
        }

        private void FormNC_Load(object sender, EventArgs e)
        {
            //コンボボックスに得意先を設定する
            //リスト全消去
            comboBoxTokuisaki.Items.Clear();
            comboBoxTokuisakiCode.Items.Clear();
            //未設定を追加
            comboBoxTokuisaki.Items.Add(string.Format("{0:s} : {1:s}", "0            ", "未設定"));

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
                    comboBoxTokuisakiCode.Items.Add(string.Format("{0:s} : {1:s}", code.PadRight(13), name));
                }
                //先頭選択状態にする（全表示)
                comboBoxTokuisaki.SelectedIndex = 0;
            }
            finally
            {
                //サーバー切断
                con.Close();
            }

        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            //画面初期化
            textBoxNcCode.Text = "";
            textBoxSeries.Text = "";
            textBoxNcProgram.Text = "";
            textBoxSiyouTaisyo.Text = "";
            textBoxThickness.Text = "";
            textBoxX.Text = "";
            textBoxY.Text = "";
            textBoxTorisu.Text = "";
            comboBoxTani.Text = "個";
            textBoxBiko1.Text = "";
            textBoxBiko2.Text = "";
            labelID.Text = "";
            labelDayTime.Text = "";
            buttonSave.Text = "登録";

            //NC管理コードを発行する
            //（最大値）
            string NewNo = SaidaiKanriCode();
            textBoxNcCode.Text = NewNo;

            //フォーカス移動
            textBoxSeries.Focus();
            //リストの選択を解除
            listBoxSeihin.ClearSelected();

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
            DialogResult result = MessageBox.Show(textBoxNcCode.Text + "\r\n" + 
                                                    textBoxSeries.Text + " " + textBoxSiyouTaisyo.Text + " を削除しますか？",
                "NC",
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
                    sqlstr = "DELETE FROM NC木取 " +
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
                textBoxNcCode.Text = "";
                textBoxSeries.Text = "";
                textBoxNcProgram.Text = "";
                textBoxSiyouTaisyo.Text = "";
                textBoxThickness.Text = "";
                textBoxX.Text = "";
                textBoxY.Text = "";
                textBoxTorisu.Text = "";
                comboBoxTani.Text = "個";
                textBoxBiko1.Text = "";
                textBoxBiko2.Text = "";
                labelID.Text = "";
                labelDayTime.Text = "";
                //メッセージボックス表示
                MessageBox.Show(msgstr, "NCプログラム　削除");
                buttonDelete.Enabled = false;

            }

        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            //リストが選択されているときのみ処理
            if (listBoxSeihin.SelectedIndex >= 0)
            {
                //リストの選択されているところから管理コードを抽出
                string liststr = listBoxSeihin.SelectedItem.ToString();
                string code = liststr.Substring(0, 8).Trim();
                //レコード表示
                RecordDisp(code);
                
            }

        }

        private void ListBoxSeihin_SelectedIndexChanged(object sender, EventArgs e)
        {
            //リストが選択されているときのみ処理
            if (listBoxSeihin.SelectedIndex >= 0)
            {
                //リストの選択されているところから管理コードを抽出
                string liststr = listBoxSeihin.SelectedItem.ToString();
                string code = liststr.Substring(0, 13).Trim();
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
            if (textBoxNcCode.Text.Trim() == "")
            {
                errMsgStr += "NC管理コードが入力されていません。\r\n";
            }
            //得意先が選択されてないとNG
            if (comboBoxTokuisakiCode.SelectedIndex == -1)
            {
                errMsgStr += "得意先を選択してください。\r\n";
            }

            //プログラム番号に数字以外の文字が入っていたらNG
            int checkPro = 0;
            if (!int.TryParse(textBoxNcProgram.Text, out checkPro))
            {
                errMsgStr += "プログラム番号の入力が間違っています。";

            }
            if (errMsgStr != "")
            {
                MessageBox.Show(errMsgStr, "NCプログラム");
                return;
            }

            //取り数に数字以外の文字が入っていたらNG
            decimal checkTanka = 0;
            if (!decimal.TryParse(textBoxTorisu.Text, out checkTanka))
            {
                errMsgStr += "取り数の入力が間違っています。";

            }
            if (errMsgStr != "")
            {
                MessageBox.Show(errMsgStr, "NCプログラム");
                return;
            }

            //厚さに数字以外の文字が入っていたらNG
            double checkT = 0;
            if (!double.TryParse(textBoxThickness.Text, out checkT))
            {
                errMsgStr += "厚さの入力が間違っています。";

            }
            if (errMsgStr != "")
            {
                MessageBox.Show(errMsgStr, "NCプログラム");
                return;
            }

            //Xに数字以外の文字が入っていたらNG
            double checkX = 0;
            if (!double.TryParse(textBoxX.Text, out checkX))
            {
                errMsgStr += "Ｘの入力が間違っています。";

            }
            if (errMsgStr != "")
            {
                MessageBox.Show(errMsgStr, "NCプログラム");
                return;
            }

            //Yに数字以外の文字が入っていたらNG
            double checkY = 0;
            if (!double.TryParse(textBoxY.Text, out checkY))
            {
                errMsgStr += "Ｙの入力が間違っています。";

            }
            if (errMsgStr != "")
            {
                MessageBox.Show(errMsgStr, "NCプログラム");
                return;
            }

            //サーバー接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                // 得意先コードをコンボボックスから取得
                string tokuListStr = comboBoxTokuisakiCode.SelectedItem.ToString();
                string tokuCodeStr = tokuListStr.Substring(0, 13).Trim();

                //NC管理コードをテキストボックスから取得
                string codestr = textBoxNcCode.Text.Trim();
                //NC管理コードで検索
                string sqlstr = "select * from NC木取 where NC管理コード= '" + codestr + "'";
                SqlCommand com = new SqlCommand(sqlstr, con);
                SqlDataReader sdr = com.ExecuteReader();
                //保存クエリー用の変数
                string saveSqlStr = "";

                if (sdr.Read() == true)
                {
                    if ((int)sdr["プログラム番号"] != checkPro)
                    {
                        DialogResult result =  MessageBox.Show("同じ管理コードのデータが存在します。\r\n上書きしますか？",
                                                                "NC",
                                                                MessageBoxButtons.YesNoCancel,
                                                                MessageBoxIcon.Warning,
                                                                MessageBoxDefaultButton.Button3);
                        if (result == DialogResult.No)
                        {
                            textBoxNcCode.Text = "";
                            textBoxNcCode.Focus();
                            return;
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            return;
                        }

                    }
                    //同一コードが見つかった場合
                    //更新
                    saveSqlStr = "UPDATE NC木取 " +
                        "SET" +
                        " 得意先コード = '" + tokuCodeStr + "', " + 
                        " シリーズ = N'" + textBoxSeries.Text.Trim() + "'," +
                        " プログラム番号 = " + textBoxNcProgram.Text.Trim() + "," +
                        " 使用対象 = N'" + textBoxSiyouTaisyo.Text.Trim() + "'," +
                        " 厚さ = " + textBoxThickness.Text +", " +
                        " X = " + textBoxX.Text + ", " +
                        " Y = " + textBoxY.Text + ", " +
                        " 取り数 = " + textBoxTorisu.Text + ", " +
                        " 単位 = N'" + comboBoxTani.SelectedItem + "', " +
                        " 備考1=N'" + textBoxBiko1.Text.Trim() + "'," +
                        " 備考2=N'" + textBoxBiko2.Text.Trim() + "'," +
                        " 最終入力日 =  getdate()" +
                        " where NC管理コード  = '" + codestr + "'";
                }
                else
                {
                    //同一コードが見つからなかった場合
                    //新規
                    saveSqlStr = "INSERT INTO NC木取 (" +
                            "NC管理コード, 得意先コード, シリーズ, プログラム番号, 使用対象, " +
                            "厚さ, X, Y, 取り数, 単位, 備考1, 備考2, 最終入力日" +
                            ") VALUES ('" +
                            textBoxNcCode.Text.Trim() + "', " +
                            "'" + tokuCodeStr + "', " +
                            "N'" + textBoxSeries.Text + "', " +
                            textBoxNcProgram.Text.Trim() + ", " +
                            "N'" + textBoxSiyouTaisyo.Text + "', " +
                            textBoxThickness.Text.Trim() + ", " +
                            textBoxX.Text.Trim() + ", " +
                            textBoxY.Text.Trim() + ", " +
                            textBoxTorisu.Text.Trim() + ", " +
                            "N'" + comboBoxTani.SelectedItem + "' ," +
                            "N'" + textBoxBiko1.Text.Trim() + "' ," +
                            "N'" + textBoxBiko2.Text.Trim() + "' ," +
                            " getdate())";

                }

                //検索結果を破棄
                sdr.Close();

                //クエリー実行
                SqlCommand saveCom = new SqlCommand(saveSqlStr, con);
                saveCom.ExecuteNonQuery();
                MessageBox.Show("保存しました", "製品マスタ");
                //リスト再表示
                ListIni();
                //レコードを表示
                //RecordDisp(textBoxNcCode.Text.Trim());

                int idx = listBoxSeihin.FindString(textBoxNcCode.Text);
                listBoxSeihin.SelectedIndex = idx;

            }
            catch (Exception)
            {
                //書き込み失敗
                MessageBox.Show("保存に失敗しました", "製品マスタ");
            }
            finally
            {
                //サーバー切断
                con.Close();
            }

        }

        private string SaidaiKanriCode()
        {
            string strMaxNo;
            int maxNo = 0;
            string getNo;
            //サーバー接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                string sqlstr = "select max(NC管理コード) as mn from NC木取";
                SqlCommand com = new SqlCommand(sqlstr, con);
                SqlDataReader sdr = com.ExecuteReader();
                if (sdr.Read() == true)
                {
                    getNo = (string)sdr["mn"];
                    if(!int.TryParse(getNo, out maxNo))
                    {
                        maxNo = 0;
                    }
                }
                else
                {
                    maxNo = 0;
                }
                //検索結果を破棄
                sdr.Close();
            }
            catch (Exception)
            {
                //書き込み失敗
                MessageBox.Show("番号の取得に失敗しました");
                maxNo = 0;
            }
            finally
            {
                //サーバー切断
                con.Close();
                
            }
            if (maxNo==0)
            {
                strMaxNo = "";
            }
            else
            {
                maxNo++;
                strMaxNo = maxNo.ToString("00000");
            }
            return strMaxNo;

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void TextBoxNcCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxTokuisaki_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListIni();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //NC管理コードを発行する
            //（最大値）
            string NewNo = SaidaiKanriCode();
            textBoxNcCode.Text = NewNo;
            labelID.Text = "";
            labelDayTime.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //現在表示されているデータはそのまま
            //管理コードのみ変える
            string NewNo = SaidaiKanriCode();
            textBoxNcCode.Text = NewNo;
            labelID.Text = "";
            labelDayTime.Text = "";


        }
    }
}
