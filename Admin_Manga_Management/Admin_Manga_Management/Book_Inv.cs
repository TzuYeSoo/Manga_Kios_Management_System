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
    public partial class Book_Inv : Form
    {
        public Book_Inv()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom = new SqlCommand();
        static SqlCommand sqlcom2 = new SqlCommand();
        static DataTable Book_Inventory = new DataTable();
        private void Trans_book_Click(object sender, EventArgs e)
        {
            Transaction trans_Book = new Transaction();
            trans_Book.Show();
            this.Hide();
        }

        private void Staffs_Book_Click(object sender, EventArgs e)
        {
            StaffsHome sh   = new StaffsHome();
            sh.Show();
            this.Hide();
        }

        private void Dash_Book_Click(object sender, EventArgs e)
        {
            Dashboard_Home dsh = new Dashboard_Home();
            dsh.Show();
            this.Hide();
        }

        private void Book_Inv_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Book.*, Bookgenre FROM Book LEFT JOIN Book_GenreName ON Book_GenreName.Book_ID = Book.Book_ID ", sqlcon);
            SqlDataAdapter sqa = new SqlDataAdapter(sqlcom);
            Book_Inventory.Clear();
            sqa.Fill(Book_Inventory);
            BookInv_GrideView.DataSource = Book_Inventory;
            sqlcon.Close();
        }

        private void search_Click(object sender, EventArgs e) 
        {

            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Book_genreName.Bookgenre FROM Book " +
                "LEFT JOIN Book_GenreName ON Book_GenreName.Book_ID = Book.Book_ID" +
                " WHERE Book_ID LIKE '%" + Search_Book_Bar_Admin.Text + "%' " +
                "OR Book_Name LIKE '%" + Search_Book_Bar_Admin.Text + "%' " +
                "OR Bookgenre LIKE '%" + Search_Book_Bar_Admin.Text + "%' " +
                "OR Book_Price = " + Search_Book_Bar_Admin.Text + " " +
               "OR Book_Quantity =  " + Search_Book_Bar_Admin.Text +" ", sqlcon);

            SqlDataAdapter sqa = new SqlDataAdapter(sqlcom);
            Book_Inventory.Clear();
            sqa.Fill(Book_Inventory);
            BookInv_GrideView.DataSource = Book_Inventory;

            sqlcon.Close();
        }

        
        

        private void AddBook_Book_Click(object sender, EventArgs e)
        {
            Add_Book ab = new Add_Book();
            ab.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit_BookInv booke = new Edit_BookInv();
            booke.Show();
            this.Hide();
        }

        private void RemoveBook_Book_Click(object sender, EventArgs e)
        {

        }
    }
}
