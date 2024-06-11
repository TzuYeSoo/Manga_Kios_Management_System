using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Manga_Management
{
    public partial class Stocks_reports : Form
    {
        public Stocks_reports()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        static SqlDataReader rdr;
        private void Stocks_reports_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            Stock_Report();
            sqlcon.Close();
        }

        public void Stock_Report()
        {
            sqlcom = new SqlCommand("SELECT Book.Book_Name, Quantity_Stock, Stocks_Report.Description, Date_Report FROM Stocks_Report " +
                "INNER JOIN Book ON Stocks_Report.Book_ID = Book.Book_ID", sqlcon);
            rdr = sqlcom.ExecuteReader();

            while(rdr.Read())
            {
                Book_Report_Panel brp = new Book_Report_Panel();
                brp.Book_Name.Text = (string)rdr.GetValue(0);
                brp.Book_Quantity.Text = rdr.GetValue(1).ToString();
                brp.Description.Text = (string)rdr.GetValue(2);
                brp.Date_Report.Text = rdr.GetValue(3).ToString();

                Book_Activity.Controls.Add(brp);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard_Home dsh = new Dashboard_Home();
            dsh.Show();
            this.Hide();
        }

        private void Staffs_Click(object sender, EventArgs e)
        {
            StaffsHome dsh = new StaffsHome();
            dsh.Show();
            this.Hide();
        }

        private void Book_Inventory_Click(object sender, EventArgs e)
        {
            Book_Inv dsh = new Book_Inv();
            dsh.Show();
            this.Hide();
        }

        private void Trans_OP_Click(object sender, EventArgs e)
        {
            Transaction dsh = new Transaction();
            dsh.Show();
            this.Hide();
        }

        private void Settings_Ad_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
