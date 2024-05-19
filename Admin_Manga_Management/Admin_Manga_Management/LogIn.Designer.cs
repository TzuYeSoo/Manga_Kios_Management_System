namespace Admin_Manga_Management
{
    partial class LogIn
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
            this.Admin_Username = new System.Windows.Forms.TextBox();
            this.Admin_Password = new System.Windows.Forms.TextBox();
            this.Log_but = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin_Username
            // 
            this.Admin_Username.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Username.Location = new System.Drawing.Point(238, 208);
            this.Admin_Username.Name = "Admin_Username";
            this.Admin_Username.Size = new System.Drawing.Size(259, 32);
            this.Admin_Username.TabIndex = 0;
            // 
            // Admin_Password
            // 
            this.Admin_Password.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Password.Location = new System.Drawing.Point(238, 262);
            this.Admin_Password.Name = "Admin_Password";
            this.Admin_Password.PasswordChar = '*';
            this.Admin_Password.Size = new System.Drawing.Size(259, 32);
            this.Admin_Password.TabIndex = 1;
            // 
            // Log_but
            // 
            this.Log_but.Location = new System.Drawing.Point(308, 315);
            this.Log_but.Name = "Log_but";
            this.Log_but.Size = new System.Drawing.Size(120, 30);
            this.Log_but.TabIndex = 2;
            this.Log_but.Text = "Sign In";
            this.Log_but.UseVisualStyleBackColor = true;
            this.Log_but.Click += new System.EventHandler(this.Log_but_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(238, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 150);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Log_but);
            this.Controls.Add(this.Admin_Password);
            this.Controls.Add(this.Admin_Username);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Admin_Username;
        private System.Windows.Forms.TextBox Admin_Password;
        private System.Windows.Forms.Button Log_but;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

