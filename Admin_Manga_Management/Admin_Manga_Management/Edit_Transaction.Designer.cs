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
            this.textBoxCustomersID.Location = new System.Drawing.Point(18, 118);
            this.textBoxCustomersID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCustomersID.Name = "textBoxCustomersID";
            this.textBoxCustomersID.Size = new System.Drawing.Size(181, 26);
            this.textBoxCustomersID.TabIndex = 0;
            // 
            // textBoxCashierID
            // 
            this.textBoxCashierID.Location = new System.Drawing.Point(720, 123);
            this.textBoxCashierID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCashierID.Name = "textBoxCashierID";
            this.textBoxCashierID.Size = new System.Drawing.Size(181, 26);
            this.textBoxCashierID.TabIndex = 1;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(18, 198);
            this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(181, 26);
            this.textBoxCustomerName.TabIndex = 2;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(720, 198);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(181, 26);
            this.textBoxDate.TabIndex = 4;
            // 
            // textBoxBookQuantity
            // 
            this.textBoxBookQuantity.Location = new System.Drawing.Point(488, 198);
            this.textBoxBookQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBookQuantity.Name = "textBoxBookQuantity";
            this.textBoxBookQuantity.Size = new System.Drawing.Size(181, 26);
            this.textBoxBookQuantity.TabIndex = 5;
            // 
            // labelCutomersID
            // 
            this.labelCutomersID.AutoSize = true;
            this.labelCutomersID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelCutomersID.Location = new System.Drawing.Point(14, 89);
            this.labelCutomersID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCutomersID.Name = "labelCutomersID";
            this.labelCutomersID.Size = new System.Drawing.Size(127, 25);
            this.labelCutomersID.TabIndex = 7;
            this.labelCutomersID.Text = "Customer_ID";
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelBookID.Location = new System.Drawing.Point(244, 89);
            this.labelBookID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(120, 25);
            this.labelBookID.TabIndex = 8;
            this.labelBookID.Text = "Book_Name";
            // 
            // labelCashierID
            // 
            this.labelCashierID.AutoSize = true;
            this.labelCashierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelCashierID.Location = new System.Drawing.Point(715, 94);
            this.labelCashierID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCashierID.Name = "labelCashierID";
            this.labelCashierID.Size = new System.Drawing.Size(143, 25);
            this.labelCashierID.TabIndex = 9;
            this.labelCashierID.Text = "Cashier_Name";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelCustomerName.Location = new System.Drawing.Point(14, 169);
            this.labelCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(160, 25);
            this.labelCustomerName.TabIndex = 10;
            this.labelCustomerName.Text = "Customer_Name";
            // 
            // labelBookQuantity
            // 
            this.labelBookQuantity.AutoSize = true;
            this.labelBookQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelBookQuantity.Location = new System.Drawing.Point(483, 169);
            this.labelBookQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBookQuantity.Name = "labelBookQuantity";
            this.labelBookQuantity.Size = new System.Drawing.Size(141, 25);
            this.labelBookQuantity.TabIndex = 11;
            this.labelBookQuantity.Text = "Book_Quantity";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelDate.Location = new System.Drawing.Point(716, 169);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(53, 25);
            this.labelDate.TabIndex = 13;
            this.labelDate.Text = "Date";
            // 
            // Trans_HisGrid
            // 
            this.Trans_HisGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Trans_HisGrid.Location = new System.Drawing.Point(18, 234);
            this.Trans_HisGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Trans_HisGrid.Name = "Trans_HisGrid";
            this.Trans_HisGrid.RowHeadersWidth = 62;
            this.Trans_HisGrid.Size = new System.Drawing.Size(1150, 420);
            this.Trans_HisGrid.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Edit Transaction";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1056, 194);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(176, 123);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 23);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(483, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Book Price";
            // 
            // Book_Price
            // 
            this.Book_Price.Location = new System.Drawing.Point(488, 120);
            this.Book_Price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Book_Price.Name = "Book_Price";
            this.Book_Price.Size = new System.Drawing.Size(181, 26);
            this.Book_Price.TabIndex = 18;
            // 
            // BookNames
            // 
            this.BookNames.FormattingEnabled = true;
            this.BookNames.Location = new System.Drawing.Point(249, 118);
            this.BookNames.Name = "BookNames";
            this.BookNames.Size = new System.Drawing.Size(190, 96);
            this.BookNames.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
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