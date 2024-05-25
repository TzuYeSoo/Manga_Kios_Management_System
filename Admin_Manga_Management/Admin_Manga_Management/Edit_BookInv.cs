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
        static DataTable dt = new DataTable();
        static string BookOptions;
        

        private void Edit_BookInv_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Book.*, Bookgenre FROM Book INNER JOIN Book_GenreName ON Book_GenreName.Book_ID = Book.Book_ID", sqlcon);
            SqlDataAdapter sda2 = new SqlDataAdapter(sqlcom);
            dt.Clear();
            sda2.Fill(dt);
            Edit_BookGrideView.DataSource = dt;


            
            sqlcon.Close();

            
                Edit_BookGen_Edit.IsAccessible = false;
                Edit_BookName_Edit.ReadOnly = true;
                Edit_BookPrice_Edit.ReadOnly = true;
                Edit_BookQuanti_Edit.ReadOnly = true;
                Edit_BookDesc_Edit.ReadOnly = true;
            
        }

        private void Confirm_ID_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            if(Confirm_BookID.Text != null)
            {
                Edit_BookGen_Edit.IsAccessible = true;
                Edit_BookName_Edit.ReadOnly = false;
                Edit_BookPrice_Edit.ReadOnly = false;
                Edit_BookQuanti_Edit.ReadOnly = false;
                Edit_BookDesc_Edit.ReadOnly = false;

                sqlcom = new SqlCommand("SELECT Book_ID, Book_Name, Book_Price, Book_Quantity, Description, Bookgenre FROM Book INNER JOIN Book_GenreName ON Book.Book_ID = Book_GenreName.Book_ID" +
                    " WHERE Book_ID = '" + Confirm_BookID.Text +"'", sqlcon);
                SqlDataReader rdr = sqlcom.ExecuteReader();

                while (rdr.Read())
                {
                    Edit_BookName_Edit.Text = (string)rdr.GetValue(1);
                    Edit_BookPrice_Edit.Text = rdr.GetValue(2).ToString();
                    Edit_BookQuanti_Edit.Text = rdr.GetValue(3).ToString();
                    if(rdr.GetValue(4).ToString() != "")
                    {
                    Edit_BookDesc_Edit.Text = (string)rdr.GetValue(4);
                    }
                    Edit_BookGen_Edit.Text = rdr.GetValue(5).ToString();
                    

                }
                    
                    
                
            }
            
            sqlcon.Close();
        }

        private void Edit_EditButt_Click(object sender, EventArgs e)
        {
            

            sqlcon.Open();
            sqlcom = new SqlCommand($"UPDATE Book SET Book_ID = '@bookID', Book_Name = '@bookname', " +
                "Book_Price = @price, Book_Quantity = @quantity, Description = '@description',  = '@category'" ,sqlcon);
            sqlcom.Parameters.Add("@bookname", Edit_BookName_Edit);
            sqlcom.Parameters.Add("@bookID", Confirm_BookID);
            sqlcom.Parameters.Add("@quantity", Edit_BookQuanti_Edit);
            sqlcom.Parameters.Add("@price", Edit_BookPrice_Edit);
            sqlcom.Parameters.Add("@description", Edit_BookDesc_Edit);
            sqlcom.Parameters.Add("@category", BookOptions);

            sqlcon.Close();

            
        }

        private void Edit_BookGen_Edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Bookgenre FROM Book_GenreName WHERE Bookgenre = @genre", sqlcon);
            sqlcom.Parameters.AddWithValue("@genre", Edit_BookGen_Edit.SelectedItem.ToString());
            BookOptions = sqlcom.ExecuteScalar().ToString();

            sqlcon.Close();
        }
    }
}
