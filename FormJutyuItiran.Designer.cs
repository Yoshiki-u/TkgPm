namespace SeisanKanri
{
    partial class FormJutyuItiran
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTokuisaki = new System.Windows.Forms.ComboBox();
            this.buttonDisp = new System.Windows.Forms.Button();
            this.dataGridViewMeisai = new System.Windows.Forms.DataGridView();
            this.受注番号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.行番号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.製品コード = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.製品名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.単価 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.金額 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.納期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生産完了予定日 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.摘要 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.特注FL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.試作FL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBoxKanryo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeisai)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(71, 9);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(126, 19);
            this.dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(226, 9);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(126, 19);
            this.dateTimePickerEnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "表示範囲";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "～";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "得意先";
            // 
            // comboBoxTokuisaki
            // 
            this.comboBoxTokuisaki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTokuisaki.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxTokuisaki.FormattingEnabled = true;
            this.comboBoxTokuisaki.Location = new System.Drawing.Point(71, 40);
            this.comboBoxTokuisaki.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.comboBoxTokuisaki.Name = "comboBoxTokuisaki";
            this.comboBoxTokuisaki.Size = new System.Drawing.Size(261, 20);
            this.comboBoxTokuisaki.TabIndex = 5;
            // 
            // buttonDisp
            // 
            this.buttonDisp.Location = new System.Drawing.Point(574, 7);
            this.buttonDisp.Name = "buttonDisp";
            this.buttonDisp.Size = new System.Drawing.Size(85, 51);
            this.buttonDisp.TabIndex = 6;
            this.buttonDisp.Text = "表示";
            this.buttonDisp.UseVisualStyleBackColor = true;
            this.buttonDisp.Click += new System.EventHandler(this.ButtonDisp_Click);
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
            this.生産完了予定日,
            this.摘要,
            this.特注FL,
            this.試作FL});
            this.dataGridViewMeisai.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewMeisai.Location = new System.Drawing.Point(10, 77);
            this.dataGridViewMeisai.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dataGridViewMeisai.MultiSelect = false;
            this.dataGridViewMeisai.Name = "dataGridViewMeisai";
            this.dataGridViewMeisai.RowTemplate.Height = 33;
            this.dataGridViewMeisai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewMeisai.Size = new System.Drawing.Size(896, 246);
            this.dataGridViewMeisai.TabIndex = 13;
            this.dataGridViewMeisai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMeisai_CellContentClick);
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
            // 生産完了予定日
            // 
            this.生産完了予定日.DataPropertyName = "生産完了予定日";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.生産完了予定日.DefaultCellStyle = dataGridViewCellStyle5;
            this.生産完了予定日.HeaderText = "生産予定";
            this.生産完了予定日.Name = "生産完了予定日";
            this.生産完了予定日.Width = 78;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "一覧印刷";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 30);
            this.button2.TabIndex = 15;
            this.button2.Text = "木取 - 加工用　印刷";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 30);
            this.button3.TabIndex = 16;
            this.button3.Text = "木取 - NC用 印刷";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(383, 336);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 30);
            this.button4.TabIndex = 17;
            this.button4.Text = "作業指示　印刷";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(523, 336);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 30);
            this.button5.TabIndex = 18;
            this.button5.Text = "出荷前チェックシート";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // checkBoxKanryo
            // 
            this.checkBoxKanryo.AutoSize = true;
            this.checkBoxKanryo.Location = new System.Drawing.Point(409, 39);
            this.checkBoxKanryo.Name = "checkBoxKanryo";
            this.checkBoxKanryo.Size = new System.Drawing.Size(129, 16);
            this.checkBoxKanryo.TabIndex = 19;
            this.checkBoxKanryo.Text = "完了のものも表示する";
            this.checkBoxKanryo.UseVisualStyleBackColor = true;
            // 
            // FormJutyuItiran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 384);
            this.Controls.Add(this.checkBoxKanryo);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewMeisai);
            this.Controls.Add(this.buttonDisp);
            this.Controls.Add(this.comboBoxTokuisaki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Name = "FormJutyuItiran";
            this.Text = "受注一覧";
            this.Load += new System.EventHandler(this.FormJutyuItiran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeisai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTokuisaki;
        private System.Windows.Forms.Button buttonDisp;
        private System.Windows.Forms.DataGridView dataGridViewMeisai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 受注番号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 行番号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 製品コード;
        private System.Windows.Forms.DataGridViewTextBoxColumn 製品名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 単価;
        private System.Windows.Forms.DataGridViewTextBoxColumn 金額;
        private System.Windows.Forms.DataGridViewTextBoxColumn 納期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生産完了予定日;
        private System.Windows.Forms.DataGridViewTextBoxColumn 摘要;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 特注FL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 試作FL;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBoxKanryo;
    }
}