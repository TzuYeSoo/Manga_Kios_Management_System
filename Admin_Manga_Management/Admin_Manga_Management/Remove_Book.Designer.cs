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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove_Book));
            this.Delete_Book_History = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RConfirm_BookID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Book_Hisotry = new System.Windows.Forms.DataGridView();
            this.Confirm_BID = new System.Windows.Forms.Button();
            this.Close_RBook = new System.Windows.Forms.Button();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.RetrieveBook = new System.Windows.Forms.Button();
            this.RConfirm_ID = new System.Windows.Forms.Button();
            this.RBook = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Book_History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Hisotry)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete_Book_History
            // 
            this.Delete_Book_History.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Delete_Book_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Delete_Book_History.Location = new System.Drawing.Point(24, 290);
            this.Delete_Book_History.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_Book_History.Name = "Delete_Book_History";
            this.Delete_Book_History.RowHeadersWidth = 62;
            this.Delete_Book_History.RowTemplate.Height = 28;
            this.Delete_Book_History.Size = new System.Drawing.Size(755, 170);
            this.Delete_Book_History.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remove Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Removed Book History";
            // 
            // RConfirm_BookID
            // 
            this.RConfirm_BookID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RConfirm_BookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RConfirm_BookID.Location = new System.Drawing.Point(24, 58);
            this.RConfirm_BookID.Margin = new System.Windows.Forms.Padding(2);
            this.RConfirm_BookID.Name = "RConfirm_BookID";
            this.RConfirm_BookID.Size = new System.Drawing.Size(178, 23);
            this.RConfirm_BookID.TabIndex = 3;
            this.RConfirm_BookID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book ID";
            // 
            // Book_Hisotry
            // 
            this.Book_Hisotry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Book_Hisotry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Book_Hisotry.Location = new System.Drawing.Point(25, 82);
            this.Book_Hisotry.Margin = new System.Windows.Forms.Padding(2);
            this.Book_Hisotry.Name = "Book_Hisotry";
            this.Book_Hisotry.RowHeadersWidth = 62;
            this.Book_Hisotry.RowTemplate.Height = 28;
            this.Book_Hisotry.Size = new System.Drawing.Size(753, 140);
            this.Book_Hisotry.TabIndex = 5;
            // 
            // Confirm_BID
            // 
            this.Confirm_BID.BackColor = System.Drawing.Color.LightGreen;
            this.Confirm_BID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_BID.ForeColor = System.Drawing.Color.Black;
            this.Confirm_BID.Location = new System.Drawing.Point(205, 55);
            this.Confirm_BID.Margin = new System.Windows.Forms.Padding(2);
            this.Confirm_BID.Name = "Confirm_BID";
            this.Confirm_BID.Size = new System.Drawing.Size(77, 23);
            this.Confirm_BID.TabIndex = 6;
            this.Confirm_BID.Text = "Confirm ID";
            this.Confirm_BID.UseVisualStyleBackColor = false;
            this.Confirm_BID.Click += new System.EventHandler(this.Confirm_BID_Click);
            // 
            // Close_RBook
            // 
            this.Close_RBook.BackColor = System.Drawing.Color.IndianRed;
            this.Close_RBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_RBook.ForeColor = System.Drawing.Color.Black;
            this.Close_RBook.Location = new System.Drawing.Point(715, 8);
            this.Close_RBook.Margin = new System.Windows.Forms.Padding(2);
            this.Close_RBook.Name = "Close_RBook";
            this.Close_RBook.Size = new System.Drawing.Size(77, 21);
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
            this.Remove_Button.Location = new System.Drawing.Point(286, 55);
            this.Remove_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(77, 23);
            this.Remove_Button.TabIndex = 8;
            this.Remove_Button.Text = "Remove";
            this.Remove_Button.UseVisualStyleBackColor = false;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // RetrieveBook
            // 
            this.RetrieveBook.BackColor = System.Drawing.Color.LightCoral;
            this.RetrieveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetrieveBook.ForeColor = System.Drawing.Color.Black;
            this.RetrieveBook.Location = new System.Drawing.Point(289, 263);
            this.RetrieveBook.Margin = new System.Windows.Forms.Padding(2);
            this.RetrieveBook.Name = "RetrieveBook";
            this.RetrieveBook.Size = new System.Drawing.Size(77, 23);
            this.RetrieveBook.TabIndex = 10;
            this.RetrieveBook.Text = "Retrieve";
            this.RetrieveBook.UseVisualStyleBackColor = false;
            this.RetrieveBook.Click += new System.EventHandler(this.RetrieveBook_Click);
            // 
            // RConfirm_ID
            // 
            this.RConfirm_ID.BackColor = System.Drawing.Color.LightGreen;
            this.RConfirm_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RConfirm_ID.ForeColor = System.Drawing.Color.Black;
            this.RConfirm_ID.Location = new System.Drawing.Point(208, 263);
            this.RConfirm_ID.Margin = new System.Windows.Forms.Padding(2);
            this.RConfirm_ID.Name = "RConfirm_ID";
            this.RConfirm_ID.Size = new System.Drawing.Size(77, 23);
            this.RConfirm_ID.TabIndex = 9;
            this.RConfirm_ID.Text = "Confirm ID";
            this.RConfirm_ID.UseVisualStyleBackColor = false;
            this.RConfirm_ID.Click += new System.EventHandler(this.RConfirm_ID_Click);
            // 
            // RBook
            // 
            this.RBook.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBook.Location = new System.Drawing.Point(26, 263);
            this.RBook.Margin = new System.Windows.Forms.Padding(2);
            this.RBook.Name = "RBook";
            this.RBook.Size = new System.Drawing.Size(178, 23);
            this.RBook.TabIndex = 11;
            this.RBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Remove_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.RBook);
            this.Controls.Add(this.RetrieveBook);
            this.Controls.Add(this.RConfirm_ID);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.Close_RBook);
            this.Controls.Add(this.Confirm_BID);
            this.Controls.Add(this.Book_Hisotry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RConfirm_BookID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete_Book_History);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Remove_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
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
        private System.Windows.Forms.Button RetrieveBook;
        private System.Windows.Forms.Button RConfirm_ID;
        private System.Windows.Forms.TextBox RBook;
    }
}