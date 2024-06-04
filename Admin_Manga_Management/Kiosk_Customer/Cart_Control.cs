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
    public partial class Cart_Control : UserControl
    {
        public Cart_Control()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        private int quantity;
        private int id;
        static decimal tcost;
        public int getquan { get { return quantity; } set { quantity = value; Quans.Text = value.ToString(); } }
        public int getID { get { return id; } set { id = value; } }
        public decimal gettcost { get { return tcost; } set { tcost = value; } }
        static Book_Cart bcart = new Book_Cart();
        private void Min_Quan_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            sqlcom = new SqlCommand("SELECT Book_Price FROM Book WHERE Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@BID", getID);
            SqlDataReader rdr = sqlcom.ExecuteReader();
            if (quantity != 0)
            {
                if (rdr.Read())
                {
                    tcost = tcost - Convert.ToDecimal(rdr.GetValue(0));
                }

                rdr.Close();
                bcart.label1.Text = tcost.ToString();
                quantity--;
                Quans.Text = quantity.ToString();

                if (Quans.Text == "0")
                {

                }
                
            }
            sqlcon.Close();
            
        }

        private void Add_Quan_Click(object sender, EventArgs e)
        {
            quantity++;
            Quans.Text = quantity.ToString();
        }
    }
}
