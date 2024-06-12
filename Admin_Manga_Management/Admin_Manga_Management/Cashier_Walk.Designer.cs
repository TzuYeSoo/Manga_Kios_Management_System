namespace Admin_Manga_Management
{
    partial class Cashier_Walk
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
            this.Bname = new System.Windows.Forms.Label();
            this.Bprice = new System.Windows.Forms.Label();
            this.Bquan = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bname
            // 
            this.Bname.AutoSize = true;
            this.Bname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Bname.Location = new System.Drawing.Point(13, 10);
            this.Bname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bname.Name = "Bname";
            this.Bname.Size = new System.Drawing.Size(86, 15);
            this.Bname.TabIndex = 0;
            this.Bname.Text = "<Book Name>";
            // 
            // Bprice
            // 
            this.Bprice.AutoSize = true;
            this.Bprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Bprice.Location = new System.Drawing.Point(109, 10);
            this.Bprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bprice.Name = "Bprice";
            this.Bprice.Size = new System.Drawing.Size(80, 15);
            this.Bprice.TabIndex = 1;
            this.Bprice.Text = "<Book Price>";
            // 
            // Bquan
            // 
            this.Bquan.AutoSize = true;
            this.Bquan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Bquan.Location = new System.Drawing.Point(303, 10);
            this.Bquan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bquan.Name = "Bquan";
            this.Bquan.Size = new System.Drawing.Size(65, 15);
            this.Bquan.TabIndex = 2;
            this.Bquan.Text = "<Quantity>";
            // 
            // add
            // 
            this.add.BackgroundImage = global::Admin_Manga_Management.Properties.Resources.add_removebg_preview;
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.Location = new System.Drawing.Point(279, 6);
            this.add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(20, 20);
            this.add.TabIndex = 3;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(365, 6);
            this.minus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(20, 20);
            this.minus.TabIndex = 4;
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // Cashier_Walk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.minus);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Bquan);
            this.Controls.Add(this.Bprice);
            this.Controls.Add(this.Bname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cashier_Walk";
            this.Size = new System.Drawing.Size(392, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Bname;
        public System.Windows.Forms.Label Bprice;
        public System.Windows.Forms.Label Bquan;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button minus;
    }
}
