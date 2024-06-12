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
        static bool checker;
        private int cid;
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
            if (MessageBox.Show("Complete this transaction ", "Complete Transaction", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sqlcon.Open();
                LogIn log = new LogIn();
                sqlcom = new SqlCommand("INSERT INTO Customers VALUES(@Customer,0,@empID,@Date,@TotalCost,2, @Cuspay)", sqlcon);
                sqlcom.Parameters.AddWithValue("@Customer", "Customer");
                sqlcom.Parameters.AddWithValue("@empID", log.EID);
                sqlcom.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy/MM/dd"));
                sqlcom.Parameters.AddWithValue("@TotalCost", Convert.ToDecimal(TCost.Text));
                sqlcom.Parameters.AddWithValue("@Cuspay", Convert.ToDecimal(cash.Text));
                sqlcom.ExecuteNonQuery();

                for (int i = 0; i < CashierHome.getBIDS.Count; i++)
                {
                    update_Bookquan(Convert.ToInt32(CashierHome.getBIDS[i]), Convert.ToInt32(CashierHome.getBIDS[i]));
                    stockR(Convert.ToInt32(CashierHome.getBIDS[i]), Convert.ToInt32(CashierHome.getBIDS[i]));
                }

                WalkIn_Rec wr = new WalkIn_Rec();
                wr.ShowDialog();
                this.Close();
                sqlcon.Close();
            }
        }
        public void update_Bookquan(int id, int quan)
        {
            sqlcom = new SqlCommand("SELECT Book_Quantity FROM Book WHERE Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@BID", id);
            int quans = 0;
            SqlDataReader rdr = sqlcom.ExecuteReader();

            if (rdr.Read())
            {
                if(quan == Convert.ToInt32(rdr.GetValue(0)))
                {
                    checker = true;
                }
                else
                {
                    checker = false;
                    quans = quan - Convert.ToInt32(rdr.GetValue(0));
                }
            }
            rdr.Close();
            if (checker == true)
            {
                sqlcom = new SqlCommand("UPDATE Book SET Book_Status = 0, Book_Quantity = 0 WHERE Book_ID = @BID", sqlcon);
                sqlcom.Parameters.AddWithValue("@BID", id);
                sqlcom.ExecuteNonQuery();
            }
            else
            {
               
                sqlcom = new SqlCommand("UPDATE Book SET Book_Quantity = @quan WHERE Book_ID = @BID", sqlcon);
                sqlcom.Parameters.AddWithValue("@BID", id);
                sqlcom.Parameters.AddWithValue("@quan", quans);
                sqlcom.ExecuteNonQuery();
            }


        }
        public void stockR(int id, int quan)
        {
            sqlcom = new SqlCommand("INSERT INTO Stocks_Report VALUES (@date, @desc, @bid, @Quan)", sqlcon);
            sqlcom.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy/MM/dd"));
            sqlcom.Parameters.AddWithValue("@desc","Sales");
            sqlcom.Parameters.AddWithValue("@bid", id);
            sqlcom.Parameters.AddWithValue("@Quan", quan);
            sqlcom.ExecuteNonQuery();
        }
    }
}
