namespace SeisanKanri
{
    partial class FormNohinHenko
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewNohin = new System.Windows.Forms.DataGridView();
            this.納品日 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.納品数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.摘要 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.必着 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.完了 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolSSLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelSeihinMei = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonInsertRow = new System.Windows.Forms.Button();
            this.buttonDeleteRow = new System.Windows.Forms.Button();
            this.buttonAddRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNohin)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewNohin
            // 
            this.dataGridViewNohin.AllowUserToAddRows = false;
            this.dataGridViewNohin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNohin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNohin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.納品日,
            this.納品数,
            this.摘要,
            this.必着,
            this.完了});
            this.dataGridViewNohin.Location = new System.Drawing.Point(12, 34);
            this.dataGridViewNohin.Name = "dataGridViewNohin";
            this.dataGridViewNohin.RowTemplate.Height = 21;
            this.dataGridViewNohin.Size = new System.Drawing.Size(461, 108);
            this.dataGridViewNohin.TabIndex = 0;
            this.dataGridViewNohin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNohin_CellContentClick);
            // 
            // 納品日
            // 
            this.納品日.FillWeight = 200F;
            this.納品日.HeaderText = "納品日";
            this.納品日.Name = "納品日";
            this.納品日.Width = 66;
            // 
            // 納品数
            // 
            this.納品数.DataPropertyName = "納品数";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,0.#";
            dataGridViewCellStyle5.NullValue = "0";
            this.納品数.DefaultCellStyle = dataGridViewCellStyle5;
            this.納品数.HeaderText = "納品数";
            this.納品数.Name = "納品数";
            this.納品数.Width = 66;
            // 
            // 摘要
            // 
            this.摘要.HeaderText = "摘要";
            this.摘要.Name = "摘要";
            this.摘要.Width = 54;
            // 
            // 必着
            // 
            this.必着.HeaderText = "必着";
            this.必着.Name = "必着";
            this.必着.Width = 35;
            // 
            // 完了
            // 
            this.完了.HeaderText = "完了";
            this.完了.Name = "完了";
            this.完了.Width = 35;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSSLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 193);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(486, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolSSLabel1
            // 
            this.toolSSLabel1.Name = "toolSSLabel1";
            this.toolSSLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolSSLabel1.Text = "toolStripStatusLabel1";
            // 
            // labelSeihinMei
            // 
            this.labelSeihinMei.AutoSize = true;
            this.labelSeihinMei.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSeihinMei.Location = new System.Drawing.Point(16, 7);
            this.labelSeihinMei.Name = "labelSeihinMei";
            this.labelSeihinMei.Size = new System.Drawing.Size(46, 16);
            this.labelSeihinMei.TabIndex = 2;
            this.labelSeihinMei.Text = "label1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(274, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "登録";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(376, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "閉じる";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonInsertRow
            // 
            this.buttonInsertRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInsertRow.Location = new System.Drawing.Point(175, 152);
            this.buttonInsertRow.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonInsertRow.Name = "buttonInsertRow";
            this.buttonInsertRow.Size = new System.Drawing.Size(80, 33);
            this.buttonInsertRow.TabIndex = 30;
            this.buttonInsertRow.Text = "行挿入";
            this.buttonInsertRow.UseVisualStyleBackColor = true;
            this.buttonInsertRow.Click += new System.EventHandler(this.buttonInsertRow_Click);
            // 
            // buttonDeleteRow
            // 
            this.buttonDeleteRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteRow.Location = new System.Drawing.Point(93, 152);
            this.buttonDeleteRow.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonDeleteRow.Name = "buttonDeleteRow";
            this.buttonDeleteRow.Size = new System.Drawing.Size(80, 33);
            this.buttonDeleteRow.TabIndex = 29;
            this.buttonDeleteRow.Text = "行削除";
            this.buttonDeleteRow.UseVisualStyleBackColor = true;
            this.buttonDeleteRow.Click += new System.EventHandler(this.buttonDeleteRow_Click);
            // 
            // buttonAddRow
            // 
            this.buttonAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddRow.Location = new System.Drawing.Point(11, 152);
            this.buttonAddRow.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonAddRow.Name = "buttonAddRow";
            this.buttonAddRow.Size = new System.Drawing.Size(80, 33);
            this.buttonAddRow.TabIndex = 28;
            this.buttonAddRow.Text = "行追加";
            this.buttonAddRow.UseVisualStyleBackColor = true;
            this.buttonAddRow.Click += new System.EventHandler(this.buttonAddRow_Click);
            // 
            // FormNohinHenko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 215);
            this.Controls.Add(this.buttonInsertRow);
            this.Controls.Add(this.buttonDeleteRow);
            this.Controls.Add(this.buttonAddRow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSeihinMei);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridViewNohin);
            this.Name = "FormNohinHenko";
            this.Text = "納品日、納品数変更";
            this.Load += new System.EventHandler(this.FormNohinHenko_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNohin)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridViewNohin;
        public System.Windows.Forms.Label labelSeihinMei;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolSSLabel1;
        private System.Windows.Forms.Button buttonInsertRow;
        private System.Windows.Forms.Button buttonDeleteRow;
        private System.Windows.Forms.Button buttonAddRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn 納品日;
        private System.Windows.Forms.DataGridViewTextBoxColumn 納品数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 摘要;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 必着;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 完了;
    }
}