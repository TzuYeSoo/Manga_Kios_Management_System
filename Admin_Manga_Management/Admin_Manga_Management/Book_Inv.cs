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
        static SqlConnection sqlcon = new SqlConnection(sqlConntector.connector);
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
            sqlcom = new SqlCommand("SELECT Book_ID ,Book_Name, Bookgenre, Book_Price, Book_Quantity FROM Book INNER JOIN Category ON Category.Category_ID = Book.Category_ID ", sqlcon);
            SqlDataAdapter sqa = new SqlDataAdapter(sqlcom);
            Book_Inventory.Clear();
            sqa.Fill(Book_Inventory);
            BookInv_GrideView.DataSource = Book_Inventory;
            sqlcon.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (Search_BookIDInv.Text != "")
            {
                SearchBook(Search_BookIDInv.Text);
            }
            else if (Search_BookGenreInv.Text == "")
            {
                SearchBook(Search_BookNameInv.Text);
            }else if (Search_BookNameInv.Text == "")
            {
                SearchBook(Search_BookGenreInv.Text);
            }else if(Search_BookNameInv.Text != "" && Search_BookGenreInv.Text != "")
            {
                SearchBook(Search_BookNameInv.Text, Search_BookGenreInv.Text);
            }
        }

        public void SearchBook(string BookT1)
        {
            if (Search_BookIDInv.Text != "")
            {
                sqlcon.Open();
                sqlcom = new SqlCommand("SELECT Book_ID ,Book_Name, Bookgenre, Book_Price, Book_Quantity FROM Book " +
                    "INNER JOIN Category ON Category.Category_ID = Book.Category_ID WHERE Book.Book_ID = '" + BookT1 +"'", sqlcon);
                SqlDataAdapter sqa = new SqlDataAdapter(sqlcom);
                Book_Inventory.Clear();
                sqa.Fill(Book_Inventory);
                BookInv_GrideView.DataSource = Book_Inventory;
                sqlcon.Close();

            }else if(Search_BookIDInv.Text == "" && Search_BookNameInv.Text == "")
            {
                sqlcon.Open();
                sqlcom = new SqlCommand("SELECT Book_ID ,Book_Name, Bookgenre, Book_Price, Book_Quantity FROM Book " +
                    "INNER JOIN Category ON Category.Category_ID = Book.Category_ID WHERE Category.Bookgenre = '" + BookT1 + "'", sqlcon);
                SqlDataAdapter sqa = new SqlDataAdapter(sqlcom);
                Book_Inventory.Clear();
                sqa.Fill(Book_Inventory);
                BookInv_GrideView.DataSource = Book_Inventory;
                sqlcon.Close();

            }else if(Search_BookIDInv.Text == "" && Search_BookGenreInv.Text == "")
            {
                sqlcon.Open();
                sqlcom = new SqlCommand("SELECT Book_ID ,Book_Name, Bookgenre, Book_Price, Book_Quantity FROM Book " +
                    "INNER JOIN Category ON Category.Category_ID = Book.Category_ID WHERE Book.Book_Name = '" + BookT1 + "'", sqlcon);
                SqlDataAdapter sqa = new SqlDataAdapter(sqlcom);
                Book_Inventory.Clear();
                sqa.Fill(Book_Inventory);
                BookInv_GrideView.DataSource = Book_Inventory;
                sqlcon.Close();

            }
        }
        public void SearchBook(string BookT1, string BookT2)
        {
            if(Search_BookIDInv.Text != "")
            {
                sqlcon.Open();
                sqlcom = new SqlCommand("SELECT Book_ID ,Book_Name, Bookgenre, Book_Price, Book_Quantity FROM Book " +
                    "INNER JOIN Category ON Category.Category_ID = Book.Category_ID WHERE Book.Book_ID = '" + BookT1 + "'", sqlcon);
                SqlDataAdapter sqa = new SqlDataAdapter(sqlcom);
                Book_Inventory.Clear();
                sqa.Fill(Book_Inventory);
                BookInv_GrideView.DataSource = Book_Inventory;
                sqlcon.Close();

            }
            else 
            {
                sqlcon.Open();
                sqlcom = new SqlCommand("SELECT Book_ID ,Book_Name, Bookgenre, Book_Price, Book_Quantity FROM Book " +
                    "INNER JOIN Category ON Category.Category_ID = Book.Category_ID WHERE Book.Book_Name = '" + BookT1 + "' AND Category.Bookgenre = '" + BookT2 + "'", sqlcon);
                SqlDataAdapter sqa = new SqlDataAdapter(sqlcom);
                Book_Inventory.Clear();
                sqa.Fill(Book_Inventory);
                BookInv_GrideView.DataSource = Book_Inventory;
                sqlcon.Close();

            }
        }
    }
}
