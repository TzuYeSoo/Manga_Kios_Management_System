using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Manga_Management
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        static SqlCommand sqlcom2;
        static DataTable transaction_table = new DataTable();

        private void Transaction_Load(object sender, EventArgs e)
        {

            sqlcon.Open();
            datatrans();
            sqlcon.Close();

        }

        private void Book_trans_Click(object sender, EventArgs e)
        {
            Book_Inv bv = new Book_Inv();
            bv.Show();
            this.Hide();
        }

        private void Settings_trans_Click(object sender, EventArgs e)
        {
            Setting_Admin sa = new Setting_Admin();
            sa.Show();
            this.Hide();

        }

        private void Staffs_trans_Click(object sender, EventArgs e)
        {
            StaffsHome sth = new StaffsHome();
            sth.Show();
            this.Hide();

        }

        private void Dash_trans_Click(object sender, EventArgs e)
        {
            Dashboard_Home ds = new Dashboard_Home();
            ds.Show();
            this.Hide();
        }


       

      
        public void datatrans()
        {
            sqlcom = new SqlCommand("SELECT Customers.*, Book_Name FROM Customers " +
                 "INNER JOIN OrderBook ON Customers.Customer_ID = OrderBook.Customer_ID " +
                 "INNER JOIN Book ON OrderBook.Book_ID = Book.Book_ID", sqlcon);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
            transaction_table.Clear();
            adapter.Fill(transaction_table);
            Trans_GridView.DataSource = transaction_table;
        }

        private void Edit_Trans_Click(object sender, EventArgs e)
        {
            Form1 edt = new Form1();
            edt.Show();
            this.Close();
        }

        private void Search_IDTrans_TextChanged(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Customers.*, Book_Name, Book_Price FROM Customers INNER JOIN OrderBook ON Customers.Customer_ID = OrderBook.Customer_ID " +
                "INNER JOIN Book ON OrderBook.Book_ID = Book.Book_ID " +
                "WHERE Customers.Customer_ID LIKE '%" + Search_IDTrans.Text + "%' " +
                "OR Customer_Name LIKE '%" + Search_IDTrans.Text + "%' " +
                "OR Order_Number LIKE '%" + Search_IDTrans.Text + "%' " +
                "OR Book_Name LIKE '%" + Search_IDTrans.Text + "%' " +
                "OR OrderBook.Book_Quantity LIKE '" + Search_IDTrans.Text + "' " +
                "OR Book_Price LIKE '" + Search_IDTrans.Text + "' " +
                "OR Date LIKE '%" + Search_IDTrans.Text + "%'"
                , sqlcon);

            sqlcom.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
            transaction_table.Clear();
            adapter.Fill(transaction_table);
            Trans_GridView.DataSource = transaction_table;


            sqlcon.Close();
        }
    }
}
