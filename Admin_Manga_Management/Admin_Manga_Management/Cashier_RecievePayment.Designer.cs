namespace Admin_Manga_Management
{
    partial class Cashier_RecievePayment
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
            this.CashR = new System.Windows.Forms.TextBox();
            this.Complete = new System.Windows.Forms.Button();
            this.corder = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TCost = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Label();
            this.ConPayment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CashR
            // 
            this.CashR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashR.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.CashR.Location = new System.Drawing.Point(76, 204);
            this.CashR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CashR.Name = "CashR";
            this.CashR.Size = new System.Drawing.Size(391, 23);
            this.CashR.TabIndex = 0;
            this.CashR.Text = "Insert Money Recieved";
            this.CashR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CashR.TextChanged += new System.EventHandler(this.CashR_TextChanged);
            // 
            // Complete
            // 
            this.Complete.Location = new System.Drawing.Point(222, 274);
            this.Complete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Complete.Name = "Complete";
            this.Complete.Size = new System.Drawing.Size(121, 31);
            this.Complete.TabIndex = 1;
            this.Complete.Text = "Complete Transaction";
            this.Complete.UseVisualStyleBackColor = true;
            this.Complete.Click += new System.EventHandler(this.Complete_Click);
            // 
            // corder
            // 
            this.corder.Location = new System.Drawing.Point(17, 10);
            this.corder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.corder.Name = "corder";
            this.corder.Size = new System.Drawing.Size(525, 164);
            this.corder.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(17, 179);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 8);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TCost
            // 
            this.TCost.AutoSize = true;
            this.TCost.Location = new System.Drawing.Point(473, 189);
            this.TCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TCost.Name = "TCost";
            this.TCost.Size = new System.Drawing.Size(0, 13);
            this.TCost.TabIndex = 4;
            this.TCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.Location = new System.Drawing.Point(473, 213);
            this.cash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(0, 13);
            this.cash.TabIndex = 5;
            this.cash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Location = new System.Drawing.Point(473, 240);
            this.change.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(0, 13);
            this.change.TabIndex = 6;
            this.change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConPayment
            // 
            this.ConPayment.Location = new System.Drawing.Point(222, 235);
            this.ConPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConPayment.Name = "ConPayment";
            this.ConPayment.Size = new System.Drawing.Size(121, 31);
            this.ConPayment.TabIndex = 7;
            this.ConPayment.Text = "Confirm Payment";
            this.ConPayment.UseVisualStyleBackColor = true;
            this.ConPayment.Click += new System.EventHandler(this.ConPayment_Click);
            // 
            // Cashier_RecievePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(560, 318);
            this.Controls.Add(this.ConPayment);
            this.Controls.Add(this.change);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.TCost);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.corder);
            this.Controls.Add(this.Complete);
            this.Controls.Add(this.CashR);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cashier_RecievePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier Kiosk";
            this.Load += new System.EventHandler(this.Cashier_RecievePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CashR;
        private System.Windows.Forms.Button Complete;
        private System.Windows.Forms.FlowLayoutPanel corder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TCost;
        private System.Windows.Forms.Label cash;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.Button ConPayment;
    }
}