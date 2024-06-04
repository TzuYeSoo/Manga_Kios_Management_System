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



        public int ID { get { return getID; } set { getID = value; } }

        private void Back_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
        public void BookPanel()
        {
            MessageBox.Show("asdad" + ID);
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

        private void Add_To_Cart_Click(object sender, EventArgs e)
        {
            SelectBook sl = new SelectBook();

            if(sl.Quan != 0)
            {
                
                Book_Cart Bcart = new Book_Cart();
                Bcart.getID = ID;
                Bcart.getQuantity = sl.Quan;
                sl.Quan = 1;
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please input Right Quantity!", "Quantity", MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            }
            
        }
    }
}
