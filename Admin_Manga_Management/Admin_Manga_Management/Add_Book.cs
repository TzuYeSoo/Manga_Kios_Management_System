using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Manga_Management
{
    public partial class Add_Book : Form
    {
        public Add_Book()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        static SqlCommand sqlcom2;
        static DataTable dt = new DataTable();
        static string BookOptionsts;

        private void Add_Book_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Book.* FROM Book INNER JOIN Book_GenreName ON Book_GenreName.Book_ID = Book.Book_ID", sqlcon);
            SqlDataAdapter sda2 = new SqlDataAdapter(sqlcom);
            dt.Clear();
            sda2.Fill(dt);
            Book_GrideView_BookADD.DataSource = dt;

            sqlcon.Close();
           
        }

        private void Add_Book_FROMADD_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
                sqlcom = new SqlCommand("INSERT INTO Book VALUES(@bookId, @name, @price, @quantity, @description)", sqlcon);
            sqlcom.Parameters.AddWithValue("@bookID", Add_BookID_Add.Text);
            sqlcom.Parameters.AddWithValue("@name", Add_BookName_Add.Text);
            sqlcom.Parameters.AddWithValue("@price", Add_BookPrice_Add.Text);
            sqlcom.Parameters.AddWithValue("@quantity", Add_BookQuantity_Add.Text);
            sqlcom.Parameters.AddWithValue("@description", Add_BookDescrip_Add.Text);
            sqlcom.ExecuteNonQuery();


            if (Add_BookID_Add.Text != null)
            {
                sqlcom = new SqlCommand("SELECT Book.*, Bookgenre FROM Book INNER JOIN Book_GenereName ON Book_GenreName.Book_ID = Book.Book_ID ", sqlcon);
                SqlDataAdapter sda2 = new SqlDataAdapter(sqlcom);
                dt.Clear();
                sda2.Fill(dt);
                Book_GrideView_BookADD.DataSource = dt;
                MessageBox.Show("Success!");


            }
            else
            {
                MessageBox.Show("Please Input Credentials");
            }
            sqlcon.Close();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Book_Inv bo = new Book_Inv();
            bo.Show();
            this.Hide();
        }
    }
}
