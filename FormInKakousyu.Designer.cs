namespace SeisanKanri
{
    partial class FormInKakousyu
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.listBoxItem = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(1, 230);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(358, 39);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(1, 180);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(358, 39);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "決　定";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // listBoxItem
            // 
            this.listBoxItem.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.ItemHeight = 16;
            this.listBoxItem.Location = new System.Drawing.Point(1, 1);
            this.listBoxItem.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.Size = new System.Drawing.Size(360, 164);
            this.listBoxItem.TabIndex = 3;
            this.listBoxItem.DoubleClick += new System.EventHandler(this.ListBoxItem_DoubleClick);
            // 
            // FormInKakousyu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 272);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.listBoxItem);
            this.Name = "FormInKakousyu";
            this.Text = "参照　加工種";
            this.Load += new System.EventHandler(this.FormInKakousyu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormInKakousyu_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        public System.Windows.Forms.ListBox listBoxItem;
    }
}