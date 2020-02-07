namespace SeisanKanri
{
    partial class FormJutyu
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
            this.dataGridViewMeisai = new System.Windows.Forms.DataGridView();
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
            this.必着 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.発注先コード = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxJutyuNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSenpoNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerJutyu = new System.Windows.Forms.DateTimePicker();
            this.textBoxTokuisakiMei = new System.Windows.Forms.TextBox();
            this.textBoxTokuisakiCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonPre = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelJutyuNo = new System.Windows.Forms.Label();
            this.buttonReference = new System.Windows.Forms.Button();
            this.buttonAddMeisai = new System.Windows.Forms.Button();
            this.buttonDeleteMeisai = new System.Windows.Forms.Button();
            this.buttonMeisaiSounyu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeisai)).BeginInit();
            this.SuspendLayout();
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
            this.単価,
            this.金額,
            this.納期,
            this.生産完了予定日,
            this.摘要,
            this.特注FL,
            this.試作FL,
            this.必着,
            this.発注先コード});
            this.dataGridViewMeisai.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewMeisai.Location = new System.Drawing.Point(18, 143);
            this.dataGridViewMeisai.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dataGridViewMeisai.MultiSelect = false;
            this.dataGridViewMeisai.Name = "dataGridViewMeisai";
            this.dataGridViewMeisai.RowTemplate.Height = 33;
            this.dataGridViewMeisai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewMeisai.Size = new System.Drawing.Size(841, 246);
            this.dataGridViewMeisai.TabIndex = 12;
            this.dataGridViewMeisai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMeisai_CellContentClick_1);
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
            // 必着
            // 
            this.必着.DataPropertyName = "必着FL";
            this.必着.HeaderText = "必着";
            this.必着.Name = "必着";
            this.必着.Width = 35;
            // 
            // 発注先コード
            // 
            this.発注先コード.DataPropertyName = "発注先コード";
            this.発注先コード.HeaderText = "発注先";
            this.発注先コード.Name = "発注先コード";
            this.発注先コード.Width = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "受注番号";
            // 
            // textBoxJutyuNo
            // 
            this.textBoxJutyuNo.Location = new System.Drawing.Point(68, 55);
            this.textBoxJutyuNo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxJutyuNo.Name = "textBoxJutyuNo";
            this.textBoxJutyuNo.Size = new System.Drawing.Size(91, 19);
            this.textBoxJutyuNo.TabIndex = 1;
            this.textBoxJutyuNo.TextChanged += new System.EventHandler(this.TextBoxJutyuNo_TextChanged);
            this.textBoxJutyuNo.Enter += new System.EventHandler(this.textBoxJutyuNo_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "先方受注番号";
            // 
            // textBoxSenpoNo
            // 
            this.textBoxSenpoNo.Location = new System.Drawing.Point(499, 56);
            this.textBoxSenpoNo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxSenpoNo.Name = "textBoxSenpoNo";
            this.textBoxSenpoNo.Size = new System.Drawing.Size(91, 19);
            this.textBoxSenpoNo.TabIndex = 6;
            this.textBoxSenpoNo.Enter += new System.EventHandler(this.textBoxSenpoNo_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "受 注 日";
            // 
            // dateTimePickerJutyu
            // 
            this.dateTimePickerJutyu.Location = new System.Drawing.Point(68, 81);
            this.dateTimePickerJutyu.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dateTimePickerJutyu.Name = "dateTimePickerJutyu";
            this.dateTimePickerJutyu.Size = new System.Drawing.Size(131, 19);
            this.dateTimePickerJutyu.TabIndex = 8;
            this.dateTimePickerJutyu.Enter += new System.EventHandler(this.dateTimePickerJutyu_Enter);
            // 
            // textBoxTokuisakiMei
            // 
            this.textBoxTokuisakiMei.Location = new System.Drawing.Point(162, 106);
            this.textBoxTokuisakiMei.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxTokuisakiMei.Name = "textBoxTokuisakiMei";
            this.textBoxTokuisakiMei.Size = new System.Drawing.Size(438, 19);
            this.textBoxTokuisakiMei.TabIndex = 11;
            this.textBoxTokuisakiMei.Enter += new System.EventHandler(this.textBoxTokuisakiMei_Enter);
            // 
            // textBoxTokuisakiCode
            // 
            this.textBoxTokuisakiCode.Location = new System.Drawing.Point(68, 106);
            this.textBoxTokuisakiCode.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxTokuisakiCode.Name = "textBoxTokuisakiCode";
            this.textBoxTokuisakiCode.Size = new System.Drawing.Size(94, 19);
            this.textBoxTokuisakiCode.TabIndex = 10;
            this.textBoxTokuisakiCode.TextChanged += new System.EventHandler(this.textBoxTokuisakiCode_TextChanged);
            this.textBoxTokuisakiCode.Enter += new System.EventHandler(this.textBoxTokuisakiCode_Enter);
            this.textBoxTokuisakiCode.Leave += new System.EventHandler(this.textBoxTokuisakiCode_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "得 意 先";
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(168, 47);
            this.buttonView.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(46, 30);
            this.buttonView.TabIndex = 2;
            this.buttonView.Text = "表示";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonPre
            // 
            this.buttonPre.Location = new System.Drawing.Point(244, 53);
            this.buttonPre.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonPre.Name = "buttonPre";
            this.buttonPre.Size = new System.Drawing.Size(39, 18);
            this.buttonPre.TabIndex = 3;
            this.buttonPre.Text = "<<";
            this.buttonPre.UseVisualStyleBackColor = true;
            this.buttonPre.Click += new System.EventHandler(this.buttonPre_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(285, 54);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(39, 17);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNew.Location = new System.Drawing.Point(393, 426);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(78, 30);
            this.buttonNew.TabIndex = 13;
            this.buttonNew.Text = "新規";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(483, 425);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(78, 30);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(574, 425);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(78, 30);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "登録";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonClose.Location = new System.Drawing.Point(777, 426);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(78, 27);
            this.buttonClose.TabIndex = 17;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(788, 30);
            this.labelID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(43, 12);
            this.labelID.TabIndex = 23;
            this.labelID.Text = "LabelID";
            // 
            // labelJutyuNo
            // 
            this.labelJutyuNo.AutoSize = true;
            this.labelJutyuNo.Location = new System.Drawing.Point(788, 46);
            this.labelJutyuNo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelJutyuNo.Name = "labelJutyuNo";
            this.labelJutyuNo.Size = new System.Drawing.Size(75, 12);
            this.labelJutyuNo.TabIndex = 24;
            this.labelJutyuNo.Text = "LabelJutyuNo";
            // 
            // buttonReference
            // 
            this.buttonReference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReference.Location = new System.Drawing.Point(677, 425);
            this.buttonReference.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonReference.Name = "buttonReference";
            this.buttonReference.Size = new System.Drawing.Size(72, 28);
            this.buttonReference.TabIndex = 16;
            this.buttonReference.Text = "参照(F8)";
            this.buttonReference.UseVisualStyleBackColor = true;
            this.buttonReference.Click += new System.EventHandler(this.buttonReference_Click);
            // 
            // buttonAddMeisai
            // 
            this.buttonAddMeisai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddMeisai.Location = new System.Drawing.Point(22, 392);
            this.buttonAddMeisai.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonAddMeisai.Name = "buttonAddMeisai";
            this.buttonAddMeisai.Size = new System.Drawing.Size(80, 33);
            this.buttonAddMeisai.TabIndex = 25;
            this.buttonAddMeisai.Text = "明細行追加";
            this.buttonAddMeisai.UseVisualStyleBackColor = true;
            this.buttonAddMeisai.Click += new System.EventHandler(this.buttonAddMeisai_Click);
            // 
            // buttonDeleteMeisai
            // 
            this.buttonDeleteMeisai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteMeisai.Location = new System.Drawing.Point(112, 392);
            this.buttonDeleteMeisai.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonDeleteMeisai.Name = "buttonDeleteMeisai";
            this.buttonDeleteMeisai.Size = new System.Drawing.Size(80, 33);
            this.buttonDeleteMeisai.TabIndex = 26;
            this.buttonDeleteMeisai.Text = "明細行削除";
            this.buttonDeleteMeisai.UseVisualStyleBackColor = true;
            this.buttonDeleteMeisai.Click += new System.EventHandler(this.buttonDeleteMeisai_Click);
            // 
            // buttonMeisaiSounyu
            // 
            this.buttonMeisaiSounyu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMeisaiSounyu.Location = new System.Drawing.Point(203, 392);
            this.buttonMeisaiSounyu.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonMeisaiSounyu.Name = "buttonMeisaiSounyu";
            this.buttonMeisaiSounyu.Size = new System.Drawing.Size(80, 33);
            this.buttonMeisaiSounyu.TabIndex = 27;
            this.buttonMeisaiSounyu.Text = "明細行挿入";
            this.buttonMeisaiSounyu.UseVisualStyleBackColor = true;
            this.buttonMeisaiSounyu.Click += new System.EventHandler(this.buttonMeisaiSounyu_Click);
            // 
            // FormJutyu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 464);
            this.Controls.Add(this.buttonMeisaiSounyu);
            this.Controls.Add(this.buttonDeleteMeisai);
            this.Controls.Add(this.buttonAddMeisai);
            this.Controls.Add(this.buttonReference);
            this.Controls.Add(this.labelJutyuNo);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPre);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.textBoxTokuisakiMei);
            this.Controls.Add(this.textBoxTokuisakiCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerJutyu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSenpoNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxJutyuNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMeisai);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "FormJutyu";
            this.Text = "受注入力";
            this.Load += new System.EventHandler(this.FormJutyu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormJutyu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeisai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMeisai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxJutyuNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSenpoNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerJutyu;
        private System.Windows.Forms.TextBox textBoxTokuisakiMei;
        private System.Windows.Forms.TextBox textBoxTokuisakiCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonPre;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelJutyuNo;
        private System.Windows.Forms.Button buttonReference;
        private System.Windows.Forms.Button buttonAddMeisai;
        private System.Windows.Forms.Button buttonDeleteMeisai;
        private System.Windows.Forms.Button buttonMeisaiSounyu;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn 必着;
        private System.Windows.Forms.DataGridViewTextBoxColumn 発注先コード;
        //private TmDBDataSetTableAdapters.受注TableAdapter 受注TableAdapter;
    }
}