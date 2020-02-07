﻿using System;
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
    public partial class FormInNut : Form
    {
        //SQLサーバー接続文字
        private string constr = @Properties.Settings.Default.ConnectStr;

        public FormInNut()
        {
            InitializeComponent();
        }

        private void FormInNut_Load(object sender, EventArgs e)
        {
            //コンボボックスに加工種を設定する
            //リスト全消去
            listBoxItem.Items.Clear();
            //サーバーに接続
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                //接続成功
                //すべてのレコードをコード昇順で出力
                string sqlstr = "select * from 金物マスタ ORDER BY 金物コード";
                SqlCommand com = new SqlCommand(sqlstr, con);
                SqlDataReader sdr = com.ExecuteReader();

                //リスト表示
                while (sdr.Read() == true)
                {
                    //書式xxx : xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
                    string code = (string)sdr["金物コード"];
                    string name = (string)sdr["金物名"];

                    listBoxItem.Items.Add(string.Format("{0:s} : {1:s}", code.PadRight(3), name));

                }
                if (listBoxItem.Items.Count > 0)
                {
                    listBoxItem.SelectedIndex = 0;
                }
            }
            finally
            {
                //サーバー切断
                con.Close();
            }

        }

        private void ListBoxItem_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxItem.SelectedIndex != -1)
            {
                this.DialogResult = DialogResult.OK;
            }

        }

        private void FormInNut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (listBoxItem.SelectedIndex != -1)
                {
                    this.DialogResult = DialogResult.OK;
                }

            }

        }
    }
}
