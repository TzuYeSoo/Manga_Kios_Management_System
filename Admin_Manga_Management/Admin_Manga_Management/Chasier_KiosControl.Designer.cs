namespace Admin_Manga_Management
{
    partial class Chasier_KiosControl
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
            this.CusN = new System.Windows.Forms.Label();
            this.CustName = new System.Windows.Forms.Label();
            this.OrdNumber = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CustIDlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CusN
            // 
            this.CusN.AutoSize = true;
            this.CusN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusN.Location = new System.Drawing.Point(13, 24);
            this.CusN.Name = "CusN";
            this.CusN.Size = new System.Drawing.Size(212, 29);
            this.CusN.TabIndex = 0;
            this.CusN.Text = "Customer Name: ";
            // 
            // CustName
            // 
            this.CustName.AutoSize = true;
            this.CustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustName.Location = new System.Drawing.Point(231, 24);
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(111, 29);
            this.CustName.TabIndex = 1;
            this.CustName.Text = "<Name>";
            // 
            // OrdNumber
            // 
            this.OrdNumber.AutoSize = true;
            this.OrdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdNumber.Location = new System.Drawing.Point(466, 24);
            this.OrdNumber.Name = "OrdNumber";
            this.OrdNumber.Size = new System.Drawing.Size(203, 29);
            this.OrdNumber.TabIndex = 2;
            this.OrdNumber.Text = "<Order Number>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(0, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1094, 14);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CustIDlabel
            // 
            this.CustIDlabel.AutoSize = true;
            this.CustIDlabel.Location = new System.Drawing.Point(718, 48);
            this.CustIDlabel.Name = "CustIDlabel";
            this.CustIDlabel.Size = new System.Drawing.Size(41, 16);
            this.CustIDlabel.TabIndex = 4;
            this.CustIDlabel.Text = "Cusid";
            this.CustIDlabel.Visible = false;
            // 
            // Chasier_KiosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustIDlabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OrdNumber);
            this.Controls.Add(this.CustName);
            this.Controls.Add(this.CusN);
            this.Name = "Chasier_KiosControl";
            this.Size = new System.Drawing.Size(1094, 84);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CusN;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label CustName;
        public System.Windows.Forms.Label OrdNumber;
        public System.Windows.Forms.Label CustIDlabel;
    }
}
