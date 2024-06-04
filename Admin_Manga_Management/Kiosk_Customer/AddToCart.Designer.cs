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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToCart));
            this.Bookn = new System.Windows.Forms.Label();
            this.Bookp = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BookIm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookIm)).BeginInit();
            this.SuspendLayout();
            // 
            // Bookn
            // 
            this.Bookn.AutoSize = true;
            this.Bookn.Location = new System.Drawing.Point(196, 302);
            this.Bookn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bookn.Name = "Bookn";
            this.Bookn.Size = new System.Drawing.Size(35, 13);
            this.Bookn.TabIndex = 2;
            this.Bookn.Text = "label1";
            // 
            // Bookp
            // 
            this.Bookp.AutoSize = true;
            this.Bookp.Location = new System.Drawing.Point(547, 302);
            this.Bookp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bookp.Name = "Bookp";
            this.Bookp.Size = new System.Drawing.Size(35, 13);
            this.Bookp.TabIndex = 3;
            this.Bookp.Text = "label2";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(500, 302);
            this.Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(35, 13);
            this.Quantity.TabIndex = 4;
            this.Quantity.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "MinQuan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(-2, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(744, 68);
            this.textBox1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Kiosk_Customer.Properties.Resources.back;
            this.button3.Image = global::Kiosk_Customer.Properties.Resources.back;
            this.button3.Location = new System.Drawing.Point(20, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 29);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(608, 306);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 27);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(106, 326);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(485, 22);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BookIm
            // 
            this.BookIm.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BookIm.Location = new System.Drawing.Point(108, 90);
            this.BookIm.Margin = new System.Windows.Forms.Padding(2);
            this.BookIm.Name = "BookIm";
            this.BookIm.Size = new System.Drawing.Size(466, 195);
            this.BookIm.TabIndex = 0;
            this.BookIm.TabStop = false;
            // 
            // AddToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Bookp);
            this.Controls.Add(this.Bookn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BookIm);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddToCart";
            this.Size = new System.Drawing.Size(727, 360);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookIm)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}
