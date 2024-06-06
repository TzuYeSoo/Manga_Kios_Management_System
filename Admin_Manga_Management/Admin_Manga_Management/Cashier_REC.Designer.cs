namespace Admin_Manga_Management
{
    partial class Cashier_REC
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tcost = new System.Windows.Forms.Label();
            this.Cash = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Label();
            this.Bname = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Quan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(12, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 10);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payment";
            // 
            // Tcost
            // 
            this.Tcost.AutoSize = true;
            this.Tcost.Location = new System.Drawing.Point(157, 252);
            this.Tcost.Name = "Tcost";
            this.Tcost.Size = new System.Drawing.Size(67, 13);
            this.Tcost.TabIndex = 3;
            this.Tcost.Text = "<Total Cost>";
            this.Tcost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cash
            // 
            this.Cash.AutoSize = true;
            this.Cash.Location = new System.Drawing.Point(181, 281);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(43, 13);
            this.Cash.TabIndex = 4;
            this.Cash.Text = "<Cash>";
            this.Cash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Change";
            // 
            // Change
            // 
            this.Change.AutoSize = true;
            this.Change.Location = new System.Drawing.Point(168, 315);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(56, 13);
            this.Change.TabIndex = 6;
            this.Change.Text = "<Change>";
            this.Change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bname
            // 
            this.Bname.AutoSize = true;
            this.Bname.Location = new System.Drawing.Point(13, 13);
            this.Bname.Name = "Bname";
            this.Bname.Size = new System.Drawing.Size(75, 13);
            this.Bname.TabIndex = 7;
            this.Bname.Text = "<Book Name>";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(189, 13);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(43, 13);
            this.Price.TabIndex = 8;
            this.Price.Text = "<Price>";
            // 
            // Quan
            // 
            this.Quan.AutoSize = true;
            this.Quan.Location = new System.Drawing.Point(125, 13);
            this.Quan.Name = "Quan";
            this.Quan.Size = new System.Drawing.Size(58, 13);
            this.Quan.TabIndex = 9;
            this.Quan.Text = "<Quantity>";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Complete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cashier_REC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Quan);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Bname);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cash);
            this.Controls.Add(this.Tcost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Cashier_REC";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Bname;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Quan;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label Tcost;
        public System.Windows.Forms.Label Cash;
        public System.Windows.Forms.Label Change;
    }
}