using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SeisanKanri.Program;

namespace SeisanKanri
{
    public partial class FormConfig : Form
    {

        public FormConfig()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.TkgName = textBoxName.Text;
            Properties.Settings.Default.TkgAddress = textBoxAddress.Text;
            Properties.Settings.Default.TkgTelFax = textBoxTelFax.Text;
            Properties.Settings.Default.TkgEmail = textBoxEmail.Text;
            Properties.Settings.Default.OoinoName = textBoxOoino.Text;
            Properties.Settings.Default.ConnectStr = textBoxConnectStr.Text;
            Properties.Settings.Default.ProFName = textBoxProjectPath.Text;

            Properties.Settings.Default.Save();

            MessageBox.Show("設定を保存しました");

        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            textBoxName.Text = Properties.Settings.Default.TkgName;
            textBoxAddress.Text = Properties.Settings.Default.TkgAddress;
            textBoxTelFax.Text = Properties.Settings.Default.TkgTelFax;
            textBoxEmail.Text = Properties.Settings.Default.TkgEmail;
            textBoxOoino.Text = Properties.Settings.Default.OoinoName;
            textBoxConnectStr.Text = Properties.Settings.Default.ConnectStr;
            textBoxProjectPath.Text = Properties.Settings.Default.ProFName;


        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
