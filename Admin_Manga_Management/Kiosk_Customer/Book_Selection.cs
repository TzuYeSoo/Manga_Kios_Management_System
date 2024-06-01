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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        static BookChoice BookS;

        public void BookShow()
        {
            sqlcom = new SqlCommand("SELECT Book_ID, Book_Name, Book_Price, BookImage FROM Book", sqlcon);  
            SqlDataReader rdr = sqlcom.ExecuteReader();

            while (rdr.Read())
            {
                BookS = new BookChoice();
                
                byte[] imageBynary = (byte[])rdr.GetValue(3);

                using (var ms = new MemoryStream(imageBynary))
                {
                    BookS.BookImage.Image = Image.FromStream(ms);
                    BookS.BookImage.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                Array.Clear(imageBynary, 0, imageBynary.Length);

                BookS.BookImage.Tag = rdr.GetValue(3);
                BookS.getBookID = Convert.ToInt16(rdr.GetValue(0));
                BookS.getBook = (string)rdr.GetValue(1);
                BookS.getBookPrice = Convert.ToDouble(rdr.GetValue(2));
                
                Books.Controls.Add(BookS);

                BookS.Click += new System.EventHandler(UserControl_Click);
            }
            rdr.Close();

        }
        void UserControl_Click(Object sender, EventArgs e)
        {
            BookChoice book = (BookChoice)sender;

            BookInfo f2 = new BookInfo();
            f2.ID = book.getBookID;
            f2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            BookShow();
            sqlcon.Close();
        }

        private void CartItem_Click(object sender, EventArgs e)
        {
            Book_Cart BC = new Book_Cart();
            BC.Show();
            this.Hide();
        }
    }
}
