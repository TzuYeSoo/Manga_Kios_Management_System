namespace Admin_Manga_Management
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxCustomersID = new System.Windows.Forms.TextBox();
            this.textBoxCashierID = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxBookQuantity = new System.Windows.Forms.TextBox();
            this.labelCutomersID = new System.Windows.Forms.Label();
            this.labelBookID = new System.Windows.Forms.Label();
            this.labelCashierID = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelBookQuantity = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.Trans_HisGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Book_Price = new System.Windows.Forms.TextBox();
            this.BookNames = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_HisGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCustomersID
            // 
            this.textBoxCustomersID.Location = new System.Drawing.Point(16, 95);
            this.textBoxCustomersID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustomersID.Name = "textBoxCustomersID";
            this.textBoxCustomersID.Size = new System.Drawing.Size(161, 22);
            this.textBoxCustomersID.TabIndex = 0;
            // 
            // textBoxCashierID
            // 
            this.textBoxCashierID.Location = new System.Drawing.Point(640, 98);
            this.textBoxCashierID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCashierID.Name = "textBoxCashierID";
            this.textBoxCashierID.Size = new System.Drawing.Size(161, 22);
            this.textBoxCashierID.TabIndex = 1;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(16, 159);
            this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(161, 22);
            this.textBoxCustomerName.TabIndex = 2;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(640, 159);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(161, 22);
            this.textBoxDate.TabIndex = 4;
            // 
            // textBoxBookQuantity
            // 
            this.textBoxBookQuantity.Location = new System.Drawing.Point(433, 159);
            this.textBoxBookQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBookQuantity.Name = "textBoxBookQuantity";
            this.textBoxBookQuantity.Size = new System.Drawing.Size(161, 22);
            this.textBoxBookQuantity.TabIndex = 5;
            // 
            // labelCutomersID
            // 
            this.labelCutomersID.AutoSize = true;
            this.labelCutomersID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelCutomersID.Location = new System.Drawing.Point(12, 71);
            this.labelCutomersID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCutomersID.Name = "labelCutomersID";
            this.labelCutomersID.Size = new System.Drawing.Size(108, 20);
            this.labelCutomersID.TabIndex = 7;
            this.labelCutomersID.Text = "Customer_ID";
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelBookID.Location = new System.Drawing.Point(217, 71);
            this.labelBookID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(100, 20);
            this.labelBookID.TabIndex = 8;
            this.labelBookID.Text = "Book_Name";
            // 
            // labelCashierID
            // 
            this.labelCashierID.AutoSize = true;
            this.labelCashierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelCashierID.Location = new System.Drawing.Point(636, 75);
            this.labelCashierID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCashierID.Name = "labelCashierID";
            this.labelCashierID.Size = new System.Drawing.Size(120, 20);
            this.labelCashierID.TabIndex = 9;
            this.labelCashierID.Text = "Cashier_Name";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelCustomerName.Location = new System.Drawing.Point(12, 135);
            this.labelCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(135, 20);
            this.labelCustomerName.TabIndex = 10;
            this.labelCustomerName.Text = "Customer_Name";
            // 
            // labelBookQuantity
            // 
            this.labelBookQuantity.AutoSize = true;
            this.labelBookQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelBookQuantity.Location = new System.Drawing.Point(429, 135);
            this.labelBookQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBookQuantity.Name = "labelBookQuantity";
            this.labelBookQuantity.Size = new System.Drawing.Size(118, 20);
            this.labelBookQuantity.TabIndex = 11;
            this.labelBookQuantity.Text = "Book_Quantity";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelDate.Location = new System.Drawing.Point(636, 135);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(45, 20);
            this.labelDate.TabIndex = 13;
            this.labelDate.Text = "Date";
            // 
            // Trans_HisGrid
            // 
            this.Trans_HisGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Trans_HisGrid.Location = new System.Drawing.Point(16, 187);
            this.Trans_HisGrid.Margin = new System.Windows.Forms.Padding(4);
            this.Trans_HisGrid.Name = "Trans_HisGrid";
            this.Trans_HisGrid.RowHeadersWidth = 62;
            this.Trans_HisGrid.Size = new System.Drawing.Size(1023, 336);
            this.Trans_HisGrid.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Edit Transaction";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(939, 155);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(156, 98);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 18);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(429, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Book Price";
            // 
            // Book_Price
            // 
            this.Book_Price.Location = new System.Drawing.Point(433, 96);
            this.Book_Price.Margin = new System.Windows.Forms.Padding(4);
            this.Book_Price.Name = "Book_Price";
            this.Book_Price.Size = new System.Drawing.Size(161, 22);
            this.Book_Price.TabIndex = 18;
            // 
            // BookNames
            // 
            this.BookNames.FormattingEnabled = true;
            this.BookNames.Location = new System.Drawing.Point(221, 95);
            this.BookNames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookNames.Name = "BookNames";
            this.BookNames.Size = new System.Drawing.Size(169, 72);
            this.BookNames.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BookNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Book_Price);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Trans_HisGrid);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelBookQuantity);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.labelCashierID);
            this.Controls.Add(this.labelBookID);
            this.Controls.Add(this.labelCutomersID);
            this.Controls.Add(this.textBoxBookQuantity);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.textBoxCashierID);
            this.Controls.Add(this.textBoxCustomersID);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Trans_HisGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCustomersID;
        private System.Windows.Forms.TextBox textBoxCashierID;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxBookQuantity;
        private System.Windows.Forms.Label labelCutomersID;
        private System.Windows.Forms.Label labelBookID;
        private System.Windows.Forms.Label labelCashierID;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelBookQuantity;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DataGridView Trans_HisGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Book_Price;
        private System.Windows.Forms.CheckedListBox BookNames;
    }
}