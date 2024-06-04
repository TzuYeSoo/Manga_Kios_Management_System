namespace Kiosk_Customer
{
    partial class Cart_Control
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
            this.RCart = new System.Windows.Forms.Button();
            this.Min_Quan = new System.Windows.Forms.Button();
            this.Add_Quan = new System.Windows.Forms.Button();
            this.Quans = new System.Windows.Forms.Label();
            this.Book_Im = new System.Windows.Forms.PictureBox();
            this.Bname = new System.Windows.Forms.Label();
            this.Bprice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Im)).BeginInit();
            this.SuspendLayout();
            // 
            // RCart
            // 
            this.RCart.Location = new System.Drawing.Point(3, 305);
            this.RCart.Name = "RCart";
            this.RCart.Size = new System.Drawing.Size(84, 31);
            this.RCart.TabIndex = 0;
            this.RCart.Text = "Remove";
            this.RCart.UseVisualStyleBackColor = true;
            // 
            // Min_Quan
            // 
            this.Min_Quan.Location = new System.Drawing.Point(102, 303);
            this.Min_Quan.Name = "Min_Quan";
            this.Min_Quan.Size = new System.Drawing.Size(75, 31);
            this.Min_Quan.TabIndex = 1;
            this.Min_Quan.Text = "Minus";
            this.Min_Quan.UseVisualStyleBackColor = true;
            this.Min_Quan.Click += new System.EventHandler(this.Min_Quan_Click);
            // 
            // Add_Quan
            // 
            this.Add_Quan.Location = new System.Drawing.Point(228, 305);
            this.Add_Quan.Name = "Add_Quan";
            this.Add_Quan.Size = new System.Drawing.Size(90, 31);
            this.Add_Quan.TabIndex = 2;
            this.Add_Quan.Text = "Add";
            this.Add_Quan.UseVisualStyleBackColor = true;
            this.Add_Quan.Click += new System.EventHandler(this.Add_Quan_Click);
            // 
            // Quans
            // 
            this.Quans.AutoSize = true;
            this.Quans.Location = new System.Drawing.Point(183, 314);
            this.Quans.Name = "Quans";
            this.Quans.Size = new System.Drawing.Size(0, 20);
            this.Quans.TabIndex = 3;
            // 
            // Book_Im
            // 
            this.Book_Im.Location = new System.Drawing.Point(44, 38);
            this.Book_Im.Name = "Book_Im";
            this.Book_Im.Size = new System.Drawing.Size(251, 179);
            this.Book_Im.TabIndex = 4;
            this.Book_Im.TabStop = false;
            // 
            // Bname
            // 
            this.Bname.AutoSize = true;
            this.Bname.Location = new System.Drawing.Point(134, 232);
            this.Bname.Name = "Bname";
            this.Bname.Size = new System.Drawing.Size(92, 20);
            this.Bname.TabIndex = 5;
            this.Bname.Text = "Book Name";
            // 
            // Bprice
            // 
            this.Bprice.AutoSize = true;
            this.Bprice.Location = new System.Drawing.Point(134, 269);
            this.Bprice.Name = "Bprice";
            this.Bprice.Size = new System.Drawing.Size(85, 20);
            this.Bprice.TabIndex = 6;
            this.Bprice.Text = "Book Price";
            // 
            // Cart_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Bprice);
            this.Controls.Add(this.Bname);
            this.Controls.Add(this.Book_Im);
            this.Controls.Add(this.Quans);
            this.Controls.Add(this.Add_Quan);
            this.Controls.Add(this.Min_Quan);
            this.Controls.Add(this.RCart);
            this.Name = "Cart_Control";
            this.Size = new System.Drawing.Size(352, 365);
            ((System.ComponentModel.ISupportInitialize)(this.Book_Im)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RCart;
        private System.Windows.Forms.Button Min_Quan;
        private System.Windows.Forms.Button Add_Quan;
        public System.Windows.Forms.Label Quans;
        public System.Windows.Forms.Label Bname;
        public System.Windows.Forms.Label Bprice;
        public System.Windows.Forms.PictureBox Book_Im;
    }
}
