namespace Admin_Manga_Management
{
    partial class Book_Report_Panel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Book_Name = new System.Windows.Forms.Label();
            this.Book_Quantity = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Date_Report = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Book_Name
            // 
            this.Book_Name.AutoSize = true;
            this.Book_Name.Location = new System.Drawing.Point(17, 16);
            this.Book_Name.Name = "Book_Name";
            this.Book_Name.Size = new System.Drawing.Size(93, 16);
            this.Book_Name.TabIndex = 0;
            this.Book_Name.Text = "<Book Name>";
            // 
            // Book_Quantity
            // 
            this.Book_Quantity.AutoSize = true;
            this.Book_Quantity.Location = new System.Drawing.Point(136, 16);
            this.Book_Quantity.Name = "Book_Quantity";
            this.Book_Quantity.Size = new System.Drawing.Size(69, 16);
            this.Book_Quantity.TabIndex = 1;
            this.Book_Quantity.Text = "<Quantity>";
            // 
            // Description
            // 
            this.Description.AllowDrop = true;
            this.Description.Location = new System.Drawing.Point(436, 16);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(341, 69);
            this.Description.TabIndex = 2;
            this.Description.Text = "<Description>";
            // 
            // Date_Report
            // 
            this.Date_Report.AutoSize = true;
            this.Date_Report.Location = new System.Drawing.Point(272, 16);
            this.Date_Report.Name = "Date_Report";
            this.Date_Report.Size = new System.Drawing.Size(50, 16);
            this.Date_Report.TabIndex = 3;
            this.Date_Report.Text = "<Date>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 17);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Book_Report_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Date_Report);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Book_Quantity);
            this.Controls.Add(this.Book_Name);
            this.Name = "Book_Report_Panel";
            this.Size = new System.Drawing.Size(780, 119);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label Date_Report;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label Book_Name;
        public System.Windows.Forms.Label Book_Quantity;
        public System.Windows.Forms.Label Description;
    }
}
