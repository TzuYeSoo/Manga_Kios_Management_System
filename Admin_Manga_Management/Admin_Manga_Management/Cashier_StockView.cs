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

namespace Admin_Manga_Management
{
    public partial class Cashier_StockView : Form
    {
        public Cashier_StockView()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Log out Account", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LogIn log = new LogIn();
                log.Show();
                this.Close();
            }
        }

        private void Kios_Cus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to leve this site?", "leave this site", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Cahsier_kios_Cus cus = new Cahsier_kios_Cus();
                cus.Show();
                this.Hide();
            }

        }

        private void Walkin_Click(object sender, EventArgs e)
        {
            CashierHome ch = new CashierHome();
            ch.Show();
            this.Hide();
        }

        private void Cashier_StockView_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            ShowStocks();
            sqlcon.Close();
        }
        public void ShowStocks()
        {
            sqlcom = new SqlCommand("SELECT Book_Name, Book_Quantity, BookImage FROM Book WHERE Book_Status = 1", sqlcon);
            SqlDataReader rdr = sqlcom.ExecuteReader();

            while (rdr.Read())
            {
                CashierStock_Control csc = new CashierStock_Control();
                csc.Bname.Text = (string)rdr.GetValue(0);
                csc.BStocks.Text = rdr.GetValue(1).ToString();

                byte[] imageBinary = (byte[])rdr.GetValue(2);
                using (MemoryStream ms = new MemoryStream(imageBinary))
                {
                    csc.bookIm.Image = Image.FromStream(ms);
                    csc.bookIm.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                csc.bookIm.Tag = rdr.GetValue(2);
                Stocks.Controls.Add(csc);
            }
            rdr.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sqlcom = new SqlCommand("SELECT Book_Name, Book_Quantity, BookImage FROM Book WHERE Book_Status = 1 " +
                "AND Book_Name LIKE %'"+textBox1.Text+"'%", sqlcon);
            SqlDataReader rdr = sqlcom.ExecuteReader();
            Stocks.Controls.Clear();
            while (rdr.Read())
            {
                CashierStock_Control csc = new CashierStock_Control();
                csc.Bname.Text = (string)rdr.GetValue(0);
                csc.BStocks.Text = rdr.GetValue(1).ToString();

                byte[] imageBinary = (byte[])rdr.GetValue(2);
                using (MemoryStream ms = new MemoryStream(imageBinary))
                {
                    csc.bookIm.Image = Image.FromStream(ms);
                    csc.bookIm.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                csc.bookIm.Tag = rdr.GetValue(2);

                Stocks.Controls.Add(csc);
            }
            rdr.Close();
        }
    }
}
