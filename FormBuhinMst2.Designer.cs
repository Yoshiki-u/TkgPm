namespace SeisanKanri
{
    partial class FormBuhinMst2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBuhinCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxKyotu = new System.Windows.Forms.CheckBox();
            this.checkBoxZaiko = new System.Windows.Forms.CheckBox();
            this.checkBoxBetuno = new System.Windows.Forms.CheckBox();
            this.checkBoxOoino = new System.Windows.Forms.CheckBox();
            this.checkBoxNC = new System.Windows.Forms.CheckBox();
            this.textBoxSiyoTaisyo = new System.Windows.Forms.TextBox();
            this.comboBoxZaisyu = new System.Windows.Forms.ComboBox();
            this.材種BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetZaisyu = new SeisanKanri.DataSetZaisyu();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxThickness = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.textBoxSuryo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxTekiyo = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.labelTokuisakiCode = new System.Windows.Forms.Label();
            this.labelSeihinCode = new System.Windows.Forms.Label();
            this.labelSeihinMei = new System.Windows.Forms.Label();
            this.材種TableAdapter = new SeisanKanri.DataSetZaisyuTableAdapters.材種TableAdapter();
            this.label15 = new System.Windows.Forms.Label();
            this.labelNo = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolSSLabelKanriCode = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSSLabelSeries = new System.Windows.Forms.ToolStripStatusLabel();
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.材種BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZaisyu)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 60;
            this.label1.Text = "製品";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 59;
            this.label5.Text = "得意先";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 62;
            this.label2.Text = "部品コード";
            // 
            // textBoxBuhinCode
            // 
            this.textBoxBuhinCode.Location = new System.Drawing.Point(75, 84);
            this.textBoxBuhinCode.MaxLength = 13;
            this.textBoxBuhinCode.Name = "textBoxBuhinCode";
            this.textBoxBuhinCode.Size = new System.Drawing.Size(100, 19);
            this.textBoxBuhinCode.TabIndex = 63;
            this.textBoxBuhinCode.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBuhinCode_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 65;
            this.label4.Text = "使用対象";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 66;
            this.label6.Text = "材種";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 12);
            this.label7.TabIndex = 67;
            this.label7.Text = "厚さ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 68;
            this.label8.Text = "巾";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 12);
            this.label9.TabIndex = 69;
            this.label9.Text = "長さ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 70;
            this.label10.Text = "数量";
            // 
            // checkBoxKyotu
            // 
            this.checkBoxKyotu.AutoSize = true;
            this.checkBoxKyotu.Location = new System.Drawing.Point(478, 113);
            this.checkBoxKyotu.Name = "checkBoxKyotu";
            this.checkBoxKyotu.Size = new System.Drawing.Size(48, 16);
            this.checkBoxKyotu.TabIndex = 71;
            this.checkBoxKyotu.Text = "共通";
            this.checkBoxKyotu.UseVisualStyleBackColor = true;
            // 
            // checkBoxZaiko
            // 
            this.checkBoxZaiko.AutoSize = true;
            this.checkBoxZaiko.Location = new System.Drawing.Point(478, 134);
            this.checkBoxZaiko.Name = "checkBoxZaiko";
            this.checkBoxZaiko.Size = new System.Drawing.Size(48, 16);
            this.checkBoxZaiko.TabIndex = 72;
            this.checkBoxZaiko.Text = "在庫";
            this.checkBoxZaiko.UseVisualStyleBackColor = true;
            // 
            // checkBoxBetuno
            // 
            this.checkBoxBetuno.AutoSize = true;
            this.checkBoxBetuno.Location = new System.Drawing.Point(478, 156);
            this.checkBoxBetuno.Name = "checkBoxBetuno";
            this.checkBoxBetuno.Size = new System.Drawing.Size(48, 16);
            this.checkBoxBetuno.TabIndex = 73;
            this.checkBoxBetuno.Text = "別納";
            this.checkBoxBetuno.UseVisualStyleBackColor = true;
            // 
            // checkBoxOoino
            // 
            this.checkBoxOoino.AutoSize = true;
            this.checkBoxOoino.Location = new System.Drawing.Point(375, 112);
            this.checkBoxOoino.Name = "checkBoxOoino";
            this.checkBoxOoino.Size = new System.Drawing.Size(60, 16);
            this.checkBoxOoino.TabIndex = 74;
            this.checkBoxOoino.Text = "大井野";
            this.checkBoxOoino.UseVisualStyleBackColor = true;
            // 
            // checkBoxNC
            // 
            this.checkBoxNC.AutoSize = true;
            this.checkBoxNC.Location = new System.Drawing.Point(375, 134);
            this.checkBoxNC.Name = "checkBoxNC";
            this.checkBoxNC.Size = new System.Drawing.Size(42, 16);
            this.checkBoxNC.TabIndex = 75;
            this.checkBoxNC.Text = "ＮＣ";
            this.checkBoxNC.UseVisualStyleBackColor = true;
            // 
            // textBoxSiyoTaisyo
            // 
            this.textBoxSiyoTaisyo.Location = new System.Drawing.Point(75, 117);
            this.textBoxSiyoTaisyo.Name = "textBoxSiyoTaisyo";
            this.textBoxSiyoTaisyo.Size = new System.Drawing.Size(229, 19);
            this.textBoxSiyoTaisyo.TabIndex = 76;
            // 
            // comboBoxZaisyu
            // 
            this.comboBoxZaisyu.DataSource = this.材種BindingSource;
            this.comboBoxZaisyu.DisplayMember = "名称";
            this.comboBoxZaisyu.FormattingEnabled = true;
            this.comboBoxZaisyu.Location = new System.Drawing.Point(75, 152);
            this.comboBoxZaisyu.Name = "comboBoxZaisyu";
            this.comboBoxZaisyu.Size = new System.Drawing.Size(229, 20);
            this.comboBoxZaisyu.TabIndex = 77;
            this.comboBoxZaisyu.ValueMember = "Id";
            // 
            // 材種BindingSource
            // 
            this.材種BindingSource.DataMember = "材種";
            this.材種BindingSource.DataSource = this.dataSetZaisyu;
            // 
            // dataSetZaisyu
            // 
            this.dataSetZaisyu.DataSetName = "DataSetZaisyu";
            this.dataSetZaisyu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(15, 371);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(506, 42);
            this.buttonClose.TabIndex = 79;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxThickness
            // 
            this.textBoxThickness.Location = new System.Drawing.Point(75, 208);
            this.textBoxThickness.Name = "textBoxThickness";
            this.textBoxThickness.Size = new System.Drawing.Size(45, 19);
            this.textBoxThickness.TabIndex = 80;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(149, 208);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(45, 19);
            this.textBoxWidth.TabIndex = 81;
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(223, 208);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(45, 19);
            this.textBoxLength.TabIndex = 82;
            // 
            // textBoxSuryo
            // 
            this.textBoxSuryo.Location = new System.Drawing.Point(75, 249);
            this.textBoxSuryo.Name = "textBoxSuryo";
            this.textBoxSuryo.Size = new System.Drawing.Size(45, 19);
            this.textBoxSuryo.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(126, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 84;
            this.label11.Text = "×";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(200, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 85;
            this.label12.Text = "×";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 86;
            this.label13.Text = "寸法";
            // 
            // textBoxTekiyo
            // 
            this.textBoxTekiyo.Location = new System.Drawing.Point(75, 286);
            this.textBoxTekiyo.Multiline = true;
            this.textBoxTekiyo.Name = "textBoxTekiyo";
            this.textBoxTekiyo.Size = new System.Drawing.Size(339, 34);
            this.textBoxTekiyo.TabIndex = 87;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(15, 326);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(506, 39);
            this.buttonSave.TabIndex = 88;
            this.buttonSave.Text = "登　録";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 293);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 89;
            this.label14.Text = "摘要";
            // 
            // labelTokuisakiCode
            // 
            this.labelTokuisakiCode.AutoSize = true;
            this.labelTokuisakiCode.Location = new System.Drawing.Point(73, 30);
            this.labelTokuisakiCode.Name = "labelTokuisakiCode";
            this.labelTokuisakiCode.Size = new System.Drawing.Size(83, 12);
            this.labelTokuisakiCode.TabIndex = 90;
            this.labelTokuisakiCode.Text = "9999999999999";
            // 
            // labelSeihinCode
            // 
            this.labelSeihinCode.AutoSize = true;
            this.labelSeihinCode.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSeihinCode.Location = new System.Drawing.Point(73, 52);
            this.labelSeihinCode.Name = "labelSeihinCode";
            this.labelSeihinCode.Size = new System.Drawing.Size(111, 15);
            this.labelSeihinCode.TabIndex = 91;
            this.labelSeihinCode.Text = "9999999999999";
            // 
            // labelSeihinMei
            // 
            this.labelSeihinMei.AutoSize = true;
            this.labelSeihinMei.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSeihinMei.Location = new System.Drawing.Point(190, 52);
            this.labelSeihinMei.Name = "labelSeihinMei";
            this.labelSeihinMei.Size = new System.Drawing.Size(295, 15);
            this.labelSeihinMei.TabIndex = 92;
            this.labelSeihinMei.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            // 
            // 材種TableAdapter
            // 
            this.材種TableAdapter.ClearBeforeFill = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(362, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 94;
            this.label15.Text = "表示順序";
            // 
            // labelNo
            // 
            this.labelNo.AutoSize = true;
            this.labelNo.Location = new System.Drawing.Point(421, 87);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(23, 12);
            this.labelNo.TabIndex = 95;
            this.labelNo.Text = "999";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSSLabelKanriCode,
            this.toolStripStatusLabel2,
            this.toolSSLabelSeries});
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(553, 22);
            this.statusStrip1.TabIndex = 98;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolSSLabelKanriCode
            // 
            this.toolSSLabelKanriCode.AutoSize = false;
            this.toolSSLabelKanriCode.Name = "toolSSLabelKanriCode";
            this.toolSSLabelKanriCode.Size = new System.Drawing.Size(80, 17);
            this.toolSSLabelKanriCode.Text = "管理コード";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(54, 17);
            this.toolStripStatusLabel2.Text = " : シリーズ ";
            // 
            // toolSSLabelSeries
            // 
            this.toolSSLabelSeries.Name = "toolSSLabelSeries";
            this.toolSSLabelSeries.Size = new System.Drawing.Size(37, 17);
            this.toolSSLabelSeries.Text = "Series";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(181, 82);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(87, 21);
            this.button.TabIndex = 99;
            this.button.Text = "コードを発行";
            this.button.UseVisualStyleBackColor = true;
            // 
            // FormBuhinMst2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 451);
            this.Controls.Add(this.button);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelNo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labelSeihinMei);
            this.Controls.Add(this.labelSeihinCode);
            this.Controls.Add(this.labelTokuisakiCode);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxTekiyo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxSuryo);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxThickness);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.comboBoxZaisyu);
            this.Controls.Add(this.textBoxSiyoTaisyo);
            this.Controls.Add(this.checkBoxNC);
            this.Controls.Add(this.checkBoxOoino);
            this.Controls.Add(this.checkBoxBetuno);
            this.Controls.Add(this.checkBoxZaiko);
            this.Controls.Add(this.checkBoxKyotu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBuhinCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "FormBuhinMst2";
            this.Text = "部品マスタ　-　入力";
            this.Load += new System.EventHandler(this.FormBuhinMst2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.材種BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZaisyu)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label labelTokuisakiCode;
        public System.Windows.Forms.Label labelSeihinCode;
        public System.Windows.Forms.Label labelSeihinMei;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label labelNo;
        public System.Windows.Forms.TextBox textBoxBuhinCode;
        public System.Windows.Forms.CheckBox checkBoxKyotu;
        public System.Windows.Forms.CheckBox checkBoxZaiko;
        public System.Windows.Forms.CheckBox checkBoxBetuno;
        public System.Windows.Forms.CheckBox checkBoxOoino;
        public System.Windows.Forms.CheckBox checkBoxNC;
        public System.Windows.Forms.TextBox textBoxSiyoTaisyo;
        public System.Windows.Forms.ComboBox comboBoxZaisyu;
        public System.Windows.Forms.TextBox textBoxThickness;
        public System.Windows.Forms.TextBox textBoxWidth;
        public System.Windows.Forms.TextBox textBoxLength;
        public System.Windows.Forms.TextBox textBoxSuryo;
        public System.Windows.Forms.TextBox textBoxTekiyo;
        public DataSetZaisyu dataSetZaisyu;
        public System.Windows.Forms.BindingSource 材種BindingSource;
        public DataSetZaisyuTableAdapters.材種TableAdapter 材種TableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel toolSSLabelKanriCode;
        public System.Windows.Forms.ToolStripStatusLabel toolSSLabelSeries;
        private System.Windows.Forms.Button button;
    }
}