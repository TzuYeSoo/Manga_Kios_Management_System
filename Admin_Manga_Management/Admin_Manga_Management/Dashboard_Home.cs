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
            

            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Customers.*, Book_Name FROM Customers " +
                "INNER JOIN OrderBook ON Customers.Customer_ID = OrderBook.Customer_ID " +
                "INNER JOIN Book ON OrderBook.Book_ID = Book.Book_ID", sqlcon);
            SqlDataAdapter Adap = new SqlDataAdapter(sqlcom);
            Dash_Table.Clear();
            Adap.Fill(Dash_Table);
            Dashboard_Grideview.DataSource = Dash_Table;
            sqlcon.Close();
            
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

        private void Settings_Ad_Click(object sender, EventArgs e)
        {
            Setting_Admin sa = new Setting_Admin();
            sa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stocks_reports sr = new Stocks_reports();
            sr.Show();
            this.Hide();
        }
    }
}
