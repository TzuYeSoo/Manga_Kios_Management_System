namespace Admin_Manga_Management
{
    partial class Cahsier_kios_Cus
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
            this.CustPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Kios_Cus = new System.Windows.Forms.Button();
            this.Walkin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PayOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.Payment = new System.Windows.Forms.Button();
            this.tcost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustPanel
            // 
            this.CustPanel.AutoScroll = true;
            this.CustPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CustPanel.Location = new System.Drawing.Point(899, 96);
            this.CustPanel.Name = "CustPanel";
            this.CustPanel.Size = new System.Drawing.Size(601, 450);
            this.CustPanel.TabIndex = 0;
            // 
            // Kios_Cus
            // 
            this.Kios_Cus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kios_Cus.Location = new System.Drawing.Point(0, 120);
            this.Kios_Cus.Name = "Kios_Cus";
            this.Kios_Cus.Size = new System.Drawing.Size(291, 44);
            this.Kios_Cus.TabIndex = 8;
            this.Kios_Cus.Text = "Self-Service Customer";
            this.Kios_Cus.UseVisualStyleBackColor = true;
            // 
            // Walkin
            // 
            this.Walkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Walkin.Location = new System.Drawing.Point(1, 40);
            this.Walkin.Name = "Walkin";
            this.Walkin.Size = new System.Drawing.Size(291, 44);
            this.Walkin.TabIndex = 7;
            this.Walkin.Text = "WALK IN";
            this.Walkin.UseVisualStyleBackColor = true;
            this.Walkin.Click += new System.EventHandler(this.Walkin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 692);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "Self-Service Customer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 44);
            this.button2.TabIndex = 17;
            this.button2.Text = "Log out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PayOrder
            // 
            this.PayOrder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PayOrder.Location = new System.Drawing.Point(299, 96);
            this.PayOrder.Name = "PayOrder";
            this.PayOrder.Size = new System.Drawing.Size(594, 316);
            this.PayOrder.TabIndex = 18;
            // 
            // Payment
            // 
            this.Payment.BackColor = System.Drawing.Color.IndianRed;
            this.Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment.Location = new System.Drawing.Point(299, 463);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(594, 83);
            this.Payment.TabIndex = 10;
            this.Payment.Text = "Payment";
            this.Payment.UseVisualStyleBackColor = false;
            this.Payment.Click += new System.EventHandler(this.Payment_Click);
            // 
            // tcost
            // 
            this.tcost.AutoSize = true;
            this.tcost.Location = new System.Drawing.Point(765, 427);
            this.tcost.Name = "tcost";
            this.tcost.Size = new System.Drawing.Size(101, 20);
            this.tcost.TabIndex = 19;
            this.tcost.Text = "<Total Price>";
            // 
            // Cahsier_kios_Cus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1444, 568);
            this.Controls.Add(this.tcost);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.PayOrder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Kios_Cus);
            this.Controls.Add(this.Walkin);
            this.Controls.Add(this.CustPanel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Cahsier_kios_Cus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier Kiosk";
            this.Load += new System.EventHandler(this.Cahsier_kios_Cus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Kios_Cus;
        private System.Windows.Forms.Button Walkin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel PayOrder;
        private System.Windows.Forms.Button Payment;
        private System.Windows.Forms.Label tcost;
        public System.Windows.Forms.FlowLayoutPanel CustPanel;
    }
}