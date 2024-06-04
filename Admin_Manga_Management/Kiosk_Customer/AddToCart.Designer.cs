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
            this.Add_button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BookIm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookIm)).BeginInit();
            this.SuspendLayout();
            // 
            // Bookn
            // 
            this.Bookn.AutoSize = true;
            this.Bookn.Location = new System.Drawing.Point(261, 372);
            this.Bookn.Name = "Bookn";
            this.Bookn.Size = new System.Drawing.Size(44, 16);
            this.Bookn.TabIndex = 2;
            this.Bookn.Text = "label1";
            // 
            // Bookp
            // 
            this.Bookp.AutoSize = true;
            this.Bookp.Location = new System.Drawing.Point(729, 372);
            this.Bookp.Name = "Bookp";
            this.Bookp.Size = new System.Drawing.Size(44, 16);
            this.Bookp.TabIndex = 3;
            this.Bookp.Text = "label2";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(667, 372);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(44, 16);
            this.Quantity.TabIndex = 4;
            this.Quantity.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 363);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "MinQuan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(-3, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(991, 83);
            this.textBox1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Kiosk_Customer.Properties.Resources.back;
            this.button3.Image = global::Kiosk_Customer.Properties.Resources.back;
            this.button3.Location = new System.Drawing.Point(27, 20);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Add_button
            // 
            this.Add_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_button.BackgroundImage")));
            this.Add_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add_button.Location = new System.Drawing.Point(215, 356);
            this.Add_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(40, 40);
            this.Add_button.TabIndex = 6;
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(141, 401);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(647, 27);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BookIm
            // 
            this.BookIm.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BookIm.Location = new System.Drawing.Point(144, 111);
            this.BookIm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookIm.Name = "BookIm";
            this.BookIm.Size = new System.Drawing.Size(621, 240);
            this.BookIm.TabIndex = 0;
            this.BookIm.TabStop = false;
            // 
            // AddToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Bookp);
            this.Controls.Add(this.Bookn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BookIm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddToCart";
            this.Size = new System.Drawing.Size(969, 443);
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
        private System.Windows.Forms.Button Add_button;
        public System.Windows.Forms.PictureBox BookIm;
        public System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}
