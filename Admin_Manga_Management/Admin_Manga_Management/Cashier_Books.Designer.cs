namespace Admin_Manga_Management
{
    partial class Cashier_Books
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Bname = new System.Windows.Forms.Label();
            this.Bprice = new System.Windows.Forms.Label();
            this.bookim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Price: ";
            // 
            // Bname
            // 
            this.Bname.AutoSize = true;
            this.Bname.Location = new System.Drawing.Point(129, 213);
            this.Bname.Name = "Bname";
            this.Bname.Size = new System.Drawing.Size(90, 16);
            this.Bname.TabIndex = 3;
            this.Bname.Text = "<Book name>";
            // 
            // Bprice
            // 
            this.Bprice.AutoSize = true;
            this.Bprice.Location = new System.Drawing.Point(129, 242);
            this.Bprice.Name = "Bprice";
            this.Bprice.Size = new System.Drawing.Size(86, 16);
            this.Bprice.TabIndex = 4;
            this.Bprice.Text = "<Book price>";
            // 
            // bookim
            // 
            this.bookim.Location = new System.Drawing.Point(44, 27);
            this.bookim.Name = "bookim";
            this.bookim.Size = new System.Drawing.Size(175, 172);
            this.bookim.TabIndex = 0;
            this.bookim.TabStop = false;
            // 
            // Cashier_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.Bprice);
            this.Controls.Add(this.Bname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookim);
            this.Name = "Cashier_Books";
            this.Size = new System.Drawing.Size(267, 282);
            ((System.ComponentModel.ISupportInitialize)(this.bookim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label Bname;
        public System.Windows.Forms.Label Bprice;
        public System.Windows.Forms.PictureBox bookim;
    }
}
