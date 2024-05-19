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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new Admin_Manga_Management.Database1DataSet1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Search_Date = new System.Windows.Forms.TextBox();
            this.Seach_Name = new System.Windows.Forms.TextBox();
            this.Search_ID = new System.Windows.Forms.TextBox();
            this.customersTableAdapter = new Admin_Manga_Management.Database1DataSet1TableAdapters.CustomersTableAdapter();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchLabel1 = new System.Windows.Forms.Label();
            this.SearchLabel2 = new System.Windows.Forms.Label();
            this.Dash_trans = new System.Windows.Forms.Button();
            this.Staffs_trans = new System.Windows.Forms.Button();
            this.Settings_trans = new System.Windows.Forms.Button();
            this.Trans_trans = new System.Windows.Forms.Button();
            this.Book_trans = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.orderNumberDataGridViewTextBoxColumn,
            this.cashierIDDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn,
            this.bookQuantityDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(212, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 320);
            this.dataGridView1.TabIndex = 1;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_Name";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer_Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "Order_Number";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "Order_Number";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            // 
            // cashierIDDataGridViewTextBoxColumn
            // 
            this.cashierIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cashierIDDataGridViewTextBoxColumn.DataPropertyName = "Cashier_ID";
            this.cashierIDDataGridViewTextBoxColumn.HeaderText = "Cashier_ID";
            this.cashierIDDataGridViewTextBoxColumn.Name = "cashierIDDataGridViewTextBoxColumn";
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            // 
            // bookQuantityDataGridViewTextBoxColumn
            // 
            this.bookQuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookQuantityDataGridViewTextBoxColumn.DataPropertyName = "Book_Quantity";
            this.bookQuantityDataGridViewTextBoxColumn.HeaderText = "Book_Quantity";
            this.bookQuantityDataGridViewTextBoxColumn.Name = "bookQuantityDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pictureBox2.Location = new System.Drawing.Point(212, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(607, 25);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Search_Date
            // 
            this.Search_Date.Location = new System.Drawing.Point(212, 67);
            this.Search_Date.Name = "Search_Date";
            this.Search_Date.Size = new System.Drawing.Size(143, 20);
            this.Search_Date.TabIndex = 3;
            // 
            // Seach_Name
            // 
            this.Seach_Name.Location = new System.Drawing.Point(361, 67);
            this.Seach_Name.Name = "Seach_Name";
            this.Seach_Name.Size = new System.Drawing.Size(143, 20);
            this.Seach_Name.TabIndex = 4;
            // 
            // Search_ID
            // 
            this.Search_ID.Location = new System.Drawing.Point(510, 67);
            this.Search_ID.Name = "Search_ID";
            this.Search_ID.Size = new System.Drawing.Size(143, 20);
            this.Search_ID.TabIndex = 5;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(209, 48);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(90, 16);
            this.SearchLabel.TabIndex = 6;
            this.SearchLabel.Text = "Search Name";
            // 
            // SearchLabel1
            // 
            this.SearchLabel1.AutoSize = true;
            this.SearchLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel1.Location = new System.Drawing.Point(358, 48);
            this.SearchLabel1.Name = "SearchLabel1";
            this.SearchLabel1.Size = new System.Drawing.Size(66, 16);
            this.SearchLabel1.TabIndex = 7;
            this.SearchLabel1.Text = "Search ID";
            // 
            // SearchLabel2
            // 
            this.SearchLabel2.AutoSize = true;
            this.SearchLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel2.Location = new System.Drawing.Point(507, 48);
            this.SearchLabel2.Name = "SearchLabel2";
            this.SearchLabel2.Size = new System.Drawing.Size(82, 16);
            this.SearchLabel2.TabIndex = 8;
            this.SearchLabel2.Text = "Search Date";
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
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
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
            this.Controls.Add(this.SearchLabel2);
            this.Controls.Add(this.SearchLabel1);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.Search_ID);
            this.Controls.Add(this.Seach_Name);
            this.Controls.Add(this.Search_Date);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Transaction";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Search_Date;
        private System.Windows.Forms.TextBox Seach_Name;
        private System.Windows.Forms.TextBox Search_ID;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Database1DataSet1TableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label SearchLabel1;
        private System.Windows.Forms.Label SearchLabel2;
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
    }
}