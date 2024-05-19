namespace Admin_Manga_Management
{
    partial class Remove_Admin
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
            this.Remove_Admin_GrideView = new System.Windows.Forms.DataGridView();
            this.AdminID_Remove = new System.Windows.Forms.TextBox();
            this.Remove_Remove = new System.Windows.Forms.Button();
            this.Admin_RemoveLabel = new System.Windows.Forms.Label();
            this.AdminID_RemoveLabel = new System.Windows.Forms.Label();
            this.Close_Remove_Admin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Remove_Admin_GrideView)).BeginInit();
            this.SuspendLayout();
            // 
            // Remove_Admin_GrideView
            // 
            this.Remove_Admin_GrideView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Remove_Admin_GrideView.Location = new System.Drawing.Point(230, 61);
            this.Remove_Admin_GrideView.Name = "Remove_Admin_GrideView";
            this.Remove_Admin_GrideView.Size = new System.Drawing.Size(432, 190);
            this.Remove_Admin_GrideView.TabIndex = 0;
            // 
            // AdminID_Remove
            // 
            this.AdminID_Remove.Location = new System.Drawing.Point(12, 106);
            this.AdminID_Remove.Name = "AdminID_Remove";
            this.AdminID_Remove.Size = new System.Drawing.Size(160, 20);
            this.AdminID_Remove.TabIndex = 1;
            // 
            // Remove_Remove
            // 
            this.Remove_Remove.BackColor = System.Drawing.Color.IndianRed;
            this.Remove_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_Remove.Location = new System.Drawing.Point(52, 132);
            this.Remove_Remove.Name = "Remove_Remove";
            this.Remove_Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove_Remove.TabIndex = 2;
            this.Remove_Remove.Text = "Remove";
            this.Remove_Remove.UseVisualStyleBackColor = false;
            this.Remove_Remove.Click += new System.EventHandler(this.Remove_Remove_Click);
            // 
            // Admin_RemoveLabel
            // 
            this.Admin_RemoveLabel.AutoSize = true;
            this.Admin_RemoveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_RemoveLabel.Location = new System.Drawing.Point(12, 9);
            this.Admin_RemoveLabel.Name = "Admin_RemoveLabel";
            this.Admin_RemoveLabel.Size = new System.Drawing.Size(68, 25);
            this.Admin_RemoveLabel.TabIndex = 3;
            this.Admin_RemoveLabel.Text = "Admin";
            // 
            // AdminID_RemoveLabel
            // 
            this.AdminID_RemoveLabel.AutoSize = true;
            this.AdminID_RemoveLabel.Location = new System.Drawing.Point(14, 90);
            this.AdminID_RemoveLabel.Name = "AdminID_RemoveLabel";
            this.AdminID_RemoveLabel.Size = new System.Drawing.Size(50, 13);
            this.AdminID_RemoveLabel.TabIndex = 4;
            this.AdminID_RemoveLabel.Text = "Admin ID";
            // 
            // Close_Remove_Admin
            // 
            this.Close_Remove_Admin.BackColor = System.Drawing.Color.IndianRed;
            this.Close_Remove_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Remove_Admin.Location = new System.Drawing.Point(587, 32);
            this.Close_Remove_Admin.Name = "Close_Remove_Admin";
            this.Close_Remove_Admin.Size = new System.Drawing.Size(75, 23);
            this.Close_Remove_Admin.TabIndex = 5;
            this.Close_Remove_Admin.Text = "Close";
            this.Close_Remove_Admin.UseVisualStyleBackColor = false;
            this.Close_Remove_Admin.Click += new System.EventHandler(this.Close_Remove_Admin_Click);
            // 
            // Remove_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 308);
            this.Controls.Add(this.Close_Remove_Admin);
            this.Controls.Add(this.AdminID_RemoveLabel);
            this.Controls.Add(this.Admin_RemoveLabel);
            this.Controls.Add(this.Remove_Remove);
            this.Controls.Add(this.AdminID_Remove);
            this.Controls.Add(this.Remove_Admin_GrideView);
            this.Name = "Remove_Admin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Remove_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Remove_Admin_GrideView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Remove_Admin_GrideView;
        private System.Windows.Forms.TextBox AdminID_Remove;
        private System.Windows.Forms.Button Remove_Remove;
        private System.Windows.Forms.Label Admin_RemoveLabel;
        private System.Windows.Forms.Label AdminID_RemoveLabel;
        private System.Windows.Forms.Button Close_Remove_Admin;
    }
}