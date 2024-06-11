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
        private int getID, quantity = 1;
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
            sqlcom = new SqlCommand("SELECT Book_Name, Book_Price, Description, BookImage FROM Book WHERE Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@BID", ID);
            rdr = sqlcom.ExecuteReader();

            if (rdr.Read())
            {
                /*
                SelectBook BSelect = new SelectBook();

                byte[] imageBynari = (byte[])rdr.GetValue(2);

                using (MemoryStream ms = new MemoryStream(imageBynari))
                {
                    BSelect.BookImage.Image = Image.FromStream(ms);
                    BSelect.BookImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                Array.Clear(imageBynari, 0, imageBynari.Length);


                BSelect.BookImage.Tag = rdr.GetValue(2);
                BSelect.BN = (string)rdr.GetValue(0);
                BSelect.Bp = Convert.ToDouble(rdr.GetValue(1));
                BSelect.Quantity.Text = "1";
                Selected_Book.Controls.Add(BSelect);
                */

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
            Book_Cart Bcart = new Book_Cart();
            if (Quantity.Text != "0")
            {
                Bcart.getID = ID;
                Bcart.getQuantity = Convert.ToInt32(Quantity.Text);
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please input Right Quantity!", "Quantity", MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            }
            sqlcon.Close();
        }

        private void AddQuan_Click(object sender, EventArgs e)
        {
            //sqlcon.Open();
            Quantity.Text = (++quantity).ToString();

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
