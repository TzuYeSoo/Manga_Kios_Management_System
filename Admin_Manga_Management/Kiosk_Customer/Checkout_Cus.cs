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

namespace Kiosk_Customer
{
    public partial class Checkout_Cus : Form
    {
        public Checkout_Cus()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        static SqlCommand sqlcom2;
        static LinkedList<int> bid = new LinkedList<int>();
        static LinkedList<int> Quan = new LinkedList<int>();
        static Checkout_Books coutb;
        private int ID;
        static int count;
        private int quan;
        private double TotalCost;
        private void Checkout_Cus_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            for (int i = 0; i < Quan.Count; i++)
            {
                book_cout(bid.ElementAt(i), Quan.ElementAt(i));
            }

            Tprice.Text = TotalCost.ToString();
            sqlcon.Close();
        }
        public void book_cout(int ID, int quan)
        {
            coutb = new Checkout_Books();
            sqlcom = new SqlCommand("SELECT Book_Name, Book_Price, BookImage FROM Book WHERE Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@BID", ID);

            SqlDataReader rdr = sqlcom.ExecuteReader();
            if (rdr.Read())
            {
                byte[] imageBinary = (byte[])rdr.GetValue(2);

                using (MemoryStream ms = new MemoryStream(imageBinary))
                {
                    coutb.Book_Image.Image = Image.FromStream(ms);
                    coutb.Book_Image.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                coutb.Book_Image.Tag = rdr.GetValue(2);
                coutb.Bname.Text = (string)rdr.GetValue(0);
                coutb.Bprice.Text = rdr.GetValue(1).ToString();

                TotalCost += (Convert.ToDouble(rdr.GetValue(1)) * quan);
            }

            rdr.Close();

            coutb.Bquan.Text = quan.ToString();

            Cout_Book.Controls.Add(coutb);
            
        }

        public int getBID { get{ return ID; } set{ ID = value; bid.AddLast(value); } }
        public int getQUAN { get { return quan; } set { quan = value; Quan.AddLast(value); } }

        private void Checkout_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            if (Cout_Book.Controls.Count != 0 && Cust_name.Text != "Please input your name here")
            {
                

                sqlcom = new SqlCommand("INSERT INTO Customers(Customer_Name, Order_Number, Date, Total_Cost, Customer_Status )VALUES(@cname, @conum, @date, @total, @customerstat)", sqlcon);
                sqlcom.Parameters.AddWithValue("@cname", Cust_name.Text);
                sqlcom.Parameters.AddWithValue("@conum", 1);
                sqlcom.Parameters.AddWithValue("@date", DateTime.Now);
                sqlcom.Parameters.AddWithValue("@total", TotalCost);
                sqlcom.Parameters.AddWithValue("@customerstat", 1);

                sqlcom.ExecuteNonQuery();

                sqlcom2 = new SqlCommand("SELECT Customer_ID FROM Customers WHERE Customer_Name = @cname AND Total_Cost = @tcost", sqlcon);
                sqlcom2.Parameters.AddWithValue("@cname", Cust_name.Text);
                sqlcom2.Parameters.AddWithValue("@date", DateTime.Now);
                sqlcom2.Parameters.AddWithValue("@tcost", TotalCost);

                SqlDataReader rdr = sqlcom2.ExecuteReader();

                if (rdr.Read())
                {
                    count = Convert.ToInt16(rdr.GetValue(0));
                }
                rdr.Close();
                for(int i = 0; i < Cout_Book.Controls.Count; i++)
                {
                    sqlcom2 = new SqlCommand("INSERT INTO OrderBook Values (@CID, @BID, @Cquan)",sqlcon);
                    sqlcom2.Parameters.AddWithValue("@CID", count);
                    sqlcom2.Parameters.AddWithValue("@BID", bid.ElementAt(i));
                    sqlcom2.Parameters.AddWithValue("@Cquan", Quan.ElementAt(i));

                    sqlcom2.ExecuteNonQuery();
                }
                bid.Clear();
                Quan.Clear();
                Cust_name.Clear();
                Form1 bs = new Form1();
                bs.Show();
                this.Hide();

                
            }
            else
            {
                MessageBox.Show("Please Complete the Credentials first");
            }
            sqlcon.Close();
        }

        private void Cust_name_TextChanged(object sender, EventArgs e)
        {
            if(Cust_name.ForeColor == Color.Gray)
            {
                Cust_name.Clear();
            }
            Cust_name.ForeColor = Color.Black;
        }
    }
}
