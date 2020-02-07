namespace SeisanKanri
{
    partial class FormReportViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetMst = new SeisanKanri.DataSetMst();
            this.得意先マスタBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.得意先マスタTableAdapter = new SeisanKanri.DataSetMstTableAdapters.得意先マスタTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.得意先マスタBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.得意先マスタBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SeisanKanri.ReportTokuisakiItiran.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.ReportViewer1_Load);
            // 
            // DataSetMst
            // 
            this.DataSetMst.DataSetName = "DataSetMst";
            this.DataSetMst.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 得意先マスタBindingSource
            // 
            this.得意先マスタBindingSource.DataMember = "得意先マスタ";
            this.得意先マスタBindingSource.DataSource = this.DataSetMst;
            // 
            // 得意先マスタTableAdapter
            // 
            this.得意先マスタTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportViewer";
            this.Text = "FormReportViewer";
            this.Load += new System.EventHandler(this.FormReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.得意先マスタBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource 得意先マスタBindingSource;
        private DataSetMst DataSetMst;
        private DataSetMstTableAdapters.得意先マスタTableAdapter 得意先マスタTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}