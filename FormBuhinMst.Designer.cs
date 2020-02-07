namespace SeisanKanri
{
    partial class FormBuhinMst
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTokuisaki = new System.Windows.Forms.ComboBox();
            this.comboBoxSeihin = new System.Windows.Forms.ComboBox();
            this.dataGridViewBuhin = new System.Windows.Forms.DataGridView();
            this.部品コード = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.使用対象 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.材種 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataSetZaisyuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetZaisyu = new SeisanKanri.DataSetZaisyu();
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.材種TableAdapter = new SeisanKanri.DataSetZaisyuTableAdapters.材種TableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSSLabelSeries = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuhin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZaisyuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZaisyu)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(282, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 42;
            this.label1.Text = "製品";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 41;
            this.label5.Text = "得意先";
            // 
            // comboBoxTokuisaki
            // 
            this.comboBoxTokuisaki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTokuisaki.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxTokuisaki.FormattingEnabled = true;
            this.comboBoxTokuisaki.Location = new System.Drawing.Point(6, 21);
            this.comboBoxTokuisaki.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.comboBoxTokuisaki.Name = "comboBoxTokuisaki";
            this.comboBoxTokuisaki.Size = new System.Drawing.Size(261, 20);
            this.comboBoxTokuisaki.TabIndex = 39;
            this.comboBoxTokuisaki.SelectedIndexChanged += new System.EventHandler(this.comboBoxTokuisaki_SelectedIndexChanged);
            // 
            // comboBoxSeihin
            // 
            this.comboBoxSeihin.Font = new System.Drawing.Font("MS UI Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxSeihin.FormattingEnabled = true;
            this.comboBoxSeihin.Location = new System.Drawing.Point(281, 21);
            this.comboBoxSeihin.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.comboBoxSeihin.Name = "comboBoxSeihin";
            this.comboBoxSeihin.Size = new System.Drawing.Size(573, 29);
            this.comboBoxSeihin.TabIndex = 43;
            this.comboBoxSeihin.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSeihin_SelectedIndexChanged);
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
            this.材種,
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
            this.dataGridViewBuhin.Location = new System.Drawing.Point(6, 79);
            this.dataGridViewBuhin.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dataGridViewBuhin.Name = "dataGridViewBuhin";
            this.dataGridViewBuhin.RowTemplate.Height = 33;
            this.dataGridViewBuhin.Size = new System.Drawing.Size(873, 372);
            this.dataGridViewBuhin.TabIndex = 44;
            this.dataGridViewBuhin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBuhin_CellContentClick);
            this.dataGridViewBuhin.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewBuhin_CellLeave);
            this.dataGridViewBuhin.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBuhin_CellValidated);
            this.dataGridViewBuhin.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewBuhin_CellValidating);
            this.dataGridViewBuhin.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewBuhin_DataError);
            // 
            // 部品コード
            // 
            this.部品コード.DataPropertyName = "部品コード";
            this.部品コード.HeaderText = "CD";
            this.部品コード.Name = "部品コード";
            this.部品コード.Width = 46;
            // 
            // 使用対象
            // 
            this.使用対象.DataPropertyName = "使用対象";
            this.使用対象.HeaderText = "使用対象";
            this.使用対象.Name = "使用対象";
            this.使用対象.Width = 78;
            // 
            // 材種
            // 
            this.材種.DataPropertyName = "材種";
            this.材種.DataSource = this.dataSetZaisyuBindingSource;
            this.材種.DisplayMember = "名称";
            this.材種.HeaderText = "材種";
            this.材種.Name = "材種";
            this.材種.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.材種.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.材種.ValueMember = "Id";
            this.材種.Width = 54;
            // 
            // dataSetZaisyuBindingSource
            // 
            this.dataSetZaisyuBindingSource.DataMember = "材種";
            this.dataSetZaisyuBindingSource.DataSource = this.dataSetZaisyu;
            // 
            // dataSetZaisyu
            // 
            this.dataSetZaisyu.DataSetName = "DataSetZaisyu";
            this.dataSetZaisyu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 厚さ
            // 
            this.厚さ.DataPropertyName = "厚さ";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "#,#0.#";
            dataGridViewCellStyle1.NullValue = null;
            this.厚さ.DefaultCellStyle = dataGridViewCellStyle1;
            this.厚さ.HeaderText = "厚さ";
            this.厚さ.Name = "厚さ";
            this.厚さ.Width = 50;
            // 
            // 巾
            // 
            this.巾.DataPropertyName = "巾";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "#,#0.#";
            dataGridViewCellStyle2.NullValue = null;
            this.巾.DefaultCellStyle = dataGridViewCellStyle2;
            this.巾.HeaderText = "巾";
            this.巾.Name = "巾";
            this.巾.Width = 42;
            // 
            // 長さ
            // 
            this.長さ.DataPropertyName = "長さ";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,#0.#";
            dataGridViewCellStyle3.NullValue = null;
            this.長さ.DefaultCellStyle = dataGridViewCellStyle3;
            this.長さ.HeaderText = "長さ";
            this.長さ.Name = "長さ";
            this.長さ.Width = 50;
            // 
            // 数量
            // 
            this.数量.DataPropertyName = "数量";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "#,#0.#";
            dataGridViewCellStyle4.NullValue = null;
            this.数量.DefaultCellStyle = dataGridViewCellStyle4;
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            this.数量.Width = 54;
            // 
            // 摘要
            // 
            this.摘要.DataPropertyName = "摘要";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.摘要.DefaultCellStyle = dataGridViewCellStyle5;
            this.摘要.HeaderText = "摘要";
            this.摘要.Name = "摘要";
            this.摘要.Width = 54;
            // 
            // 大井野FL
            // 
            this.大井野FL.DataPropertyName = "大井野FL";
            this.大井野FL.HeaderText = "大井野";
            this.大井野FL.Name = "大井野FL";
            this.大井野FL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.大井野FL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.大井野FL.Width = 66;
            // 
            // NCFL
            // 
            this.NCFL.DataPropertyName = "NCFL";
            this.NCFL.HeaderText = "NC";
            this.NCFL.Name = "NCFL";
            this.NCFL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NCFL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NCFL.Width = 46;
            // 
            // 共通FL
            // 
            this.共通FL.DataPropertyName = "共通FL";
            this.共通FL.HeaderText = "共通";
            this.共通FL.Name = "共通FL";
            this.共通FL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.共通FL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.共通FL.Width = 54;
            // 
            // 在庫FL
            // 
            this.在庫FL.DataPropertyName = "在庫FL";
            this.在庫FL.HeaderText = "在庫";
            this.在庫FL.Name = "在庫FL";
            this.在庫FL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.在庫FL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.在庫FL.Width = 54;
            // 
            // 別納FL
            // 
            this.別納FL.DataPropertyName = "別納FL";
            this.別納FL.HeaderText = "別納";
            this.別納FL.Name = "別納FL";
            this.別納FL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.別納FL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.別納FL.Width = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 46;
            this.label2.Text = "部品";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(6, 457);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(101, 31);
            this.buttonAdd.TabIndex = 50;
            this.buttonAdd.Text = "追加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(109, 457);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(101, 31);
            this.buttonDelete.TabIndex = 51;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(570, 457);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(111, 32);
            this.buttonSave.TabIndex = 52;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClose.Location = new System.Drawing.Point(693, 457);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(111, 32);
            this.buttonClose.TabIndex = 53;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // 材種TableAdapter
            // 
            this.材種TableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolSSLabelSeries});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(889, 22);
            this.statusStrip1.TabIndex = 55;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "シリーズ ";
            // 
            // toolSSLabelSeries
            // 
            this.toolSSLabelSeries.Name = "toolSSLabelSeries";
            this.toolSSLabelSeries.Size = new System.Drawing.Size(37, 17);
            this.toolSSLabelSeries.Text = "Series";
            // 
            // FormBuhinMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 512);
            this.Controls.Add(this.statusStrip1);
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
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "FormBuhinMst";
            this.Text = "部品　一覧入力";
            this.Load += new System.EventHandler(this.FormBuhinMst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuhin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZaisyuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZaisyu)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTokuisaki;
        private System.Windows.Forms.ComboBox comboBoxSeihin;
        private System.Windows.Forms.DataGridView dataGridViewBuhin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.BindingSource dataSetZaisyuBindingSource;
        private DataSetZaisyu dataSetZaisyu;
        private DataSetZaisyuTableAdapters.材種TableAdapter 材種TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 部品コード;
        private System.Windows.Forms.DataGridViewTextBoxColumn 使用対象;
        private System.Windows.Forms.DataGridViewComboBoxColumn 材種;
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
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolSSLabelSeries;
    }
}