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
            this.CustPanel.Location = new System.Drawing.Point(0, 108);
            this.CustPanel.Name = "CustPanel";
            this.CustPanel.Size = new System.Drawing.Size(1094, 344);
            this.CustPanel.TabIndex = 0;
            // 
            // Kios_Cus
            // 
            this.Kios_Cus.Location = new System.Drawing.Point(530, 0);
            this.Kios_Cus.Name = "Kios_Cus";
            this.Kios_Cus.Size = new System.Drawing.Size(563, 73);
            this.Kios_Cus.TabIndex = 8;
            this.Kios_Cus.Text = "Self_Service Customer";
            this.Kios_Cus.UseVisualStyleBackColor = true;
            // 
            // Walkin
            // 
            this.Walkin.Location = new System.Drawing.Point(2, 0);
            this.Walkin.Name = "Walkin";
            this.Walkin.Size = new System.Drawing.Size(530, 73);
            this.Walkin.TabIndex = 7;
            this.Walkin.Text = "Line Customers";
            this.Walkin.UseVisualStyleBackColor = true;
            // 
            // Cahsier_kios_Cus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 450);
            this.Controls.Add(this.Kios_Cus);
            this.Controls.Add(this.Walkin);
            this.Controls.Add(this.CustPanel);
            this.Name = "Cahsier_kios_Cus";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Cahsier_kios_Cus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CustPanel;
        private System.Windows.Forms.Button Kios_Cus;
        private System.Windows.Forms.Button Walkin;
    }
}