namespace Admin_Manga_Management
{
    partial class Cashier_CompleteOrder
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
            this.BookName = new System.Windows.Forms.Label();
            this.OrdNum = new System.Windows.Forms.Label();
            this.BookQuan = new System.Windows.Forms.Label();
            this.BookPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BookName.Location = new System.Drawing.Point(23, 17);
            this.BookName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(86, 15);
            this.BookName.TabIndex = 0;
            this.BookName.Text = "<Book Name>";
            this.BookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrdNum
            // 
            this.OrdNum.AutoSize = true;
            this.OrdNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.OrdNum.Location = new System.Drawing.Point(140, 17);
            this.OrdNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrdNum.Name = "OrdNum";
            this.OrdNum.Size = new System.Drawing.Size(100, 15);
            this.OrdNum.TabIndex = 1;
            this.OrdNum.Text = "<Order Number>";
            this.OrdNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookQuan
            // 
            this.BookQuan.AutoSize = true;
            this.BookQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BookQuan.Location = new System.Drawing.Point(293, 17);
            this.BookQuan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookQuan.Name = "BookQuan";
            this.BookQuan.Size = new System.Drawing.Size(96, 15);
            this.BookQuan.TabIndex = 2;
            this.BookQuan.Text = "<Book Quantity>";
            this.BookQuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookPrice
            // 
            this.BookPrice.AutoSize = true;
            this.BookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BookPrice.Location = new System.Drawing.Point(390, 17);
            this.BookPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.Size = new System.Drawing.Size(80, 15);
            this.BookPrice.TabIndex = 3;
            this.BookPrice.Text = "<Book Price>";
            this.BookPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cashier_CompleteOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.BookPrice);
            this.Controls.Add(this.BookQuan);
            this.Controls.Add(this.OrdNum);
            this.Controls.Add(this.BookName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cashier_CompleteOrder";
            this.Size = new System.Drawing.Size(479, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label BookName;
        public System.Windows.Forms.Label OrdNum;
        public System.Windows.Forms.Label BookQuan;
        public System.Windows.Forms.Label BookPrice;
    }
}
