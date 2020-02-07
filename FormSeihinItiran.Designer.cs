namespace SeisanKanri
{
    partial class FormSeihinItiran
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
            this.dataGridViewSeihin = new System.Windows.Forms.DataGridView();
            this.製品コード = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.製品名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.摘要 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.共通FL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTokuisaki = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeihin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSeihin
            // 
            this.dataGridViewSeihin.AllowUserToAddRows = false;
            this.dataGridViewSeihin.AllowUserToDeleteRows = false;
            this.dataGridViewSeihin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeihin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.製品コード,
            this.製品名,
            this.摘要,
            this.共通FL});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSeihin.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSeihin.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewSeihin.Name = "dataGridViewSeihin";
            this.dataGridViewSeihin.ReadOnly = true;
            this.dataGridViewSeihin.RowTemplate.Height = 21;
            this.dataGridViewSeihin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSeihin.Size = new System.Drawing.Size(692, 343);
            this.dataGridViewSeihin.TabIndex = 0;
            // 
            // 製品コード
            // 
            this.製品コード.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.製品コード.DataPropertyName = "製品コード";
            this.製品コード.HeaderText = "製品コード";
            this.製品コード.Name = "製品コード";
            this.製品コード.ReadOnly = true;
            this.製品コード.Width = 81;
            // 
            // 製品名
            // 
            this.製品名.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.製品名.DataPropertyName = "製品名";
            this.製品名.HeaderText = "製品名";
            this.製品名.Name = "製品名";
            this.製品名.ReadOnly = true;
            this.製品名.Width = 66;
            // 
            // 摘要
            // 
            this.摘要.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.摘要.DataPropertyName = "摘要";
            this.摘要.HeaderText = "摘要";
            this.摘要.Name = "摘要";
            this.摘要.ReadOnly = true;
            this.摘要.Width = 54;
            // 
            // 共通FL
            // 
            this.共通FL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.共通FL.DataPropertyName = "共通FL";
            this.共通FL.HeaderText = "共通";
            this.共通FL.Name = "共通FL";
            this.共通FL.ReadOnly = true;
            this.共通FL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.共通FL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.共通FL.Width = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "得意先";
            // 
            // comboBoxTokuisaki
            // 
            this.comboBoxTokuisaki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTokuisaki.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxTokuisaki.FormattingEnabled = true;
            this.comboBoxTokuisaki.Location = new System.Drawing.Point(12, 21);
            this.comboBoxTokuisaki.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.comboBoxTokuisaki.Name = "comboBoxTokuisaki";
            this.comboBoxTokuisaki.Size = new System.Drawing.Size(370, 23);
            this.comboBoxTokuisaki.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "得意先で絞り込み表示";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 26);
            this.button2.TabIndex = 10;
            this.button2.Text = "全て表示";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(447, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 33);
            this.button3.TabIndex = 11;
            this.button3.Text = "出荷前チェック項目";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(311, 418);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 33);
            this.button4.TabIndex = 12;
            this.button4.Text = "部品一覧入力";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(185, 418);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 33);
            this.button5.TabIndex = 13;
            this.button5.Text = "部品詳細入力";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormSeihinItiran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 486);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTokuisaki);
            this.Controls.Add(this.dataGridViewSeihin);
            this.Name = "FormSeihinItiran";
            this.Text = "製品一覧";
            this.Load += new System.EventHandler(this.FormSeihinItiran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeihin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSeihin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTokuisaki;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 製品コード;
        private System.Windows.Forms.DataGridViewTextBoxColumn 製品名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 摘要;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 共通FL;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}