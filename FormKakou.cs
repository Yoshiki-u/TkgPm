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
    public partial class FormKakou : Form
    {
        private string constr = @Properties.Settings.Default.ConnectStr;
        private string acName = ""; //アクティブなコントロールの名前を入れる
       

        public FormKakou()
        {
            InitializeComponent();
        }

        private void GetKakousyu(string code)
        {
            //加工種別
            if (code != "")
            {
                //サーバー接続
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                try
                {
                    //SQL文で検索
                    string sqlStr = "SELECT * FROM 加工種 WHERE 加工種コード = '" + code + "'";
                    SqlCommand com = new SqlCommand(sqlStr, con);
                    SqlDataReader sdr = com.ExecuteReader();

                    //見つかった場合のみ処理を行う
                    if (sdr.Read() == true)
                    {
                        string syubetu = (string)sdr["加工種"];
                        textBoxKakouSyubetu.Text = syubetu;
                       if (textBoxNaiyoS.Text == "")
                        {
                            textBoxNaiyoS.Text = (sdr["定型文"] == DBNull.Value ? "" : (string)sdr["定型文"]);
                        }
                        sdr.Close();

                    }
                    else
                    {
                        textBoxKakouSyubetu.Text = "";
                    }

                }
                finally
                {
                    //サーバー切断
                    con.Close();
                }

            }
        }

        private void GetKikai(string code)
        {
            //加工種別
            if (code != "")
            {
                //サーバー接続
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                try
                {
                    //SQL文で検索
                    string sqlStr = "SELECT * FROM 機械 WHERE 機械コード = '" + code + "'";
                    SqlCommand com = new SqlCommand(sqlStr, con);
                    SqlDataReader sdr = com.ExecuteReader();

                    //見つかった場合のみ処理を行う
                    if (sdr.Read() == true)
                    {
                        string syubetu = (string)sdr["機械"];
                        textBoxKikai.Text = syubetu;

                        sdr.Close();

                    }
                    else
                    {
                        textBoxKikai.Text = "";
                    }

                }
                finally
                {
                    //サーバー切断
                    con.Close();
                }

            }
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
        }

        private void FormKakou_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxKakouSyubetuCode_Leave(object sender, EventArgs e)
        {
            //加工種別
            string code = textBoxKakouSyubetuCode.Text;
            GetKakousyu(code);

        }

        private void TextBoxKikaiCode_Leave(object sender, EventArgs e)
        {
            //機械
            string code = textBoxKikaiCode.Text;
            GetKikai(code);

        }

        private void ButtonRef1_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                textBoxGazo1.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = textBoxGazo1.Text;
            }
        }

        private void ButtonRef2_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                textBoxGazo2.Text = openFileDialog1.FileName;
                pictureBox2.ImageLocation = textBoxGazo2.Text;
            }

        }

        private void ButtonRef3_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                textBoxGazo3.Text = openFileDialog1.FileName;
                pictureBox3.ImageLocation = textBoxGazo3.Text;
            }

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            int pn;
            int sr;

            if (!int.TryParse(textBoxNCProgramNo.Text, out pn))
            {
                textBoxNCProgramNo.Text = "0";
            }

            if (!int.TryParse(textBoxNCTorisu.Text, out sr))
            {
                textBoxNCTorisu.Text = "0";
            }

            //メッセージ用変数を初期化
            string msgstr = "";
            //保存クエリー用の変数
            string saveSqlStr = "";

            string editNo = "";
            int pno = 0;
            decimal torisu = 0;

            //サーバー接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                //labelKanriCodeが空白なら新規、そうでなければその番号で更新
                if (toolSSLabelKakouKanriCode.Text != "")
                {
                    //更新
                    editNo = toolSSLabelKakouKanriCode.Text;

                    saveSqlStr = "UPDATE 加工 " +
                        "SET" +
                        " 加工管理コード = '" + string.Format("{0}-{1}", toolSSLabelKanriCode.Text.Trim(), textBoxKakouNo.Text.Trim()) + "', " +
                        " 加工コード = '" + textBoxKakouNo.Text + "', " +
                        " 加工種コード = '" + textBoxKakouSyubetuCode.Text + "', " +
                        " 機械コード = '" + textBoxKikaiCode.Text + "', " +
                        " 作業内容 = N'" + textBoxNaiyoS.Text + "', " +
                        " 作業詳細 = N'" + textBoxNaiyoL.Text + "', " +
                        " 参照画像1 = N'" + textBoxGazo1.Text + "', " +
                        " 参照画像2 = N'" + textBoxGazo2.Text + "', " +
                        " 参照画像3 = N'" + textBoxGazo3.Text + "', " +
                        " シリーズ = N'" + toolSSLabelSeries.Text + "', " +
                        " NC管理コード = '" + textBoxNcCode.Text + "', " +
                        " プログラム番号 = " + (int.TryParse(textBoxNCProgramNo.Text, out pno) ? pno.ToString() : "0") + ", " +
                        " NC取り数 = " + (decimal.TryParse(textBoxNCTorisu.Text, out torisu) ? torisu.ToString() : "0") + ", " +
                        " 最終入力日 =  getdate()" +
                        " where 加工管理コード  = '" + editNo + "'";
                }
                else
                {
                    //新規
                    editNo = string.Format("{0}-{1}", toolSSLabelKanriCode.Text.Trim(), textBoxKakouNo.Text.Trim());
                    //受注データ　新規登録
                    saveSqlStr = "INSERT INTO 加工 (" +
                                    "加工管理コード, 管理コード,  製品コード, 部品コード, 加工コード, 順番, 加工種コード, 機械コード, " +
                                    " 作業内容, 作業詳細, 参照画像1, 参照画像2, 参照画像3, シリーズ, NC管理コード, プログラム番号, NC取り数, 最終入力日" +
                                    ") VALUES (" +
                                    "'" + editNo + "', " +
                                    "'" + toolSSLabelKanriCode.Text + "', " +
                                    "'" + labelSeihinCode.Text + "', " +
                                    "'" + labelBuhinCode.Text + "', " +
                                    "'" + textBoxKakouNo.Text + "', " +
                                    labelJunban.Text + ", " +
                                    "'" + textBoxKakouSyubetuCode.Text + "', " +
                                    "'" + textBoxKikaiCode.Text + "', " +
                                    "N'" + textBoxNaiyoS.Text + "', " +
                                    "N'" + textBoxNaiyoL.Text + "', " +
                                    "N'" + textBoxGazo1.Text + "', " +
                                    "N'" + textBoxGazo2.Text + "', " +
                                    "N'" + textBoxGazo3.Text + "', " +
                                    "N'" + toolSSLabelSeries.Text + "', " +
                                    "'" + textBoxNcCode.Text + "', " +
                                    (int.TryParse(textBoxNCProgramNo.Text, out pno) ? pno.ToString() : "0") + ", " +
                                    (decimal.TryParse(textBoxNCTorisu.Text, out torisu) ? torisu.ToString() : "0") + ", " +
                                    " getdate())";

                }
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
            //結果をメッセージボックスで表示(成功したときは表示せずにこの画面を閉じる)
            if (msgstr != "保存しました")
            {
                MessageBox.Show(msgstr, "部品マスタ 加工");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }

        }

        private void FormKakou_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                // このフォームで現在アクティブなコントロールを取得する
                //Control cControl = this.ActiveControl;

                // 取得できた場合のみ、そのコントロールの名前を表示する
                //if (cControl != null)
                //{
                //    MessageBox.Show(cControl.Name);
                //}
                switch (acName)
                {
                    case "加工種コード":
                        buttonRefKakousyu.PerformClick();
                        break;

                    case "機械コード":
                        buttonRefKikai.PerformClick();
                        break;
                }
            }

        }

        private void ButtonReference_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxKakouNo_Enter(object sender, EventArgs e)
        {
            acName = "加工コード";
        }
        private void TextBoxKakouSyubetuCode_Enter(object sender, EventArgs e)
        {
            acName = "加工種コード";
        }

        private void TextBoxKikaiCode_Enter(object sender, EventArgs e)
        {
            acName = "機械コード";
        }

        private void TextBoxKakouSyubetuCode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBoxKakouSyubetu_Enter(object sender, EventArgs e)
        {
            acName = "加工種";
        }

        private void TextBoxNaiyoS_Enter(object sender, EventArgs e)
        {
            acName = "作業内容";
        }

        private void TextBoxNaiyoL_Enter(object sender, EventArgs e)
        {
            acName = "作業詳細";
        }

        private void TextBoxKikai_Enter(object sender, EventArgs e)
        {
            acName = "機械";
        }

        private void TextBoxGazo1_Enter(object sender, EventArgs e)
        {
            acName = "参照画像1";
        }

        private void TextBoxGazo2_Enter(object sender, EventArgs e)
        {
            acName = "参照画像2";
        }

        private void TextBoxGazo3_Enter(object sender, EventArgs e)
        {
            acName = "参照画像3";
        }
        private void ButtonRefKakousyu_Click(object sender, EventArgs e)
        {
            DialogResult drRet;
            FormInKakousyu frmInKakousyu = new FormInKakousyu();
            drRet = frmInKakousyu.ShowDialog();
            if (drRet == DialogResult.OK)
            {
                //リストから選択されていなければなにもしない
                if (frmInKakousyu.listBoxItem.SelectedIndex == -1) return;
                //リストの選択されているところから加工種コードを抽出
                string listStr = frmInKakousyu.listBoxItem.SelectedItem.ToString();
                string codeStr = listStr.Substring(0, 3).Trim();
                textBoxKakouSyubetuCode.Text = codeStr;
                GetKakousyu(codeStr);

            }

        }

        private void ButtonRefKikai_Click(object sender, EventArgs e)
        {
            DialogResult drRet;
            FormInKikai frmInKikai = new FormInKikai();
            drRet = frmInKikai.ShowDialog();
            if (drRet == DialogResult.OK)
            {
                //リストから選択されていなければなにもしない
                if (frmInKikai.listBoxItem.SelectedIndex == -1) return;
                //リストの選択されているところから加工種コードを抽出
                string listStr = frmInKikai.listBoxItem.SelectedItem.ToString();
                string codeStr = listStr.Substring(0, 3).Trim();
                textBoxKikaiCode.Text = codeStr;
                GetKikai(codeStr);

            }

        }

        private void ButtonRefNC_Click(object sender, EventArgs e)
        {
            DialogResult drRet;


            string tokuListStr = labelTokuisaki.Text;
            string tokuCodeStr = tokuListStr.Substring(0, 13).Trim();

            FormInNC frmInNC = new FormInNC();
            frmInNC.textBoxSeries.Text = toolSSLabelSeries.Text;
            frmInNC.strRefTokui = tokuCodeStr;
            drRet = frmInNC.ShowDialog();
            if (drRet == DialogResult.OK)
            {
                //リストから選択されていなければなにもしない
                if (frmInNC.listBoxSeihin.SelectedIndex == -1) return;
                //リストの選択されているところからNC管理コードを抽出
                string listStr = frmInNC.listBoxSeihin.SelectedItem.ToString();
                string codeStr = listStr.Substring(0, 13).Trim();

                //サーバーに接続
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                try
                {
                    //接続成功
                    //レコードをコードで検索
                    string sqlstr = "SELECT * FROM NC木取 WHERE NC管理コード = '" + codeStr + "'";
                    SqlCommand com = new SqlCommand(sqlstr, con);
                    SqlDataReader sdr = com.ExecuteReader();

                    //リスト表示
                    if (sdr.Read() == true)
                    {
                        textBoxNcCode.Text = (string)sdr["NC管理コード"];
                        int pno;
                        pno = (int)sdr["プログラム番号"];
                        textBoxNCProgramNo.Text = pno.ToString("####");
                        decimal torisu = (decimal)sdr["取り数"];
                        textBoxNCTorisu.Text = torisu.ToString("#0.#");

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
