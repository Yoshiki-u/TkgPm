namespace SeisanKanri
{
    partial class FormHattyusakiMstcs
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
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonDisp = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxFax = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxTokuisakiMei = new System.Windows.Forms.TextBox();
            this.textBoxTokuisakiCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.listBoxTokuisaki = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(379, 232);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(59, 31);
            this.buttonPrint.TabIndex = 35;
            this.buttonPrint.Text = "印刷";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Visible = false;
            // 
            // buttonDisp
            // 
            this.buttonDisp.Location = new System.Drawing.Point(419, 19);
            this.buttonDisp.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonDisp.Name = "buttonDisp";
            this.buttonDisp.Size = new System.Drawing.Size(94, 20);
            this.buttonDisp.TabIndex = 34;
            this.buttonDisp.Text = "コードで検索";
            this.buttonDisp.UseVisualStyleBackColor = true;
            this.buttonDisp.Click += new System.EventHandler(this.buttonDisp_Click);
            // 
            // labelID
            // 
            this.labelID.Location = new System.Drawing.Point(526, 21);
            this.labelID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(55, 12);
            this.labelID.TabIndex = 33;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(521, 232);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(59, 31);
            this.buttonClose.TabIndex = 32;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(310, 149);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(185, 28);
            this.buttonSave.TabIndex = 31;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxFax
            // 
            this.textBoxFax.Location = new System.Drawing.Point(310, 111);
            this.textBoxFax.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxFax.Name = "textBoxFax";
            this.textBoxFax.Size = new System.Drawing.Size(160, 19);
            this.textBoxFax.TabIndex = 30;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(310, 81);
            this.textBoxTel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(160, 19);
            this.textBoxTel.TabIndex = 29;
            // 
            // textBoxTokuisakiMei
            // 
            this.textBoxTokuisakiMei.Location = new System.Drawing.Point(310, 51);
            this.textBoxTokuisakiMei.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxTokuisakiMei.Name = "textBoxTokuisakiMei";
            this.textBoxTokuisakiMei.Size = new System.Drawing.Size(276, 19);
            this.textBoxTokuisakiMei.TabIndex = 28;
            // 
            // textBoxTokuisakiCode
            // 
            this.textBoxTokuisakiCode.Location = new System.Drawing.Point(310, 21);
            this.textBoxTokuisakiCode.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxTokuisakiCode.Name = "textBoxTokuisakiCode";
            this.textBoxTokuisakiCode.Size = new System.Drawing.Size(94, 19);
            this.textBoxTokuisakiCode.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "FAX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "TEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "発注先名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "発注先コード";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(153, 237);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(59, 31);
            this.buttonEdit.TabIndex = 22;
            this.buttonEdit.Text = "編集";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.listBoxTokuisaki_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(85, 237);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(59, 31);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(19, 237);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(59, 31);
            this.buttonNew.TabIndex = 20;
            this.buttonNew.Text = "追加";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // listBoxTokuisaki
            // 
            this.listBoxTokuisaki.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBoxTokuisaki.FormattingEnabled = true;
            this.listBoxTokuisaki.ItemHeight = 12;
            this.listBoxTokuisaki.Location = new System.Drawing.Point(10, 11);
            this.listBoxTokuisaki.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.listBoxTokuisaki.Name = "listBoxTokuisaki";
            this.listBoxTokuisaki.Size = new System.Drawing.Size(216, 220);
            this.listBoxTokuisaki.TabIndex = 19;
            // 
            // FormHattyusakiMstcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 293);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonDisp);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxFax);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxTokuisakiMei);
            this.Controls.Add(this.textBoxTokuisakiCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.listBoxTokuisaki);
            this.Name = "FormHattyusakiMstcs";
            this.Text = "発注先マスタ";
            this.Load += new System.EventHandler(this.FormHattyusakiMstcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonDisp;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxFax;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxTokuisakiMei;
        private System.Windows.Forms.TextBox textBoxTokuisakiCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.ListBox listBoxTokuisaki;
    }
}