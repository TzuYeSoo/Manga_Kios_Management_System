namespace Admin_Manga_Management
{
    partial class Remove_Book
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
            this.Delete_Book_History = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RConfirm_BookID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Book_Hisotry = new System.Windows.Forms.DataGridView();
            this.Confirm_BID = new System.Windows.Forms.Button();
            this.Close_RBook = new System.Windows.Forms.Button();
            this.Remove_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Book_History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Hisotry)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete_Book_History
            // 
            this.Delete_Book_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Delete_Book_History.Location = new System.Drawing.Point(36, 373);
            this.Delete_Book_History.Name = "Delete_Book_History";
            this.Delete_Book_History.RowHeadersWidth = 62;
            this.Delete_Book_History.RowTemplate.Height = 28;
            this.Delete_Book_History.Size = new System.Drawing.Size(1132, 262);
            this.Delete_Book_History.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remove Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Removed Book History";
            // 
            // RConfirm_BookID
            // 
            this.RConfirm_BookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RConfirm_BookID.Location = new System.Drawing.Point(36, 90);
            this.RConfirm_BookID.Name = "RConfirm_BookID";
            this.RConfirm_BookID.Size = new System.Drawing.Size(265, 30);
            this.RConfirm_BookID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book ID";
            // 
            // Book_Hisotry
            // 
            this.Book_Hisotry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Book_Hisotry.Location = new System.Drawing.Point(38, 126);
            this.Book_Hisotry.Name = "Book_Hisotry";
            this.Book_Hisotry.RowHeadersWidth = 62;
            this.Book_Hisotry.RowTemplate.Height = 28;
            this.Book_Hisotry.Size = new System.Drawing.Size(1130, 216);
            this.Book_Hisotry.TabIndex = 5;
            // 
            // Confirm_BID
            // 
            this.Confirm_BID.BackColor = System.Drawing.Color.Lime;
            this.Confirm_BID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_BID.ForeColor = System.Drawing.Color.Black;
            this.Confirm_BID.Location = new System.Drawing.Point(307, 85);
            this.Confirm_BID.Name = "Confirm_BID";
            this.Confirm_BID.Size = new System.Drawing.Size(116, 35);
            this.Confirm_BID.TabIndex = 6;
            this.Confirm_BID.Text = "Confirm ID";
            this.Confirm_BID.UseVisualStyleBackColor = false;
            this.Confirm_BID.Click += new System.EventHandler(this.Confirm_BID_Click);
            // 
            // Close_RBook
            // 
            this.Close_RBook.BackColor = System.Drawing.Color.Lime;
            this.Close_RBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_RBook.ForeColor = System.Drawing.Color.Black;
            this.Close_RBook.Location = new System.Drawing.Point(1072, 12);
            this.Close_RBook.Name = "Close_RBook";
            this.Close_RBook.Size = new System.Drawing.Size(116, 33);
            this.Close_RBook.TabIndex = 7;
            this.Close_RBook.Text = "Close";
            this.Close_RBook.UseVisualStyleBackColor = false;
            this.Close_RBook.Click += new System.EventHandler(this.Close_RBook_Click);
            // 
            // Remove_Button
            // 
            this.Remove_Button.BackColor = System.Drawing.Color.LightCoral;
            this.Remove_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_Button.ForeColor = System.Drawing.Color.Black;
            this.Remove_Button.Location = new System.Drawing.Point(429, 85);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(116, 35);
            this.Remove_Button.TabIndex = 8;
            this.Remove_Button.Text = "Remove";
            this.Remove_Button.UseVisualStyleBackColor = false;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // Remove_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.Close_RBook);
            this.Controls.Add(this.Confirm_BID);
            this.Controls.Add(this.Book_Hisotry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RConfirm_BookID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete_Book_History);
            this.Name = "Remove_Book";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Remove_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Book_History)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Hisotry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Delete_Book_History;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RConfirm_BookID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Book_Hisotry;
        private System.Windows.Forms.Button Confirm_BID;
        private System.Windows.Forms.Button Close_RBook;
        private System.Windows.Forms.Button Remove_Button;
    }
}