namespace Admin_Manga_Management
{
    partial class Transaction
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
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new Admin_Manga_Management.Database1DataSet1();
            this.Search_IDTrans = new System.Windows.Forms.TextBox();
            this.customersTableAdapter = new Admin_Manga_Management.Database1DataSet1TableAdapters.CustomersTableAdapter();
            this.Dash_trans = new System.Windows.Forms.Button();
            this.Staffs_trans = new System.Windows.Forms.Button();
            this.Settings_trans = new System.Windows.Forms.Button();
            this.Trans_trans = new System.Windows.Forms.Button();
            this.Book_trans = new System.Windows.Forms.Button();
            this.SearchBut_Trans = new System.Windows.Forms.Button();
            this.Edit_Trans = new System.Windows.Forms.Button();
            this.Remove_Trans = new System.Windows.Forms.Button();
            this.Trans_GridView = new System.Windows.Forms.DataGridView();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Search_IDTrans
            // 
            this.Search_IDTrans.Location = new System.Drawing.Point(212, 66);
            this.Search_IDTrans.Name = "Search_IDTrans";
            this.Search_IDTrans.Size = new System.Drawing.Size(501, 20);
            this.Search_IDTrans.TabIndex = 3;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // Dash_trans
            // 
            this.Dash_trans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.Dash_trans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dash_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dash_trans.ForeColor = System.Drawing.Color.Transparent;
            this.Dash_trans.Location = new System.Drawing.Point(0, 40);
            this.Dash_trans.Name = "Dash_trans";
            this.Dash_trans.Size = new System.Drawing.Size(194, 47);
            this.Dash_trans.TabIndex = 9;
            this.Dash_trans.Text = "Dashboard";
            this.Dash_trans.UseVisualStyleBackColor = false;
            this.Dash_trans.Click += new System.EventHandler(this.Dash_trans_Click);
            // 
            // Staffs_trans
            // 
            this.Staffs_trans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.Staffs_trans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Staffs_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staffs_trans.ForeColor = System.Drawing.Color.Transparent;
            this.Staffs_trans.Location = new System.Drawing.Point(0, 120);
            this.Staffs_trans.Name = "Staffs_trans";
            this.Staffs_trans.Size = new System.Drawing.Size(194, 47);
            this.Staffs_trans.TabIndex = 10;
            this.Staffs_trans.Text = "Manage Staffs";
            this.Staffs_trans.UseVisualStyleBackColor = false;
            this.Staffs_trans.Click += new System.EventHandler(this.Staffs_trans_Click);
            // 
            // Settings_trans
            // 
            this.Settings_trans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.Settings_trans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Settings_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_trans.ForeColor = System.Drawing.Color.Transparent;
            this.Settings_trans.Location = new System.Drawing.Point(0, 360);
            this.Settings_trans.Name = "Settings_trans";
            this.Settings_trans.Size = new System.Drawing.Size(194, 47);
            this.Settings_trans.TabIndex = 11;
            this.Settings_trans.Text = "Settings";
            this.Settings_trans.UseVisualStyleBackColor = false;
            this.Settings_trans.Click += new System.EventHandler(this.Settings_trans_Click);
            // 
            // Trans_trans
            // 
            this.Trans_trans.BackColor = System.Drawing.Color.Silver;
            this.Trans_trans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Trans_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trans_trans.ForeColor = System.Drawing.Color.Transparent;
            this.Trans_trans.Location = new System.Drawing.Point(0, 280);
            this.Trans_trans.Name = "Trans_trans";
            this.Trans_trans.Size = new System.Drawing.Size(194, 47);
            this.Trans_trans.TabIndex = 12;
            this.Trans_trans.Text = "Transactions";
            this.Trans_trans.UseVisualStyleBackColor = false;
            // 
            // Book_trans
            // 
            this.Book_trans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.Book_trans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Book_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Book_trans.ForeColor = System.Drawing.Color.Transparent;
            this.Book_trans.Location = new System.Drawing.Point(0, 200);
            this.Book_trans.Name = "Book_trans";
            this.Book_trans.Size = new System.Drawing.Size(194, 47);
            this.Book_trans.TabIndex = 13;
            this.Book_trans.Text = "Book Inventory";
            this.Book_trans.UseVisualStyleBackColor = false;
            this.Book_trans.Click += new System.EventHandler(this.Book_trans_Click);
            // 
            // SearchBut_Trans
            // 
            this.SearchBut_Trans.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SearchBut_Trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBut_Trans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBut_Trans.Location = new System.Drawing.Point(718, 64);
            this.SearchBut_Trans.Name = "SearchBut_Trans";
            this.SearchBut_Trans.Size = new System.Drawing.Size(101, 23);
            this.SearchBut_Trans.TabIndex = 19;
            this.SearchBut_Trans.Text = "Search";
            this.SearchBut_Trans.UseVisualStyleBackColor = false;
            this.SearchBut_Trans.Click += new System.EventHandler(this.SearchBut_Trans_Click);
            // 
            // Edit_Trans
            // 
            this.Edit_Trans.BackColor = System.Drawing.Color.Khaki;
            this.Edit_Trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Trans.Location = new System.Drawing.Point(212, 360);
            this.Edit_Trans.Name = "Edit_Trans";
            this.Edit_Trans.Size = new System.Drawing.Size(123, 23);
            this.Edit_Trans.TabIndex = 20;
            this.Edit_Trans.Text = "Edit";
            this.Edit_Trans.UseVisualStyleBackColor = false;
            this.Edit_Trans.Click += new System.EventHandler(this.Edit_Trans_Click);
            // 
            // Remove_Trans
            // 
            this.Remove_Trans.BackColor = System.Drawing.Color.IndianRed;
            this.Remove_Trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_Trans.Location = new System.Drawing.Point(350, 360);
            this.Remove_Trans.Name = "Remove_Trans";
            this.Remove_Trans.Size = new System.Drawing.Size(123, 23);
            this.Remove_Trans.TabIndex = 21;
            this.Remove_Trans.Text = "Remove";
            this.Remove_Trans.UseVisualStyleBackColor = false;
            // 
            // Trans_GridView
            // 
            this.Trans_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Trans_GridView.Location = new System.Drawing.Point(212, 114);
            this.Trans_GridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Trans_GridView.Name = "Trans_GridView";
            this.Trans_GridView.RowHeadersWidth = 62;
            this.Trans_GridView.RowTemplate.Height = 28;
            this.Trans_GridView.Size = new System.Drawing.Size(607, 240);
            this.Trans_GridView.TabIndex = 22;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pictureBox7.BackgroundImage = global::Admin_Manga_Management.Properties.Resources.settings_removebg_preview;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(45, 369);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pictureBox6.BackgroundImage = global::Admin_Manga_Management.Properties.Resources.staff_removebg_preview__1_;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(29, 129);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pictureBox5.BackgroundImage = global::Admin_Manga_Management.Properties.Resources.Dash_removebg_preview;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(36, 49);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Silver;
            this.pictureBox4.BackgroundImage = global::Admin_Manga_Management.Properties.Resources.Transactions_removebg_preview;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(30, 289);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pictureBox3.BackgroundImage = global::Admin_Manga_Management.Properties.Resources.Books_removebg_preview;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(19, 204);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pictureBox2.Location = new System.Drawing.Point(212, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(607, 25);
            this.pictureBox2.TabIndex = 2;
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
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.Trans_GridView);
            this.Controls.Add(this.Remove_Trans);
            this.Controls.Add(this.Edit_Trans);
            this.Controls.Add(this.SearchBut_Trans);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Book_trans);
            this.Controls.Add(this.Trans_trans);
            this.Controls.Add(this.Settings_trans);
            this.Controls.Add(this.Staffs_trans);
            this.Controls.Add(this.Dash_trans);
            this.Controls.Add(this.Search_IDTrans);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Transaction";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Search_IDTrans;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Database1DataSet1TableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Button Dash_trans;
        private System.Windows.Forms.Button Staffs_trans;
        private System.Windows.Forms.Button Settings_trans;
        private System.Windows.Forms.Button Trans_trans;
        private System.Windows.Forms.Button Book_trans;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button SearchBut_Trans;
        private System.Windows.Forms.Button Edit_Trans;
        private System.Windows.Forms.Button Remove_Trans;
        private System.Windows.Forms.DataGridView Trans_GridView;
    }
}