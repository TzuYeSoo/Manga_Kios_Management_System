namespace Kiosk_Customer
{
    partial class Customer_Number
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Quan = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Bname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ord_num = new System.Windows.Forms.Label();
            this.tcost = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 87);
            this.label3.TabIndex = 12;
            this.label3.Text = "    EIWA STORE \r\nTHANK YOU FOR \r\n     SHOPPING";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "------------------------------------------------------------------------------";
            // 
            // Quan
            // 
            this.Quan.AutoSize = true;
            this.Quan.Location = new System.Drawing.Point(183, 149);
            this.Quan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quan.Name = "Quan";
            this.Quan.Size = new System.Drawing.Size(86, 20);
            this.Quan.TabIndex = 16;
            this.Quan.Text = "<Quantity>";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(279, 149);
            this.Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(62, 20);
            this.Price.TabIndex = 15;
            this.Price.Text = "<Price>";
            // 
            // Bname
            // 
            this.Bname.AutoSize = true;
            this.Bname.Location = new System.Drawing.Point(20, 149);
            this.Bname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bname.Name = "Bname";
            this.Bname.Size = new System.Drawing.Size(110, 20);
            this.Bname.TabIndex = 14;
            this.Bname.Text = "<Book Name>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 397);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "------------------------------------------------------------------------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-22, 357);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(399, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "------------------------------------------------------------------------------";
            // 
            // ord_num
            // 
            this.ord_num.AutoSize = true;
            this.ord_num.Location = new System.Drawing.Point(116, 436);
            this.ord_num.Name = "ord_num";
            this.ord_num.Size = new System.Drawing.Size(127, 20);
            this.ord_num.TabIndex = 19;
            this.ord_num.Text = "<Order Number>";
            // 
            // tcost
            // 
            this.tcost.AutoSize = true;
            this.tcost.Location = new System.Drawing.Point(240, 377);
            this.tcost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tcost.Name = "tcost";
            this.tcost.Size = new System.Drawing.Size(101, 20);
            this.tcost.TabIndex = 20;
            this.tcost.Text = "<Total Price>";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Customer_Number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tcost);
            this.Controls.Add(this.ord_num);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quan);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Bname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Customer_Number";
            this.Text = "Kiosk";
            this.Load += new System.EventHandler(this.Customer_Number_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label Quan;
        public System.Windows.Forms.Label Price;
        public System.Windows.Forms.Label Bname;
        public System.Windows.Forms.Label tcost;
        public System.Windows.Forms.Label ord_num;
    }
}