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
    public partial class WalkComplete : Form
    {
        public WalkComplete()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        static decimal totalcost;
        private void CashR_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(CashR.Text, out double number))
            {
                CashR.Clear();
            }
        }

        private void WalkComplete_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            for (int i = 0; i < CashierHome.getBIDS.Count; i++)
            {
               
                OrderDetails(Convert.ToInt32(CashierHome.getBIDS[i]), Convert.ToInt32(CashierHome.getQuantity[i]));
            }
            TCost.Text = totalcost.ToString();
            Complete.Visible = false;
            sqlcon.Close();
        }

        public void OrderDetails(int id, int quan)
        {
            sqlcom = new SqlCommand("SELECT Book_Name, Book_Price FROM Book WHERE Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@BID", id);
            SqlDataReader rdr = sqlcom.ExecuteReader();
            if (rdr.Read())
            {
                Bookname.Text += "\n" + (string)rdr.GetValue(0);
                Price.Text += "\n" + rdr.GetValue(1).ToString();
                Quantity.Text += "\n" + quan.ToString();
                totalcost += (quan * Convert.ToDecimal(rdr.GetValue(1)));
            }
            rdr.Close();
        }

        private void ConPayment_Click(object sender, EventArgs e)
        {
            if(Convert.ToDecimal(CashR.Text) > Convert.ToDecimal(TCost.Text) || CashR.Text.Equals(TCost.Text))
            {
                change.Text = (Convert.ToDecimal(CashR.Text) - Convert.ToDecimal(TCost.Text)).ToString();
                cash.Text = CashR.Text;
                Complete.Visible = true;
                ConPayment.Visible = false;
                CashR.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid Inputs");
            }
        }

        private void Complete_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            sqlcom = new SqlCommand();
            sqlcon.Close();
        }
    }
}
