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
    public partial class FormNut : Form
    {
        private string constr = @Properties.Settings.Default.ConnectStr;
        private string acName;

        public FormNut()
        {
            InitializeComponent();
        }

        private void GetNut(string code)
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
                    string sqlStr = "SELECT * FROM 金物マスタ WHERE 金物コード = '" + code + "'";
                    SqlCommand com = new SqlCommand(sqlStr, con);
                    SqlDataReader sdr = com.ExecuteReader();

                    //見つかった場合のみ処理を行う
                    if (sdr.Read() == true)
                    {
                        string syubetu = (string)sdr["金物名"];
                        textBoxNut.Text = syubetu;

                        sdr.Close();

                    }
                    else
                    {
                        textBoxNut.Text = "";
                    }

                }
                finally
                {
                    //サーバー切断
                    con.Close();
                }

            }
        }

        private void TextBoxNutCode_Leave(object sender, EventArgs e)
        {
            //ナット
            string code = textBoxNutCode.Text;
            GetNut(code);

        }

        private void FormNut_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            //メッセージ用変数を初期化
            string msgstr = "";
            //保存クエリー用の変数
            string saveSqlStr = "";

            string editNo = "";

            //サーバー接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                //labelKanriCodeが空白なら新規、そうでなければその番号で更新
                if (labelKakouKanriCode.Text != "")
                {
                    //更新
                    editNo = labelKakouKanriCode.Text;

                    saveSqlStr = "UPDATE 金物 " +
                        "SET" +
                        " 金物コード = '" + textBoxNutCode.Text + "', " +
                        " 金物名 = N'" + textBoxNut.Text + "', " +
                        " 数量 = " + textBoxSuryo.Text + ", " +
                        " 最終入力日 =  getdate()" +
                        " where 金物管理コード  = '" + editNo + "'";
                }
                else
                {
                    //新規
                    editNo = string.Format("{0}-{1}", labelKanriCode.Text.Trim(), textBoxNutCode.Text.Trim());
                    saveSqlStr = "INSERT INTO 金物 (" +
                                    "金物管理コード, 管理コード,  製品コード, 部品コード, 金物コード, 金物名, 数量, 最終入力日" +
                                    ") VALUES (" +
                                    "'" + editNo + "', " +
                                    "'" + labelKanriCode.Text + "', " +
                                    "'" + labelSeihinCode.Text + "', " +
                                    "'" + labelBuhinCode.Text + "', " +
                                    "'" + textBoxNutCode.Text + "', " +
                                    "N'" + textBoxNut.Text + "', " +
                                    "" + textBoxSuryo.Text + ", " +
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
                MessageBox.Show(msgstr, "部品マスタ 金物");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }

        }

        private void ButtonRefNut_Click(object sender, EventArgs e)
        {
            DialogResult drRet;
            FormInNut frmInNut = new FormInNut();
            drRet = frmInNut.ShowDialog();
            if (drRet == DialogResult.OK)
            {
                //リストから選択されていなければなにもしない
                if (frmInNut.listBoxItem.SelectedIndex == -1) return;
                //リストの選択されているところから金物コードを抽出
                string listStr = frmInNut.listBoxItem.SelectedItem.ToString();
                string codeStr = listStr.Substring(0, 3).Trim();
                textBoxNutCode.Text = codeStr;
                GetNut(codeStr);

            }

        }

        private void FormNut_KeyDown(object sender, KeyEventArgs e)
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
                    case "金物コード":
                        buttonRefNut.PerformClick();
                        break;

                }
            }

        }

        private void TextBoxNutCode_Enter(object sender, EventArgs e)
        {
            acName = "金物コード";
        }

        private void TextBoxSuryo_Enter(object sender, EventArgs e)
        {
            acName = "数量";
        }

        private void TextBoxNut_Enter(object sender, EventArgs e)
        {
            acName = "金物名";
        }
    }
}
