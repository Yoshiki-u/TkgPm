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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        //SQLサーバー接続文字
        private string constr = @Properties.Settings.Default.ConnectStr;

        private void button1_Click(object sender, EventArgs e)
        {
            FormTokuisakiMst frmTokuisaki = new FormTokuisakiMst();

            frmTokuisaki.Show();

        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            buttonBuhin.Text = "部品　個別入力" + System.Environment.NewLine + "加工 ナット 入力";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSeihinMast frmSeihin = new FormSeihinMast();

            frmSeihin.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormJutyu frmJutyu = new FormJutyu();

            frmJutyu.Show();

        }

        private void buttonBuhin_Click(object sender, EventArgs e)
        {
            FormBuhinItiran frmBuhinItiran = new FormBuhinItiran();
            frmBuhinItiran.Show();

            //FormBuhinMst frmBuhinMst = new FormBuhinMst();
            //frmBuhinMst.Show();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FormNutMst frmNutMst = new FormNutMst();
            frmNutMst.Show();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            FormKikaiMst frmKikaiMst = new FormKikaiMst();
            frmKikaiMst.Show();

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            FormKakousyuMst frmKakousyuMst = new FormKakousyuMst();
            frmKakousyuMst.Show();

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            FormBuhinMst frmBuhinMst = new FormBuhinMst();
            frmBuhinMst.Show();

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            FormReadCSV frmReadCsv = new FormReadCSV();
            frmReadCsv.Show();


        }

        private void Button9_Click(object sender, EventArgs e)
        {
            FormJutyuItiran frmJutyuItiran = new FormJutyuItiran();
            frmJutyuItiran.Show();

        }

        private void Button10_Click(object sender, EventArgs e)
        {

            FormBuhinHattyu frmBuhinHattyu = new FormBuhinHattyu();
            frmBuhinHattyu.Show();

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            FormConfig frmConfig = new FormConfig();
            frmConfig.Show();

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            FormNC frmNc = new FormNC();
            frmNc.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FormSeihinItiran frmSeihinItiran = new FormSeihinItiran();

            frmSeihinItiran.Show();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("製品マスタのアップデートをします",
                                                    "データ修正",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Information,
                                                    MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                //メッセージ用変数を初期化
                string msgstr = "";
                string saveSqlStr;
                //サーバー接続
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                try
                {
                    saveSqlStr = "UPDATE 製品マスタ " +
                        "SET" +
                        " 発注先コード = ''";
                    //クエリー実行
                    SqlCommand saveCom = new SqlCommand(saveSqlStr, con);
                    saveCom.ExecuteNonQuery();
                    msgstr = "完了しました";


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
                    MessageBox.Show(msgstr);
                }

            }


        }

        private void button15_Click(object sender, EventArgs e)
        {
            FormHattyusakiMstcs frmHattyusaki = new FormHattyusakiMstcs();

            frmHattyusaki.Show();

        }
    }
}
