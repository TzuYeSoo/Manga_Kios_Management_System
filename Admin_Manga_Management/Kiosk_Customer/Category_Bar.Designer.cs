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
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CategoryLabel.Location = new System.Drawing.Point(51, 4);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(76, 15);
            this.CategoryLabel.TabIndex = 0;
            this.CategoryLabel.Text = "<Cateogory>";
            // 
            // Clicked
            // 
            this.Clicked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.Clicked.Location = new System.Drawing.Point(0, 0);
            this.Clicked.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Clicked.Name = "Clicked";
            this.Clicked.Size = new System.Drawing.Size(14, 21);
            this.Clicked.TabIndex = 2;
            this.Clicked.TabStop = false;
            this.Clicked.Visible = false;
            // 
            // Category_Bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Clicked);
            this.Controls.Add(this.CategoryLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Category_Bar";
            this.Size = new System.Drawing.Size(171, 21);
            ((System.ComponentModel.ISupportInitialize)(this.Clicked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label CategoryLabel;
        public System.Windows.Forms.PictureBox Clicked;
    }
}
