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
    public partial class FormSeihinItiran : Form
    {
        public FormSeihinItiran()
        {
            InitializeComponent();
        }

        //SQLサーバー接続文字
        private string constr = @Properties.Settings.Default.ConnectStr;
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        private void DisplaySeihin(string sqlstr)
        {
            //SQL文が空白なら処理しない
            if (sqlstr != "")
            {
                //サーバー接続
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                try
                {


                    //データテーブル初期化
                    ds.Tables["製品マスタ"].Rows.Clear();

                    //テーブルへ行を追加

                    SqlCommand comMei = new SqlCommand(sqlstr, con);
                    SqlDataReader sdrMei = comMei.ExecuteReader();

                    while (sdrMei.Read())
                    {
                        DataRow row = ds.Tables["製品マスタ"].NewRow();

                        row["Id"] = (int)sdrMei["Id"];
                        row["製品コード"] = (string)sdrMei["製品コード"];
                        row["製品名"] = (string)sdrMei["製品名"];
                        row["摘要"] = (string)sdrMei["摘要"];
                        row["共通FL"] = (bool)sdrMei["共通FL"];
                        row["得意先コード"] = (string)sdrMei["得意先コード"];

                        ds.Tables["製品マスタ"].Rows.Add(row);
                    }

                    sdrMei.Close();


                }
                finally
                {
                    //サーバー切断
                    con.Close();
                }

            }
        }


        private void FormSeihinItiran_Load(object sender, EventArgs e)
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
            }
            finally
            {
                //サーバー切断
                con.Close();
            }

            dt.TableName = "製品マスタ";

            dt.Columns.Add("Id", Type.GetType("System.Int32"));
            dt.Columns.Add("製品コード");
            dt.Columns.Add("製品名");
            dt.Columns.Add("摘要");
            dt.Columns.Add("共通FL", Type.GetType("System.Boolean"));
            dt.Columns.Add("得意先コード");
            ds.Tables.Add(dt);

            dataGridViewSeihin.AutoGenerateColumns = false;
            dataGridViewSeihin.DataSource = ds.Tables["製品マスタ"];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strSql;
            string tokuListStr;

            if (comboBoxTokuisaki.SelectedIndex >= 0)
            {
                tokuListStr = comboBoxTokuisaki.SelectedItem.ToString();
                string tokuCodeStr = tokuListStr.Substring(0, 13).Trim();

                strSql = "SELECT * FROM 製品マスタ WHERE 得意先コード = '" + tokuCodeStr + "' ORDER BY 製品コード";
            }
            else
            {
                strSql = "";
            }
            DisplaySeihin(strSql);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strSql;

            strSql = "SELECT * FROM 製品マスタ ORDER BY 製品コード";
            DisplaySeihin(strSql);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowNo = dataGridViewSeihin.CurrentCellAddress.Y;
            if (rowNo < 0) return;
            string editNo = (string)ds.Tables["製品マスタ"].Rows[rowNo]["製品コード"];
            string editName = (string)ds.Tables["製品マスタ"].Rows[rowNo]["製品名"];

            FormCheckKomoku frmCheckKomoku = new FormCheckKomoku();
            frmCheckKomoku.labelSeihinCode.Text = editNo;
            frmCheckKomoku.labelSeihinMei.Text = editName;

            frmCheckKomoku.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            //カレント行を取得
            int rowNo = dataGridViewSeihin.CurrentCellAddress.Y;
            if (rowNo < 0) return;

            //部品一覧入力画面を準備
            FormBuhinMst frmBuhinMst = new FormBuhinMst();

            //得意先コードと製品コードを取得
            string tokuCodeStr = (string)ds.Tables["製品マスタ"].Rows[rowNo]["得意先コード"];
            string SeiCodeStr = (string)ds.Tables["製品マスタ"].Rows[rowNo]["製品コード"];

            //部品一覧入力画面の変数にそれぞれのコードを渡す
            frmBuhinMst.strRefTokui = tokuCodeStr;
            frmBuhinMst.strRefSeihin = SeiCodeStr;

            frmBuhinMst.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //部品詳細入力
            //カレント行を取得
            int rowNo = dataGridViewSeihin.CurrentCellAddress.Y;
            if (rowNo < 0) return;

            //部品一覧入力画面を準備
            FormBuhinItiran frmBuhinItiran = new FormBuhinItiran();

            //得意先コードと製品コードを取得
            string tokuCodeStr = (string)ds.Tables["製品マスタ"].Rows[rowNo]["得意先コード"];
            string SeiCodeStr = (string)ds.Tables["製品マスタ"].Rows[rowNo]["製品コード"];

            //部品一覧入力画面の変数にそれぞれのコードを渡す
            frmBuhinItiran.strRefTokui = tokuCodeStr;
            frmBuhinItiran.strRefSeihin = SeiCodeStr;

            frmBuhinItiran.Show();

        }
    }
}
