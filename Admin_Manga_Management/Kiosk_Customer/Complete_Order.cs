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

namespace Kiosk_Customer
{
    public partial class Complete_Order : Form
    {
        public Complete_Order()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom = new SqlCommand();
        static int ord;
        private void COrder_Click(object sender, EventArgs e)
        {
            Book_Cart bCart = new Book_Cart();
            RunNum();
            sqlcon.Open();
            if (Name.Text != "")
            {
                sqlcom = new SqlCommand("INSERT INTO Customers(Customer_ID, Customer_Name, Order_Number, Date, Total_Cost, Customer_Status) " +
                    "VALUES(@CNAME, @Onum, @DATE, @tcost, @Cstat)", sqlcon);
                sqlcom.Parameters.AddWithValue("@CNAME", Name.Text);
                sqlcom.Parameters.AddWithValue("@Onum", ord);
                sqlcom.Parameters.AddWithValue("@DATE", DateTime.Now);
                sqlcom.Parameters.AddWithValue("@tcost", Convert.ToDecimal(bCart.TTPrice.Text));
                sqlcom.Parameters.AddWithValue("@Cstat", 1);
            }
            sqlcon.Close();
        }
        public void RunNum()
        {
            Random rand = new Random(2000);
            ord = rand.Next();
        }

    }
}
