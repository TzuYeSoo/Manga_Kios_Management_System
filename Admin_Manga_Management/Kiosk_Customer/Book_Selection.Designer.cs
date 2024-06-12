namespace Kiosk_Customer
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
            this.Books = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CartItem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Category_Bar_Des = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Books
            // 
            this.Books.AutoScroll = true;
            this.Books.BackColor = System.Drawing.Color.Transparent;
            this.Books.Location = new System.Drawing.Point(199, 109);
            this.Books.Margin = new System.Windows.Forms.Padding(2);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(681, 255);
            this.Books.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(919, 59);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CartItem
            // 
            this.CartItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CartItem.BackgroundImage")));
            this.CartItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CartItem.Location = new System.Drawing.Point(838, 14);
            this.CartItem.Margin = new System.Windows.Forms.Padding(2);
            this.CartItem.Name = "CartItem";
            this.CartItem.Size = new System.Drawing.Size(38, 32);
            this.CartItem.TabIndex = 2;
            this.CartItem.UseVisualStyleBackColor = true;
            this.CartItem.Click += new System.EventHandler(this.CartItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(502, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Category_Bar_Des
            // 
            this.Category_Bar_Des.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Category_Bar_Des.Location = new System.Drawing.Point(8, 109);
            this.Category_Bar_Des.Margin = new System.Windows.Forms.Padding(2);
            this.Category_Bar_Des.Name = "Category_Bar_Des";
            this.Category_Bar_Des.Size = new System.Drawing.Size(171, 255);
            this.Category_Bar_Des.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 405);
            this.Controls.Add(this.Category_Bar_Des);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CartItem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Books);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EIWA MANGA STORE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Books;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button CartItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel Category_Bar_Des;
    }
}