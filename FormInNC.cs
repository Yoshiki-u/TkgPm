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
    public partial class FormInNC : Form
    {
        private string _strRefTokui;

        public string strRefTokui
        {
            get
            {
                return _strRefTokui;
            }
            set
            {
                _strRefTokui = value;
            }
        }

        public FormInNC()
        {
            InitializeComponent();
        }

        //SQLサーバー接続文字
        private string constr = @Properties.Settings.Default.ConnectStr;

        //リストボックス初期化
        //得意先コードを基に絞り込んで表示
        private void ListIni()
        {
            //リスト全消去
            listBoxSeihin.Items.Clear();

            //リストの選択されているところから得意先コードを抽出 選択されていなければなにもしない
            string tokuListStr = "";
            if (comboBoxTokuisaki.SelectedIndex == -1)
            {
                return;
            }
            tokuListStr = comboBoxTokuisaki.SelectedItem.ToString();
            string tokuCodeStr = tokuListStr.Substring(0, 13).Trim();

            string series = textBoxSeries.Text.Trim();

            //サーバーに接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                //接続成功
                //すべてのレコードをコード昇順で出力
                string sqlstr = "SELECT * FROM NC木取 " + 
                                "WHERE 得意先コード = '" + tokuCodeStr + "' AND シリーズ ='" + series + 
                                "' ORDER BY シリーズ, プログラム番号";
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
                if (listBoxSeihin.Items.Count > 0)
                {
                    listBoxSeihin.SelectedIndex = 0;
                }

            }
            finally
            {
                //サーバー切断
                con.Close();
            }

        }

        private void FormInNC_Load(object sender, EventArgs e)
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
                //選択状態にする
                if (strRefTokui != "")
                {
                    int cbi = comboBoxTokuisaki.FindString(strRefTokui);
                    if (cbi != -1)
                    {
                        comboBoxTokuisaki.SelectedIndex = cbi;
                    }
                }
            }
            finally
            {
                //サーバー切断
                con.Close();
            }

        }

        private void ComboBoxTokuisaki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTokuisaki.SelectedIndex >= 0)
            {
                ListIni();
            }
            else
            {
                listBoxSeihin.Items.Clear();
            }

        }

        private void FormInNC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (listBoxSeihin.SelectedIndex != -1)
                {
                    this.DialogResult = DialogResult.OK;
                }
                
                if (listBoxSeihin.Items.Count == 0)
                {
                    ListIni();
                }

            }

        }

        private void ListBoxSeihin_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxSeihin.SelectedIndex != -1)
            {
                this.DialogResult = DialogResult.OK;
            }

        }

        private void TextBoxSeries_TextChanged(object sender, EventArgs e)
        {
            listBoxSeihin.Items.Clear();

        }
    }
}
