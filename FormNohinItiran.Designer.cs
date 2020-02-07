namespace SeisanKanri
{
    partial class FormNohinItiran
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewMeisai = new System.Windows.Forms.DataGridView();
            this.buttonDisp = new System.Windows.Forms.Button();
            this.comboBoxTokuisaki = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.受注番号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.行番号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.製品コード = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.製品名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.単価 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.金額 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.納期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.摘要 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.特注FL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.試作FL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.必着FL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.完了FL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeisai)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMeisai
            // 
            this.dataGridViewMeisai.AllowUserToAddRows = false;
            this.dataGridViewMeisai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMeisai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeisai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.受注番号,
            this.行番号,
            this.製品コード,
            this.製品名,
            this.数量,
            this.単価,
            this.金額,
            this.納期,
            this.摘要,
            this.特注FL,
            this.試作FL,
            this.必着FL,
            this.完了FL});
            this.dataGridViewMeisai.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewMeisai.Location = new System.Drawing.Point(10, 81);
            this.dataGridViewMeisai.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dataGridViewMeisai.MultiSelect = false;
            this.dataGridViewMeisai.Name = "dataGridViewMeisai";
            this.dataGridViewMeisai.RowTemplate.Height = 33;
            this.dataGridViewMeisai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewMeisai.Size = new System.Drawing.Size(896, 246);
            this.dataGridViewMeisai.TabIndex = 21;
            // 
            // buttonDisp
            // 
            this.buttonDisp.Location = new System.Drawing.Point(372, 13);
            this.buttonDisp.Name = "buttonDisp";
            this.buttonDisp.Size = new System.Drawing.Size(85, 51);
            this.buttonDisp.TabIndex = 20;
            this.buttonDisp.Text = "表示";
            this.buttonDisp.UseVisualStyleBackColor = true;
            this.buttonDisp.Click += new System.EventHandler(this.buttonDisp_Click);
            // 
            // comboBoxTokuisaki
            // 
            this.comboBoxTokuisaki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTokuisaki.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxTokuisaki.FormattingEnabled = true;
            this.comboBoxTokuisaki.Location = new System.Drawing.Point(71, 44);
            this.comboBoxTokuisaki.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.comboBoxTokuisaki.Name = "comboBoxTokuisaki";
            this.comboBoxTokuisaki.Size = new System.Drawing.Size(261, 20);
            this.comboBoxTokuisaki.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "得意先";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "～";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "表示範囲";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(226, 13);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(126, 19);
            this.dateTimePickerEnd.TabIndex = 15;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(71, 13);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(126, 19);
            this.dateTimePickerStart.TabIndex = 14;
            // 
            // 受注番号
            // 
            this.受注番号.DataPropertyName = "受注番号";
            this.受注番号.HeaderText = "受注番号";
            this.受注番号.Name = "受注番号";
            this.受注番号.Width = 78;
            // 
            // 行番号
            // 
            this.行番号.DataPropertyName = "行番号";
            this.行番号.HeaderText = "行番号";
            this.行番号.Name = "行番号";
            this.行番号.Width = 66;
            // 
            // 製品コード
            // 
            this.製品コード.DataPropertyName = "製品コード";
            this.製品コード.HeaderText = "製品コード";
            this.製品コード.Name = "製品コード";
            this.製品コード.Width = 81;
            // 
            // 製品名
            // 
            this.製品名.DataPropertyName = "製品名";
            this.製品名.HeaderText = "製品名";
            this.製品名.Name = "製品名";
            this.製品名.Width = 66;
            // 
            // 数量
            // 
            this.数量.DataPropertyName = "数量";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "#,0.#";
            dataGridViewCellStyle1.NullValue = "0";
            this.数量.DefaultCellStyle = dataGridViewCellStyle1;
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            this.数量.Width = 54;
            // 
            // 単価
            // 
            this.単価.DataPropertyName = "単価";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "#,0.#";
            dataGridViewCellStyle2.NullValue = "0";
            this.単価.DefaultCellStyle = dataGridViewCellStyle2;
            this.単価.HeaderText = "単価";
            this.単価.Name = "単価";
            this.単価.Width = 54;
            // 
            // 金額
            // 
            this.金額.DataPropertyName = "金額";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,0.#";
            dataGridViewCellStyle3.NullValue = "0";
            this.金額.DefaultCellStyle = dataGridViewCellStyle3;
            this.金額.HeaderText = "金額";
            this.金額.Name = "金額";
            this.金額.Width = 54;
            // 
            // 納期
            // 
            this.納期.DataPropertyName = "納期";
            dataGridViewCellStyle4.Format = "D";
            dataGridViewCellStyle4.NullValue = null;
            this.納期.DefaultCellStyle = dataGridViewCellStyle4;
            this.納期.HeaderText = "納期";
            this.納期.Name = "納期";
            this.納期.Width = 54;
            // 
            // 摘要
            // 
            this.摘要.DataPropertyName = "摘要";
            this.摘要.HeaderText = "摘要";
            this.摘要.Name = "摘要";
            this.摘要.Width = 54;
            // 
            // 特注FL
            // 
            this.特注FL.DataPropertyName = "特注FL";
            this.特注FL.HeaderText = "特注";
            this.特注FL.Name = "特注FL";
            this.特注FL.Width = 35;
            // 
            // 試作FL
            // 
            this.試作FL.DataPropertyName = "試作FL";
            this.試作FL.HeaderText = "試作";
            this.試作FL.Name = "試作FL";
            this.試作FL.Width = 35;
            // 
            // 必着FL
            // 
            this.必着FL.HeaderText = "必着";
            this.必着FL.Name = "必着FL";
            this.必着FL.Width = 35;
            // 
            // 完了FL
            // 
            this.完了FL.HeaderText = "完了";
            this.完了FL.Name = "完了FL";
            this.完了FL.Width = 35;
            // 
            // FormNohinItiran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.dataGridViewMeisai);
            this.Controls.Add(this.buttonDisp);
            this.Controls.Add(this.comboBoxTokuisaki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Name = "FormNohinItiran";
            this.Text = "FormNohinItiran";
            this.Load += new System.EventHandler(this.FormNohinItiran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeisai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMeisai;
        private System.Windows.Forms.Button buttonDisp;
        private System.Windows.Forms.ComboBox comboBoxTokuisaki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn 受注番号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 行番号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 製品コード;
        private System.Windows.Forms.DataGridViewTextBoxColumn 製品名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 単価;
        private System.Windows.Forms.DataGridViewTextBoxColumn 金額;
        private System.Windows.Forms.DataGridViewTextBoxColumn 納期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 摘要;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 特注FL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 試作FL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 必着FL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 完了FL;
    }
}