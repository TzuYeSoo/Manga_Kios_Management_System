namespace Admin_Manga_Management
{
    partial class Add_Admin
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
            this.AdminID_Add = new System.Windows.Forms.TextBox();
            this.AdminUsername_Add = new System.Windows.Forms.TextBox();
            this.AdminPass_Add = new System.Windows.Forms.TextBox();
            this.AdminCon_Add = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Admin_IDLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Admin_Pass_Label = new System.Windows.Forms.Label();
            this.Admin_Con_Label = new System.Windows.Forms.Label();
            this.Admin_View_Add = new System.Windows.Forms.DataGridView();
            this.adminIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminUserNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet3 = new Admin_Manga_Management.Database1DataSet3();
            this.adminTableAdapter = new Admin_Manga_Management.Database1DataSet3TableAdapters.AdminTableAdapter();
            this.Add_AdminBUtt = new System.Windows.Forms.Button();
            this.Close_Button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_View_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminID_Add
            // 
            this.AdminID_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminID_Add.Location = new System.Drawing.Point(42, 86);
            this.AdminID_Add.Name = "AdminID_Add";
            this.AdminID_Add.Size = new System.Drawing.Size(182, 22);
            this.AdminID_Add.TabIndex = 0;
            // 
            // AdminUsername_Add
            // 
            this.AdminUsername_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminUsername_Add.Location = new System.Drawing.Point(42, 127);
            this.AdminUsername_Add.Name = "AdminUsername_Add";
            this.AdminUsername_Add.Size = new System.Drawing.Size(182, 22);
            this.AdminUsername_Add.TabIndex = 1;
            // 
            // AdminPass_Add
            // 
            this.AdminPass_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPass_Add.Location = new System.Drawing.Point(42, 168);
            this.AdminPass_Add.Name = "AdminPass_Add";
            this.AdminPass_Add.Size = new System.Drawing.Size(182, 22);
            this.AdminPass_Add.TabIndex = 2;
            // 
            // AdminCon_Add
            // 
            this.AdminCon_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCon_Add.Location = new System.Drawing.Point(42, 209);
            this.AdminCon_Add.Name = "AdminCon_Add";
            this.AdminCon_Add.Size = new System.Drawing.Size(182, 22);
            this.AdminCon_Add.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Admin";
            // 
            // Admin_IDLabel
            // 
            this.Admin_IDLabel.AutoSize = true;
            this.Admin_IDLabel.Location = new System.Drawing.Point(39, 70);
            this.Admin_IDLabel.Name = "Admin_IDLabel";
            this.Admin_IDLabel.Size = new System.Drawing.Size(50, 13);
            this.Admin_IDLabel.TabIndex = 5;
            this.Admin_IDLabel.Text = "Admin ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Admin Username";
            // 
            // Admin_Pass_Label
            // 
            this.Admin_Pass_Label.AutoSize = true;
            this.Admin_Pass_Label.Location = new System.Drawing.Point(39, 152);
            this.Admin_Pass_Label.Name = "Admin_Pass_Label";
            this.Admin_Pass_Label.Size = new System.Drawing.Size(85, 13);
            this.Admin_Pass_Label.TabIndex = 7;
            this.Admin_Pass_Label.Text = "Admin Password";
            // 
            // Admin_Con_Label
            // 
            this.Admin_Con_Label.AutoSize = true;
            this.Admin_Con_Label.Location = new System.Drawing.Point(39, 193);
            this.Admin_Con_Label.Name = "Admin_Con_Label";
            this.Admin_Con_Label.Size = new System.Drawing.Size(44, 13);
            this.Admin_Con_Label.TabIndex = 8;
            this.Admin_Con_Label.Text = "Contact";
            // 
            // Admin_View_Add
            // 
            this.Admin_View_Add.AutoGenerateColumns = false;
            this.Admin_View_Add.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Admin_View_Add.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminIDDataGridViewTextBoxColumn,
            this.adminUserNameDataGridViewTextBoxColumn,
            this.adminPasswordDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn});
            this.Admin_View_Add.DataSource = this.adminBindingSource;
            this.Admin_View_Add.Location = new System.Drawing.Point(269, 86);
            this.Admin_View_Add.Name = "Admin_View_Add";
            this.Admin_View_Add.Size = new System.Drawing.Size(399, 198);
            this.Admin_View_Add.TabIndex = 9;
            // 
            // adminIDDataGridViewTextBoxColumn
            // 
            this.adminIDDataGridViewTextBoxColumn.DataPropertyName = "Admin_ID";
            this.adminIDDataGridViewTextBoxColumn.HeaderText = "Admin_ID";
            this.adminIDDataGridViewTextBoxColumn.Name = "adminIDDataGridViewTextBoxColumn";
            // 
            // adminUserNameDataGridViewTextBoxColumn
            // 
            this.adminUserNameDataGridViewTextBoxColumn.DataPropertyName = "Admin_UserName";
            this.adminUserNameDataGridViewTextBoxColumn.HeaderText = "Admin_UserName";
            this.adminUserNameDataGridViewTextBoxColumn.Name = "adminUserNameDataGridViewTextBoxColumn";
            // 
            // adminPasswordDataGridViewTextBoxColumn
            // 
            this.adminPasswordDataGridViewTextBoxColumn.DataPropertyName = "Admin_Password";
            this.adminPasswordDataGridViewTextBoxColumn.HeaderText = "Admin_Password";
            this.adminPasswordDataGridViewTextBoxColumn.Name = "adminPasswordDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
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
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // Add_AdminBUtt
            // 
            this.Add_AdminBUtt.BackColor = System.Drawing.Color.LightGreen;
            this.Add_AdminBUtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_AdminBUtt.Location = new System.Drawing.Point(88, 261);
            this.Add_AdminBUtt.Name = "Add_AdminBUtt";
            this.Add_AdminBUtt.Size = new System.Drawing.Size(75, 23);
            this.Add_AdminBUtt.TabIndex = 10;
            this.Add_AdminBUtt.Text = "Add";
            this.Add_AdminBUtt.UseVisualStyleBackColor = false;
            this.Add_AdminBUtt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Close_Button_Add
            // 
            this.Close_Button_Add.BackColor = System.Drawing.Color.IndianRed;
            this.Close_Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button_Add.ForeColor = System.Drawing.Color.Transparent;
            this.Close_Button_Add.Location = new System.Drawing.Point(593, 9);
            this.Close_Button_Add.Name = "Close_Button_Add";
            this.Close_Button_Add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Close_Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Close_Button_Add.TabIndex = 11;
            this.Close_Button_Add.Text = "Close";
            this.Close_Button_Add.UseVisualStyleBackColor = false;
            this.Close_Button_Add.Click += new System.EventHandler(this.Close_Button_Add_Click);
            // 
            // Add_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 308);
            this.Controls.Add(this.Close_Button_Add);
            this.Controls.Add(this.Add_AdminBUtt);
            this.Controls.Add(this.Admin_View_Add);
            this.Controls.Add(this.Admin_Con_Label);
            this.Controls.Add(this.Admin_Pass_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Admin_IDLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminCon_Add);
            this.Controls.Add(this.AdminPass_Add);
            this.Controls.Add(this.AdminUsername_Add);
            this.Controls.Add(this.AdminID_Add);
            this.Name = "Add_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Admin_View_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdminID_Add;
        private System.Windows.Forms.TextBox AdminUsername_Add;
        private System.Windows.Forms.TextBox AdminPass_Add;
        private System.Windows.Forms.TextBox AdminCon_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Admin_IDLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Admin_Pass_Label;
        private System.Windows.Forms.Label Admin_Con_Label;
        private System.Windows.Forms.DataGridView Admin_View_Add;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private Database1DataSet3TableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminUserNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Add_AdminBUtt;
        private System.Windows.Forms.Button Close_Button_Add;
    }
}