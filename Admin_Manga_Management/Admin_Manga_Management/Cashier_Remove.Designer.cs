namespace Admin_Manga_Management
{
    partial class Cashier_Remove
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
            this.Close_Cashier_Remove = new System.Windows.Forms.Button();
            this.Remove_button_Cahsier = new System.Windows.Forms.Button();
            this.Remove_CashierID_Tx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Remove_CashierGrideView = new System.Windows.Forms.DataGridView();
            this.Cashier_RemoveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Remove_CashierGrideView)).BeginInit();
            this.SuspendLayout();
            // 
            // Close_Cashier_Remove
            // 
            this.Close_Cashier_Remove.BackColor = System.Drawing.Color.IndianRed;
            this.Close_Cashier_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Cashier_Remove.Location = new System.Drawing.Point(574, 12);
            this.Close_Cashier_Remove.Name = "Close_Cashier_Remove";
            this.Close_Cashier_Remove.Size = new System.Drawing.Size(75, 23);
            this.Close_Cashier_Remove.TabIndex = 0;
            this.Close_Cashier_Remove.Text = "Close";
            this.Close_Cashier_Remove.UseVisualStyleBackColor = false;
            this.Close_Cashier_Remove.Click += new System.EventHandler(this.Close_Cashier_Remove_Click);
            // 
            // Remove_button_Cahsier
            // 
            this.Remove_button_Cahsier.BackColor = System.Drawing.Color.IndianRed;
            this.Remove_button_Cahsier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_button_Cahsier.Location = new System.Drawing.Point(68, 106);
            this.Remove_button_Cahsier.Name = "Remove_button_Cahsier";
            this.Remove_button_Cahsier.Size = new System.Drawing.Size(75, 23);
            this.Remove_button_Cahsier.TabIndex = 1;
            this.Remove_button_Cahsier.Text = "Remove";
            this.Remove_button_Cahsier.UseVisualStyleBackColor = false;
            this.Remove_button_Cahsier.Click += new System.EventHandler(this.Remove_button_Cahsier_Click);
            // 
            // Remove_CashierID_Tx
            // 
            this.Remove_CashierID_Tx.Location = new System.Drawing.Point(20, 80);
            this.Remove_CashierID_Tx.Name = "Remove_CashierID_Tx";
            this.Remove_CashierID_Tx.Size = new System.Drawing.Size(174, 20);
            this.Remove_CashierID_Tx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cashier";
            // 
            // Remove_CashierGrideView
            // 
            this.Remove_CashierGrideView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Remove_CashierGrideView.Location = new System.Drawing.Point(230, 61);
            this.Remove_CashierGrideView.Name = "Remove_CashierGrideView";
            this.Remove_CashierGrideView.Size = new System.Drawing.Size(430, 190);
            this.Remove_CashierGrideView.TabIndex = 4;
            // 
            // Cashier_RemoveLabel
            // 
            this.Cashier_RemoveLabel.AutoSize = true;
            this.Cashier_RemoveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cashier_RemoveLabel.Location = new System.Drawing.Point(17, 61);
            this.Cashier_RemoveLabel.Name = "Cashier_RemoveLabel";
            this.Cashier_RemoveLabel.Size = new System.Drawing.Size(69, 16);
            this.Cashier_RemoveLabel.TabIndex = 5;
            this.Cashier_RemoveLabel.Text = "Cashier ID";
            // 
            // Cashier_Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 308);
            this.Controls.Add(this.Cashier_RemoveLabel);
            this.Controls.Add(this.Remove_CashierGrideView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Remove_CashierID_Tx);
            this.Controls.Add(this.Remove_button_Cahsier);
            this.Controls.Add(this.Close_Cashier_Remove);
            this.Name = "Cashier_Remove";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Cashier_Remove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Remove_CashierGrideView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close_Cashier_Remove;
        private System.Windows.Forms.Button Remove_button_Cahsier;
        private System.Windows.Forms.TextBox Remove_CashierID_Tx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Remove_CashierGrideView;
        private System.Windows.Forms.Label Cashier_RemoveLabel;
    }
}