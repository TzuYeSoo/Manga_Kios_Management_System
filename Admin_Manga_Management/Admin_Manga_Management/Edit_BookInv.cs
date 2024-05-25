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
using System.Xml.Linq;

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
        static string BGname;

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
                rdr.Close();
                    
                    
                
            }
            sqlcom2 = new SqlCommand("SELECT Bookgenre FROM Book_GenreName WHERE Book_ID = '" + Confirm_BookID +"'",sqlcon );
            SqlDataReader rdr1 = sqlcom2.ExecuteReader();

           
            
                for (int i = 0; i < Book_GenreEdit.Items.Count; i++)
                {
                while (rdr1.Read())
                {
                    if (Book_GenreEdit.Items[i].Equals(rdr1.GetValue(0)))
                    {
                        Book_GenreEdit.SetItemCheckState(i, CheckState.Checked);
                    }

                }


                }

            
            
            sqlcon.Close();
        }

        private void Edit_EditButt_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            //try
            //{
                
                
                if (Edit_BookName_Edit.Text != "" && Confirm_BookID.Text != "" && Edit_BookQuanti_Edit.Text != ""
                    && Edit_BookPrice_Edit.Text != "")
                {
                    sqlcom = new SqlCommand("DELETE FROM Book_GenreName " +
                        "WHERE Book_ID = '" + Confirm_BookID +"'",sqlcon);
                    sqlcom.ExecuteNonQuery();



                for (int i = 0; i < Book_GenreEdit.Items.Count; i++)
                    {
                        if (Book_GenreEdit.GetItemChecked(i))
                        {
                            BGname = $"{Book_GenreEdit.Items[i]}"; ;
                            sqlcom2 = new SqlCommand("INSERT INTO Book_GenreName VALUES(@bookgenre, @book_ID)", sqlcon);
                            sqlcom2.Parameters.AddWithValue("book_ID", Confirm_ID.Text);
                            sqlcom2.Parameters.AddWithValue("@bookgenre", BGname);
                            sqlcom2.ExecuteNonQuery();

                        }
                        if (i >= Book_GenreEdit.Items.Count)
                        {
                            sqlcom = new SqlCommand($"UPDATE Book SET Book_ID = '@bookID', Book_Name = '@bookname', " +
                                "Book_Price = @price, Book_Quantity = @quantity, Description = '@description'", sqlcon);
                            sqlcom.Parameters.Add("@bookname", Edit_BookName_Edit.Text);
                            sqlcom.Parameters.Add("@bookID", Confirm_BookID.Text);
                            sqlcom.Parameters.Add("@quantity", Edit_BookQuanti_Edit.Text);
                            sqlcom.Parameters.Add("@price", Edit_BookPrice_Edit.Text);
                            sqlcom.Parameters.Add("@description", Edit_BookDesc_Edit.Text);

                        }
                    }
                    datagrid();
                }

                
/*
            }catch(SqlException ex)
            {
                MessageBox.Show("Existing Book File");

            }
*/
            sqlcon.Close();


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
