﻿namespace Kiosk_Customer
{
    partial class Checkout_Books
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
            this.Book_Image = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bname = new System.Windows.Forms.Label();
            this.Bprice = new System.Windows.Forms.Label();
            this.Bquan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Book_Image
            // 
            this.Book_Image.Location = new System.Drawing.Point(30, 12);
            this.Book_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Book_Image.Name = "Book_Image";
            this.Book_Image.Size = new System.Drawing.Size(228, 191);
            this.Book_Image.TabIndex = 0;
            this.Book_Image.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Name: \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Price: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Book Quantity: \r\n";
            // 
            // Bname
            // 
            this.Bname.AutoSize = true;
            this.Bname.Location = new System.Drawing.Point(139, 217);
            this.Bname.Name = "Bname";
            this.Bname.Size = new System.Drawing.Size(79, 16);
            this.Bname.TabIndex = 4;
            this.Bname.Text = "Book Name";
            // 
            // Bprice
            // 
            this.Bprice.AutoSize = true;
            this.Bprice.Location = new System.Drawing.Point(139, 245);
            this.Bprice.Name = "Bprice";
            this.Bprice.Size = new System.Drawing.Size(79, 16);
            this.Bprice.TabIndex = 5;
            this.Bprice.Text = "Book Name";
            // 
            // Bquan
            // 
            this.Bquan.AutoSize = true;
            this.Bquan.Location = new System.Drawing.Point(139, 274);
            this.Bquan.Name = "Bquan";
            this.Bquan.Size = new System.Drawing.Size(79, 16);
            this.Bquan.TabIndex = 6;
            this.Bquan.Text = "Book Name";
            // 
            // Checkout_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Bquan);
            this.Controls.Add(this.Bprice);
            this.Controls.Add(this.Bname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Book_Image);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Checkout_Books";
            this.Size = new System.Drawing.Size(290, 303);
            ((System.ComponentModel.ISupportInitialize)(this.Book_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox Book_Image;
        public System.Windows.Forms.Label Bname;
        public System.Windows.Forms.Label Bprice;
        public System.Windows.Forms.Label Bquan;
    }
}
