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
            this.SuspendLayout();
            // 
            // CustPanel
            // 
            this.CustPanel.AutoScroll = true;
            this.CustPanel.Location = new System.Drawing.Point(0, 88);
            this.CustPanel.Margin = new System.Windows.Forms.Padding(2);
            this.CustPanel.Name = "CustPanel";
            this.CustPanel.Size = new System.Drawing.Size(820, 280);
            this.CustPanel.TabIndex = 0;
            this.CustPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CustPanel_Paint);
            // 
            // Kios_Cus
            // 
            this.Kios_Cus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kios_Cus.Location = new System.Drawing.Point(398, 0);
            this.Kios_Cus.Margin = new System.Windows.Forms.Padding(2);
            this.Kios_Cus.Name = "Kios_Cus";
            this.Kios_Cus.Size = new System.Drawing.Size(422, 59);
            this.Kios_Cus.TabIndex = 8;
            this.Kios_Cus.Text = "Self-Service Customer";
            this.Kios_Cus.UseVisualStyleBackColor = true;
            this.Kios_Cus.Click += new System.EventHandler(this.Kios_Cus_Click);
            // 
            // Walkin
            // 
            this.Walkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Walkin.Location = new System.Drawing.Point(2, 0);
            this.Walkin.Margin = new System.Windows.Forms.Padding(2);
            this.Walkin.Name = "Walkin";
            this.Walkin.Size = new System.Drawing.Size(398, 59);
            this.Walkin.TabIndex = 7;
            this.Walkin.Text = "WALK IN";
            this.Walkin.UseVisualStyleBackColor = true;
            this.Walkin.Click += new System.EventHandler(this.Walkin_Click);
            // 
            // Cahsier_kios_Cus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(820, 366);
            this.Controls.Add(this.Kios_Cus);
            this.Controls.Add(this.Walkin);
            this.Controls.Add(this.CustPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cahsier_kios_Cus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier Kiosk";
            this.Load += new System.EventHandler(this.Cahsier_kios_Cus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CustPanel;
        private System.Windows.Forms.Button Kios_Cus;
        private System.Windows.Forms.Button Walkin;
    }
}