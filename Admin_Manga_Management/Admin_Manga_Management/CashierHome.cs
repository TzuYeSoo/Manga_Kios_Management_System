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

namespace Admin_Manga_Management
{
    public partial class CashierHome : Form
    {
        public CashierHome()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        private int id, quan, listNum = 0;
        public static ArrayList getBIDS = new ArrayList();
        static LinkedList<int> getIDList = new LinkedList<int>();
        static LinkedList<int> getIDQuan = new LinkedList<int>();
        public static ArrayList getQuantity = new ArrayList();
        private void Kios_Cus_Click(object sender, EventArgs e)
        {
            Cahsier_kios_Cus ckc = new Cahsier_kios_Cus();
            ckc.Show();
            this.Hide();
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            WalkComplete wc = new WalkComplete();
            wc.Show();
            this.Hide();
        }

        private void CashierHome_Load(object sender, EventArgs e)
        {
            sqlcon.Open();

            sqlcom = new SqlCommand("SELECT Book_Name, Book_Price, Book_ID, BookImage FROM Book WHERE Book_Status = 1", sqlcon);
            SqlDataReader rdr = sqlcom.ExecuteReader();
            
            while (rdr.Read())
            {
                Cashier_Books book = new Cashier_Books();
                book.Bname.Text = (string)rdr.GetValue(0);
                book.Bprice.Text = rdr.GetValue(1).ToString();
                book.labelID.Text = rdr.GetValue(2).ToString();

                byte[] imageBinary = (byte[])rdr.GetValue(3);

                using (MemoryStream ms = new MemoryStream(imageBinary))
                {
                    book.bookim.Image = Image.FromStream(ms);
                    book.bookim.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                book.bookim.Tag = rdr.GetValue(3);


                Book_Items.Controls.Add(book);
                book.Click += new System.EventHandler(book_Click);

            }
            sqlcon.Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Log out Account", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LogIn log = new LogIn();
                log.Show();
                this.Close();
            }

        }

        public void book_Click(object sender, EventArgs e)
        {
            Cashier_Books book = (Cashier_Books)sender;
            if (!getIDList.Contains(Convert.ToInt16(book.labelID.Text)))
            {
                Cashier_Walk pay = new Cashier_Walk();
                pay.Bname.Text = book.Bname.Text;
                pay.Bprice.Text = book.Bprice.Text;
                pay.Bquan.Text = "1";
                
                getIDList.AddLast(Convert.ToInt16(book.labelID.Text));
                getIDQuan.AddLast(Convert.ToInt32(pay.Bquan.Text));
               
                pay.getBID = Convert.ToInt32(book.labelID.Text);
                Newcust.Controls.Add(pay);

                for(int i = 0; i <  getIDList.Count; i++)
                {
                    if (!getBIDS.Contains(getIDList.ElementAt(i)))
                    {
                        getBIDS.Add(getIDList.ElementAt(i));
                        getQuantity.Add(getIDQuan.ElementAt(i));
                    }
                    
                }
                MessageBox.Show(getBIDS.Count + "");
            }
            else
            {
                MessageBox.Show("Item Added already");
            }
        }
        public void removeVals()
        {
            getBIDS.Clear();
            getIDList.Clear();
            getIDQuan.Clear();
            getIDQuan.Clear();
        }
    }
}
