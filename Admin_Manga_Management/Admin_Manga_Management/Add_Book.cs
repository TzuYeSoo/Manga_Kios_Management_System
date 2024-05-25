using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
        static string BGName;
        private void Add_Book_Load(object sender, EventArgs e)
        {
            

            sqlcon.Open();
            GridviewOutput();

            sqlcom2 = new SqlCommand("SELECT Bookgenre FROM Book_GenreName", sqlcon);
            SqlDataReader rdr = sqlcom2.ExecuteReader();
            

            while (rdr.Read())
            {
                GenreNames.Items.Add(rdr.GetValue(0));

            }

            rdr.Close();
            sqlcon.Close();


        }

        private void Add_Book_FROMADD_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            try
            {
                if (Add_BookID_Add.Text != " " && Add_BookName_Add.Text != " " && Add_BookPrice_Add.Text != " "
                    && Add_BookQuantity_Add.Text != " ")
                {


                    if ()
                    {

                    }

                    for (int i = 0; i < GenreNames.Items.Count; i++)
                    {
                        if (GenreNames.GetItemChecked(i))
                        {
                            BGName = $"{GenreNames.Items[i]}"; ;
                            sqlcom2 = new SqlCommand("INSERT INTO Book_GenreName VALUES(@bookgenre, @book_ID)", sqlcon);
                            sqlcom2.Parameters.AddWithValue("book_ID", Add_BookID_Add.Text);
                            sqlcom2.Parameters.AddWithValue("@bookgenre", BGName);
                            sqlcom2.ExecuteNonQuery();
                        }
                        if(i > GenreNames.Items.Count)
                        {
                            sqlcom = new SqlCommand("INSERT INTO Book VALUES(@bookId, @name, @price, @quantity, @description)", sqlcon);
                            sqlcom.Parameters.AddWithValue("@bookID", Add_BookID_Add.Text);
                            sqlcom.Parameters.AddWithValue("@name", Add_BookName_Add.Text);
                            sqlcom.Parameters.AddWithValue("@price", Add_BookPrice_Add.Text);
                            sqlcom.Parameters.AddWithValue("@quantity", Add_BookQuantity_Add.Text);
                            sqlcom.Parameters.AddWithValue("@description", Add_BookDescrip_Add.Text);
                            sqlcom.ExecuteNonQuery();
                        }

                    }
                    GridviewOutput();



                }
                else
                {
                    MessageBox.Show("Please Input Credentials");
                }
            }catch (SqlException ex)
            {
                MessageBox.Show("Existing Data Files");
            }
            sqlcon.Close();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Book_Inv bo = new Book_Inv();
            bo.Show();
            this.Hide();
        }

        public void GridviewOutput()
        {
            sqlcom = new SqlCommand("SELECT Book.*, Bookgenre FROM Book LEFT JOIN Book_GenreName ON Book_GenreName.Book_ID = Book.Book_ID ", sqlcon);
            SqlDataAdapter sda2 = new SqlDataAdapter(sqlcom);
            dt.Clear();
            sda2.Fill(dt);
            Book_GrideView_BookADD.DataSource = dt;

        }


    }
}
