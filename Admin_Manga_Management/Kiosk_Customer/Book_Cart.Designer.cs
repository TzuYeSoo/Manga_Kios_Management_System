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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Cart));
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
            this.CartPanel.Location = new System.Drawing.Point(147, 37);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.Size = new System.Drawing.Size(482, 323);
            this.CartPanel.TabIndex = 0;
            // 
            // check_out
            // 
            this.check_out.Location = new System.Drawing.Point(672, 388);
            this.check_out.Name = "check_out";
            this.check_out.Size = new System.Drawing.Size(102, 34);
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
            this.back_Book.Text = "Back";
            this.back_Book.UseVisualStyleBackColor = true;
            this.back_Book.Click += new System.EventHandler(this.back_Book_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Cost: ";
            // 
            // TTPrice
            // 
            this.TTPrice.AutoSize = true;
            this.TTPrice.Location = new System.Drawing.Point(531, 363);
            this.TTPrice.Name = "TTPrice";
            this.TTPrice.Size = new System.Drawing.Size(0, 20);
            this.TTPrice.TabIndex = 4;
            // 
            // Book_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.TTPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_Book);
            this.Controls.Add(this.check_out);
            this.Controls.Add(this.CartPanel);
            this.Name = "Book_Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EIWA STORE";
            this.Load += new System.EventHandler(this.Book_Cart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button check_out;
        private System.Windows.Forms.Button back_Book;
        public System.Windows.Forms.Label TTPrice;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel CartPanel;
    }
}