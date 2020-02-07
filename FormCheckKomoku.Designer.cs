namespace SeisanKanri
{
    partial class FormCheckKomoku
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
            this.dataGridViewCheck = new System.Windows.Forms.DataGridView();
            this.labelSeihinCode = new System.Windows.Forms.Label();
            this.labelSeihinMei = new System.Windows.Forms.Label();
            this.グループ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.項目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMeisaiSounyu = new System.Windows.Forms.Button();
            this.buttonDeleteMeisai = new System.Windows.Forms.Button();
            this.buttonAddMeisai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCheck
            // 
            this.dataGridViewCheck.AllowUserToAddRows = false;
            this.dataGridViewCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.グループ,
            this.項目});
            this.dataGridViewCheck.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewCheck.Location = new System.Drawing.Point(12, 61);
            this.dataGridViewCheck.Name = "dataGridViewCheck";
            this.dataGridViewCheck.RowTemplate.Height = 21;
            this.dataGridViewCheck.Size = new System.Drawing.Size(535, 234);
            this.dataGridViewCheck.TabIndex = 0;
            // 
            // labelSeihinCode
            // 
            this.labelSeihinCode.AutoSize = true;
            this.labelSeihinCode.Location = new System.Drawing.Point(19, 15);
            this.labelSeihinCode.Name = "labelSeihinCode";
            this.labelSeihinCode.Size = new System.Drawing.Size(35, 12);
            this.labelSeihinCode.TabIndex = 1;
            this.labelSeihinCode.Text = "label1";
            // 
            // labelSeihinMei
            // 
            this.labelSeihinMei.AutoSize = true;
            this.labelSeihinMei.Location = new System.Drawing.Point(19, 36);
            this.labelSeihinMei.Name = "labelSeihinMei";
            this.labelSeihinMei.Size = new System.Drawing.Size(35, 12);
            this.labelSeihinMei.TabIndex = 2;
            this.labelSeihinMei.Text = "label2";
            // 
            // グループ
            // 
            this.グループ.DataPropertyName = "グループ";
            this.グループ.HeaderText = "パーツ";
            this.グループ.Name = "グループ";
            // 
            // 項目
            // 
            this.項目.DataPropertyName = "項目";
            this.項目.HeaderText = "項目";
            this.項目.Name = "項目";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMeisaiSounyu
            // 
            this.buttonMeisaiSounyu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMeisaiSounyu.Location = new System.Drawing.Point(192, 300);
            this.buttonMeisaiSounyu.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonMeisaiSounyu.Name = "buttonMeisaiSounyu";
            this.buttonMeisaiSounyu.Size = new System.Drawing.Size(80, 33);
            this.buttonMeisaiSounyu.TabIndex = 30;
            this.buttonMeisaiSounyu.Text = "行挿入";
            this.buttonMeisaiSounyu.UseVisualStyleBackColor = true;
            this.buttonMeisaiSounyu.Click += new System.EventHandler(this.buttonMeisaiSounyu_Click);
            // 
            // buttonDeleteMeisai
            // 
            this.buttonDeleteMeisai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteMeisai.Location = new System.Drawing.Point(101, 300);
            this.buttonDeleteMeisai.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonDeleteMeisai.Name = "buttonDeleteMeisai";
            this.buttonDeleteMeisai.Size = new System.Drawing.Size(80, 33);
            this.buttonDeleteMeisai.TabIndex = 29;
            this.buttonDeleteMeisai.Text = "行削除";
            this.buttonDeleteMeisai.UseVisualStyleBackColor = true;
            this.buttonDeleteMeisai.Click += new System.EventHandler(this.buttonDeleteMeisai_Click);
            // 
            // buttonAddMeisai
            // 
            this.buttonAddMeisai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddMeisai.Location = new System.Drawing.Point(11, 300);
            this.buttonAddMeisai.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonAddMeisai.Name = "buttonAddMeisai";
            this.buttonAddMeisai.Size = new System.Drawing.Size(80, 33);
            this.buttonAddMeisai.TabIndex = 28;
            this.buttonAddMeisai.Text = "行追加";
            this.buttonAddMeisai.UseVisualStyleBackColor = true;
            this.buttonAddMeisai.Click += new System.EventHandler(this.buttonAddMeisai_Click);
            // 
            // FormCheckKomoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 369);
            this.Controls.Add(this.buttonMeisaiSounyu);
            this.Controls.Add(this.buttonDeleteMeisai);
            this.Controls.Add(this.buttonAddMeisai);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSeihinMei);
            this.Controls.Add(this.labelSeihinCode);
            this.Controls.Add(this.dataGridViewCheck);
            this.Name = "FormCheckKomoku";
            this.Text = "製品　出荷前チェック項目";
            this.Load += new System.EventHandler(this.FormCheckKomoku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCheck;
        public System.Windows.Forms.Label labelSeihinCode;
        public System.Windows.Forms.Label labelSeihinMei;
        private System.Windows.Forms.DataGridViewTextBoxColumn グループ;
        private System.Windows.Forms.DataGridViewTextBoxColumn 項目;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMeisaiSounyu;
        private System.Windows.Forms.Button buttonDeleteMeisai;
        private System.Windows.Forms.Button buttonAddMeisai;
    }
}