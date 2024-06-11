namespace Admin_Manga_Management
{
    partial class Edit_BookStocks
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
            this.Stock_Quantity = new System.Windows.Forms.TextBox();
            this.Desc_Report = new System.Windows.Forms.TextBox();
            this.Bname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_Stock = new System.Windows.Forms.Button();
            this.Min_Quantity = new System.Windows.Forms.Button();
            this.Stock_edit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseBut = new System.Windows.Forms.Button();
            this.Book_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Stock_Quantity
            // 
            this.Stock_Quantity.Location = new System.Drawing.Point(356, 93);
            this.Stock_Quantity.Name = "Stock_Quantity";
            this.Stock_Quantity.Size = new System.Drawing.Size(100, 22);
            this.Stock_Quantity.TabIndex = 2;
            // 
            // Desc_Report
            // 
            this.Desc_Report.Location = new System.Drawing.Point(356, 147);
            this.Desc_Report.Multiline = true;
            this.Desc_Report.Name = "Desc_Report";
            this.Desc_Report.Size = new System.Drawing.Size(425, 92);
            this.Desc_Report.TabIndex = 4;
            // 
            // Bname
            // 
            this.Bname.AutoSize = true;
            this.Bname.Location = new System.Drawing.Point(134, 264);
            this.Bname.Name = "Bname";
            this.Bname.Size = new System.Drawing.Size(93, 16);
            this.Bname.TabIndex = 5;
            this.Bname.Text = "<Book Name>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Existing Quantity";
            // 
            // Add_Stock
            // 
            this.Add_Stock.Location = new System.Drawing.Point(356, 264);
            this.Add_Stock.Name = "Add_Stock";
            this.Add_Stock.Size = new System.Drawing.Size(75, 23);
            this.Add_Stock.TabIndex = 8;
            this.Add_Stock.Text = "Add";
            this.Add_Stock.UseVisualStyleBackColor = true;
            this.Add_Stock.Click += new System.EventHandler(this.Add_Stock_Click);
            // 
            // Min_Quantity
            // 
            this.Min_Quantity.Location = new System.Drawing.Point(464, 264);
            this.Min_Quantity.Name = "Min_Quantity";
            this.Min_Quantity.Size = new System.Drawing.Size(75, 23);
            this.Min_Quantity.TabIndex = 9;
            this.Min_Quantity.Text = "Remove";
            this.Min_Quantity.UseVisualStyleBackColor = true;
            this.Min_Quantity.Click += new System.EventHandler(this.Min_Quantity_Click);
            // 
            // Stock_edit
            // 
            this.Stock_edit.Location = new System.Drawing.Point(480, 93);
            this.Stock_edit.Name = "Stock_edit";
            this.Stock_edit.Size = new System.Drawing.Size(100, 22);
            this.Stock_edit.TabIndex = 10;
            this.Stock_edit.TextChanged += new System.EventHandler(this.Stock_edit_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantity";
            // 
            // CloseBut
            // 
            this.CloseBut.Location = new System.Drawing.Point(713, 12);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(75, 23);
            this.CloseBut.TabIndex = 12;
            this.CloseBut.Text = "Close";
            this.CloseBut.UseVisualStyleBackColor = true;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // Book_Image
            // 
            this.Book_Image.Location = new System.Drawing.Point(64, 12);
            this.Book_Image.Name = "Book_Image";
            this.Book_Image.Size = new System.Drawing.Size(257, 227);
            this.Book_Image.TabIndex = 0;
            this.Book_Image.TabStop = false;
            // 
            // Edit_BookStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 318);
            this.Controls.Add(this.CloseBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Stock_edit);
            this.Controls.Add(this.Min_Quantity);
            this.Controls.Add(this.Add_Stock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bname);
            this.Controls.Add(this.Desc_Report);
            this.Controls.Add(this.Stock_Quantity);
            this.Controls.Add(this.Book_Image);
            this.Name = "Edit_BookStocks";
            this.Text = "Edit_BookStocks";
            this.Load += new System.EventHandler(this.Edit_BookStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Book_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Book_Image;
        private System.Windows.Forms.TextBox Stock_Quantity;
        private System.Windows.Forms.TextBox Desc_Report;
        private System.Windows.Forms.Label Bname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_Stock;
        private System.Windows.Forms.Button Min_Quantity;
        private System.Windows.Forms.TextBox Stock_edit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CloseBut;
    }
}