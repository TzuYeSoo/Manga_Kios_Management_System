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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CusN
            // 
            this.CusN.AutoSize = true;
            this.CusN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusN.Location = new System.Drawing.Point(15, 30);
            this.CusN.Name = "CusN";
            this.CusN.Size = new System.Drawing.Size(165, 25);
            this.CusN.TabIndex = 0;
            this.CusN.Text = "Customer Name: ";
            // 
            // CustName
            // 
            this.CustName.AutoSize = true;
            this.CustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustName.Location = new System.Drawing.Point(201, 30);
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(88, 25);
            this.CustName.TabIndex = 1;
            this.CustName.Text = "<Name>";
            // 
            // OrdNumber
            // 
            this.OrdNumber.AutoSize = true;
            this.OrdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdNumber.Location = new System.Drawing.Point(362, 30);
            this.OrdNumber.Name = "OrdNumber";
            this.OrdNumber.Size = new System.Drawing.Size(160, 25);
            this.OrdNumber.TabIndex = 2;
            this.OrdNumber.Text = "<Order Number>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(0, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(541, 12);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CustIDlabel
            // 
            this.CustIDlabel.AutoSize = true;
            this.CustIDlabel.Location = new System.Drawing.Point(16, 10);
            this.CustIDlabel.Name = "CustIDlabel";
            this.CustIDlabel.Size = new System.Drawing.Size(49, 20);
            this.CustIDlabel.TabIndex = 4;
            this.CustIDlabel.Text = "Cusid";
            this.CustIDlabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "BID";
            this.label1.Visible = false;
            // 
            // Chasier_KiosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustIDlabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OrdNumber);
            this.Controls.Add(this.CustName);
            this.Controls.Add(this.CusN);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Chasier_KiosControl";
            this.Size = new System.Drawing.Size(541, 89);
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
        public System.Windows.Forms.Label label1;
    }
}
