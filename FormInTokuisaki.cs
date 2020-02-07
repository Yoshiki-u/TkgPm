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
    public partial class FormInTokuisaki : Form
    {
        public FormInTokuisaki()
        {
            InitializeComponent();
        }

        //SQLサーバー接続文字
        private string constr = @Properties.Settings.Default.ConnectStr;

        private void FormInTokuisaki_Load(object sender, EventArgs e)
        {
            //コンボボックスに得意先を設定する
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
                if (listBoxTokuisaki.Items.Count > 0)
                {
                    listBoxTokuisaki.SelectedIndex = 0;
                }
            }
            finally
            {
                //サーバー切断
                con.Close();
            }

        }

        private void listBoxTokuisaki_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxTokuisaki.SelectedIndex != -1)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void FormInTokuisaki_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (listBoxTokuisaki.SelectedIndex != -1)
                {
                    this.DialogResult = DialogResult.OK;
                }

            }

        }
    }
}
