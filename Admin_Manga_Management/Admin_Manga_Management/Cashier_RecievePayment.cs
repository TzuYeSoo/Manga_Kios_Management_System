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
using System.Text.RegularExpressions;

namespace Admin_Manga_Management
{
    public partial class Cashier_RecievePayment : Form
    {
        public Cashier_RecievePayment()
        {
            InitializeComponent();
        }
        private int CID;
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        static SqlCommand sqlcom2;
        private decimal Finalcost;
        private int EmpID, Quans;
        
        public int getCID { get { return CID; }set { CID = value; } }
        public LinkedList<int> bid = new LinkedList<int>();
        public LinkedList<int> quan = new LinkedList<int>();

        public decimal tcost { get { return Finalcost; } set { Finalcost = value; } }
        private void CashR_TextChanged(object sender, EventArgs e)
        {
            if(CashR.Text == "Insert Money Recieved")
            {
                CashR.Clear();
            }
            CashR.ForeColor = Color.Black;

           
        }
        public void Customer_Order(int quan, int id)
        {

            sqlcon.Open();

            sqlcom = new SqlCommand("SELECT Book_Name, Book_Price, Total_Cost, OrderBook.Book_Quantity, Order_Number FROM Customers " +
                "INNER JOIN OrderBook ON Customers.Customer_ID = OrderBook.Customer_ID " +
                "INNER JOIN Book ON OrderBook.Book_ID = Book.Book_ID WHERE Customers.Customer_ID = @CID AND OrderBook.Book_ID = @BID ",sqlcon);
            sqlcom.Parameters.AddWithValue("@CID", getCID);
            sqlcom.Parameters.AddWithValue("@BID", id);

            SqlDataReader rdr = sqlcom.ExecuteReader();
            if (rdr.Read())
            {
                Cashier_CompleteOrder cco = new Cashier_CompleteOrder();

                cco.BookQuan.Text = quan.ToString();
                cco.BookPrice.Text = rdr.GetValue(1).ToString();
                cco.BookName.Text = (string)rdr.GetValue(0);
                cco.OrdNum.Text = rdr.GetValue(4).ToString();

                corder.Controls.Add(cco);
                TCost.Text = Finalcost.ToString();
            }
            sqlcon.Close();

            
        }

        private void Cashier_RecievePayment_Load(object sender, EventArgs e)
        {
            Complete.Visible = false;
            getlist();
            for(int i = 0; i < bid.Count; i++)
            {
              //+ bid.ElementAt(i));
                Customer_Order(quan.ElementAt(i), bid.ElementAt(i));
            }
        }
        public void getlist()
        {
            sqlcon.Open();

            sqlcom = new SqlCommand("SELECT Book_Quantity, Book_ID FROM OrderBook WHERE Customer_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@BID", getCID);

            SqlDataReader rdr = sqlcom.ExecuteReader();

            while (rdr.Read())
            {
                bid.AddLast(Convert.ToInt32(rdr.GetValue(1)));
                quan.AddLast(Convert.ToInt32(rdr.GetValue(0)));
            }
            rdr.Close();
            sqlcon.Close();
        }

        

        private void ConPayment_Click(object sender, EventArgs e)
        {
            Match match = Regex.Match(CashR.Text, "^[0-9]+$", RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                MessageBox.Show("Invalid Inputs");
                CashR.Clear();

            }
            else
            {
                if (Convert.ToDecimal(CashR.Text) > Convert.ToDecimal(TCost.Text))
                {
                    change.Text = (Convert.ToDecimal(CashR.Text) - Convert.ToDecimal(TCost.Text)).ToString();
                    Complete.Visible = true;
                    ConPayment.Visible = false;
                    CashR.Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid Cash Recieved");
                }
                cash.Text = CashR.Text;

            }
            

        }

        private void Complete_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            if(MessageBox.Show("Continue to Complete this Transaction", "Complete Transaction", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LogIn logIn = new LogIn();

                empID = logIn.EID;
                sqlcom = new SqlCommand("UPDATE Customers SET Total_Cost = @tcost, Customer_Status = 2, Employee_ID = @eid", sqlcon);
                sqlcom.Parameters.AddWithValue("@eid", empID);
                sqlcom.Parameters.AddWithValue("@tcost", Finalcost);
                sqlcom.ExecuteNonQuery();
                MessageBox.Show(empID + "");
                Cashier_REC cre = new Cashier_REC();
                for (int i = 0; i < bid.Count; i++)
                {
                    sqlcom = new SqlCommand("SELECT Book_Name, Book.Book_Price, OrderBook.Book_Quantity FROM Book " +
                        "INNER JOIN OrderBook ON Book.Book_ID = OrderBook.Book_ID WHERE Book.Book_ID = @BID", sqlcon);
                    sqlcom.Parameters.AddWithValue("@BID", bid.ElementAt(i));
                    SqlDataReader rdr = sqlcom.ExecuteReader();
                    if (rdr.Read())
                    {
                        cre.addText(Convert.ToDecimal(rdr.GetValue(1)), (string)rdr.GetValue(0), Convert.ToInt32(rdr.GetValue(2)));

                    }
                    cre.Tcost.Text = TCost.Text;
                    cre.Cash.Text = cash.Text;
                    cre.Change.Text = cash.Text;
                    cre.ShowDialog();
                    rdr.Close();
                    mindstock(bid.ElementAt(i), quan.ElementAt(i));
                }
                Cashier_REC cashier_REC = new Cashier_REC();

                this.Close();

            }
            
            sqlcon.Close();

        }
        public void mindstock(int id, int quan)
        {
            sqlcom2 = new SqlCommand("SELECT Book_Quantity FROM Book WHERE Book_ID = @id", sqlcon);
            sqlcom2.Parameters.AddWithValue("@id", id);

            SqlDataReader rdr = sqlcom2.ExecuteReader();
            if (rdr.Read())
            {
                Quans = Convert.ToInt32(rdr.GetValue(0));
            }
            rdr.Close();


            sqlcom = new SqlCommand("UPDATE Book SET Book_Quantity = @bnum WHERE Book_ID = @bid", sqlcon);
            sqlcom.Parameters.AddWithValue("@bid", id);
            sqlcom.Parameters.AddWithValue("@bnum", Quans - quan);
            sqlcom.ExecuteNonQuery();

        }
        public int empID { get { return EmpID; } set { EmpID = value; } }
    }
}
