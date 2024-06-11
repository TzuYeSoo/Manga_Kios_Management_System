namespace Kiosk_Customer
{
    partial class Complete_Order
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
            this.COrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // COrder
            // 
            this.COrder.Location = new System.Drawing.Point(56, 101);
            this.COrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.COrder.Name = "COrder";
            this.COrder.Size = new System.Drawing.Size(167, 24);
            this.COrder.TabIndex = 0;
            this.COrder.Text = "Complete";
            this.COrder.UseVisualStyleBackColor = true;
            this.COrder.Click += new System.EventHandler(this.COrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(56, 78);
            this.Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(168, 20);
            this.Name.TabIndex = 2;
            // 
            // Complete_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(294, 159);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.COrder);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complete Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button COrder;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Name;
    }
}