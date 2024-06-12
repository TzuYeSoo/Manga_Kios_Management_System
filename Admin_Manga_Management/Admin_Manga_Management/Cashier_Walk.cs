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
    public partial class Cashier_Walk : UserControl
    {
        public Cashier_Walk()
        {
            InitializeComponent();
        }
        static int quantity =1;
        static int quan;
        static int BID;
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        public int getBID { get { return BID; } set { BID = value; } }
        private void add_Click(object sender, EventArgs e)
        {
            
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Book_Quantity FROM Book WHERE Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@BID", BID);
            SqlDataReader rdr = sqlcom.ExecuteReader();
            if (rdr.Read())
            {
                quan = Convert.ToInt32(rdr.GetValue(0));
            }
            rdr.Close();
            if(quan > quantity)
            {
                quantity++;
                Bquan.Text = quantity.ToString();
                CashierHome.getQuantity.Insert(CashierHome.getBIDS.IndexOf(getBID), quantity);

            }
            else
            {
                MessageBox.Show("The item have already max it's stocks");
            }
            sqlcon.Close();
           
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (quantity > 1)
            {
                quantity--;
                Bquan.Text = quantity.ToString();
                CashierHome.getQuantity.Insert(CashierHome.getBIDS.IndexOf(getBID), quantity);
            }
            
        }
    }
}
