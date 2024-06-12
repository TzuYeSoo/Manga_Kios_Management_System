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
            this.Search_Box_Book = new System.Windows.Forms.TextBox();
            this.Walkin = new System.Windows.Forms.Button();
            this.Kios_Cus = new System.Windows.Forms.Button();
            this.Book_Items = new System.Windows.Forms.FlowLayoutPanel();
            this.Newcust = new System.Windows.Forms.FlowLayoutPanel();
            this.Payment = new System.Windows.Forms.Button();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_Box_Book
            // 
            this.Search_Box_Book.Location = new System.Drawing.Point(1012, 74);
            this.Search_Box_Book.Name = "Search_Box_Book";
            this.Search_Box_Book.Size = new System.Drawing.Size(488, 22);
            this.Search_Box_Book.TabIndex = 4;
            // 
            // Walkin
            // 
            this.Walkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Walkin.Location = new System.Drawing.Point(0, 40);
            this.Walkin.Name = "Walkin";
            this.Walkin.Size = new System.Drawing.Size(291, 44);
            this.Walkin.TabIndex = 5;
            this.Walkin.Text = "WALK IN";
            this.Walkin.UseVisualStyleBackColor = true;
            // 
            // Kios_Cus
            // 
            this.Kios_Cus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kios_Cus.Location = new System.Drawing.Point(0, 120);
            this.Kios_Cus.Name = "Kios_Cus";
            this.Kios_Cus.Size = new System.Drawing.Size(291, 44);
            this.Kios_Cus.TabIndex = 6;
            this.Kios_Cus.Text = "Self-Service Customer";
            this.Kios_Cus.UseVisualStyleBackColor = true;
            this.Kios_Cus.Click += new System.EventHandler(this.Kios_Cus_Click);
            // 
            // Book_Items
            // 
            this.Book_Items.AutoScroll = true;
            this.Book_Items.Location = new System.Drawing.Point(937, 110);
            this.Book_Items.Name = "Book_Items";
            this.Book_Items.Size = new System.Drawing.Size(563, 423);
            this.Book_Items.TabIndex = 7;
            // 
            // Newcust
            // 
            this.Newcust.Location = new System.Drawing.Point(323, 110);
            this.Newcust.Name = "Newcust";
            this.Newcust.Size = new System.Drawing.Size(588, 287);
            this.Newcust.TabIndex = 8;
            // 
            // Payment
            // 
            this.Payment.BackColor = System.Drawing.Color.IndianRed;
            this.Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment.Location = new System.Drawing.Point(323, 450);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(588, 83);
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
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(0, 280);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(291, 44);
            this.logout.TabIndex = 10;
            this.logout.Text = "Log out";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 575);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Stocks";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CashierHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1370, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Walkin);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.Newcust);
            this.Controls.Add(this.Book_Items);
            this.Controls.Add(this.Kios_Cus);
            this.Controls.Add(this.Search_Box_Book);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CashierHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.CashierHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Search_Box_Book;
        private System.Windows.Forms.Button Walkin;
        private System.Windows.Forms.Button Kios_Cus;
        private System.Windows.Forms.FlowLayoutPanel Book_Items;
        private System.Windows.Forms.Button Payment;
        public System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.FlowLayoutPanel Newcust;
    }
}