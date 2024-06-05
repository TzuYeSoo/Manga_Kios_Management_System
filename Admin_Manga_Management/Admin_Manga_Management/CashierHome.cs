using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Manga_Management
{
    public partial class CashierHome : Form
    {
        public CashierHome()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        private int id, ord;
        private string name;
        private decimal price;
        static LinkedList<int> cid = new LinkedList<int>();
        static LinkedList<int> bid = new LinkedList<int>();

        public int getID { get { return id; } set { id = value; } }
        public int getord { get { return ord; } set { ord = value; } }
        public string getname { get { return name; } set { name = value; } }
        public decimal totalcost { get { return price; }set { price = value; } }
        private void CashierHome_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            Cashhome();
            sqlcon.Close();

        }
        public void getids()
        {
            sqlcom = new SqlCommand("SELECT Customer_Name, Book_Name, Book_Price, OrderBook.Book_Quantity FROM Customers " +
                "INNER JOIN OrderBook ON Customers.Customer_ID = OrderBook.Customer_ID " +
                "INNER JOIN Book ON OrderBook.Book_ID = Book.Book_ID WHERE Customers.Customer_ID = @cid AND Customer_Status = 1", sqlcon);
            sqlcom.Parameters.AddWithValue("@cid", getID);

        }

        private void Search_Box_Book_TextChanged(object sender, EventArgs e)
        {
            sqlcon.Open();
            if (Search_Box_Book.Text != "")
            {
             
                sqlcom = new SqlCommand("SELECT Book_Name, Book_Price, BookImage FROM Book WHERE Book_Name LIKE '%" + Search_Box_Book.Text + "%'", sqlcon);
                Book_Items.Controls.Clear();
                SqlDataReader rdr1 = sqlcom.ExecuteReader();

                while (rdr1.Read())
                {
                    Cashier_Books book = new Cashier_Books();

                    book.Bprice.Text = rdr1.GetValue(1).ToString();
                    book.Bname.Text = (string)rdr1.GetValue(0);
                    byte[] imageBinary = (byte[])rdr1.GetValue(2);
                    using (MemoryStream ms = new MemoryStream(imageBinary))
                    {
                        book.bookim.Image = Image.FromStream(ms);
                        book.bookim.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    book.bookim.Tag = rdr1.GetValue(2);

                    Book_Items.Controls.Add(book);
                }
                rdr1.Close();
            }
            else
            {
                Book_Items.Controls.Clear();
                Cashhome();
            }
            sqlcon.Close();
        }
        public void Cashhome()
        {
            sqlcom = new SqlCommand("SELECT Book_Name, Book_Price, BookImage FROM Book", sqlcon);

            SqlDataReader rdr = sqlcom.ExecuteReader();

            while (rdr.Read())
            {
                Cashier_Books book = new Cashier_Books();

                book.Bprice.Text = rdr.GetValue(1).ToString();
                book.Bname.Text = (string)rdr.GetValue(0);
                byte[] imageBinary = (byte[])rdr.GetValue(2);
                using (MemoryStream ms = new MemoryStream(imageBinary))
                {
                    book.bookim.Image = Image.FromStream(ms);
                    book.bookim.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                book.bookim.Tag = rdr.GetValue(2);

                Book_Items.Controls.Add(book);
            }
        }

        private void Kios_Cus_Click(object sender, EventArgs e)
        {
            Cahsier_kios_Cus ckc = new Cahsier_kios_Cus();
            ckc.Show();
            this.Hide();
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            if (TotalPrice.Text != "<Total Price>" && TotalPrice.Text != "0")
            {
                Cashier_RecievePayment crp = new Cashier_RecievePayment();
                crp.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please Input Order First");
            }
            
        }

        public void Paying(int bid)
        {
            sqlcon.Open();
            PayCus pay = new PayCus();

            sqlcom = new SqlCommand("SELECT Customer_Name, Book_Name, Book_Price, OrderBook.Book_Quantity, Book.Book_ID FROM Customers " +
                "INNER JOIN OrderBook ON Customers.Customer_ID = OrderBook.Customer_ID " +
                "INNER JOIN Book ON OrderBook.Book_ID = Book.Book_ID WHERE Customers.Customer_ID = @cid AND Customer_Status = 1 AND OrderBook.Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@cid", getID);
            sqlcom.Parameters.AddWithValue("@BID", bid);

            SqlDataReader rdr = sqlcom.ExecuteReader();

            while (rdr.Read())
            {
                pay.Cname.Text = (string)rdr.GetValue(0);
                pay.Bname.Text = (string)rdr.GetValue(1);
                pay.OrderPrice.Text = rdr.GetValue(2).ToString();
                pay.getQuantity = Convert.ToInt32(rdr.GetValue(3));
                pay.getCID = Convert.ToInt32(rdr.GetValue(4));
                totalcost += Convert.ToDecimal(rdr.GetValue(2)) * Convert.ToInt32(rdr.GetValue(3));
                PayOrder.Controls.Add(pay);
                pay.gettcost = totalcost;

            }

            TotalPrice.Text = totalcost.ToString();
            sqlcon.Close();
        }
      
    }
}
