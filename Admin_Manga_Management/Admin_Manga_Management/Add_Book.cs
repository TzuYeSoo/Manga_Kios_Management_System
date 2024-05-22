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
        static string[] BookGenre;
        static string BookOptionsts;

        private void Add_Book_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Book.Book_ID, Book_Name, Bookgenre, Book_Price, Book_Quantity FROM Book INNER JOIN Category ON Category.Category_ID = Book.Category_ID", sqlcon);
            SqlDataAdapter sda2 = new SqlDataAdapter(sqlcom);
            dt.Clear();
            sda2.Fill(dt);
            Book_GrideView_BookADD.DataSource = dt;

            sqlcom = new SqlCommand("SELECT Bookgenre FROM Category", sqlcon);
            SqlDataReader rdr = sqlcom.ExecuteReader();
            
            while (rdr.Read())
            {
               
                GenreOPtions.Items.Add(rdr.GetValue(0));

            }
            sqlcon.Close();
           
        }

        private void Add_Book_FROMADD_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
                sqlcom = new SqlCommand("INSERT INTO Book VALUES(@bookId, @name, @price, @category, @quantity, @description)", sqlcon);
            sqlcom.Parameters.AddWithValue("@bookID", Add_BookID_Add.Text);
            sqlcom.Parameters.AddWithValue("@name", Add_BookName_Add.Text);
            sqlcom.Parameters.AddWithValue("@price", Add_BookPrice_Add.Text);
            sqlcom.Parameters.AddWithValue("@category", BookOptionsts);
            sqlcom.Parameters.AddWithValue("@quantity", Add_BookQuantity_Add.Text);
            sqlcom.Parameters.AddWithValue("@description", Add_BookDescrip_Add.Text);
            sqlcom.ExecuteNonQuery();


            if (Add_BookID_Add.Text != null)
            {
                sqlcom = new SqlCommand("SELECT Book.*, Bookgenre FROM Book INNER JOIN Category ON Category.Category_ID = Book.Category_ID ", sqlcon);
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

        private void GenreOPtions_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlcon.Open();

                sqlcom = new SqlCommand("SELECT Category_ID FROM Category WHERE Bookgenre = @genre", sqlcon);
                sqlcom.Parameters.AddWithValue("@genre", GenreOPtions.SelectedItem.ToString());
                BookOptionsts = sqlcom.ExecuteScalar().ToString();

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
