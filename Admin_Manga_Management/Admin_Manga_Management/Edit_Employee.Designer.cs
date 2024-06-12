namespace Admin_Manga_Management
{
    partial class Edit_Employee
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
            this.Search_Bar = new System.Windows.Forms.TextBox();
            this.Confirm_ID = new System.Windows.Forms.Button();
            this.comboBoxEmpPos = new System.Windows.Forms.ComboBox();
            this.dataEditHis = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Close_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmpID = new System.Windows.Forms.TextBox();
            this.textBoxEmpname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.textBoxEmppass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmpuser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEmpcon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataEditHis)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_Bar
            // 
            this.Search_Bar.Location = new System.Drawing.Point(17, 185);
            this.Search_Bar.Name = "Search_Bar";
            this.Search_Bar.Size = new System.Drawing.Size(258, 20);
            this.Search_Bar.TabIndex = 0;
            this.Search_Bar.TextChanged += new System.EventHandler(this.Search_Bar_TextChanged);
            // 
            // Confirm_ID
            // 
            this.Confirm_ID.BackColor = System.Drawing.Color.Lime;
            this.Confirm_ID.Location = new System.Drawing.Point(148, 84);
            this.Confirm_ID.Name = "Confirm_ID";
            this.Confirm_ID.Size = new System.Drawing.Size(75, 23);
            this.Confirm_ID.TabIndex = 1;
            this.Confirm_ID.Text = "Confirm ID";
            this.Confirm_ID.UseVisualStyleBackColor = false;
            this.Confirm_ID.Click += new System.EventHandler(this.Confirm_ID_Click);
            // 
            // comboBoxEmpPos
            // 
            this.comboBoxEmpPos.FormattingEnabled = true;
            this.comboBoxEmpPos.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.comboBoxEmpPos.Location = new System.Drawing.Point(445, 87);
            this.comboBoxEmpPos.Name = "comboBoxEmpPos";
            this.comboBoxEmpPos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmpPos.TabIndex = 2;
            // 
            // dataEditHis
            // 
            this.dataEditHis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEditHis.Location = new System.Drawing.Point(17, 211);
            this.dataEditHis.Name = "dataEditHis";
            this.dataEditHis.RowHeadersWidth = 51;
            this.dataEditHis.Size = new System.Drawing.Size(759, 197);
            this.dataEditHis.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Edit Employee Details";
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.IndianRed;
            this.Close_Button.Location = new System.Drawing.Point(701, 13);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(75, 23);
            this.Close_Button.TabIndex = 5;
            this.Close_Button.Text = "Close";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Employee ID";
            // 
            // textBoxEmpID
            // 
            this.textBoxEmpID.Location = new System.Drawing.Point(17, 84);
            this.textBoxEmpID.Name = "textBoxEmpID";
            this.textBoxEmpID.Size = new System.Drawing.Size(125, 20);
            this.textBoxEmpID.TabIndex = 7;
            // 
            // textBoxEmpname
            // 
            this.textBoxEmpname.Location = new System.Drawing.Point(17, 133);
            this.textBoxEmpname.Name = "textBoxEmpname";
            this.textBoxEmpname.Size = new System.Drawing.Size(125, 20);
            this.textBoxEmpname.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(14, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.Yellow;
            this.Edit.Location = new System.Drawing.Point(622, 130);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(121, 23);
            this.Edit.TabIndex = 10;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // textBoxEmppass
            // 
            this.textBoxEmppass.Location = new System.Drawing.Point(253, 133);
            this.textBoxEmppass.Name = "textBoxEmppass";
            this.textBoxEmppass.Size = new System.Drawing.Size(125, 20);
            this.textBoxEmppass.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(250, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // textBoxEmpuser
            // 
            this.textBoxEmpuser.Location = new System.Drawing.Point(253, 87);
            this.textBoxEmpuser.Name = "textBoxEmpuser";
            this.textBoxEmpuser.Size = new System.Drawing.Size(125, 20);
            this.textBoxEmpuser.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(250, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(442, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Position";
            // 
            // textBoxEmpcon
            // 
            this.textBoxEmpcon.Location = new System.Drawing.Point(445, 133);
            this.textBoxEmpcon.Name = "textBoxEmpcon";
            this.textBoxEmpcon.Size = new System.Drawing.Size(125, 20);
            this.textBoxEmpcon.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(442, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Contact";
            // 
            // Edit_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxEmpcon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEmpuser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEmppass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.textBoxEmpname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEmpID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataEditHis);
            this.Controls.Add(this.comboBoxEmpPos);
            this.Controls.Add(this.Confirm_ID);
            this.Controls.Add(this.Search_Bar);
            this.Name = "Edit_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Edit_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEditHis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Search_Bar;
        private System.Windows.Forms.Button Confirm_ID;
        private System.Windows.Forms.ComboBox comboBoxEmpPos;
        private System.Windows.Forms.DataGridView dataEditHis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmpID;
        private System.Windows.Forms.TextBox textBoxEmpname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.TextBox textBoxEmppass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmpuser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEmpcon;
        private System.Windows.Forms.Label label7;
    }
}