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
    public partial class BookInfo : Form
    {
        
        public BookInfo()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        private int getID;

        private void Form2_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Book_Name, Book_Price, BookImage FROM Book WHERE Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@BID", ID);
            SqlDataReader rdr = sqlcom.ExecuteReader();
            if (rdr.Read())
            {

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

                Selected_Book.Controls.Add(BSelect);
            }

            sqlcon.Close();
        }

        public int ID { get { return getID; } set { getID = value; } }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Add_To_Cart_Click(object sender, EventArgs e)
        {
            SelectBook BSelect = new SelectBook();
            Book_Cart bc = new Book_Cart();
            bc.getID = ID;
            bc.getQuantity = BSelect.Quan;
            BSelect.Quan = 1;

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }
    }
}
