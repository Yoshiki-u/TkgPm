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
    public partial class FormReportViewer : Form
    {
        public FormReportViewer()
        {
            InitializeComponent();
        }

        private void FormReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'DataSetMst.得意先マスタ' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.得意先マスタTableAdapter.Fill(this.DataSetMst.得意先マスタ);

            this.reportViewer1.RefreshReport();
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
