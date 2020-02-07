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
    public partial class FormBuhinMst2 : Form
    {
        private string constr = @Properties.Settings.Default.ConnectStr;

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        public FormBuhinMst2()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            

        }

        private void FormBuhinMst2_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'dataSetZaisyu.材種' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.材種TableAdapter.Fill(this.dataSetZaisyu.材種);

        }

        private void textBoxBuhinCode_Validating(object sender, CancelEventArgs e)
        {
            //コード重複チェック
            //選択レコード画面表示
            //コードが空白なら処理しない
            if (textBoxBuhinCode.Text.Trim() != "")
            {
                //サーバー接続
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                try
                {
                    string editNo = string.Format("{0}-{1}", labelSeihinCode.Text.Trim(), textBoxBuhinCode.Text.Trim());

                    //管理コードで検索
                    string sqlstr = "select * from 部品マスタ where 管理コード = '" + editNo + "'";
                    SqlCommand com = new SqlCommand(sqlstr, con);
                    SqlDataReader sdr = com.ExecuteReader();

                    //見つかった場合のみ処理を行う
                    if (sdr.Read() == true)
                    {
                        if ((string)sdr["管理コード"] == toolSSLabelKanriCode.Text)
                        {
                            //見つけた番号とlabelKanriCodeの番号が同じ場合、同一レコードと判断する
                            //新規の場合labelKanriCodeは空白
                            return;
                        }
                        else
                        {
                            MessageBox.Show("この部品コードは既に使用されています。");
                            e.Cancel = true;

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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //コントロールの内容を保持する変数


            //変数にコントロールの内容を代入


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
                if (toolSSLabelKanriCode.Text != "")
                {
                    //更新
                    editNo = toolSSLabelKanriCode.Text;

                    saveSqlStr = "UPDATE 部品マスタ " +
                        "SET" +
                        " 使用対象 = N'" + textBoxSiyoTaisyo.Text.Trim() + "'," +
                        " 材種 = " + comboBoxZaisyu.SelectedValue + "," +
                        " 厚さ = " + textBoxThickness.Text + "," +
                        " 巾 = " + textBoxWidth.Text + "," +
                        " 長さ = " + textBoxLength.Text + "," +
                        " 数量 = " + decimal.Parse(textBoxSuryo.Text).ToString() + "," +
                        " 摘要 = N'" + textBoxTekiyo.Text + "'," +
                        " 大井野FL = '" + checkBoxOoino.Checked + "'," +
                        " NCFL = '" + checkBoxNC.Checked + "'," +
                        " 共通FL = '" + checkBoxKyotu.Checked + "'," +
                        " 在庫FL = '" + checkBoxZaiko.Checked + "'," +
                        " 別納FL = '" + checkBoxBetuno.Checked + "'," +
                        " シリーズ = N'" + toolSSLabelSeries.Text + "'," +
                        " 最終入力日 =  getdate()" +
                        " where 管理コード  = '" + editNo + "'";

                }
                else
                {
                    //新規
                    editNo = string.Format("{0}-{1}", labelSeihinCode.Text.Trim(), textBoxBuhinCode.Text.Trim());
                    toolSSLabelKanriCode.Text = editNo;
                    //受注データ　新規登録
                    saveSqlStr = "INSERT INTO 部品マスタ (" +
                                    "部品コード, 製品コード, 管理コード, 行番号, 使用対象, " +
                                    " 材種, 厚さ, 巾, 長さ, 数量, 摘要," +
                                    " 大井野FL, NCFL, 共通FL, 在庫FL, 別納FL, 最終入力日, シリーズ" +
                                    ") VALUES (" +
                                    " '" + textBoxBuhinCode.Text.Trim() + "'," +
                                    " '" + labelSeihinCode.Text + "'," +
                                    "  '" + editNo + "'," +
                                    labelNo.Text + "," +
                                    " N'" + textBoxSiyoTaisyo.Text.Trim() + "', " +
                                    comboBoxZaisyu.SelectedValue + ", " +
                                    textBoxThickness.Text + ", " +
                                    textBoxWidth.Text + ", " +
                                    textBoxLength.Text + ", " +
                                    textBoxSuryo.Text + ", " +
                                    " N'" + textBoxTekiyo.Text + "', " +
                                    "'" + checkBoxOoino.Checked + "', " +
                                    "'" + checkBoxNC.Checked + "', " +
                                    "'" + checkBoxKyotu.Checked + "', " +
                                    "'" + checkBoxZaiko.Checked + "', " +
                                    "'" + checkBoxBetuno.Checked + "', " +
                                    " getdate(), N'" + toolSSLabelSeries.Text + "')";

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
                MessageBox.Show(msgstr, "部品マスタ");
            }
            else
            {
                //親フォームにデータ受け渡し




                this.DialogResult = DialogResult.OK;
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
                string sqlstr = "select max(NC管理コード) as mn from 部品マスタ";
                SqlCommand com = new SqlCommand(sqlstr, con);
                SqlDataReader sdr = com.ExecuteReader();
                if (sdr.Read() == true)
                {
                    getNo = (string)sdr["mn"];
                    if (!int.TryParse(getNo, out maxNo))
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
            if (maxNo == 0)
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

    }
}
