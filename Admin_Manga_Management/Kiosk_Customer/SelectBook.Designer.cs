namespace Kiosk_Customer
{
    partial class SelectBook
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
            this.BookImage = new System.Windows.Forms.PictureBox();
            this.AddQuan = new System.Windows.Forms.Button();
            this.BookN = new System.Windows.Forms.Label();
            this.BookP = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.MinQuan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BookImage
            // 
            this.BookImage.Location = new System.Drawing.Point(38, 33);
            this.BookImage.Name = "BookImage";
            this.BookImage.Size = new System.Drawing.Size(366, 312);
            this.BookImage.TabIndex = 0;
            this.BookImage.TabStop = false;
            // 
            // AddQuan
            // 
            this.AddQuan.Location = new System.Drawing.Point(350, 384);
            this.AddQuan.Name = "AddQuan";
            this.AddQuan.Size = new System.Drawing.Size(75, 35);
            this.AddQuan.TabIndex = 1;
            this.AddQuan.Text = "Add";
            this.AddQuan.UseVisualStyleBackColor = true;
            this.AddQuan.Click += new System.EventHandler(this.AddQuan_Click);
            // 
            // BookN
            // 
            this.BookN.AutoSize = true;
            this.BookN.Location = new System.Drawing.Point(110, 352);
            this.BookN.Name = "BookN";
            this.BookN.Size = new System.Drawing.Size(92, 20);
            this.BookN.TabIndex = 2;
            this.BookN.Text = "Book Name";
            // 
            // BookP
            // 
            this.BookP.AutoSize = true;
            this.BookP.Location = new System.Drawing.Point(110, 391);
            this.BookP.Name = "BookP";
            this.BookP.Size = new System.Drawing.Size(85, 20);
            this.BookP.TabIndex = 3;
            this.BookP.Text = "Book Price";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(310, 391);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(18, 20);
            this.Quantity.TabIndex = 4;
            this.Quantity.Text = "1";
            // 
            // MinQuan
            // 
            this.MinQuan.Location = new System.Drawing.Point(229, 384);
            this.MinQuan.Name = "MinQuan";
            this.MinQuan.Size = new System.Drawing.Size(75, 35);
            this.MinQuan.TabIndex = 5;
            this.MinQuan.Text = "Minus";
            this.MinQuan.UseVisualStyleBackColor = true;
            this.MinQuan.Click += new System.EventHandler(this.MinQuan_Click);
            // 
            // SelectBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MinQuan);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.BookP);
            this.Controls.Add(this.BookN);
            this.Controls.Add(this.AddQuan);
            this.Controls.Add(this.BookImage);
            this.Name = "SelectBook";
            this.Size = new System.Drawing.Size(469, 434);
            ((System.ComponentModel.ISupportInitialize)(this.BookImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox BookImage;
        private System.Windows.Forms.Button AddQuan;
        private System.Windows.Forms.Label BookN;
        private System.Windows.Forms.Label BookP;
        private System.Windows.Forms.Button MinQuan;
        public System.Windows.Forms.Label Quantity;
    }
}
