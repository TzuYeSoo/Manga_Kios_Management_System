namespace Admin_Manga_Management
{
    partial class CashierHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierHome));
            this.Search_Box_Book = new System.Windows.Forms.TextBox();
            this.Walkin = new System.Windows.Forms.Button();
            this.Kios_Cus = new System.Windows.Forms.Button();
            this.Book_Items = new System.Windows.Forms.FlowLayoutPanel();
            this.PayOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.Payment = new System.Windows.Forms.Button();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Search_Box_Book
            // 
            this.Search_Box_Book.Location = new System.Drawing.Point(528, 101);
            this.Search_Box_Book.Name = "Search_Box_Book";
            this.Search_Box_Book.Size = new System.Drawing.Size(488, 22);
            this.Search_Box_Book.TabIndex = 4;
            this.Search_Box_Book.TextChanged += new System.EventHandler(this.Search_Box_Book_TextChanged);
            // 
            // Walkin
            // 
            this.Walkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Walkin.Location = new System.Drawing.Point(0, 4);
            this.Walkin.Name = "Walkin";
            this.Walkin.Size = new System.Drawing.Size(522, 73);
            this.Walkin.TabIndex = 5;
            this.Walkin.Text = "WALK IN";
            this.Walkin.UseVisualStyleBackColor = true;
            // 
            // Kios_Cus
            // 
            this.Kios_Cus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kios_Cus.Location = new System.Drawing.Point(528, 4);
            this.Kios_Cus.Name = "Kios_Cus";
            this.Kios_Cus.Size = new System.Drawing.Size(488, 73);
            this.Kios_Cus.TabIndex = 6;
            this.Kios_Cus.Text = "Self-Service Customer";
            this.Kios_Cus.UseVisualStyleBackColor = true;
            this.Kios_Cus.Click += new System.EventHandler(this.Kios_Cus_Click);
            // 
            // Book_Items
            // 
            this.Book_Items.AutoScroll = true;
            this.Book_Items.Location = new System.Drawing.Point(528, 129);
            this.Book_Items.Name = "Book_Items";
            this.Book_Items.Size = new System.Drawing.Size(563, 423);
            this.Book_Items.TabIndex = 7;
            // 
            // PayOrder
            // 
            this.PayOrder.Location = new System.Drawing.Point(0, 77);
            this.PayOrder.Name = "PayOrder";
            this.PayOrder.Size = new System.Drawing.Size(522, 361);
            this.PayOrder.TabIndex = 8;
            // 
            // Payment
            // 
            this.Payment.BackColor = System.Drawing.Color.IndianRed;
            this.Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment.Location = new System.Drawing.Point(0, 469);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(530, 83);
            this.Payment.TabIndex = 9;
            this.Payment.Text = "Payment";
            this.Payment.UseVisualStyleBackColor = false;
            this.Payment.Click += new System.EventHandler(this.Payment_Click);
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Location = new System.Drawing.Point(412, 446);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(0, 16);
            this.TotalPrice.TabIndex = 0;
            // 
            // logout
            // 
            this.logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout.BackgroundImage")));
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.Location = new System.Drawing.Point(1022, 5);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 72);
            this.logout.TabIndex = 10;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // CashierHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 554);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.PayOrder);
            this.Controls.Add(this.Book_Items);
            this.Controls.Add(this.Kios_Cus);
            this.Controls.Add(this.Walkin);
            this.Controls.Add(this.Search_Box_Book);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CashierHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.CashierHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Search_Box_Book;
        private System.Windows.Forms.Button Walkin;
        private System.Windows.Forms.Button Kios_Cus;
        private System.Windows.Forms.FlowLayoutPanel Book_Items;
        private System.Windows.Forms.FlowLayoutPanel PayOrder;
        private System.Windows.Forms.Button Payment;
        public System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Button logout;
    }
}