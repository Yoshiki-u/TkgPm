namespace SeisanKanri
{
    partial class FormInNC
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxSeihin = new System.Windows.Forms.ListBox();
            this.comboBoxTokuisaki = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSeries = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(10, 432);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(337, 37);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(10, 387);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(337, 37);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "決　定";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "ＮＣ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "得意先";
            // 
            // listBoxSeihin
            // 
            this.listBoxSeihin.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBoxSeihin.FormattingEnabled = true;
            this.listBoxSeihin.ItemHeight = 16;
            this.listBoxSeihin.Location = new System.Drawing.Point(10, 79);
            this.listBoxSeihin.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.listBoxSeihin.Name = "listBoxSeihin";
            this.listBoxSeihin.Size = new System.Drawing.Size(340, 292);
            this.listBoxSeihin.TabIndex = 8;
            this.listBoxSeihin.DoubleClick += new System.EventHandler(this.ListBoxSeihin_DoubleClick);
            // 
            // comboBoxTokuisaki
            // 
            this.comboBoxTokuisaki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTokuisaki.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxTokuisaki.FormattingEnabled = true;
            this.comboBoxTokuisaki.Location = new System.Drawing.Point(66, 11);
            this.comboBoxTokuisaki.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.comboBoxTokuisaki.Name = "comboBoxTokuisaki";
            this.comboBoxTokuisaki.Size = new System.Drawing.Size(281, 20);
            this.comboBoxTokuisaki.TabIndex = 12;
            this.comboBoxTokuisaki.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTokuisaki_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "シリーズ";
            // 
            // textBoxSeries
            // 
            this.textBoxSeries.Location = new System.Drawing.Point(66, 37);
            this.textBoxSeries.Name = "textBoxSeries";
            this.textBoxSeries.Size = new System.Drawing.Size(130, 19);
            this.textBoxSeries.TabIndex = 14;
            this.textBoxSeries.TextChanged += new System.EventHandler(this.TextBoxSeries_TextChanged);
            // 
            // FormInNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 480);
            this.Controls.Add(this.textBoxSeries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxSeihin);
            this.Controls.Add(this.comboBoxTokuisaki);
            this.KeyPreview = true;
            this.Name = "FormInNC";
            this.Text = "参照　ＮＣプログラム";
            this.Load += new System.EventHandler(this.FormInNC_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormInNC_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox listBoxSeihin;
        private System.Windows.Forms.ComboBox comboBoxTokuisaki;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxSeries;
    }
}