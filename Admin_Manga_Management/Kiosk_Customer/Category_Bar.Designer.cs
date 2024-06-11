namespace Kiosk_Customer
{
    partial class Category_Bar
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
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.Clicked = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Clicked)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(76, 6);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(100, 20);
            this.CategoryLabel.TabIndex = 0;
            this.CategoryLabel.Text = "<Cateogory>";
            // 
            // Clicked
            // 
            this.Clicked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.Clicked.Location = new System.Drawing.Point(0, 0);
            this.Clicked.Name = "Clicked";
            this.Clicked.Size = new System.Drawing.Size(21, 32);
            this.Clicked.TabIndex = 2;
            this.Clicked.TabStop = false;
            this.Clicked.Visible = false;
            // 
            // Category_Bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Clicked);
            this.Controls.Add(this.CategoryLabel);
            this.Name = "Category_Bar";
            this.Size = new System.Drawing.Size(257, 32);
            ((System.ComponentModel.ISupportInitialize)(this.Clicked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label CategoryLabel;
        public System.Windows.Forms.PictureBox Clicked;
    }
}
