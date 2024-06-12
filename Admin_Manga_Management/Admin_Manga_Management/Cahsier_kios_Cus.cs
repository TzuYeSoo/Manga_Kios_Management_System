using System;
using System.Collections;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Admin_Manga_Management
{
    public partial class Cahsier_kios_Cus : Form
    {
        public Cahsier_kios_Cus()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        static decimal totalcost;
        static ArrayList CID = new ArrayList();
        static ArrayList BID = new ArrayList();
        static int id;
        public void CustShow()
        {
            sqlcon.Open();

            sqlcom = new SqlCommand("SELECT Customers.Customer_ID, Book_ID, Customer_Name, Order_Number FROM Customers " +
                "INNER JOIN OrderBook ON Customers.Customer_ID = OrderBook.Customer_ID WHERE Customer_Status = 1", sqlcon);



            SqlDataReader rdr = sqlcom.ExecuteReader();
            while (rdr.Read())
            {
                if (!CID.Contains(Convert.ToInt32(rdr.GetValue(0))))
                {
                    CID.Add(Convert.ToInt32(rdr.GetValue(0)));
                }
                if (!BID.Contains(Convert.ToInt32(rdr.GetValue(1))))
                {
                    BID.Add(Convert.ToInt32(rdr.GetValue(1)));
                }


            }
            rdr.Close();
            rdr.Close();
            sqlcon.Close();
        }

        private void Cahsier_kios_Cus_Load(object sender, EventArgs e)
        {
            CustPanel.Controls.Clear();
            CustShow();

            for (int i = 0; i < CID.Count; i++)
            {
                customers(Convert.ToInt32(CID[i]));
            }
        }
        public void Cust_CLick(object sender, EventArgs e)
        {
           
            Chasier_KiosControl ckc = (Chasier_KiosControl)sender;
            sqlcon.Open();
            PayCus pay = new PayCus();

            sqlcom = new SqlCommand("SELECT Customer_Name, Book_Name, Book_Price, OrderBook.Book_Quantity, Book.Book_ID, Total_Cost FROM Customers " +
                "INNER JOIN OrderBook ON Customers.Customer_ID = OrderBook.Customer_ID " +
                "INNER JOIN Book ON OrderBook.Book_ID = Book.Book_ID WHERE Customers.Customer_ID = @cid AND Customer_Status = 1 AND OrderBook.Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@cid", Convert.ToInt32(ckc.CustIDlabel.Text));
            sqlcom.Parameters.AddWithValue("@BID", Convert.ToInt32(ckc.label1.Text));

            SqlDataReader rdr = sqlcom.ExecuteReader();

            while (rdr.Read())
            {
                pay.Cname.Text = (string)rdr.GetValue(0);
                pay.Bname.Text = (string)rdr.GetValue(1);
                pay.min_quan.Visible = false;
                pay.plus_quan.Visible = false;
                pay.OrderPrice.Text = rdr.GetValue(2).ToString();
                pay.getQuantity = Convert.ToInt32(rdr.GetValue(3));
                pay.getCID = Convert.ToInt32(rdr.GetValue(4));
                totalcost = Convert.ToDecimal(rdr.GetValue(5));
                PayOrder.Controls.Add(pay);
                pay.gettcost = totalcost;
                id = Convert.ToInt32(ckc.CustIDlabel.Text);
            }

            tcost.Text = totalcost.ToString();
            sqlcon.Close();



        }
        public void customers(int ciddd)
        {
            sqlcon.Open();
            Chasier_KiosControl ckc = new Chasier_KiosControl();

            sqlcom = new SqlCommand("SELECT Customers.Customer_ID, Customer_Name, Order_Number, Total_Cost, Book_ID FROM Customers INNER JOIN " +
                "OrderBook ON Customers.Customer_ID = OrderBook.Customer_ID WHERE Customers.Customer_ID = @id ", sqlcon);
            sqlcom.Parameters.AddWithValue("@id", ciddd);

            SqlDataReader rdr1 = sqlcom.ExecuteReader();

            if (rdr1.Read())
            {
                ckc.CustIDlabel.Text = rdr1.GetValue(0).ToString();
                ckc.OrdNumber.Text = rdr1.GetValue(2).ToString();
                ckc.CustName.Text = (string)rdr1.GetValue(1);
                ckc.label1.Text = rdr1.GetValue(4).ToString();
                CustPanel.Controls.Add(ckc);

                ckc.Click += new EventHandler(Cust_CLick);
            }
            sqlcon.Close();
        }
        public void clearItems()
        {
           BID.Clear();
           CID.Clear();
        }

        private void Walkin_Click(object sender, EventArgs e)
        {
            CashierHome ch = new CashierHome();
            ch.Show();
            this.Hide();
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            if (tcost.Text != "<Total Price>" && tcost.Text != "0")
            {
                Cashier_RecievePayment crp = new Cashier_RecievePayment();
                crp.getCID = id;
                crp.tcost = Convert.ToDecimal(tcost.Text);
                crp.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Input Order First");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Log out Account", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LogIn log = new LogIn();
                log.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to leave this site", "LEave this site", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PayOrder.Controls.Clear();
                Cashier_StockView csv = new Cashier_StockView();
                csv.Show();
                this.Close();
            }
        }
    }
}
