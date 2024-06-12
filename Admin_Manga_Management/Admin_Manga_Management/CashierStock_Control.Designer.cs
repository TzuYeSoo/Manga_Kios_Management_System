namespace Admin_Manga_Management
{
    partial class CashierStock_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookIm = new System.Windows.Forms.PictureBox();
            this.Bname = new System.Windows.Forms.Label();
            this.BStocks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookIm)).BeginInit();
            this.SuspendLayout();
            // 
            // bookIm
            // 
            this.bookIm.Location = new System.Drawing.Point(33, 23);
            this.bookIm.Name = "bookIm";
            this.bookIm.Size = new System.Drawing.Size(241, 205);
            this.bookIm.TabIndex = 0;
            this.bookIm.TabStop = false;
            // 
            // Bname
            // 
            this.Bname.AutoSize = true;
            this.Bname.Location = new System.Drawing.Point(108, 244);
            this.Bname.Name = "Bname";
            this.Bname.Size = new System.Drawing.Size(110, 20);
            this.Bname.TabIndex = 1;
            this.Bname.Text = "<Book Name>";
            // 
            // BStocks
            // 
            this.BStocks.AutoSize = true;
            this.BStocks.Location = new System.Drawing.Point(109, 269);
            this.BStocks.Name = "BStocks";
            this.BStocks.Size = new System.Drawing.Size(109, 20);
            this.BStocks.TabIndex = 2;
            this.BStocks.Text = "<Book Stock>";
            // 
            // CashierStock_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BStocks);
            this.Controls.Add(this.Bname);
            this.Controls.Add(this.bookIm);
            this.Name = "CashierStock_Control";
            this.Size = new System.Drawing.Size(307, 304);
            ((System.ComponentModel.ISupportInitialize)(this.bookIm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox bookIm;
        public System.Windows.Forms.Label Bname;
        public System.Windows.Forms.Label BStocks;
    }
}
