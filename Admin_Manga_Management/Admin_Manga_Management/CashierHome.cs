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
    public partial class CashierHome : Form
    {
        public CashierHome()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        static DataTable dt = new DataTable();
        private void CashierHome_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Book_Name, Customers.Book_Quantity FROM Customers " +
                "INNER JOIN OrderBook ON Customers.Customer_ID = OrderBook.Customer_ID " +
                "INNER JOIN Book ON OrderBook.Book_ID = Book.Book_ID", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            dt.Clear();
            sda.Fill(dt);
            CustomerOrder.DataSource = dt;
            sqlcon.Close();

        }
    }
}
