using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
        static SqlCommand sqlcom;
        static SqlCommand sqlcom2;
        static int ord, cid;
        private decimal iTCOST;
        private int ID, quan;
        static LinkedList<int> IDS = new LinkedList<int>();
        static LinkedList<int> Quan = new LinkedList<int>();
        static Customer_Number csnum;

        private void COrder_Click(object sender, EventArgs e)
        {
            
            RunNum();
            sqlcon.Open();
            if (Name.Text != "")
            {
                sqlcom = new SqlCommand("INSERT INTO Customers(Customer_Name, Order_Number, Date, Total_Cost, Customer_Status) " +
                    "VALUES(@CNAME, @Onum, @DATE, @tcost, @Cstat)", sqlcon);
                sqlcom.Parameters.AddWithValue("@CNAME", Name.Text);
                sqlcom.Parameters.AddWithValue("@Onum", ord);
                sqlcom.Parameters.AddWithValue("@DATE", DateTime.Now);
                sqlcom.Parameters.AddWithValue("@tcost", iTCOST);
                sqlcom.Parameters.AddWithValue("@Cstat", 1);
                sqlcom.ExecuteNonQuery();

                sqlcom2 = new SqlCommand("SELECT Customer_ID FROM Customers WHERE Customer_Name = @name AND Order_Number = @ord", sqlcon);
                sqlcom2.Parameters.AddWithValue("@ord", ord);
                sqlcom2.Parameters.AddWithValue("@name", Name.Text);
                SqlDataReader rdr = sqlcom2.ExecuteReader();

               
                if (rdr.Read())
                {
                    cid = Convert.ToInt32(rdr.GetValue(0));
                }
                rdr.Close();

                Book_Cart bc = new Book_Cart();
                bc.removecarts();
                bc.Hide();
                csnum = new Customer_Number();
                for (int i = 0; i < IDS.Count; i++)
                {
                    sqlcom = new SqlCommand("INSERT INTO OrderBook Values(@CID, @BID, @quan)", sqlcon);
                    sqlcom.Parameters.AddWithValue("@CID", cid);
                    sqlcom.Parameters.AddWithValue("@BID", IDS.ElementAt(i));
                    sqlcom.Parameters.AddWithValue("@quan", Quan.ElementAt(i));
                    sqlcom.ExecuteNonQuery();
                }

                for (int i = 0; i < IDS.Count; i++)
                {
                    string bname;
                    decimal price;
          
                    sqlcom = new SqlCommand("SELECT Book_Name, Book_Price FROM Book WHERE Book_ID = @ID", sqlcon);
                    sqlcom.Parameters.AddWithValue("@ID", IDS.ElementAt(i));

                    SqlDataReader rdr1 = sqlcom.ExecuteReader();

                    if (rdr1.Read())
                    {
                        csnum.tcost.Text = iTCOST.ToString();
                        csnum.Bname.Text += "\n" + (string)rdr1.GetValue(0);
                        csnum.Price.Text += "\n" + rdr1.GetValue(1).ToString();
                        csnum.Quan.Text += "\n" + Quan.ElementAt(i).ToString();
                        csnum.ord_num.Text = cid.ToString();
                    }


                    rdr1.Close();


                }
                csnum.ShowDialog();

                Name.Clear();
                this.Close();

            }
            sqlcon.Close();
        }
        public void RunNum()
        {

            Random rand = new Random();
            ord = rand.Next(1,2000);  
        }
        public void CustQuery(int id, int quan)
        {
            csnum = new Customer_Number();

            
        }
        public decimal TCOST { get { return iTCOST; } set { iTCOST = value;} }
        public int getidi { get { return ID; }set { ID = value; IDS.AddLast(value); } }
        public int getquan { get { return quan; } set { quan = value; Quan.AddLast(value); } }

    }
}
