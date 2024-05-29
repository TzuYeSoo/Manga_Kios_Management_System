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
            this.AdminUsername_Add = new System.Windows.Forms.TextBox();
            this.AdminPass_Add = new System.Windows.Forms.TextBox();
            this.AdminCon_Add = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Admin_Pass_Label = new System.Windows.Forms.Label();
            this.Admin_Con_Label = new System.Windows.Forms.Label();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet3 = new Admin_Manga_Management.Database1DataSet3();
            this.adminTableAdapter = new Admin_Manga_Management.Database1DataSet3TableAdapters.AdminTableAdapter();
            this.Add_AdminBUtt = new System.Windows.Forms.Button();
            this.Close_Button_Add = new System.Windows.Forms.Button();
            this.Admin_View_Add = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PositionBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_View_Add)).BeginInit();
            this.SuspendLayout();
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
            this.AdminPass_Add.Location = new System.Drawing.Point(42, 86);
            this.AdminPass_Add.Name = "AdminPass_Add";
            this.AdminPass_Add.Size = new System.Drawing.Size(182, 22);
            this.AdminPass_Add.TabIndex = 2;
            // 
            // AdminCon_Add
            // 
            this.AdminCon_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCon_Add.Location = new System.Drawing.Point(427, 85);
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
            this.Admin_Pass_Label.Location = new System.Drawing.Point(39, 70);
            this.Admin_Pass_Label.Name = "Admin_Pass_Label";
            this.Admin_Pass_Label.Size = new System.Drawing.Size(85, 13);
            this.Admin_Pass_Label.TabIndex = 7;
            this.Admin_Pass_Label.Text = "Admin Password";
            // 
            // Admin_Con_Label
            // 
            this.Admin_Con_Label.AutoSize = true;
            this.Admin_Con_Label.Location = new System.Drawing.Point(424, 69);
            this.Admin_Con_Label.Name = "Admin_Con_Label";
            this.Admin_Con_Label.Size = new System.Drawing.Size(44, 13);
            this.Admin_Con_Label.TabIndex = 8;
            this.Admin_Con_Label.Text = "Contact";
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
            this.Add_AdminBUtt.Location = new System.Drawing.Point(427, 127);
            this.Add_AdminBUtt.Name = "Add_AdminBUtt";
            this.Add_AdminBUtt.Size = new System.Drawing.Size(182, 23);
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
            this.Close_Button_Add.Location = new System.Drawing.Point(634, 13);
            this.Close_Button_Add.Name = "Close_Button_Add";
            this.Close_Button_Add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Close_Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Close_Button_Add.TabIndex = 11;
            this.Close_Button_Add.Text = "Close";
            this.Close_Button_Add.UseVisualStyleBackColor = false;
            this.Close_Button_Add.Click += new System.EventHandler(this.Close_Button_Add_Click);
            // 
            // Admin_View_Add
            // 
            this.Admin_View_Add.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Admin_View_Add.Location = new System.Drawing.Point(42, 173);
            this.Admin_View_Add.Name = "Admin_View_Add";
            this.Admin_View_Add.Size = new System.Drawing.Size(667, 161);
            this.Admin_View_Add.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 16;
            // 
            // PositionBox
            // 
            this.PositionBox.FormattingEnabled = true;
            this.PositionBox.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.PositionBox.Location = new System.Drawing.Point(236, 85);
            this.PositionBox.Name = "PositionBox";
            this.PositionBox.Size = new System.Drawing.Size(182, 21);
            this.PositionBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Name";
            // 
            // TName
            // 
            this.TName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TName.Location = new System.Drawing.Point(236, 127);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(182, 22);
            this.TName.TabIndex = 18;
            // 
            // Add_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 381);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.PositionBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Admin_View_Add);
            this.Controls.Add(this.Close_Button_Add);
            this.Controls.Add(this.Add_AdminBUtt);
            this.Controls.Add(this.Admin_Con_Label);
            this.Controls.Add(this.Admin_Pass_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminCon_Add);
            this.Controls.Add(this.AdminPass_Add);
            this.Controls.Add(this.AdminUsername_Add);
            this.Name = "Add_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_View_Add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AdminUsername_Add;
        private System.Windows.Forms.TextBox AdminPass_Add;
        private System.Windows.Forms.TextBox AdminCon_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Admin_Pass_Label;
        private System.Windows.Forms.Label Admin_Con_Label;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private Database1DataSet3TableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.Button Add_AdminBUtt;
        private System.Windows.Forms.Button Close_Button_Add;
        private System.Windows.Forms.DataGridView Admin_View_Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PositionBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TName;
    }
}