﻿namespace Kiosk_Customer
{
    partial class BookInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookInfo));
            this.Add_To_Cart = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Book_Image = new System.Windows.Forms.PictureBox();
            this.desc = new System.Windows.Forms.Label();
            this.Book_Price = new System.Windows.Forms.Label();
            this.Book_Name = new System.Windows.Forms.Label();
            this.MinQuan = new System.Windows.Forms.Button();
            this.AddQuan = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_To_Cart
            // 
            this.Add_To_Cart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_To_Cart.BackgroundImage")));
            this.Add_To_Cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add_To_Cart.Location = new System.Drawing.Point(669, 14);
            this.Add_To_Cart.Name = "Add_To_Cart";
            this.Add_To_Cart.Size = new System.Drawing.Size(57, 63);
            this.Add_To_Cart.TabIndex = 1;
            this.Add_To_Cart.UseVisualStyleBackColor = true;
            this.Add_To_Cart.Click += new System.EventHandler(this.Add_To_Cart_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 52);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Book_Image
            // 
            this.Book_Image.Location = new System.Drawing.Point(110, 131);
            this.Book_Image.Name = "Book_Image";
            this.Book_Image.Size = new System.Drawing.Size(298, 280);
            this.Book_Image.TabIndex = 4;
            this.Book_Image.TabStop = false;
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(720, 131);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(260, 280);
            this.desc.TabIndex = 5;
            this.desc.Text = "Book Desciption:";
            // 
            // Book_Price
            // 
            this.Book_Price.AutoSize = true;
            this.Book_Price.Location = new System.Drawing.Point(448, 174);
            this.Book_Price.Name = "Book_Price";
            this.Book_Price.Size = new System.Drawing.Size(103, 20);
            this.Book_Price.TabIndex = 6;
            this.Book_Price.Text = "<Book Price>";
            // 
            // Book_Name
            // 
            this.Book_Name.AutoSize = true;
            this.Book_Name.Location = new System.Drawing.Point(448, 131);
            this.Book_Name.Name = "Book_Name";
            this.Book_Name.Size = new System.Drawing.Size(110, 20);
            this.Book_Name.TabIndex = 7;
            this.Book_Name.Text = "<Book Name>";
            // 
            // MinQuan
            // 
            this.MinQuan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinQuan.BackgroundImage")));
            this.MinQuan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinQuan.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinQuan.Location = new System.Drawing.Point(153, 417);
            this.MinQuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinQuan.Name = "MinQuan";
            this.MinQuan.Size = new System.Drawing.Size(34, 38);
            this.MinQuan.TabIndex = 9;
            this.MinQuan.UseVisualStyleBackColor = true;
            this.MinQuan.Click += new System.EventHandler(this.MinQuan_Click);
            // 
            // AddQuan
            // 
            this.AddQuan.BackColor = System.Drawing.Color.Transparent;
            this.AddQuan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddQuan.BackgroundImage")));
            this.AddQuan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddQuan.Location = new System.Drawing.Point(285, 416);
            this.AddQuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddQuan.Name = "AddQuan";
            this.AddQuan.Size = new System.Drawing.Size(34, 38);
            this.AddQuan.TabIndex = 8;
            this.AddQuan.UseVisualStyleBackColor = false;
            this.AddQuan.Click += new System.EventHandler(this.AddQuan_Click);
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(193, 425);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(86, 20);
            this.Quantity.TabIndex = 10;
            this.Quantity.Text = "<Quantity>";
            this.Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Genre
            // 
            this.Genre.Location = new System.Drawing.Point(448, 221);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(244, 190);
            this.Genre.TabIndex = 11;
            this.Genre.Text = "Genre:";
            // 
            // BookInfo
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1037, 507);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.MinQuan);
            this.Controls.Add(this.AddQuan);
            this.Controls.Add(this.Book_Name);
            this.Controls.Add(this.Book_Price);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.Book_Image);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Add_To_Cart);
            this.Name = "BookInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EIWA STORE";
            ((System.ComponentModel.ISupportInitialize)(this.Book_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add_To_Cart;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.PictureBox Book_Image;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Label Book_Price;
        private System.Windows.Forms.Label Book_Name;
        private System.Windows.Forms.Button MinQuan;
        private System.Windows.Forms.Button AddQuan;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label Genre;
    }
}