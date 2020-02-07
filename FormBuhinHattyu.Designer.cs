namespace SeisanKanri
{
    partial class FormBuhinHattyu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonView = new System.Windows.Forms.Button();
            this.dateTimePickerJutyu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxJutyuNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMeisaiSounyu = new System.Windows.Forms.Button();
            this.buttonDeleteMeisai = new System.Windows.Forms.Button();
            this.buttonAddMeisai = new System.Windows.Forms.Button();
            this.buttonReference = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.dataGridViewMeisai = new System.Windows.Forms.DataGridView();
            this.製品コード = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.製品名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.納期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.摘要 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelJutyuNo = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxTanto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeisai)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(452, 7);
            this.buttonView.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(130, 30);
            this.buttonView.TabIndex = 14;
            this.buttonView.Text = "番号で検索して表示";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // dateTimePickerJutyu
            // 
            this.dateTimePickerJutyu.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePickerJutyu.Location = new System.Drawing.Point(61, 15);
            this.dateTimePickerJutyu.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dateTimePickerJutyu.Name = "dateTimePickerJutyu";
            this.dateTimePickerJutyu.Size = new System.Drawing.Size(156, 22);
            this.dateTimePickerJutyu.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "発 注 日";
            // 
            // textBoxJutyuNo
            // 
            this.textBoxJutyuNo.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxJutyuNo.Location = new System.Drawing.Point(352, 15);
            this.textBoxJutyuNo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxJutyuNo.Name = "textBoxJutyuNo";
            this.textBoxJutyuNo.Size = new System.Drawing.Size(91, 22);
            this.textBoxJutyuNo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "発注番号";
            // 
            // buttonMeisaiSounyu
            // 
            this.buttonMeisaiSounyu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMeisaiSounyu.Location = new System.Drawing.Point(194, 362);
            this.buttonMeisaiSounyu.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonMeisaiSounyu.Name = "buttonMeisaiSounyu";
            this.buttonMeisaiSounyu.Size = new System.Drawing.Size(80, 33);
            this.buttonMeisaiSounyu.TabIndex = 36;
            this.buttonMeisaiSounyu.Text = "明細行挿入";
            this.buttonMeisaiSounyu.UseVisualStyleBackColor = true;
            this.buttonMeisaiSounyu.Click += new System.EventHandler(this.buttonMeisaiSounyu_Click);
            // 
            // buttonDeleteMeisai
            // 
            this.buttonDeleteMeisai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteMeisai.Location = new System.Drawing.Point(103, 362);
            this.buttonDeleteMeisai.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonDeleteMeisai.Name = "buttonDeleteMeisai";
            this.buttonDeleteMeisai.Size = new System.Drawing.Size(80, 33);
            this.buttonDeleteMeisai.TabIndex = 35;
            this.buttonDeleteMeisai.Text = "明細行削除";
            this.buttonDeleteMeisai.UseVisualStyleBackColor = true;
            this.buttonDeleteMeisai.Click += new System.EventHandler(this.buttonDeleteMeisai_Click);
            // 
            // buttonAddMeisai
            // 
            this.buttonAddMeisai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddMeisai.Location = new System.Drawing.Point(13, 362);
            this.buttonAddMeisai.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonAddMeisai.Name = "buttonAddMeisai";
            this.buttonAddMeisai.Size = new System.Drawing.Size(80, 33);
            this.buttonAddMeisai.TabIndex = 34;
            this.buttonAddMeisai.Text = "明細行追加";
            this.buttonAddMeisai.UseVisualStyleBackColor = true;
            this.buttonAddMeisai.Click += new System.EventHandler(this.buttonAddMeisai_Click);
            // 
            // buttonReference
            // 
            this.buttonReference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReference.Location = new System.Drawing.Point(276, 411);
            this.buttonReference.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonReference.Name = "buttonReference";
            this.buttonReference.Size = new System.Drawing.Size(72, 28);
            this.buttonReference.TabIndex = 32;
            this.buttonReference.Text = "参照(F8)";
            this.buttonReference.UseVisualStyleBackColor = true;
            this.buttonReference.Click += new System.EventHandler(this.buttonReference_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(573, 409);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(78, 30);
            this.buttonClose.TabIndex = 33;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(172, 411);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(78, 30);
            this.buttonSave.TabIndex = 31;
            this.buttonSave.Text = "登録";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(91, 411);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(78, 30);
            this.buttonDelete.TabIndex = 30;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNew.Location = new System.Drawing.Point(10, 411);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(78, 30);
            this.buttonNew.TabIndex = 29;
            this.buttonNew.Text = "新規";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // dataGridViewMeisai
            // 
            this.dataGridViewMeisai.AllowUserToAddRows = false;
            this.dataGridViewMeisai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMeisai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMeisai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeisai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.製品コード,
            this.製品名,
            this.数量,
            this.納期,
            this.摘要});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMeisai.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMeisai.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewMeisai.Location = new System.Drawing.Point(9, 113);
            this.dataGridViewMeisai.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dataGridViewMeisai.MultiSelect = false;
            this.dataGridViewMeisai.Name = "dataGridViewMeisai";
            this.dataGridViewMeisai.RowTemplate.Height = 33;
            this.dataGridViewMeisai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewMeisai.Size = new System.Drawing.Size(663, 246);
            this.dataGridViewMeisai.TabIndex = 28;
            this.dataGridViewMeisai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMeisai_CellContentClick);
            this.dataGridViewMeisai.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMeisai_CellEndEdit);
            this.dataGridViewMeisai.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewMeisai_DataError);
            this.dataGridViewMeisai.Enter += new System.EventHandler(this.dataGridViewMeisai_Enter);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "#,0.#";
            dataGridViewCellStyle4.NullValue = "0";
            this.数量.DefaultCellStyle = dataGridViewCellStyle4;
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            this.数量.Width = 54;
            // 
            // 納期
            // 
            this.納期.DataPropertyName = "納期";
            dataGridViewCellStyle5.Format = "D";
            dataGridViewCellStyle5.NullValue = null;
            this.納期.DefaultCellStyle = dataGridViewCellStyle5;
            this.納期.HeaderText = "　　納　期　　";
            this.納期.Name = "納期";
            this.納期.Width = 94;
            // 
            // 摘要
            // 
            this.摘要.DataPropertyName = "摘要";
            this.摘要.HeaderText = "摘要";
            this.摘要.Name = "摘要";
            this.摘要.Width = 54;
            // 
            // labelJutyuNo
            // 
            this.labelJutyuNo.AutoSize = true;
            this.labelJutyuNo.Location = new System.Drawing.Point(587, 81);
            this.labelJutyuNo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelJutyuNo.Name = "labelJutyuNo";
            this.labelJutyuNo.Size = new System.Drawing.Size(75, 12);
            this.labelJutyuNo.TabIndex = 38;
            this.labelJutyuNo.Text = "LabelJutyuNo";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(587, 65);
            this.labelID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(43, 12);
            this.labelID.TabIndex = 37;
            this.labelID.Text = "LabelID";
            // 
            // textBoxTanto
            // 
            this.textBoxTanto.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxTanto.Location = new System.Drawing.Point(61, 57);
            this.textBoxTanto.Name = "textBoxTanto";
            this.textBoxTanto.Size = new System.Drawing.Size(139, 22);
            this.textBoxTanto.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "担当";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 12);
            this.label4.TabIndex = 41;
            this.label4.Text = "※　新規の時は自動で番号が発行されるので空白にしてください。";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 42;
            this.button1.Text = "発注書印刷";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FormBuhinHattyu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTanto);
            this.Controls.Add(this.labelJutyuNo);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonMeisaiSounyu);
            this.Controls.Add(this.buttonDeleteMeisai);
            this.Controls.Add(this.buttonAddMeisai);
            this.Controls.Add(this.buttonReference);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.dataGridViewMeisai);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.dateTimePickerJutyu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxJutyuNo);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FormBuhinHattyu";
            this.Text = "発注";
            this.Load += new System.EventHandler(this.FormBuhinHattyu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBuhinHattyu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeisai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.DateTimePicker dateTimePickerJutyu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxJutyuNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMeisaiSounyu;
        private System.Windows.Forms.Button buttonDeleteMeisai;
        private System.Windows.Forms.Button buttonAddMeisai;
        private System.Windows.Forms.Button buttonReference;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.DataGridView dataGridViewMeisai;
        private System.Windows.Forms.Label labelJutyuNo;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxTanto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 製品コード;
        private System.Windows.Forms.DataGridViewTextBoxColumn 製品名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 納期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 摘要;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}