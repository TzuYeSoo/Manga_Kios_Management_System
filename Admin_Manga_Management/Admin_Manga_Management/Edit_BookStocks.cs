using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Manga_Management
{
    public partial class Edit_BookStocks : Form
    {
        public Edit_BookStocks()
        {
            InitializeComponent();
        }
        private int Bid;
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        static SqlDataReader rdr;
        public int getID { get { return Bid; }set { Bid = value; } }

        private void Edit_BookStocks_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            Book();
            sqlcon.Close();
        }

        public void Book()
        {
            sqlcom = new SqlCommand("SELECT Book_Name, BookImage, Book_Quantity FROM Book WHERE Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@BID", Bid);

            rdr = sqlcom.ExecuteReader();

            if (rdr.Read())
            {
                byte[] ImageBinary = (byte[])rdr.GetValue(1);
                using (MemoryStream ms = new MemoryStream(ImageBinary))
                {
                    Book_Image.Image = Image.FromStream(ms);
                    Book_Image.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                Stock_Quantity.Text = rdr.GetValue(2).ToString();
                Stock_Quantity.ReadOnly = true;
                Book_Image.Tag = rdr.GetValue(1);
                Bname.Text = (string)rdr.GetValue(0);
            }
            rdr.Close();
        }

        private void Add_Stock_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            if(Stock_edit.Text != "" && Desc_Report.Text != "")
            {
                if (MessageBox.Show("Continue to Add this Stock into this book \n if the Book is inactive it will become active", "Add Stocks", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ValueInsert();
                    AddQuan();
                    MessageBox.Show("Stock added Succesfully");
                    Edit_BookInv eb = new Edit_BookInv();
                    eb.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please input a complete details or Quantity", "Incomplete Details");
            }
            sqlcon.Close();
        }
        public void ValueInsert()
        {
            sqlcom = new SqlCommand("INSERT INTO Stocks_Report VALUES(@Date, @Description, @BookID, @Quantity)", sqlcon);
            sqlcom.Parameters.AddWithValue("@BookID", getID);
            sqlcom.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy/MM/dd"));
            sqlcom.Parameters.AddWithValue("@Description", Desc_Report.Text);
            sqlcom.Parameters.AddWithValue("@Quantity", Convert.ToInt32(Stock_edit.Text));

            sqlcom.ExecuteNonQuery();
        }
        public void AddQuan()
        {
            int quantity = Convert.ToInt32(Stock_Quantity.Text) + Convert.ToInt32(Stock_edit.Text);

            sqlcom = new SqlCommand("UPDATE Book SET Book_Quantity = @quan, Book_Status = 1 WHERE Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@BID", getID);
            sqlcom.Parameters.AddWithValue("@quan", quantity);

            sqlcom.ExecuteNonQuery();
        }
        public void MinQuan()
        {
            int quantity = Convert.ToInt32(Stock_Quantity.Text) - Convert.ToInt32(Stock_edit.Text);
            MessageBox.Show("sasd" + quantity);
            sqlcom = new SqlCommand("UPDATE Book SET Book_Quantity = @quan WHERE Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@BID", getID);
            sqlcom.Parameters.AddWithValue("@quan", quantity);
            sqlcom.ExecuteNonQuery();
        }
        private void Min_Quantity_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            if (Stock_edit.Text != "" && Desc_Report.Text != "")
            {
                if (Convert.ToInt32(Stock_Quantity.Text) > Convert.ToInt32(Stock_edit.Text))
                {
                    if (MessageBox.Show("Continue to Add this Stock into this book", "Add Stocks", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ValueInsert();
                        MinQuan();
                        MessageBox.Show("Stock Subtract Succesfully");
                        Edit_BookInv eb = new Edit_BookInv();
                        eb.Show();
                        this.Close();
                    }
                }
                else if (Convert.ToInt32(Stock_Quantity.Text) == Convert.ToInt32(Stock_edit.Text))
                {
                    sqlcom = new SqlCommand("UPDATE Book SET Book_Status = 0, Book_Quantity = 0 WHERE Book_ID = @BID", sqlcon);
                    sqlcom.Parameters.AddWithValue("@BID", getID);
                    sqlcom.ExecuteNonQuery();
                    ValueInsert();
                    MessageBox.Show("Stock Remove Succesfully");
                    Edit_BookInv eb = new Edit_BookInv();
                    eb.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cannot Subtract Quantity higher than the existing quantity");
                }
               
            }
            else
            {
                MessageBox.Show("Please input a complete details or Quantity", "Incomplete Details");
            }
            sqlcon.Close();
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            Edit_BookInv eb = new Edit_BookInv();
            eb.Show();
            this.Close();
        }

        private void Stock_edit_TextChanged(object sender, EventArgs e)
        {
            Match match = Regex.Match(Stock_edit.Text, "^[0-9]+$", RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                Stock_edit.Clear();
            }
        }
    }
}
