namespace SeisanKanri
{
    partial class FormSeihinMast
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
            this.comboBoxTokuisaki = new System.Windows.Forms.ComboBox();
            this.listBoxSeihin = new System.Windows.Forms.ListBox();
            this.buttonDisp = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.textBoxTekiyo = new System.Windows.Forms.TextBox();
            this.textBoxSeihinMei = new System.Windows.Forms.TextBox();
            this.textBoxSeihinCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxKyotu = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDayTime = new System.Windows.Forms.Label();
            this.textBoxTanka = new System.Windows.Forms.TextBox();
            this.textBoxSeries = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTokuisaki
            // 
            this.comboBoxTokuisaki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTokuisaki.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxTokuisaki.FormattingEnabled = true;
            this.comboBoxTokuisaki.Location = new System.Drawing.Point(14, 22);
            this.comboBoxTokuisaki.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.comboBoxTokuisaki.Name = "comboBoxTokuisaki";
            this.comboBoxTokuisaki.Size = new System.Drawing.Size(261, 20);
            this.comboBoxTokuisaki.TabIndex = 0;
            this.comboBoxTokuisaki.SelectedIndexChanged += new System.EventHandler(this.comboBoxTokuisaki_SelectedIndexChanged);
            // 
            // listBoxSeihin
            // 
            this.listBoxSeihin.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBoxSeihin.FormattingEnabled = true;
            this.listBoxSeihin.ItemHeight = 12;
            this.listBoxSeihin.Location = new System.Drawing.Point(14, 70);
            this.listBoxSeihin.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.listBoxSeihin.Name = "listBoxSeihin";
            this.listBoxSeihin.Size = new System.Drawing.Size(256, 304);
            this.listBoxSeihin.TabIndex = 1;
            this.listBoxSeihin.SelectedIndexChanged += new System.EventHandler(this.listBoxSeihin_SelectedIndexChanged);
            // 
            // buttonDisp
            // 
            this.buttonDisp.Location = new System.Drawing.Point(459, 60);
            this.buttonDisp.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonDisp.Name = "buttonDisp";
            this.buttonDisp.Size = new System.Drawing.Size(94, 20);
            this.buttonDisp.TabIndex = 23;
            this.buttonDisp.Text = "コードで検索";
            this.buttonDisp.UseVisualStyleBackColor = true;
            this.buttonDisp.Click += new System.EventHandler(this.buttonDisp_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(572, 384);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(59, 31);
            this.buttonClose.TabIndex = 22;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(357, 384);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(185, 28);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(173, 384);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(59, 31);
            this.buttonEdit.TabIndex = 20;
            this.buttonEdit.Text = "編集";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.listBoxSeihin_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(105, 384);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(59, 31);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(39, 384);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(59, 31);
            this.buttonNew.TabIndex = 18;
            this.buttonNew.Text = "追加";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // textBoxTekiyo
            // 
            this.textBoxTekiyo.Location = new System.Drawing.Point(357, 185);
            this.textBoxTekiyo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxTekiyo.Multiline = true;
            this.textBoxTekiyo.Name = "textBoxTekiyo";
            this.textBoxTekiyo.Size = new System.Drawing.Size(276, 132);
            this.textBoxTekiyo.TabIndex = 30;
            // 
            // textBoxSeihinMei
            // 
            this.textBoxSeihinMei.Location = new System.Drawing.Point(357, 91);
            this.textBoxSeihinMei.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxSeihinMei.Name = "textBoxSeihinMei";
            this.textBoxSeihinMei.Size = new System.Drawing.Size(276, 19);
            this.textBoxSeihinMei.TabIndex = 29;
            // 
            // textBoxSeihinCode
            // 
            this.textBoxSeihinCode.Location = new System.Drawing.Point(357, 62);
            this.textBoxSeihinCode.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxSeihinCode.Name = "textBoxSeihinCode";
            this.textBoxSeihinCode.Size = new System.Drawing.Size(94, 19);
            this.textBoxSeihinCode.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "摘　要";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "商品名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "商品コード";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "単　価";
            // 
            // checkBoxKyotu
            // 
            this.checkBoxKyotu.AutoSize = true;
            this.checkBoxKyotu.Location = new System.Drawing.Point(359, 334);
            this.checkBoxKyotu.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.checkBoxKyotu.Name = "checkBoxKyotu";
            this.checkBoxKyotu.Size = new System.Drawing.Size(72, 16);
            this.checkBoxKyotu.TabIndex = 33;
            this.checkBoxKyotu.Text = "共通部品";
            this.checkBoxKyotu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxKyotu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 34;
            this.label5.Text = "得意先";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(572, 61);
            this.labelID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 12);
            this.labelID.TabIndex = 35;
            this.labelID.TextChanged += new System.EventHandler(this.labelID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 362);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 36;
            this.label6.Text = "最終更新日";
            // 
            // labelDayTime
            // 
            this.labelDayTime.AutoSize = true;
            this.labelDayTime.Location = new System.Drawing.Point(437, 349);
            this.labelDayTime.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelDayTime.Name = "labelDayTime";
            this.labelDayTime.Size = new System.Drawing.Size(0, 12);
            this.labelDayTime.TabIndex = 37;
            // 
            // textBoxTanka
            // 
            this.textBoxTanka.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxTanka.Location = new System.Drawing.Point(357, 118);
            this.textBoxTanka.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxTanka.Name = "textBoxTanka";
            this.textBoxTanka.Size = new System.Drawing.Size(106, 19);
            this.textBoxTanka.TabIndex = 38;
            this.textBoxTanka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSeries
            // 
            this.textBoxSeries.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxSeries.Location = new System.Drawing.Point(357, 145);
            this.textBoxSeries.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxSeries.Name = "textBoxSeries";
            this.textBoxSeries.Size = new System.Drawing.Size(106, 19);
            this.textBoxSeries.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 12);
            this.label7.TabIndex = 39;
            this.label7.Text = "シリーズ";
            // 
            // FormSeihinMast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 427);
            this.Controls.Add(this.textBoxSeries);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTanka);
            this.Controls.Add(this.labelDayTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxKyotu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTekiyo);
            this.Controls.Add(this.textBoxSeihinMei);
            this.Controls.Add(this.textBoxSeihinCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDisp);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.listBoxSeihin);
            this.Controls.Add(this.comboBoxTokuisaki);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "FormSeihinMast";
            this.Text = "製品マスタ";
            this.Load += new System.EventHandler(this.FormSeihinMast_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTokuisaki;
        private System.Windows.Forms.ListBox listBoxSeihin;
        private System.Windows.Forms.Button buttonDisp;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TextBox textBoxTekiyo;
        private System.Windows.Forms.TextBox textBoxSeihinMei;
        private System.Windows.Forms.TextBox textBoxSeihinCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxKyotu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDayTime;
        private System.Windows.Forms.TextBox textBoxTanka;
        private System.Windows.Forms.TextBox textBoxSeries;
        private System.Windows.Forms.Label label7;
    }
}