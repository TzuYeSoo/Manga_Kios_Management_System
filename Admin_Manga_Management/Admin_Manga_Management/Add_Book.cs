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
        static DataTable dt = new DataTable();

        private void Add_Book_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Book.Book_ID, Book_Name, Bookgeenre, Book_Price, Book_Quantity FROM Book INNER JOIN Category IN Category.Category_ID = Book.Category_ID", sqlcon);
            SqlDataAdapter sda2 = new SqlDataAdapter(sqlcom);
            dt.Clear();
            sda2.Fill(dt);
            Book_GrideView_BookADD.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Book.*, Bookgenre FROM Book INNER JOIN Category IN Category.Category_ID = Book.Category_ID", sqlcon);
            SqlDataReader reader = sqlcom.ExecuteReader();
            while (reader.Read())
            {
                
            }

        }
    }
}
