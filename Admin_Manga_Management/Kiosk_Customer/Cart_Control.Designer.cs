﻿namespace Kiosk_Customer
{
    partial class Cart_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart_Control));
            this.Min_Quan = new System.Windows.Forms.Button();
            this.Add_Quan = new System.Windows.Forms.Button();
            this.Quans = new System.Windows.Forms.Label();
            this.Book_Im = new System.Windows.Forms.PictureBox();
            this.Bname = new System.Windows.Forms.Label();
            this.Bprice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Remove_Book = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Im)).BeginInit();
            this.SuspendLayout();
            // 
            // Min_Quan
            // 
            this.Min_Quan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Min_Quan.BackgroundImage")));
            this.Min_Quan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Min_Quan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min_Quan.Location = new System.Drawing.Point(76, 202);
            this.Min_Quan.Margin = new System.Windows.Forms.Padding(2);
            this.Min_Quan.Name = "Min_Quan";
            this.Min_Quan.Size = new System.Drawing.Size(22, 24);
            this.Min_Quan.TabIndex = 1;
            this.Min_Quan.UseVisualStyleBackColor = true;
            this.Min_Quan.Click += new System.EventHandler(this.Min_Quan_Click);
            // 
            // Add_Quan
            // 
            this.Add_Quan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_Quan.BackgroundImage")));
            this.Add_Quan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add_Quan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Quan.Location = new System.Drawing.Point(162, 204);
            this.Add_Quan.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Quan.Name = "Add_Quan";
            this.Add_Quan.Size = new System.Drawing.Size(22, 24);
            this.Add_Quan.TabIndex = 2;
            this.Add_Quan.UseVisualStyleBackColor = true;
            this.Add_Quan.Click += new System.EventHandler(this.Add_Quan_Click);
            // 
            // Quans
            // 
            this.Quans.AutoSize = true;
            this.Quans.Location = new System.Drawing.Point(122, 204);
            this.Quans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Quans.Name = "Quans";
            this.Quans.Size = new System.Drawing.Size(0, 13);
            this.Quans.TabIndex = 3;
            // 
            // Book_Im
            // 
            this.Book_Im.Location = new System.Drawing.Point(55, 10);
            this.Book_Im.Margin = new System.Windows.Forms.Padding(2);
            this.Book_Im.Name = "Book_Im";
            this.Book_Im.Size = new System.Drawing.Size(168, 162);
            this.Book_Im.TabIndex = 4;
            this.Book_Im.TabStop = false;
            // 
            // Bname
            // 
            this.Bname.AutoSize = true;
            this.Bname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Bname.Location = new System.Drawing.Point(103, 178);
            this.Bname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bname.Name = "Bname";
            this.Bname.Size = new System.Drawing.Size(72, 15);
            this.Bname.TabIndex = 5;
            this.Bname.Text = "Book Name";
            // 
            // Bprice
            // 
            this.Bprice.AutoSize = true;
            this.Bprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Bprice.Location = new System.Drawing.Point(103, 191);
            this.Bprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bprice.Name = "Bprice";
            this.Bprice.Size = new System.Drawing.Size(66, 15);
            this.Bprice.TabIndex = 6;
            this.Bprice.Text = "Book Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(2, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "<ID>";
            this.label1.Visible = false;
            // 
            // Remove_Book
            // 
            this.Remove_Book.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Remove_Book.BackgroundImage")));
            this.Remove_Book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Remove_Book.Location = new System.Drawing.Point(257, 2);
            this.Remove_Book.Margin = new System.Windows.Forms.Padding(2);
            this.Remove_Book.Name = "Remove_Book";
            this.Remove_Book.Size = new System.Drawing.Size(22, 24);
            this.Remove_Book.TabIndex = 8;
            this.Remove_Book.UseVisualStyleBackColor = true;
            this.Remove_Book.Click += new System.EventHandler(this.Remove_Book_Click);
            // 
            // Cart_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.Remove_Book);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bprice);
            this.Controls.Add(this.Bname);
            this.Controls.Add(this.Book_Im);
            this.Controls.Add(this.Quans);
            this.Controls.Add(this.Add_Quan);
            this.Controls.Add(this.Min_Quan);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cart_Control";
            this.Size = new System.Drawing.Size(282, 248);
            ((System.ComponentModel.ISupportInitialize)(this.Book_Im)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Min_Quan;
        private System.Windows.Forms.Button Add_Quan;
        public System.Windows.Forms.Label Quans;
        public System.Windows.Forms.Label Bname;
        public System.Windows.Forms.Label Bprice;
        public System.Windows.Forms.PictureBox Book_Im;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Remove_Book;
    }
}
