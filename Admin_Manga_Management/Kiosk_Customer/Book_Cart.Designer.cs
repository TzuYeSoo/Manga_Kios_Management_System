namespace Kiosk_Customer
{
    partial class Book_Cart
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
            this.CartPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.check_out = new System.Windows.Forms.Button();
            this.back_Book = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CartPanel
            // 
            this.CartPanel.AutoScroll = true;
            this.CartPanel.Location = new System.Drawing.Point(146, 37);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.Size = new System.Drawing.Size(438, 322);
            this.CartPanel.TabIndex = 0;
            // 
            // check_out
            // 
            this.check_out.Location = new System.Drawing.Point(688, 388);
            this.check_out.Name = "check_out";
            this.check_out.Size = new System.Drawing.Size(86, 40);
            this.check_out.TabIndex = 1;
            this.check_out.Text = "Checkout";
            this.check_out.UseVisualStyleBackColor = true;
            this.check_out.Click += new System.EventHandler(this.check_out_Click);
            // 
            // back_Book
            // 
            this.back_Book.Location = new System.Drawing.Point(12, 12);
            this.back_Book.Name = "back_Book";
            this.back_Book.Size = new System.Drawing.Size(75, 31);
            this.back_Book.TabIndex = 2;
            this.back_Book.Text = "back_Book";
            this.back_Book.UseVisualStyleBackColor = true;
            this.back_Book.Click += new System.EventHandler(this.back_Book_Click);
            // 
            // Book_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_Book);
            this.Controls.Add(this.check_out);
            this.Controls.Add(this.CartPanel);
            this.Name = "Book_Cart";
            this.Text = "Book_Cart";
            this.Load += new System.EventHandler(this.Book_Cart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CartPanel;
        private System.Windows.Forms.Button check_out;
        private System.Windows.Forms.Button back_Book;
    }
}