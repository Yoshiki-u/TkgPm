namespace SeisanKanri
{
    partial class FormBuhinItiran
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewBuhin = new System.Windows.Forms.DataGridView();
            this.部品コード = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.使用対象 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.材種名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厚さ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.巾 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.長さ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.摘要 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.大井野FL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NCFL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.共通FL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.在庫FL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.別納FL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comboBoxSeihin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTokuisaki = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSetMst1 = new SeisanKanri.DataSetMst();
            this.buttonMachining = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolSSLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSSLabelSeries = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuhin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMst1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClose.Location = new System.Drawing.Point(962, 486);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(111, 32);
            this.buttonClose.TabIndex = 63;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(470, 487);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(111, 32);
            this.buttonSave.TabIndex = 62;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(144, 487);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(101, 31);
            this.buttonDelete.TabIndex = 61;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(41, 487);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(101, 31);
            this.buttonAdd.TabIndex = 60;
            this.buttonAdd.Text = "追加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 59;
            this.label2.Text = "部品";
            // 
            // dataGridViewBuhin
            // 
            this.dataGridViewBuhin.AllowUserToAddRows = false;
            this.dataGridViewBuhin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBuhin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewBuhin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuhin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.部品コード,
            this.使用対象,
            this.材種名,
            this.厚さ,
            this.巾,
            this.長さ,
            this.数量,
            this.摘要,
            this.大井野FL,
            this.NCFL,
            this.共通FL,
            this.在庫FL,
            this.別納FL});
            this.dataGridViewBuhin.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewBuhin.Location = new System.Drawing.Point(37, 107);
            this.dataGridViewBuhin.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dataGridViewBuhin.Name = "dataGridViewBuhin";
            this.dataGridViewBuhin.ReadOnly = true;
            this.dataGridViewBuhin.RowTemplate.Height = 33;
            this.dataGridViewBuhin.Size = new System.Drawing.Size(1050, 375);
            this.dataGridViewBuhin.TabIndex = 58;
            this.dataGridViewBuhin.DoubleClick += new System.EventHandler(this.buttonEdit_Click);
            // 
            // 部品コード
            // 
            this.部品コード.DataPropertyName = "部品コード";
            this.部品コード.HeaderText = "CD";
            this.部品コード.Name = "部品コード";
            this.部品コード.ReadOnly = true;
            this.部品コード.Width = 46;
            // 
            // 使用対象
            // 
            this.使用対象.DataPropertyName = "使用対象";
            this.使用対象.HeaderText = "使用対象";
            this.使用対象.Name = "使用対象";
            this.使用対象.ReadOnly = true;
            this.使用対象.Width = 78;
            // 
            // 材種名
            // 
            this.材種名.DataPropertyName = "材種名";
            this.材種名.HeaderText = "材種";
            this.材種名.Name = "材種名";
            this.材種名.ReadOnly = true;
            this.材種名.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.材種名.Width = 54;
            // 
            // 厚さ
            // 
            this.厚さ.DataPropertyName = "厚さ";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#,#0.#";
            dataGridViewCellStyle6.NullValue = null;
            this.厚さ.DefaultCellStyle = dataGridViewCellStyle6;
            this.厚さ.HeaderText = "厚さ";
            this.厚さ.Name = "厚さ";
            this.厚さ.ReadOnly = true;
            this.厚さ.Width = 50;
            // 
            // 巾
            // 
            this.巾.DataPropertyName = "巾";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "#,#0.#";
            dataGridViewCellStyle7.NullValue = null;
            this.巾.DefaultCellStyle = dataGridViewCellStyle7;
            this.巾.HeaderText = "巾";
            this.巾.Name = "巾";
            this.巾.ReadOnly = true;
            this.巾.Width = 42;
            // 
            // 長さ
            // 
            this.長さ.DataPropertyName = "長さ";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "#,#0.#";
            dataGridViewCellStyle8.NullValue = null;
            this.長さ.DefaultCellStyle = dataGridViewCellStyle8;
            this.長さ.HeaderText = "長さ";
            this.長さ.Name = "長さ";
            this.長さ.ReadOnly = true;
            this.長さ.Width = 50;
            // 
            // 数量
            // 
            this.数量.DataPropertyName = "数量";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "#,#0.#";
            dataGridViewCellStyle9.NullValue = null;
            this.数量.DefaultCellStyle = dataGridViewCellStyle9;
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            this.数量.ReadOnly = true;
            this.数量.Width = 54;
            // 
            // 摘要
            // 
            this.摘要.DataPropertyName = "摘要";
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.摘要.DefaultCellStyle = dataGridViewCellStyle10;
            this.摘要.HeaderText = "摘要";
            this.摘要.Name = "摘要";
            this.摘要.ReadOnly = true;
            this.摘要.Width = 54;
            // 
            // 大井野FL
            // 
            this.大井野FL.DataPropertyName = "大井野FL";
            this.大井野FL.HeaderText = "大井野";
            this.大井野FL.Name = "大井野FL";
            this.大井野FL.ReadOnly = true;
            this.大井野FL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.大井野FL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.大井野FL.Width = 66;
            // 
            // NCFL
            // 
            this.NCFL.DataPropertyName = "NCFL";
            this.NCFL.HeaderText = "NC";
            this.NCFL.Name = "NCFL";
            this.NCFL.ReadOnly = true;
            this.NCFL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NCFL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NCFL.Width = 46;
            // 
            // 共通FL
            // 
            this.共通FL.DataPropertyName = "共通FL";
            this.共通FL.HeaderText = "共通";
            this.共通FL.Name = "共通FL";
            this.共通FL.ReadOnly = true;
            this.共通FL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.共通FL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.共通FL.Width = 54;
            // 
            // 在庫FL
            // 
            this.在庫FL.DataPropertyName = "在庫FL";
            this.在庫FL.HeaderText = "在庫";
            this.在庫FL.Name = "在庫FL";
            this.在庫FL.ReadOnly = true;
            this.在庫FL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.在庫FL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.在庫FL.Width = 54;
            // 
            // 別納FL
            // 
            this.別納FL.DataPropertyName = "別納FL";
            this.別納FL.HeaderText = "別納";
            this.別納FL.Name = "別納FL";
            this.別納FL.ReadOnly = true;
            this.別納FL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.別納FL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.別納FL.Width = 54;
            // 
            // comboBoxSeihin
            // 
            this.comboBoxSeihin.Font = new System.Drawing.Font("MS UI Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxSeihin.FormattingEnabled = true;
            this.comboBoxSeihin.Location = new System.Drawing.Point(285, 54);
            this.comboBoxSeihin.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.comboBoxSeihin.Name = "comboBoxSeihin";
            this.comboBoxSeihin.Size = new System.Drawing.Size(573, 29);
            this.comboBoxSeihin.TabIndex = 57;
            this.comboBoxSeihin.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeihin_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(286, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 56;
            this.label1.Text = "製品";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 55;
            this.label5.Text = "得意先";
            // 
            // comboBoxTokuisaki
            // 
            this.comboBoxTokuisaki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTokuisaki.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxTokuisaki.FormattingEnabled = true;
            this.comboBoxTokuisaki.Location = new System.Drawing.Point(10, 54);
            this.comboBoxTokuisaki.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.comboBoxTokuisaki.Name = "comboBoxTokuisaki";
            this.comboBoxTokuisaki.Size = new System.Drawing.Size(261, 20);
            this.comboBoxTokuisaki.TabIndex = 54;
            this.comboBoxTokuisaki.SelectedIndexChanged += new System.EventHandler(this.comboBoxTokuisaki_SelectedIndexChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEdit.Location = new System.Drawing.Point(249, 487);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(101, 31);
            this.buttonEdit.TabIndex = 64;
            this.buttonEdit.Text = "編集";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(12, 196);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(22, 99);
            this.buttonUp.TabIndex = 65;
            this.buttonUp.Text = "↑";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(12, 301);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(22, 99);
            this.buttonDown.TabIndex = 66;
            this.buttonDown.Text = "↓";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(354, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 67;
            this.button1.Text = "部品一覧　印刷";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSetMst1
            // 
            this.dataSetMst1.DataSetName = "DataSetMst";
            this.dataSetMst1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonMachining
            // 
            this.buttonMachining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMachining.Location = new System.Drawing.Point(699, 487);
            this.buttonMachining.Name = "buttonMachining";
            this.buttonMachining.Size = new System.Drawing.Size(148, 32);
            this.buttonMachining.TabIndex = 68;
            this.buttonMachining.Text = "加工作業　行程入力";
            this.buttonMachining.UseVisualStyleBackColor = true;
            this.buttonMachining.Click += new System.EventHandler(this.ButtonMachining_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSSLabel1,
            this.toolSSLabelSeries});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1098, 22);
            this.statusStrip1.TabIndex = 70;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolSSLabel1
            // 
            this.toolSSLabel1.Name = "toolSSLabel1";
            this.toolSSLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolSSLabel1.Text = " シリーズ";
            // 
            // toolSSLabelSeries
            // 
            this.toolSSLabelSeries.Name = "toolSSLabelSeries";
            this.toolSSLabelSeries.Size = new System.Drawing.Size(37, 17);
            this.toolSSLabelSeries.Text = "Series";
            // 
            // FormBuhinItiran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 551);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonMachining);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewBuhin);
            this.Controls.Add(this.comboBoxSeihin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTokuisaki);
            this.Name = "FormBuhinItiran";
            this.Text = "部品　詳細入力";
            this.Load += new System.EventHandler(this.FormBuhinMst2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuhin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMst1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewBuhin;
        private System.Windows.Forms.ComboBox comboBoxSeihin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTokuisaki;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button button1;
        private DataSetMst dataSetMst1;
        private System.Windows.Forms.Button buttonMachining;
        private System.Windows.Forms.DataGridViewTextBoxColumn 部品コード;
        private System.Windows.Forms.DataGridViewTextBoxColumn 使用対象;
        private System.Windows.Forms.DataGridViewTextBoxColumn 材種名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厚さ;
        private System.Windows.Forms.DataGridViewTextBoxColumn 巾;
        private System.Windows.Forms.DataGridViewTextBoxColumn 長さ;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 摘要;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 大井野FL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NCFL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 共通FL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 在庫FL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 別納FL;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolSSLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolSSLabelSeries;
    }
}