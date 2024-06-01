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
                AddToCart add = new AddToCart();

                byte[] imageBynari = (byte[])rdr.GetValue(2);
                using (MemoryStream ms = new MemoryStream(imageBynari))
                {
                    add.BookIm.Image = Image.FromStream(ms);
                    add.BookIm.SizeMode = PictureBoxSizeMode.StretchImage;
                    add.getquan = quan;
                }
                MessageBox.Show(quan +"asada" + id);

                add.BookIm.Tag = rdr.GetValue(2);
                add.BookP = Convert.ToDouble(rdr.GetValue(1));
                add.Bname = (string)rdr.GetValue(0);

                CartPanel.Controls.Add(add);
            }
            sqlcon.Close();
            
            


        }

        private void Book_Cart_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < ID.Count; i++)
            {
                
                Book_CartOUt(ID.ElementAt(i), Quantity.ElementAt(i));


            }
        }
    }
}
