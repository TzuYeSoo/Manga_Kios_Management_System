namespace Kiosk_Customer
{
    partial class BookChoice
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
            this.BookImage = new System.Windows.Forms.PictureBox();
            this.BookName = new System.Windows.Forms.Label();
            this.BookPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BookImage
            // 
            this.BookImage.Location = new System.Drawing.Point(27, 46);
            this.BookImage.Name = "BookImage";
            this.BookImage.Size = new System.Drawing.Size(231, 219);
            this.BookImage.TabIndex = 0;
            this.BookImage.TabStop = false;
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Location = new System.Drawing.Point(103, 278);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(51, 20);
            this.BookName.TabIndex = 1;
            this.BookName.Text = "label1";
            // 
            // BookPrice
            // 
            this.BookPrice.AutoSize = true;
            this.BookPrice.Location = new System.Drawing.Point(103, 320);
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.Size = new System.Drawing.Size(51, 20);
            this.BookPrice.TabIndex = 2;
            this.BookPrice.Text = "label2";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BookPrice);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.BookImage);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(328, 367);
            ((System.ComponentModel.ISupportInitialize)(this.BookImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BookImage;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.Label BookPrice;
    }
}
