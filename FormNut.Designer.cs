namespace SeisanKanri
{
    partial class FormNut
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
            this.textBoxNut = new System.Windows.Forms.TextBox();
            this.textBoxNutCode = new System.Windows.Forms.TextBox();
            this.labelKakouKanriCode = new System.Windows.Forms.Label();
            this.labelKanriCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelSuryo = new System.Windows.Forms.Label();
            this.labelBuhin = new System.Windows.Forms.Label();
            this.labelSeihinMei = new System.Windows.Forms.Label();
            this.labelBuhinCode = new System.Windows.Forms.Label();
            this.labelSeihinCode = new System.Windows.Forms.Label();
            this.labelTokuisaki = new System.Windows.Forms.Label();
            this.textBoxSuryo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRefNut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNut
            // 
            this.textBoxNut.Location = new System.Drawing.Point(116, 125);
            this.textBoxNut.Name = "textBoxNut";
            this.textBoxNut.Size = new System.Drawing.Size(164, 19);
            this.textBoxNut.TabIndex = 2;
            this.textBoxNut.Enter += new System.EventHandler(this.TextBoxNut_Enter);
            // 
            // textBoxNutCode
            // 
            this.textBoxNutCode.Location = new System.Drawing.Point(83, 125);
            this.textBoxNutCode.Name = "textBoxNutCode";
            this.textBoxNutCode.Size = new System.Drawing.Size(27, 19);
            this.textBoxNutCode.TabIndex = 1;
            this.textBoxNutCode.Enter += new System.EventHandler(this.TextBoxNutCode_Enter);
            this.textBoxNutCode.Leave += new System.EventHandler(this.TextBoxNutCode_Leave);
            // 
            // labelKakouKanriCode
            // 
            this.labelKakouKanriCode.AutoSize = true;
            this.labelKakouKanriCode.Location = new System.Drawing.Point(322, 32);
            this.labelKakouKanriCode.Name = "labelKakouKanriCode";
            this.labelKakouKanriCode.Size = new System.Drawing.Size(35, 12);
            this.labelKakouKanriCode.TabIndex = 60;
            this.labelKakouKanriCode.Text = "label6";
            // 
            // labelKanriCode
            // 
            this.labelKanriCode.AutoSize = true;
            this.labelKanriCode.Location = new System.Drawing.Point(322, 12);
            this.labelKanriCode.Name = "labelKanriCode";
            this.labelKanriCode.Size = new System.Drawing.Size(35, 12);
            this.labelKanriCode.TabIndex = 59;
            this.labelKanriCode.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "使用金物";
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(21, 215);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(336, 28);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "キャンセル";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(21, 183);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(336, 28);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelSuryo
            // 
            this.labelSuryo.AutoSize = true;
            this.labelSuryo.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSuryo.Location = new System.Drawing.Point(71, 84);
            this.labelSuryo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSuryo.Name = "labelSuryo";
            this.labelSuryo.Size = new System.Drawing.Size(72, 15);
            this.labelSuryo.TabIndex = 42;
            this.labelSuryo.Text = "数量　　個";
            // 
            // labelBuhin
            // 
            this.labelBuhin.AutoSize = true;
            this.labelBuhin.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelBuhin.Location = new System.Drawing.Point(71, 57);
            this.labelBuhin.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelBuhin.Name = "labelBuhin";
            this.labelBuhin.Size = new System.Drawing.Size(238, 15);
            this.labelBuhin.TabIndex = 41;
            this.labelBuhin.Text = "使用箇所　材種　厚さ　ｘ　巾　ｘ　長さ";
            // 
            // labelSeihinMei
            // 
            this.labelSeihinMei.AutoSize = true;
            this.labelSeihinMei.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSeihinMei.Location = new System.Drawing.Point(71, 32);
            this.labelSeihinMei.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSeihinMei.Name = "labelSeihinMei";
            this.labelSeihinMei.Size = new System.Drawing.Size(52, 15);
            this.labelSeihinMei.TabIndex = 40;
            this.labelSeihinMei.Text = "製品名";
            // 
            // labelBuhinCode
            // 
            this.labelBuhinCode.AutoSize = true;
            this.labelBuhinCode.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelBuhinCode.Location = new System.Drawing.Point(11, 57);
            this.labelBuhinCode.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelBuhinCode.Name = "labelBuhinCode";
            this.labelBuhinCode.Size = new System.Drawing.Size(40, 15);
            this.labelBuhinCode.TabIndex = 39;
            this.labelBuhinCode.Text = "コード";
            // 
            // labelSeihinCode
            // 
            this.labelSeihinCode.AutoSize = true;
            this.labelSeihinCode.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSeihinCode.Location = new System.Drawing.Point(11, 32);
            this.labelSeihinCode.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSeihinCode.Name = "labelSeihinCode";
            this.labelSeihinCode.Size = new System.Drawing.Size(40, 15);
            this.labelSeihinCode.TabIndex = 38;
            this.labelSeihinCode.Text = "コード";
            // 
            // labelTokuisaki
            // 
            this.labelTokuisaki.AutoSize = true;
            this.labelTokuisaki.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTokuisaki.Location = new System.Drawing.Point(10, 9);
            this.labelTokuisaki.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelTokuisaki.Name = "labelTokuisaki";
            this.labelTokuisaki.Size = new System.Drawing.Size(40, 15);
            this.labelTokuisaki.TabIndex = 37;
            this.labelTokuisaki.Text = "コード";
            // 
            // textBoxSuryo
            // 
            this.textBoxSuryo.Location = new System.Drawing.Point(83, 149);
            this.textBoxSuryo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxSuryo.Name = "textBoxSuryo";
            this.textBoxSuryo.Size = new System.Drawing.Size(67, 19);
            this.textBoxSuryo.TabIndex = 5;
            this.textBoxSuryo.Enter += new System.EventHandler(this.TextBoxSuryo_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 152);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "数量";
            // 
            // buttonRefNut
            // 
            this.buttonRefNut.Location = new System.Drawing.Point(286, 125);
            this.buttonRefNut.Name = "buttonRefNut";
            this.buttonRefNut.Size = new System.Drawing.Size(40, 19);
            this.buttonRefNut.TabIndex = 3;
            this.buttonRefNut.Text = "参照";
            this.buttonRefNut.UseVisualStyleBackColor = true;
            this.buttonRefNut.Click += new System.EventHandler(this.ButtonRefNut_Click);
            // 
            // FormNut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 260);
            this.Controls.Add(this.buttonRefNut);
            this.Controls.Add(this.textBoxNut);
            this.Controls.Add(this.textBoxNutCode);
            this.Controls.Add(this.labelKakouKanriCode);
            this.Controls.Add(this.labelKanriCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSuryo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelSuryo);
            this.Controls.Add(this.labelBuhin);
            this.Controls.Add(this.labelSeihinMei);
            this.Controls.Add(this.labelBuhinCode);
            this.Controls.Add(this.labelSeihinCode);
            this.Controls.Add(this.labelTokuisaki);
            this.KeyPreview = true;
            this.Name = "FormNut";
            this.Text = "部品マスタ - 金物（ナット)";
            this.Load += new System.EventHandler(this.FormNut_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormNut_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxNut;
        public System.Windows.Forms.TextBox textBoxNutCode;
        public System.Windows.Forms.Label labelKakouKanriCode;
        public System.Windows.Forms.Label labelKanriCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.Label labelSuryo;
        public System.Windows.Forms.Label labelBuhin;
        public System.Windows.Forms.Label labelSeihinMei;
        public System.Windows.Forms.Label labelBuhinCode;
        public System.Windows.Forms.Label labelSeihinCode;
        public System.Windows.Forms.Label labelTokuisaki;
        public System.Windows.Forms.TextBox textBoxSuryo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonRefNut;
    }
}