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
            this.label1 = new System.Windows.Forms.Label();
            this.TTPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CartPanel
            // 
            this.CartPanel.AutoScroll = true;
            this.CartPanel.Location = new System.Drawing.Point(130, 30);
            this.CartPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.Size = new System.Drawing.Size(389, 258);
            this.CartPanel.TabIndex = 0;
            // 
            // check_out
            // 
            this.check_out.Location = new System.Drawing.Point(612, 310);
            this.check_out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_out.Name = "check_out";
            this.check_out.Size = new System.Drawing.Size(76, 32);
            this.check_out.TabIndex = 1;
            this.check_out.Text = "Checkout";
            this.check_out.UseVisualStyleBackColor = true;
            this.check_out.Click += new System.EventHandler(this.check_out_Click);
            // 
            // back_Book
            // 
            this.back_Book.Location = new System.Drawing.Point(11, 10);
            this.back_Book.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_Book.Name = "back_Book";
            this.back_Book.Size = new System.Drawing.Size(67, 25);
            this.back_Book.TabIndex = 2;
            this.back_Book.Text = "back_Book";
            this.back_Book.UseVisualStyleBackColor = true;
            this.back_Book.Click += new System.EventHandler(this.back_Book_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Cost: ";
            // 
            // TTPrice
            // 
            this.TTPrice.AutoSize = true;
            this.TTPrice.Location = new System.Drawing.Point(472, 290);
            this.TTPrice.Name = "TTPrice";
            this.TTPrice.Size = new System.Drawing.Size(44, 16);
            this.TTPrice.TabIndex = 4;
            this.TTPrice.Text = "label2";
            // 
            // Book_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.TTPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_Book);
            this.Controls.Add(this.check_out);
            this.Controls.Add(this.CartPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Book_Cart";
            this.Text = "Book_Cart";
            this.Load += new System.EventHandler(this.Book_Cart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CartPanel;
        private System.Windows.Forms.Button check_out;
        private System.Windows.Forms.Button back_Book;
        public System.Windows.Forms.Label TTPrice;
        public System.Windows.Forms.Label label1;
    }
}