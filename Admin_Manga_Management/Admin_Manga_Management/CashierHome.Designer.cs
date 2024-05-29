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
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerOrder = new System.Windows.Forms.DataGridView();
            this.BookList = new System.Windows.Forms.DataGridView();
            this.Search_Box_Book = new System.Windows.Forms.TextBox();
            this.Customers_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cashier";
            // 
            // CustomerOrder
            // 
            this.CustomerOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerOrder.Location = new System.Drawing.Point(106, 163);
            this.CustomerOrder.Name = "CustomerOrder";
            this.CustomerOrder.Size = new System.Drawing.Size(396, 352);
            this.CustomerOrder.TabIndex = 1;
            // 
            // BookList
            // 
            this.BookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookList.Location = new System.Drawing.Point(545, 163);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(396, 352);
            this.BookList.TabIndex = 2;
            // 
            // Search_Box_Book
            // 
            this.Search_Box_Book.Location = new System.Drawing.Point(775, 62);
            this.Search_Box_Book.Name = "Search_Box_Book";
            this.Search_Box_Book.Size = new System.Drawing.Size(209, 22);
            this.Search_Box_Book.TabIndex = 4;
            // 
            // Customers_Name
            // 
            this.Customers_Name.AutoSize = true;
            this.Customers_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Customers_Name.Location = new System.Drawing.Point(42, 105);
            this.Customers_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Customers_Name.Name = "Customers_Name";
            this.Customers_Name.Size = new System.Drawing.Size(0, 25);
            this.Customers_Name.TabIndex = 5;
            // 
            // CashierHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Customers_Name);
            this.Controls.Add(this.Search_Box_Book);
            this.Controls.Add(this.BookList);
            this.Controls.Add(this.CustomerOrder);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CashierHome";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.CashierHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CustomerOrder;
        private System.Windows.Forms.DataGridView BookList;
        private System.Windows.Forms.TextBox Search_Box_Book;
        private System.Windows.Forms.Label Customers_Name;
    }
}