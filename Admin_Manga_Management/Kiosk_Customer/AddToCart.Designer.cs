namespace Kiosk_Customer
{
    partial class AddToCart
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
            this.BookIm = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Bookn = new System.Windows.Forms.Label();
            this.Bookp = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookIm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BookIm
            // 
            this.BookIm.Location = new System.Drawing.Point(71, 20);
            this.BookIm.Name = "BookIm";
            this.BookIm.Size = new System.Drawing.Size(258, 237);
            this.BookIm.TabIndex = 0;
            this.BookIm.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(0, 353);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(402, 17);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Bookn
            // 
            this.Bookn.AutoSize = true;
            this.Bookn.Location = new System.Drawing.Point(67, 272);
            this.Bookn.Name = "Bookn";
            this.Bookn.Size = new System.Drawing.Size(51, 20);
            this.Bookn.TabIndex = 2;
            this.Bookn.Text = "label1";
            // 
            // Bookp
            // 
            this.Bookp.AutoSize = true;
            this.Bookp.Location = new System.Drawing.Point(278, 272);
            this.Bookp.Name = "Bookp";
            this.Bookp.Size = new System.Drawing.Size(51, 20);
            this.Bookp.TabIndex = 3;
            this.Bookp.Text = "label2";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(175, 318);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(51, 20);
            this.Quantity.TabIndex = 4;
            this.Quantity.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "MinQuan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "AddQuan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Bookp);
            this.Controls.Add(this.Bookn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BookIm);
            this.Name = "AddToCart";
            this.Size = new System.Drawing.Size(402, 370);
            ((System.ComponentModel.ISupportInitialize)(this.BookIm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Bookn;
        private System.Windows.Forms.Label Bookp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.PictureBox BookIm;
        public System.Windows.Forms.Label Quantity;
    }
}
