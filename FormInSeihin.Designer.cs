﻿namespace SeisanKanri
{
    partial class FormInSeihin
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
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxSeihin = new System.Windows.Forms.ListBox();
            this.comboBoxTokuisaki = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "得意先";
            // 
            // listBoxSeihin
            // 
            this.listBoxSeihin.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBoxSeihin.FormattingEnabled = true;
            this.listBoxSeihin.ItemHeight = 16;
            this.listBoxSeihin.Location = new System.Drawing.Point(6, 66);
            this.listBoxSeihin.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.listBoxSeihin.Name = "listBoxSeihin";
            this.listBoxSeihin.Size = new System.Drawing.Size(340, 292);
            this.listBoxSeihin.TabIndex = 2;
            this.listBoxSeihin.DoubleClick += new System.EventHandler(this.listBoxSeihin_DoubleClick);
            // 
            // comboBoxTokuisaki
            // 
            this.comboBoxTokuisaki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTokuisaki.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxTokuisaki.FormattingEnabled = true;
            this.comboBoxTokuisaki.Location = new System.Drawing.Point(6, 17);
            this.comboBoxTokuisaki.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.comboBoxTokuisaki.Name = "comboBoxTokuisaki";
            this.comboBoxTokuisaki.Size = new System.Drawing.Size(261, 20);
            this.comboBoxTokuisaki.TabIndex = 6;
            this.comboBoxTokuisaki.SelectedIndexChanged += new System.EventHandler(this.comboBoxTokuisaki_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "製品";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(6, 374);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(337, 37);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "決　定";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(6, 419);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(337, 37);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FormInSeihin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 467);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxSeihin);
            this.Controls.Add(this.comboBoxTokuisaki);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "FormInSeihin";
            this.Text = "FormInSeihin";
            this.Load += new System.EventHandler(this.FormInSeihin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormInSeihin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTokuisaki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.ListBox listBoxSeihin;
    }
}