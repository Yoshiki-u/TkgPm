using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeisanKanri
{
    public partial class FormInDate : Form
    {
        public FormInDate()
        {
            InitializeComponent();
        }

        private void FormInDate_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.DialogResult = DialogResult.OK; 
        }
    }
}
