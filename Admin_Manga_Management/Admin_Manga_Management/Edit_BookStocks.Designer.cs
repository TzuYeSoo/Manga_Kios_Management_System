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
            this.Stock_Quantity.Location = new System.Drawing.Point(267, 76);
            this.Stock_Quantity.Margin = new System.Windows.Forms.Padding(2);
            this.Stock_Quantity.Name = "Stock_Quantity";
            this.Stock_Quantity.Size = new System.Drawing.Size(76, 20);
            this.Stock_Quantity.TabIndex = 2;
            // 
            // Desc_Report
            // 
            this.Desc_Report.Location = new System.Drawing.Point(267, 119);
            this.Desc_Report.Margin = new System.Windows.Forms.Padding(2);
            this.Desc_Report.Multiline = true;
            this.Desc_Report.Name = "Desc_Report";
            this.Desc_Report.Size = new System.Drawing.Size(320, 76);
            this.Desc_Report.TabIndex = 4;
            // 
            // Bname
            // 
            this.Bname.AutoSize = true;
            this.Bname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Bname.Location = new System.Drawing.Point(100, 214);
            this.Bname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bname.Name = "Bname";
            this.Bname.Size = new System.Drawing.Size(86, 15);
            this.Bname.TabIndex = 5;
            this.Bname.Text = "<Book Name>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Existing Quantity";
            // 
            // Add_Stock
            // 
            this.Add_Stock.BackColor = System.Drawing.Color.Yellow;
            this.Add_Stock.Location = new System.Drawing.Point(267, 208);
            this.Add_Stock.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Stock.Name = "Add_Stock";
            this.Add_Stock.Size = new System.Drawing.Size(67, 23);
            this.Add_Stock.TabIndex = 8;
            this.Add_Stock.Text = "Add";
            this.Add_Stock.UseVisualStyleBackColor = false;
            this.Add_Stock.Click += new System.EventHandler(this.Add_Stock_Click);
            // 
            // Min_Quantity
            // 
            this.Min_Quantity.BackColor = System.Drawing.Color.IndianRed;
            this.Min_Quantity.Location = new System.Drawing.Point(344, 208);
            this.Min_Quantity.Margin = new System.Windows.Forms.Padding(2);
            this.Min_Quantity.Name = "Min_Quantity";
            this.Min_Quantity.Size = new System.Drawing.Size(55, 23);
            this.Min_Quantity.TabIndex = 9;
            this.Min_Quantity.Text = "Remove";
            this.Min_Quantity.UseVisualStyleBackColor = false;
            this.Min_Quantity.Click += new System.EventHandler(this.Min_Quantity_Click);
            // 
            // Stock_edit
            // 
            this.Stock_edit.Location = new System.Drawing.Point(377, 76);
            this.Stock_edit.Margin = new System.Windows.Forms.Padding(2);
            this.Stock_edit.Name = "Stock_edit";
            this.Stock_edit.Size = new System.Drawing.Size(76, 20);
            this.Stock_edit.TabIndex = 10;
            this.Stock_edit.TextChanged += new System.EventHandler(this.Stock_edit_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantity";
            // 
            // CloseBut
            // 
            this.CloseBut.Location = new System.Drawing.Point(535, 10);
            this.CloseBut.Margin = new System.Windows.Forms.Padding(2);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(56, 19);
            this.CloseBut.TabIndex = 12;
            this.CloseBut.Text = "Close";
            this.CloseBut.UseVisualStyleBackColor = true;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // Book_Image
            // 
            this.Book_Image.Location = new System.Drawing.Point(48, 10);
            this.Book_Image.Margin = new System.Windows.Forms.Padding(2);
            this.Book_Image.Name = "Book_Image";
            this.Book_Image.Size = new System.Drawing.Size(193, 184);
            this.Book_Image.TabIndex = 0;
            this.Book_Image.TabStop = false;
            // 
            // Edit_BookStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(600, 258);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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