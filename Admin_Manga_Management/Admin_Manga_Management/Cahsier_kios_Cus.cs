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
    public partial class Cahsier_kios_Cus : Form
    {
        public Cahsier_kios_Cus()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        static LinkedList<int> cids = new LinkedList<int>();
        static LinkedList<int> bids = new LinkedList<int>();
        public void CustShow()
        {
            sqlcon.Open();

            sqlcom = new SqlCommand("SELECT Customers.Customer_ID, Book_ID, Customer_Name, Order_Number FROM Customers " +
                "INNER JOIN OrderBook ON Customers.Customer_ID = OrderBook.Customer_ID WHERE Customer_Status = 1", sqlcon);


            
            SqlDataReader rdr = sqlcom.ExecuteReader();
            while (rdr.Read())
            {
                if (!cids.Contains(Convert.ToInt16(rdr.GetValue(0))))
                {
                    cids.AddLast(Convert.ToInt32(rdr.GetValue(0)));

                    
                }
                if (!bids.Contains(Convert.ToInt32(rdr.GetValue(1))))
                {
                    bids.AddLast(Convert.ToInt32(rdr.GetValue(1)));
                }
                

            }
            rdr.Close();
           
           
            sqlcon.Close();
        }

        private void Cahsier_kios_Cus_Load(object sender, EventArgs e)
        {
            CustShow();

            for (int i = 0; i < cids.Count; i++)
            {
                customers(cids.ElementAt(i));
            }
        }
        public void Cust_CLick(object sender, EventArgs e)
        {


            sqlcom = new SqlCommand("SELECT Customers.Customer_ID, Book_ID, Customer_Name, Order_Number FROM Customers " +
                "INNER JOIN OrderBook ON Customers.Customer_ID = OrderBook.Customer_ID WHERE Customer_Status = 1", sqlcon);

            Chasier_KiosControl ckc = (Chasier_KiosControl)sender;
            CashierHome chome = new CashierHome();

            //for(int i )
            chome.getID = Convert.ToInt16(ckc.CustIDlabel.Text);
            chome.getord = Convert.ToInt32(ckc.OrdNumber.Text);
            chome.getname = ckc.CustName.Text;
            for(int i = 0; i < bids.Count; i++)
            {
          
                chome.Paying(bids.ElementAt(i));
            }
            
            chome.Show();
            this.Hide();

        }
        public void customers(int ciddd)
        {
            sqlcon.Open();
            Chasier_KiosControl ckc = new Chasier_KiosControl();

            sqlcom = new SqlCommand("SELECT Customer_ID, Customer_Name, Order_Number, Total_Cost FROM Customers WHERE Customer_ID = @id ", sqlcon);
            sqlcom.Parameters.AddWithValue("@id", ciddd);

            SqlDataReader rdr1 = sqlcom.ExecuteReader();

            if (rdr1.Read())
            {
                ckc.CustIDlabel.Text = rdr1.GetValue(0).ToString();
                ckc.OrdNumber.Text = rdr1.GetValue(2).ToString();
                ckc.CustName.Text = (string)rdr1.GetValue(1);

                CustPanel.Controls.Add(ckc);

                ckc.Click += new EventHandler(Cust_CLick);
            }
            sqlcon.Close();
        }
        public void clearItems()
        {
            cids.Clear();
            bids.Clear();
        }

        private void Walkin_Click(object sender, EventArgs e)
        {
            CashierHome ch = new CashierHome();
            ch.Show();
            this.Hide();
        }
    }
}
