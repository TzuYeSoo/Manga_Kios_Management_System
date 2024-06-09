namespace Kiosk_Customer
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
            this.Selected_Book = new System.Windows.Forms.FlowLayoutPanel();
            this.Add_To_Cart = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Selected_Book
            // 
            this.Selected_Book.AutoScroll = true;
            this.Selected_Book.Location = new System.Drawing.Point(104, 46);
            this.Selected_Book.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Selected_Book.Name = "Selected_Book";
            this.Selected_Book.Size = new System.Drawing.Size(284, 300);
            this.Selected_Book.TabIndex = 0;
            // 
            // Add_To_Cart
            // 
            this.Add_To_Cart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_To_Cart.BackgroundImage")));
            this.Add_To_Cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add_To_Cart.Location = new System.Drawing.Point(446, 9);
            this.Add_To_Cart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add_To_Cart.Name = "Add_To_Cart";
            this.Add_To_Cart.Size = new System.Drawing.Size(38, 41);
            this.Add_To_Cart.TabIndex = 1;
            this.Add_To_Cart.UseVisualStyleBackColor = true;
            this.Add_To_Cart.Click += new System.EventHandler(this.Add_To_Cart_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(8, 8);
            this.Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(50, 34);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // BookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 449);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Add_To_Cart);
            this.Controls.Add(this.Selected_Book);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EIWA STORE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Selected_Book;
        private System.Windows.Forms.Button Add_To_Cart;
        private System.Windows.Forms.Button Back;
    }
}