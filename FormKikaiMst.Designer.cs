namespace SeisanKanri
{
    partial class FormKikaiMst
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.listBoxSeihin = new System.Windows.Forms.ListBox();
            this.labelDayTime = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxSeihinMei = new System.Windows.Forms.TextBox();
            this.textBoxSeihinCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDisp = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(176, 328);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(59, 31);
            this.buttonEdit.TabIndex = 75;
            this.buttonEdit.Text = "編集";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(108, 328);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(59, 31);
            this.buttonDelete.TabIndex = 74;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(42, 328);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(59, 31);
            this.buttonNew.TabIndex = 73;
            this.buttonNew.Text = "追加";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // listBoxSeihin
            // 
            this.listBoxSeihin.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBoxSeihin.FormattingEnabled = true;
            this.listBoxSeihin.ItemHeight = 12;
            this.listBoxSeihin.Location = new System.Drawing.Point(10, 11);
            this.listBoxSeihin.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.listBoxSeihin.Name = "listBoxSeihin";
            this.listBoxSeihin.Size = new System.Drawing.Size(256, 304);
            this.listBoxSeihin.TabIndex = 72;
            this.listBoxSeihin.SelectedIndexChanged += new System.EventHandler(this.ListBoxSeihin_SelectedIndexChanged);
            // 
            // labelDayTime
            // 
            this.labelDayTime.AutoSize = true;
            this.labelDayTime.Location = new System.Drawing.Point(418, 193);
            this.labelDayTime.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelDayTime.Name = "labelDayTime";
            this.labelDayTime.Size = new System.Drawing.Size(0, 12);
            this.labelDayTime.TabIndex = 70;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(571, 12);
            this.labelID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 12);
            this.labelID.TabIndex = 68;
            // 
            // textBoxSeihinMei
            // 
            this.textBoxSeihinMei.Location = new System.Drawing.Point(356, 42);
            this.textBoxSeihinMei.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxSeihinMei.Name = "textBoxSeihinMei";
            this.textBoxSeihinMei.Size = new System.Drawing.Size(276, 19);
            this.textBoxSeihinMei.TabIndex = 65;
            // 
            // textBoxSeihinCode
            // 
            this.textBoxSeihinCode.Location = new System.Drawing.Point(356, 13);
            this.textBoxSeihinCode.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxSeihinCode.Name = "textBoxSeihinCode";
            this.textBoxSeihinCode.Size = new System.Drawing.Size(94, 19);
            this.textBoxSeihinCode.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 62;
            this.label2.Text = "名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 61;
            this.label1.Text = "コード";
            // 
            // buttonDisp
            // 
            this.buttonDisp.Location = new System.Drawing.Point(458, 11);
            this.buttonDisp.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonDisp.Name = "buttonDisp";
            this.buttonDisp.Size = new System.Drawing.Size(94, 20);
            this.buttonDisp.TabIndex = 60;
            this.buttonDisp.Text = "コードで検索";
            this.buttonDisp.UseVisualStyleBackColor = true;
            this.buttonDisp.Click += new System.EventHandler(this.ButtonDisp_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(553, 258);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(59, 31);
            this.buttonClose.TabIndex = 59;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(338, 242);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(185, 28);
            this.buttonSave.TabIndex = 58;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // FormKikaiMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.listBoxSeihin);
            this.Controls.Add(this.labelDayTime);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxSeihinMei);
            this.Controls.Add(this.textBoxSeihinCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDisp);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormKikaiMst";
            this.Text = "機械マスタ";
            this.Load += new System.EventHandler(this.FormKikaiMst_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.ListBox listBoxSeihin;
        private System.Windows.Forms.Label labelDayTime;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxSeihinMei;
        private System.Windows.Forms.TextBox textBoxSeihinCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDisp;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
    }
}