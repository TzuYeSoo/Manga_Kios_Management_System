namespace Admin_Manga_Management
{
    partial class Cashier_StockView
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Kios_Cus = new System.Windows.Forms.Button();
            this.Walkin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(-3, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 44);
            this.button2.TabIndex = 23;
            this.button2.Text = "Log out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-3, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 44);
            this.button1.TabIndex = 22;
            this.button1.Text = "Stocks";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Kios_Cus
            // 
            this.Kios_Cus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kios_Cus.Location = new System.Drawing.Point(-3, 118);
            this.Kios_Cus.Name = "Kios_Cus";
            this.Kios_Cus.Size = new System.Drawing.Size(291, 44);
            this.Kios_Cus.TabIndex = 20;
            this.Kios_Cus.Text = "Self-Service Customer";
            this.Kios_Cus.UseVisualStyleBackColor = true;
            this.Kios_Cus.Click += new System.EventHandler(this.Kios_Cus_Click);
            // 
            // Walkin
            // 
            this.Walkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Walkin.Location = new System.Drawing.Point(-2, 38);
            this.Walkin.Name = "Walkin";
            this.Walkin.Size = new System.Drawing.Size(291, 44);
            this.Walkin.TabIndex = 19;
            this.Walkin.Text = "WALK IN";
            this.Walkin.UseVisualStyleBackColor = true;
            this.Walkin.Click += new System.EventHandler(this.Walkin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 692);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(348, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(716, 375);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(348, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 26);
            this.textBox1.TabIndex = 25;
            // 
            // Cashier_StockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 456);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Kios_Cus);
            this.Controls.Add(this.Walkin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Cashier_StockView";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Kios_Cus;
        private System.Windows.Forms.Button Walkin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}