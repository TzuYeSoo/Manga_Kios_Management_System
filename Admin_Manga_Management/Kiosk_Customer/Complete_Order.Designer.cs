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
            this.COrder.Location = new System.Drawing.Point(75, 124);
            this.COrder.Name = "COrder";
            this.COrder.Size = new System.Drawing.Size(223, 30);
            this.COrder.TabIndex = 0;
            this.COrder.Text = "Complete";
            this.COrder.UseVisualStyleBackColor = true;
            this.COrder.Click += new System.EventHandler(this.COrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(75, 96);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(223, 22);
            this.Name.TabIndex = 2;
            // 
            // Complete_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 196);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.COrder);
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