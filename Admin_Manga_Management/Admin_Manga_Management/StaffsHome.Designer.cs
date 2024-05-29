namespace Admin_Manga_Management
{
    partial class StaffsHome
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
            this.components = new System.ComponentModel.Container();
            this.Dash_Staffs = new System.Windows.Forms.Button();
            this.Settings_Staffs = new System.Windows.Forms.Button();
            this.Trans_Staffs = new System.Windows.Forms.Button();
            this.BookInv_Staffs = new System.Windows.Forms.Button();
            this.Staffs_Staffs = new System.Windows.Forms.Button();
            this.cashierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2 = new Admin_Manga_Management.Database1DataSet2();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet3 = new Admin_Manga_Management.Database1DataSet3();
            this.Admin_Text = new System.Windows.Forms.Label();
            this.cashierTableAdapter = new Admin_Manga_Management.Database1DataSet2TableAdapters.CashierTableAdapter();
            this.adminTableAdapter = new Admin_Manga_Management.Database1DataSet3TableAdapters.AdminTableAdapter();
            this.Add_User_Admin = new System.Windows.Forms.Button();
            this.Edit_User_Admin = new System.Windows.Forms.Button();
            this.Remove_User_Admin = new System.Windows.Forms.Button();
            this.Employee_Data = new System.Windows.Forms.DataGridView();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dash_Staffs
            // 
            this.Dash_Staffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.Dash_Staffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dash_Staffs.ForeColor = System.Drawing.Color.Transparent;
            this.Dash_Staffs.Location = new System.Drawing.Point(0, 40);
            this.Dash_Staffs.Name = "Dash_Staffs";
            this.Dash_Staffs.Size = new System.Drawing.Size(194, 47);
            this.Dash_Staffs.TabIndex = 1;
            this.Dash_Staffs.Text = "Dashboard";
            this.Dash_Staffs.UseVisualStyleBackColor = false;
            this.Dash_Staffs.Click += new System.EventHandler(this.Dash_Staffs_Click);
            // 
            // Settings_Staffs
            // 
            this.Settings_Staffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.Settings_Staffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Staffs.ForeColor = System.Drawing.Color.Transparent;
            this.Settings_Staffs.Location = new System.Drawing.Point(0, 360);
            this.Settings_Staffs.Name = "Settings_Staffs";
            this.Settings_Staffs.Size = new System.Drawing.Size(194, 47);
            this.Settings_Staffs.TabIndex = 2;
            this.Settings_Staffs.Text = "Settings";
            this.Settings_Staffs.UseVisualStyleBackColor = false;
            this.Settings_Staffs.Click += new System.EventHandler(this.Settings_Staffs_Click);
            // 
            // Trans_Staffs
            // 
            this.Trans_Staffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.Trans_Staffs.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Trans_Staffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trans_Staffs.ForeColor = System.Drawing.Color.Transparent;
            this.Trans_Staffs.Location = new System.Drawing.Point(0, 280);
            this.Trans_Staffs.Name = "Trans_Staffs";
            this.Trans_Staffs.Size = new System.Drawing.Size(194, 47);
            this.Trans_Staffs.TabIndex = 3;
            this.Trans_Staffs.Text = "Transaction";
            this.Trans_Staffs.UseVisualStyleBackColor = false;
            this.Trans_Staffs.Click += new System.EventHandler(this.Trans_Staffs_Click);
            // 
            // BookInv_Staffs
            // 
            this.BookInv_Staffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BookInv_Staffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookInv_Staffs.ForeColor = System.Drawing.Color.Transparent;
            this.BookInv_Staffs.Location = new System.Drawing.Point(0, 200);
            this.BookInv_Staffs.Name = "BookInv_Staffs";
            this.BookInv_Staffs.Size = new System.Drawing.Size(194, 47);
            this.BookInv_Staffs.TabIndex = 4;
            this.BookInv_Staffs.Text = "Book Inventory";
            this.BookInv_Staffs.UseVisualStyleBackColor = false;
            this.BookInv_Staffs.Click += new System.EventHandler(this.BookInv_Staffs_Click);
            // 
            // Staffs_Staffs
            // 
            this.Staffs_Staffs.BackColor = System.Drawing.Color.Silver;
            this.Staffs_Staffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staffs_Staffs.ForeColor = System.Drawing.Color.Transparent;
            this.Staffs_Staffs.Location = new System.Drawing.Point(0, 120);
            this.Staffs_Staffs.Name = "Staffs_Staffs";
            this.Staffs_Staffs.Size = new System.Drawing.Size(194, 47);
            this.Staffs_Staffs.TabIndex = 5;
            this.Staffs_Staffs.Text = "Manage Staffs";
            this.Staffs_Staffs.UseVisualStyleBackColor = false;
            // 
            // cashierBindingSource
            // 
            this.cashierBindingSource.DataMember = "Cashier";
            this.cashierBindingSource.DataSource = this.database1DataSet2;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.database1DataSet3;
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Admin_Text
            // 
            this.Admin_Text.AutoSize = true;
            this.Admin_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Text.Location = new System.Drawing.Point(217, 41);
            this.Admin_Text.Name = "Admin_Text";
            this.Admin_Text.Size = new System.Drawing.Size(68, 25);
            this.Admin_Text.TabIndex = 13;
            this.Admin_Text.Text = "Admin";
            // 
            // cashierTableAdapter
            // 
            this.cashierTableAdapter.ClearBeforeFill = true;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // Add_User_Admin
            // 
            this.Add_User_Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Add_User_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_User_Admin.Location = new System.Drawing.Point(554, 40);
            this.Add_User_Admin.Name = "Add_User_Admin";
            this.Add_User_Admin.Size = new System.Drawing.Size(75, 23);
            this.Add_User_Admin.TabIndex = 18;
            this.Add_User_Admin.Text = "Add";
            this.Add_User_Admin.UseVisualStyleBackColor = false;
            this.Add_User_Admin.Click += new System.EventHandler(this.Add_User_Admin_Click);
            // 
            // Edit_User_Admin
            // 
            this.Edit_User_Admin.BackColor = System.Drawing.SystemColors.Info;
            this.Edit_User_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_User_Admin.Location = new System.Drawing.Point(635, 40);
            this.Edit_User_Admin.Name = "Edit_User_Admin";
            this.Edit_User_Admin.Size = new System.Drawing.Size(75, 23);
            this.Edit_User_Admin.TabIndex = 19;
            this.Edit_User_Admin.Text = "Edit";
            this.Edit_User_Admin.UseVisualStyleBackColor = false;
            this.Edit_User_Admin.Click += new System.EventHandler(this.Edit_User_Admin_Click);
            // 
            // Remove_User_Admin
            // 
            this.Remove_User_Admin.BackColor = System.Drawing.Color.LightCoral;
            this.Remove_User_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_User_Admin.Location = new System.Drawing.Point(716, 40);
            this.Remove_User_Admin.Name = "Remove_User_Admin";
            this.Remove_User_Admin.Size = new System.Drawing.Size(75, 23);
            this.Remove_User_Admin.TabIndex = 20;
            this.Remove_User_Admin.Text = "Remove";
            this.Remove_User_Admin.UseVisualStyleBackColor = false;
            this.Remove_User_Admin.Click += new System.EventHandler(this.Remove_User_Admin_Click);
            // 
            // Employee_Data
            // 
            this.Employee_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employee_Data.Location = new System.Drawing.Point(225, 76);
            this.Employee_Data.Name = "Employee_Data";
            this.Employee_Data.Size = new System.Drawing.Size(569, 331);
            this.Employee_Data.TabIndex = 21;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Silver;
            this.pictureBox6.BackgroundImage = global::Admin_Manga_Management.Properties.Resources.staff_removebg_preview__1_;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(29, 129);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pictureBox5.BackgroundImage = global::Admin_Manga_Management.Properties.Resources.Transactions_removebg_preview;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(35, 289);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pictureBox4.BackgroundImage = global::Admin_Manga_Management.Properties.Resources.Books_removebg_preview;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(16, 204);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pictureBox3.BackgroundImage = global::Admin_Manga_Management.Properties.Resources.Dash_removebg_preview;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(36, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pictureBox2.BackgroundImage = global::Admin_Manga_Management.Properties.Resources.settings_removebg_preview;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(45, 369);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StaffsHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.Employee_Data);
            this.Controls.Add(this.Remove_User_Admin);
            this.Controls.Add(this.Edit_User_Admin);
            this.Controls.Add(this.Add_User_Admin);
            this.Controls.Add(this.Admin_Text);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Staffs_Staffs);
            this.Controls.Add(this.BookInv_Staffs);
            this.Controls.Add(this.Trans_Staffs);
            this.Controls.Add(this.Settings_Staffs);
            this.Controls.Add(this.Dash_Staffs);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StaffsHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StaffsHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Dash_Staffs;
        private System.Windows.Forms.Button Settings_Staffs;
        private System.Windows.Forms.Button Trans_Staffs;
        private System.Windows.Forms.Button BookInv_Staffs;
        private System.Windows.Forms.Button Staffs_Staffs;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label Admin_Text;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource cashierBindingSource;
        private Database1DataSet2TableAdapters.CashierTableAdapter cashierTableAdapter;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private Database1DataSet3TableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.Button Add_User_Admin;
        private System.Windows.Forms.Button Edit_User_Admin;
        private System.Windows.Forms.Button Remove_User_Admin;
        private System.Windows.Forms.DataGridView Employee_Data;
    }
}