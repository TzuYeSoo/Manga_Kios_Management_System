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
            this.textBoxCustomersID.Location = new System.Drawing.Point(12, 77);
            this.textBoxCustomersID.Name = "textBoxCustomersID";
            this.textBoxCustomersID.Size = new System.Drawing.Size(122, 20);
            this.textBoxCustomersID.TabIndex = 0;
            // 
            // textBoxCashierID
            // 
            this.textBoxCashierID.Location = new System.Drawing.Point(480, 80);
            this.textBoxCashierID.Name = "textBoxCashierID";
            this.textBoxCashierID.Size = new System.Drawing.Size(122, 20);
            this.textBoxCashierID.TabIndex = 1;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(12, 129);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(122, 20);
            this.textBoxCustomerName.TabIndex = 2;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(480, 129);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(122, 20);
            this.textBoxDate.TabIndex = 4;
            // 
            // textBoxBookQuantity
            // 
            this.textBoxBookQuantity.Location = new System.Drawing.Point(325, 129);
            this.textBoxBookQuantity.Name = "textBoxBookQuantity";
            this.textBoxBookQuantity.Size = new System.Drawing.Size(122, 20);
            this.textBoxBookQuantity.TabIndex = 5;
            // 
            // labelCutomersID
            // 
            this.labelCutomersID.AutoSize = true;
            this.labelCutomersID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelCutomersID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCutomersID.Location = new System.Drawing.Point(9, 58);
            this.labelCutomersID.Name = "labelCutomersID";
            this.labelCutomersID.Size = new System.Drawing.Size(89, 17);
            this.labelCutomersID.TabIndex = 7;
            this.labelCutomersID.Text = "Customer_ID";
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelBookID.Location = new System.Drawing.Point(163, 58);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(85, 17);
            this.labelBookID.TabIndex = 8;
            this.labelBookID.Text = "Book_Name";
            // 
            // labelCashierID
            // 
            this.labelCashierID.AutoSize = true;
            this.labelCashierID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelCashierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCashierID.Location = new System.Drawing.Point(477, 61);
            this.labelCashierID.Name = "labelCashierID";
            this.labelCashierID.Size = new System.Drawing.Size(101, 17);
            this.labelCashierID.TabIndex = 9;
            this.labelCashierID.Text = "Cashier_Name";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCustomerName.Location = new System.Drawing.Point(9, 110);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(113, 17);
            this.labelCustomerName.TabIndex = 10;
            this.labelCustomerName.Text = "Customer_Name";
            // 
            // labelBookQuantity
            // 
            this.labelBookQuantity.AutoSize = true;
            this.labelBookQuantity.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelBookQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelBookQuantity.Location = new System.Drawing.Point(322, 110);
            this.labelBookQuantity.Name = "labelBookQuantity";
            this.labelBookQuantity.Size = new System.Drawing.Size(101, 17);
            this.labelBookQuantity.TabIndex = 11;
            this.labelBookQuantity.Text = "Book_Quantity";
            this.labelBookQuantity.Click += new System.EventHandler(this.labelBookQuantity_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDate.Location = new System.Drawing.Point(477, 110);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(38, 17);
            this.labelDate.TabIndex = 13;
            this.labelDate.Text = "Date";
            // 
            // Trans_HisGrid
            // 
            this.Trans_HisGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Trans_HisGrid.Location = new System.Drawing.Point(12, 152);
            this.Trans_HisGrid.Name = "Trans_HisGrid";
            this.Trans_HisGrid.RowHeadersWidth = 62;
            this.Trans_HisGrid.Size = new System.Drawing.Size(767, 273);
            this.Trans_HisGrid.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Edit Transaction";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(704, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(117, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(322, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Book Price";
            // 
            // Book_Price
            // 
            this.Book_Price.Location = new System.Drawing.Point(325, 78);
            this.Book_Price.Name = "Book_Price";
            this.Book_Price.Size = new System.Drawing.Size(122, 20);
            this.Book_Price.TabIndex = 18;
            // 
            // BookNames
            // 
            this.BookNames.FormattingEnabled = true;
            this.BookNames.Location = new System.Drawing.Point(166, 77);
            this.BookNames.Margin = new System.Windows.Forms.Padding(2);
            this.BookNames.Name = "BookNames";
            this.BookNames.Size = new System.Drawing.Size(128, 49);
            this.BookNames.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
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