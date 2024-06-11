using System;
using System.Collections;
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
        static SqlDataReader rdr;
        public void BookShow()
        {
            sqlcom = new SqlCommand("SELECT Book_ID, Book_Name, Book_Price, BookImage FROM Book", sqlcon);  
            rdr = sqlcom.ExecuteReader();

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
            }
            rdr.Close(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            BookShow();
            CategPicker();
            sqlcon.Close();
        }
        public void CategPicker()
        {
            sqlcom = new SqlCommand("SELECT BookGenreNames FROM BookOptions", sqlcon);
            rdr = sqlcom.ExecuteReader();

            while (rdr.Read())
            {
                Category_Bar cat = new Category_Bar();
                cat.CategoryLabel.Text = (string)rdr.GetValue(0);

                Category_Bar_Des.Controls.Add(cat);
                cat.Click += new System.EventHandler(Cat_Click);
            }
        }
        public void Cat_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            Category_Bar cat = (Category_Bar)sender;

            cat.Clicked.Visible = true;
            Books.Controls.Clear();

            sqlcom = new SqlCommand("SELECT Book.Book_ID, Book_Name, Book_Price, BookImage, Bookgenre FROM Book INNER JOIN " +
                "Book_GenreName ON Book.Book_ID = Book_GenreName.Book_ID WHERE Bookgenre = @genre", sqlcon);
            sqlcom.Parameters.AddWithValue("@genre", cat.CategoryLabel.Text);
            rdr = sqlcom.ExecuteReader();
            while (rdr.Read())
            {
                BookChoice BookS = new BookChoice();

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
                BookS.Genre.Text = (string)rdr.GetValue(4);
                Books.Controls.Add(BookS);
            }
            sqlcon.Close();
        }

        private void CartItem_Click(object sender, EventArgs e)
        {
            Book_Cart BC = new Book_Cart();
            BC.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sqlcon.Open();
            Books.Controls.Clear();
            sqlcom = new SqlCommand("SELECT Book_ID, Book_Name, Book_Price, BookImage FROM Book WHERE Book_Name LIKE '%"+textBox1.Text+"%'", sqlcon);

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
            }
            rdr.Close();

            sqlcon.Close();
        }
    }
}
