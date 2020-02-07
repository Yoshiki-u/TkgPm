namespace SeisanKanri
{
    partial class FormInTokuisaki
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
            this.listBoxTokuisaki = new System.Windows.Forms.ListBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTokuisaki
            // 
            this.listBoxTokuisaki.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBoxTokuisaki.FormattingEnabled = true;
            this.listBoxTokuisaki.ItemHeight = 33;
            this.listBoxTokuisaki.Location = new System.Drawing.Point(12, 12);
            this.listBoxTokuisaki.Name = "listBoxTokuisaki";
            this.listBoxTokuisaki.Size = new System.Drawing.Size(776, 334);
            this.listBoxTokuisaki.TabIndex = 0;
            this.listBoxTokuisaki.DoubleClick += new System.EventHandler(this.listBoxTokuisaki_DoubleClick);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(12, 370);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(776, 78);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "決　定";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(12, 470);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(776, 78);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormInTokuisaki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.listBoxTokuisaki);
            this.KeyPreview = true;
            this.Name = "FormInTokuisaki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "参照　得意先";
            this.Load += new System.EventHandler(this.FormInTokuisaki_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormInTokuisaki_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.ListBox listBoxTokuisaki;
    }
}