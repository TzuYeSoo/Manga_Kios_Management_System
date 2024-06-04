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
    public partial class Book_Cart : Form
    {
        public Book_Cart()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        public static LinkedList<int> ID = new LinkedList<int>();
        public static LinkedList<int> Quantity = new LinkedList<int>();
        private int setID, setquan;
        public int getID { get { return setID; } set { setID = value; ID.AddLast(value); } }
        public int getQuantity { get { return setquan; } set { setquan = value; Quantity.AddLast(value); } }
        public void Book_CartOUt(int id, int quan)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Book_Name, Book_Price, BookImage FROM Book WHERE Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@BID", id);
            SqlDataReader rdr = sqlcom.ExecuteReader();
            
            if (rdr.Read())
            {
                Cart_Control add = new Cart_Control();

                byte[] imageBynari = (byte[])rdr.GetValue(2);
                using (MemoryStream ms = new MemoryStream(imageBynari))
                {
                    add.Book_Im.Image = Image.FromStream(ms);
                    add.Book_Im.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                add.Book_Im.Tag = rdr.GetValue(2);
                add.Bprice.Text = (Convert.ToDouble(rdr.GetValue(1)) * quan).ToString();
                add.Bname.Text= (string)rdr.GetValue(0);
                add.Quans.Text = quan.ToString();
                CartPanel.Controls.Add(add);
                
                
            }
            rdr.Close();
            sqlcon.Close();
            
            


        }

        private void back_Book_Click(object sender, EventArgs e)
        {
           Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void check_out_Click(object sender, EventArgs e)
        {
            Checkout_Cus cout = new Checkout_Cus();

            for(int i = 0; i < ID.Count; i++)
            {
                cout.getBID = ID.ElementAt(i);
                cout.getQUAN = Quantity.ElementAt(i);
            }
            
            cout.Show();
            this.Hide();
        }

        private void Book_Cart_Load(object sender, EventArgs e)
        {
            showBooks();
        }
        public void showBooks()
        {
            Cart_Control ad = new Cart_Control();
            for (int i = 0; i < ID.Count; i++)
            {
                if (ad.Quans.Text == "0")
                {
                    ID.Remove(i);
                    Quantity.Remove(i);

                    CartPanel.Controls.Clear();
                    Book_CartOUt(ID.ElementAt(i), Quantity.ElementAt(i));
                }
                else
                {
                    Book_CartOUt(ID.ElementAt(i), Quantity.ElementAt(i));
                    ID.Remove(i);
                    Quantity.Remove(i);
                }
            }
        }
    }
}
