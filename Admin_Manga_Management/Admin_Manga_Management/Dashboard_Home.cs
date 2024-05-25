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
    public partial class Dashboard_Home : Form
    {
        public Dashboard_Home()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom = new SqlCommand();
        static DataTable Dash_Table = new DataTable();
        private void Dashboard_Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.database1DataSet.Customers);
            // TODO: This line of code loads data into the 'database1DataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.database1DataSet.Book);


            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Customer_ID, Customer_Name, Order_Number, Book_Price, Book_Name, Customers.Book_Quantity FROM Customers INNER JOIN Book ON Book.Book_ID = Customers.Book_ID ",sqlcon);
            SqlDataAdapter Adap = new SqlDataAdapter(sqlcom);
            Adap.Fill(Dash_Table);
            Dashboard_Grideview.DataSource = Dash_Table;
            sqlcon.Close();

            //TransHis_Chart]

        }

        private void Trans_OP_Click(object sender, EventArgs e)
        {
            Transaction tr = new Transaction();
            tr.Show();
            this.Hide();

        }

        private void Book_Inventory_Click(object sender, EventArgs e)
        {
            Book_Inv BV = new Book_Inv();
            BV.Show();
            this.Hide();

        }

        private void Staffs_Click(object sender, EventArgs e)
        {
            StaffsHome sfh = new StaffsHome();
            sfh.Show();
            this.Hide();
        }

     
    }
}
