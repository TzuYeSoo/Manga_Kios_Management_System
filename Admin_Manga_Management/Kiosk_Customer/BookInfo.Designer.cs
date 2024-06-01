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
            this.Selected_Book = new System.Windows.Forms.FlowLayoutPanel();
            this.Add_To_Cart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Selected_Book
            // 
            this.Selected_Book.AutoScroll = true;
            this.Selected_Book.Location = new System.Drawing.Point(150, 29);
            this.Selected_Book.Name = "Selected_Book";
            this.Selected_Book.Size = new System.Drawing.Size(440, 371);
            this.Selected_Book.TabIndex = 0;
            // 
            // Add_To_Cart
            // 
            this.Add_To_Cart.Location = new System.Drawing.Point(617, 359);
            this.Add_To_Cart.Name = "Add_To_Cart";
            this.Add_To_Cart.Size = new System.Drawing.Size(75, 52);
            this.Add_To_Cart.TabIndex = 1;
            this.Add_To_Cart.Text = "Add to Cart";
            this.Add_To_Cart.UseVisualStyleBackColor = true;
            this.Add_To_Cart.Click += new System.EventHandler(this.Add_To_Cart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Check Out";
            this.button2.UseVisualStyleBackColor = true;
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
            // BookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add_To_Cart);
            this.Controls.Add(this.Selected_Book);
            this.Name = "BookInfo";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Selected_Book;
        private System.Windows.Forms.Button Add_To_Cart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Back;
    }
}