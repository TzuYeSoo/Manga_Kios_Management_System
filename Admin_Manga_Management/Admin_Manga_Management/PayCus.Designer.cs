namespace Admin_Manga_Management
{
    partial class PayCus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayCus));
            this.min_quan = new System.Windows.Forms.Button();
            this.plus_quan = new System.Windows.Forms.Button();
            this.LabelQuan = new System.Windows.Forms.Label();
            this.Bname = new System.Windows.Forms.Label();
            this.Cname = new System.Windows.Forms.Label();
            this.OrderPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // min_quan
            // 
            this.min_quan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("min_quan.BackgroundImage")));
            this.min_quan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.min_quan.Location = new System.Drawing.Point(380, 19);
            this.min_quan.Name = "min_quan";
            this.min_quan.Size = new System.Drawing.Size(30, 30);
            this.min_quan.TabIndex = 1;
            this.min_quan.UseVisualStyleBackColor = true;
            this.min_quan.Click += new System.EventHandler(this.min_quan_Click);
            // 
            // plus_quan
            // 
            this.plus_quan.BackgroundImage = global::Admin_Manga_Management.Properties.Resources.add_removebg_preview;
            this.plus_quan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plus_quan.Location = new System.Drawing.Point(475, 19);
            this.plus_quan.Name = "plus_quan";
            this.plus_quan.Size = new System.Drawing.Size(30, 30);
            this.plus_quan.TabIndex = 0;
            this.plus_quan.UseVisualStyleBackColor = true;
            this.plus_quan.Click += new System.EventHandler(this.plus_quan_Click);
            // 
            // LabelQuan
            // 
            this.LabelQuan.AutoSize = true;
            this.LabelQuan.Location = new System.Drawing.Point(416, 26);
            this.LabelQuan.Name = "LabelQuan";
            this.LabelQuan.Size = new System.Drawing.Size(44, 16);
            this.LabelQuan.TabIndex = 2;
            this.LabelQuan.Text = "label1";
            // 
            // Bname
            // 
            this.Bname.AutoSize = true;
            this.Bname.Location = new System.Drawing.Point(159, 26);
            this.Bname.Name = "Bname";
            this.Bname.Size = new System.Drawing.Size(93, 16);
            this.Bname.TabIndex = 3;
            this.Bname.Text = "<Book Name>";
            // 
            // Cname
            // 
            this.Cname.AutoSize = true;
            this.Cname.Location = new System.Drawing.Point(18, 26);
            this.Cname.Name = "Cname";
            this.Cname.Size = new System.Drawing.Size(118, 16);
            this.Cname.TabIndex = 4;
            this.Cname.Text = "<Customer Name>";
            // 
            // OrderPrice
            // 
            this.OrderPrice.AutoSize = true;
            this.OrderPrice.Location = new System.Drawing.Point(269, 26);
            this.OrderPrice.Name = "OrderPrice";
            this.OrderPrice.Size = new System.Drawing.Size(89, 16);
            this.OrderPrice.TabIndex = 5;
            this.OrderPrice.Text = "<Order Price>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(3, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(519, 10);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PayCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OrderPrice);
            this.Controls.Add(this.Cname);
            this.Controls.Add(this.Bname);
            this.Controls.Add(this.LabelQuan);
            this.Controls.Add(this.min_quan);
            this.Controls.Add(this.plus_quan);
            this.Name = "PayCus";
            this.Size = new System.Drawing.Size(522, 62);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plus_quan;
        private System.Windows.Forms.Button min_quan;
        public System.Windows.Forms.Label LabelQuan;
        public System.Windows.Forms.Label Bname;
        public System.Windows.Forms.Label Cname;
        public System.Windows.Forms.Label OrderPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
