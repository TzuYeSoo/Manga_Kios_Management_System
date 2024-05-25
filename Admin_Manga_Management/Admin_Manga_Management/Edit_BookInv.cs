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
    public partial class Edit_BookInv : Form
    {
        public Edit_BookInv()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        static SqlCommand sqlcom2;
        static DataTable dt = new DataTable();
        static string BookOptions;
        

        private void Edit_BookInv_Load(object sender, EventArgs e)
        {
            


           sqlcon.Open();
            datagrid();

            sqlcom2 = new SqlCommand("SELECT Bookgenre FROM Book_Genrename", sqlcon);
            SqlDataReader rdr = sqlcom2.ExecuteReader();

            while (rdr.Read())
            {
                Book_GenreEdit.Items.Add(rdr.GetValue(0));
            }
                Edit_BookName_Edit.ReadOnly = true;
                Edit_BookPrice_Edit.ReadOnly = true;
                Edit_BookQuanti_Edit.ReadOnly = true;
                Edit_BookDesc_Edit.ReadOnly = true;

            sqlcon.Close();
        }

        private void Confirm_ID_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            if(Confirm_BookID.Text != null)
            {
                
                Edit_BookName_Edit.ReadOnly = false;
                Edit_BookPrice_Edit.ReadOnly = false;
                Edit_BookQuanti_Edit.ReadOnly = false;
                Edit_BookDesc_Edit.ReadOnly = false;

                sqlcom = new SqlCommand("SELECT Book_ID, Book_Name, Book_Price, Book_Quantity, Description FROM Book WHERE Book_ID = '" + Confirm_BookID.Text + "'", sqlcon);
                SqlDataReader rdr = sqlcom.ExecuteReader();

                if (rdr.Read())
                {
                    Edit_BookName_Edit.Text = (string)rdr.GetValue(1);
                    Edit_BookPrice_Edit.Text = rdr.GetValue(2).ToString();
                    Edit_BookQuanti_Edit.Text = rdr.GetValue(3).ToString();
                    if(rdr.GetValue(4).ToString() != "")
                    {
                    Edit_BookDesc_Edit.Text = (string)rdr.GetValue(4);
                    }
                    
                    

                }
                    
                    
                
            }
            sqlcom2 = new SqlCommand("SELECT Bookgenre FROM Book_GenreName WHERE Book_ID = '" + Confirm_BookID +"'",sqlcon );
             foreach (CheckBox genre in Book_GenreEdit.Items)
            {
                SqlDataReader rdr = sqlcom2.ExecuteReader();

                if (genre.Checked)
                {
                    while (rdr.Read())
                    {
                        
                    }

                }
                
            }
            sqlcon.Close();
        }

        private void Edit_EditButt_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                
                if (Edit_BookName_Edit.Text != "" && Confirm_BookID.Text != "" && Edit_BookQuanti_Edit.Text != ""
                    && Edit_BookPrice_Edit.Text != "")
                {
                    sqlcom2 = new SqlCommand("ALTER TABLE Book_GenreName DROP COlUMN bookgenre and Book_ID " +
                        "WHERE Book_ID = '" + Confirm_BookID +"'",sqlcon);

                    foreach (CheckBox genre in Book_GenreEdit.Items)
                    {

                            if (genre.Checked)
                            {
                                
                                sqlcom = new SqlCommand("INSERT INTO Book_GenreName VALUES (Book_ID = @bookID, Bookgenre = @bookgenre)", sqlcon);
                                sqlcom.Parameters.AddWithValue("@bookID", Confirm_BookID.Text);
                                sqlcom.Parameters.AddWithValue("@bookgenre", genre);


                            }
                        }
                    }

                    sqlcon.Open();
                    sqlcom = new SqlCommand($"UPDATE Book SET Book_ID = '@bookID', Book_Name = '@bookname', " +
                        "Book_Price = @price, Book_Quantity = @quantity, Description = '@description'", sqlcon);
                    sqlcom.Parameters.Add("@bookname", Edit_BookName_Edit.Text);
                    sqlcom.Parameters.Add("@bookID", Confirm_BookID.Text);
                    sqlcom.Parameters.Add("@quantity", Edit_BookQuanti_Edit.Text);
                    sqlcom.Parameters.Add("@price", Edit_BookPrice_Edit.Text);
                    sqlcom.Parameters.Add("@description", Edit_BookDesc_Edit.Text);

                
                

                sqlcon.Close();

            }catch(SqlException ex)
            {
                MessageBox.Show("Existing Book File");

            }
            

            
        }

       

        private void Close_EditBook_Click(object sender, EventArgs e)
        {
            Book_Inv Binv = new Book_Inv();
            Binv.Show();
            this.Hide()
;        }
        public void datagrid()
        {
            sqlcom = new SqlCommand("SELECT Book.*, Bookgenre FROM Book INNER JOIN Book_GenreName ON Book_GenreName.Book_ID = Book.Book_ID", sqlcon);
            SqlDataAdapter sda2 = new SqlDataAdapter(sqlcom);
            dt.Clear();
            sda2.Fill(dt);
            Edit_BookGrideView.DataSource = dt;
            
        }
       
    }
}
