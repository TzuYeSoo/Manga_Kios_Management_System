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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kiosk_Customer
{
    public partial class BookInfo : Form
    {
        
        public BookInfo()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        private int getID, quantity = 1, Book_quan;
        private decimal tcost;
        static SqlDataReader rdr;


        public int ID { get { return getID; } set { getID = value; } }

        private void Back_Click(object sender, EventArgs e)
        {
            Quantity.Text = "1";
            this.Hide();
        }
        public void BookPanel()
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Book_Name, Book_Price, Description, BookImage, Book_Quantity FROM Book WHERE Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@BID", ID);
            rdr = sqlcom.ExecuteReader();

            if (rdr.Read())
            {
                byte[] imageBynari = (byte[])rdr.GetValue(3);

                using (MemoryStream ms = new MemoryStream(imageBynari))
                {
                    Book_Image.Image = Image.FromStream(ms);
                    Book_Image.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                Array.Clear(imageBynari, 0, imageBynari.Length);


                Book_Image.Tag = rdr.GetValue(3);
                Book_Name.Text = (string)rdr.GetValue(0);
                Book_Price.Text = rdr.GetValue(1).ToString();
                desc.Text = (string)rdr.GetValue(2);
                Quantity.Text = "1";
                Book_quan = Convert.ToInt32(rdr.GetValue(4));

            }
            rdr.Close();

           
            sqlcom = new SqlCommand("SELECT Bookgenre FROM Book_GenreName WHERE Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@BID", ID);
            rdr = sqlcom.ExecuteReader();

            while (rdr.Read())
            {
                Genre.Text += "\n" + (string)rdr.GetValue(0) + " ";
            }

            sqlcon.Close();

        }

        private void Add_To_Cart_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            if (Quantity.Text != "0")
            {
                if (Book_Cart.BookID.Contains(getID))
                {
                    if(MessageBox.Show("This Book is already in your cart do you want to add quantity?","Already in Cart", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int quan = Book_Cart.BookID.IndexOf(getID);

                        int new_quan = Convert.ToInt32(Quantity.Text) + Convert.ToInt32(Book_Cart.QuantityID[quan]);
                        if(new_quan > Book_quan)
                        {
                            MessageBox.Show("Sorry but stock is low");
                        }
                        else
                        {
                            Book_Cart.QuantityID.Insert(Book_Cart.BookID.IndexOf(getID), new_quan);
                            this.Hide();
                        }
                        
                    }
                }
                else
                {
                    Book_Cart Bcart = new Book_Cart();
                    Bcart.getID = ID;
                    Bcart.getQuantity = Convert.ToInt32(Quantity.Text);
                    this.Hide();
                }
               

            }
            else
            {
                MessageBox.Show("Please input Right Quantity!", "Quantity", MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            }
            sqlcon.Close();
        }

        private void AddQuan_Click(object sender, EventArgs e)
        {
            if (quantity < Book_quan)
            {
                Quantity.Text = (++quantity).ToString();
            }
            else
            {
                MessageBox.Show("Sorry but stock is low");
            }
        }

        private void MinQuan_Click(object sender, EventArgs e)
        {
            if(Quantity.Text != "1")
            {
                Quantity.Text = (--quantity).ToString();
            }
        }
    }
}
