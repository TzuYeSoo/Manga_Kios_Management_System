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
    public partial class Book_Cart : Form
    {
        public Book_Cart()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        public static ArrayList BookID = new ArrayList();
        public static ArrayList QuantityID = new ArrayList();
        private int setID, setquan;
        private decimal tcost;
        public int getID { get { return setID; } set { setID = value; BookID.Add(value); } }
        public int getQuantity { get { return setquan; } set { setquan = value; QuantityID.Add(value); } }
        public decimal getTcost { get { return tcost; }set { tcost = value; } }
        
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
                add.Bprice.Text = rdr.GetValue(1).ToString();
                tcost += (Convert.ToDecimal(rdr.GetValue(1)) * quan);
                add.Bname.Text= (string)rdr.GetValue(0);
                add.Quans.Text = quan.ToString();
                add.getquan = quan;
                add.getID = id;
                add.label1.Text = id.ToString();
                CartPanel.Controls.Add(add);
                add.gettcost = tcost;

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
            if(CartPanel.Controls.Count == 0)
            {
                MessageBox.Show("PLease Make an order first");

            }
            else
            {
                if (MessageBox.Show("Do you want to continue to order this book", "Complete Order", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    Complete_Order corder = new Complete_Order();
                    corder.TCOST = Convert.ToDecimal(TTPrice.Text);
                    corder.ShowDialog();
                    this.Hide();
                }
            }
            
            
        }

        private void Book_Cart_Load(object sender, EventArgs e)
        {
            showBooks();
            TTPrice.Text = tcost.ToString();

        }
        public void showBooks()
        {
   
            for (int i = 0; i < BookID.Count; i++)
            {
                Book_CartOUt(Convert.ToInt32(BookID[i]), Convert.ToInt32(QuantityID[i]));
            }
            
        }
        public void removecarts()
        {
            Complete_Order co = new Complete_Order();
            for (int i = 0;i < BookID.Count; i++)
            {
                co.getidi = Convert.ToInt32(BookID[i]);
                co.getquan = Convert.ToInt32(QuantityID[i]);
            }
            BookID.Clear();
            QuantityID.Clear();
        }
    }
}
