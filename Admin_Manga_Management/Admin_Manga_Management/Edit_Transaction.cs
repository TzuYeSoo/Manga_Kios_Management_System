using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Manga_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        SqlCommand sqlcom;
        SqlCommand sqlcom2;
        DataTable dt = new DataTable();
        static string bookname, BID, CID, Ordernum, BookQuan, Bdate, Cname, CASID;
        static double BookP;


        private void Form1_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            dataTrans();
            booklist();

            sqlcon.Close();
;        }
        public void dataTrans()
        {

            sqlcom = new SqlCommand("SELECT Customers.*, Book_Name FROM Customers " +
                 "INNER JOIN OrderBook ON Customers.Customer_ID = OrderBook.Customer_ID " +
                 "INNER JOIN Book ON OrderBook.Book_ID = Book.Book_ID", sqlcon);
            SqlDataAdapter sqda = new SqlDataAdapter(sqlcom);
            dt.Clear();
            sqda.Fill(dt);
            Trans_HisGrid.DataSource = dt;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            if (textBoxCustomersID.Text != "")
            {
                if(MessageBox.Show("","", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    
                 
                   


                    sqlcom = new SqlCommand("SELECT Customers.Customer_ID, Customer_Name, Order_Number, Cashier_ID, " +
                        "Book_Name, Customers.Book_Quantity, Book_Price, Date FROM Customers " +
                        "INNER JOIN OrderBook ON Customers.Customer_ID = OrderBook.Customer_ID " +
                        "INNER JOIN Book ON OrderBook.Book_ID = Book.Book_ID WHERE Customers.Customer_ID = '" + textBoxCustomersID.Text +"'", sqlcon);

                    SqlDataReader rdr = sqlcom.ExecuteReader();

                    while (rdr.Read())
                    {

                        CID = (string)rdr.GetValue(0);
                        Cname = (string)rdr.GetValue(1);
                        Ordernum = (string)rdr.GetValue(2);
                        if(rdr.GetValue(3).ToString() != "")
                        {
                            CASID = (string)rdr.GetValue(3);
                        }

                        bookname = (string)rdr.GetValue(4);
                        BookQuan = rdr.GetValue(5).ToString();
                        
                        Bdate = (string)rdr.GetValue(7);

                        for (int i = 0; i < BookNames.Items.Count; i++)
                        {
                            string Booksss = $"{BookNames.Items[i]}";

                            if (Booksss.Equals((string)rdr.GetValue(4)))
                            {
                                BookNames.SetItemChecked(i, true);
                                Book_Price.Text = rdr.GetValue(6).ToString();
                            }
                        }

                    }
                    rdr.Close();
                    SqlDataAdapter sqda = new SqlDataAdapter(sqlcom);
                    dt.Clear();
                    sqda.Fill(dt);
                    Trans_HisGrid.DataSource = dt;
                }
               
            }
            else
            {
                MessageBox.Show("Input Customer_ID First");
            }



            sqlcon.Close();
            textBoxCashierID.Text = CASID;
            textBoxCustomersID.Text = CID;
            textBoxCustomerName.Text = Cname;
            textBoxDate.Text = Bdate;
            textBoxBookQuantity.Text = BookQuan;
            ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxBookQuantity.Text != "" && textBoxCustomerName.Text != "" 
                && textBoxDate.Text != "" && Book_Price.Text != "")
            {
                if(MessageBox.Show("Are sure you want to continue the edit in this customer???","Edit Customer", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    
                    sqlcon.Open();
                    sqlcom = new SqlCommand("DELETE FROM OrderBook WHERE Customer_ID = @cuid",sqlcon);
                    sqlcom.Parameters.AddWithValue("@cuid", CID);
                    sqlcom.ExecuteNonQuery();
                    for (int i = 0; i < BookNames.Items.Count; i++)
                    {

                        if (BookNames.GetItemChecked(i))
                        {

                            sqlcom2 = new SqlCommand("SELECT Book_Price, Book_ID FROM Book WHERE Book_Name = '" + BookNames.Items[i] + "'", sqlcon);
                            SqlDataReader rdr1 = sqlcom2.ExecuteReader();
                            if (rdr1.Read())
                            {

                                BookP += Convert.ToDouble(rdr1.GetValue(0));
                                BID = (string)rdr1.GetValue(1);

                                
                            }
                            rdr1.Close();

                            sqlcom = new SqlCommand("INSERT INTO OrderBook VALUES(@cusid, @bID)", sqlcon);
                            sqlcom.Parameters.AddWithValue("@cusid", CID);
                            sqlcom.Parameters.AddWithValue("@bID", BID);
                            sqlcom.ExecuteNonQuery();

                        }
                    }

                    

                   
                    Book_Price.Text = BookP.ToString();
                    
                    sqlcom = new SqlCommand("UPDATE Customers SET Customer_Name = @cname, Book_Quantity = @bquan," +
                        "Total_Cost = @bookprice WHERE Customer_ID = @cid", sqlcon);
                    sqlcom.Parameters.AddWithValue("@cname", textBoxCustomerName.Text);
                    sqlcom.Parameters.AddWithValue("@bquan", textBoxBookQuantity.Text);
                    sqlcom.Parameters.AddWithValue("@bookprice", BookP);
                    sqlcom.Parameters.AddWithValue("@cid", textBoxCustomersID.Text);
                    sqlcom.ExecuteNonQuery();


                    dataTrans();
                    sqlcon.Close();

                }
            }
        }
        public void booklist()
        {
            sqlcom = new SqlCommand("SELECT Book_Name, Book_Price FROM Book", sqlcon);
            SqlDataReader rdr = sqlcom.ExecuteReader();

            while (rdr.Read())
            {
                BookNames.Items.Add(rdr.GetString(0));
            }
            rdr.Close();
        }
    }
}
