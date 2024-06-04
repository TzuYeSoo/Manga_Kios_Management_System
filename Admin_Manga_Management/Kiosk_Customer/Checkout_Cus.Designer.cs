namespace Kiosk_Customer
{
    partial class Checkout_Cus
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
            this.Cout_Book = new System.Windows.Forms.FlowLayoutPanel();
            this.AddMore = new System.Windows.Forms.Button();
            this.Checkout = new System.Windows.Forms.Button();
            this.Cust_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tprice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cout_Book
            // 
            this.Cout_Book.AutoScroll = true;
            this.Cout_Book.Location = new System.Drawing.Point(88, 36);
            this.Cout_Book.Name = "Cout_Book";
            this.Cout_Book.Size = new System.Drawing.Size(635, 305);
            this.Cout_Book.TabIndex = 0;
            // 
            // AddMore
            // 
            this.AddMore.Location = new System.Drawing.Point(12, 405);
            this.AddMore.Name = "AddMore";
            this.AddMore.Size = new System.Drawing.Size(93, 33);
            this.AddMore.TabIndex = 1;
            this.AddMore.Text = "Add More";
            this.AddMore.UseVisualStyleBackColor = true;
            // 
            // Checkout
            // 
            this.Checkout.Location = new System.Drawing.Point(695, 405);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(93, 33);
            this.Checkout.TabIndex = 2;
            this.Checkout.Text = "Checkout";
            this.Checkout.UseVisualStyleBackColor = true;
            this.Checkout.Click += new System.EventHandler(this.Checkout_Click);
            // 
            // Cust_name
            // 
            this.Cust_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cust_name.ForeColor = System.Drawing.Color.Gray;
            this.Cust_name.Location = new System.Drawing.Point(257, 386);
            this.Cust_name.Name = "Cust_name";
            this.Cust_name.Size = new System.Drawing.Size(262, 30);
            this.Cust_name.TabIndex = 3;
            this.Cust_name.Text = "Please input your name here";
            this.Cust_name.TextChanged += new System.EventHandler(this.Cust_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(240, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Price: ";
            // 
            // Tprice
            // 
            this.Tprice.AutoSize = true;
            this.Tprice.Location = new System.Drawing.Point(656, 354);
            this.Tprice.Name = "Tprice";
            this.Tprice.Size = new System.Drawing.Size(0, 20);
            this.Tprice.TabIndex = 6;
            // 
            // Checkout_Cus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cust_name);
            this.Controls.Add(this.Checkout);
            this.Controls.Add(this.AddMore);
            this.Controls.Add(this.Cout_Book);
            this.Controls.Add(this.label1);
            this.Name = "Checkout_Cus";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Checkout_Cus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Cout_Book;
        private System.Windows.Forms.Button AddMore;
        private System.Windows.Forms.Button Checkout;
        private System.Windows.Forms.TextBox Cust_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Tprice;
    }
}