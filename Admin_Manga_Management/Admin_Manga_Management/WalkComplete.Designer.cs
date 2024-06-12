namespace Admin_Manga_Management
{
    partial class WalkComplete
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
            this.ConPayment = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.Label();
            this.TCost = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Complete = new System.Windows.Forms.Button();
            this.CashR = new System.Windows.Forms.TextBox();
            this.Bookname = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConPayment
            // 
            this.ConPayment.Location = new System.Drawing.Point(333, 364);
            this.ConPayment.Name = "ConPayment";
            this.ConPayment.Size = new System.Drawing.Size(182, 48);
            this.ConPayment.TabIndex = 15;
            this.ConPayment.Text = "Confirm Payment";
            this.ConPayment.UseVisualStyleBackColor = true;
            this.ConPayment.Click += new System.EventHandler(this.ConPayment_Click);
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Location = new System.Drawing.Point(710, 371);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(0, 20);
            this.change.TabIndex = 14;
            this.change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.Location = new System.Drawing.Point(710, 330);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(0, 20);
            this.cash.TabIndex = 13;
            this.cash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TCost
            // 
            this.TCost.AutoSize = true;
            this.TCost.Location = new System.Drawing.Point(710, 293);
            this.TCost.Name = "TCost";
            this.TCost.Size = new System.Drawing.Size(0, 20);
            this.TCost.TabIndex = 12;
            this.TCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(26, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 12);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Complete
            // 
            this.Complete.Location = new System.Drawing.Point(333, 424);
            this.Complete.Name = "Complete";
            this.Complete.Size = new System.Drawing.Size(182, 48);
            this.Complete.TabIndex = 9;
            this.Complete.Text = "Complete Transaction";
            this.Complete.UseVisualStyleBackColor = true;
            this.Complete.Click += new System.EventHandler(this.Complete_Click);
            // 
            // CashR
            // 
            this.CashR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CashR.Location = new System.Drawing.Point(114, 316);
            this.CashR.Name = "CashR";
            this.CashR.Size = new System.Drawing.Size(584, 31);
            this.CashR.TabIndex = 8;
            this.CashR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CashR.TextChanged += new System.EventHandler(this.CashR_TextChanged);
            // 
            // Bookname
            // 
            this.Bookname.AutoSize = true;
            this.Bookname.Location = new System.Drawing.Point(22, 25);
            this.Bookname.Name = "Bookname";
            this.Bookname.Size = new System.Drawing.Size(110, 20);
            this.Bookname.TabIndex = 16;
            this.Bookname.Text = "<Book Name>";
            this.Bookname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(598, 25);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(86, 20);
            this.Quantity.TabIndex = 17;
            this.Quantity.Text = "<Quantity>";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(710, 25);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(103, 20);
            this.Price.TabIndex = 18;
            this.Price.Text = "<Book Price>";
            // 
            // WalkComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 489);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Bookname);
            this.Controls.Add(this.ConPayment);
            this.Controls.Add(this.change);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.TCost);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Complete);
            this.Controls.Add(this.CashR);
            this.Name = "WalkComplete";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.WalkComplete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConPayment;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.Label cash;
        private System.Windows.Forms.Label TCost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Complete;
        private System.Windows.Forms.TextBox CashR;
        private System.Windows.Forms.Label Bookname;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label Price;
    }
}