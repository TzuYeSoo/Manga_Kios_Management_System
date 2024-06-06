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
    public partial class Remove_Book : Form
    {
        public Remove_Book()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        static SqlCommand sqlcom2;
        static DataTable dt = new DataTable();
        static DataTable dt2 = new DataTable();
        static string Bname, BID, Bdesc, Bgenre, BPrice, BQuantity;
        static List<string> Bookg = new List<string>();
        static int stat = 0;
        static bool checkBRM = false, checkBRT = false;

        private void Close_RBook_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("DO you want to close this site","Close Remove Book", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Book_Inv Binv = new Book_Inv();
                Binv.Show();
                this.Close();
            }
            
        }

        private void RetrieveBook_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            if(checkBRT == true)
            {
                if(RBook.Text != "")
                {
                    if(MessageBox.Show("Do you want to retrieve this Book?", "Retrieve Book", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        sqlcom = new SqlCommand("UPDATE Book SET Book_Status = 1 WHERE Book_ID = @EMPID", sqlcon);
                        sqlcom.Parameters.AddWithValue("@EMPID", RBook.Text);
                        sqlcom.ExecuteNonQuery();

                        RBook.Clear();
                        checkBRT = false;

                        dataBookHis();
                        dataBookRemove();

                    }                   
                }
                else
                {
                    MessageBox.Show("Reinput the ID Verify it again");
                }
            }
            else
            {
                MessageBox.Show("Please Verify ID first");
            }
            sqlcon.Close();
        }

        private void RConfirm_ID_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            if(RBook.Text == "")
            {
                MessageBox.Show("Please input ID value first");
            }
            else
            {
                sqlcom = new SqlCommand("SELECT Book_Status FROM Book WHERE Book_ID = @EMPID", sqlcon);
                sqlcom.Parameters.AddWithValue("@EMPID", RBook.Text);

                SqlDataReader rdr = sqlcom.ExecuteReader();
                if (rdr.Read())
                {
                    stat = Convert.ToInt16(rdr.GetValue(0));
                }
                rdr.Close();

                if (stat == 0)
                {
                    if(MessageBox.Show("Do you want to confirm this ID?", "Confirm Book ID", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        checkBRT = true;

                        sqlcom = new SqlCommand("SELECT Book.*, Bookgenre FROM Book INNER JOIN Book_GenreName ON Book.Book_ID = Book_GenreName.Book_ID" +
                            " WHERE Book.Book_ID = @BID", sqlcon);
                        sqlcom.Parameters.AddWithValue("@BID", RBook.Text);

                        SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                        dt.Clear();
                        sda.Fill(dt);
                        Delete_Book_History.DataSource = dt;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Book Already Active");
                }

            }
            

            sqlcon.Close();
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            if (checkBRM == true)
            {
                if (RConfirm_BookID.Text != "")
                {
                    if (MessageBox.Show("Do you want to retrieve this Book?", "Retrieve Book", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        sqlcom = new SqlCommand("UPDATE Book SET Book_Status = 0 WHERE Book_ID = @EMPID", sqlcon);
                        sqlcom.Parameters.AddWithValue("@EMPID", RConfirm_BookID.Text);
                        sqlcom.ExecuteNonQuery();

                        RConfirm_BookID.Clear();
                        checkBRM = false;

                        dataBookHis();
                        dataBookRemove();

                    }
                }
                else
                {
                    MessageBox.Show("Reinput the ID Verify it again");
                }
            }
            else
            {
                MessageBox.Show("Please Verify ID first");
            }
            sqlcon.Close();

        }

        private void Remove_Book_Load(object sender, EventArgs e)
        {
            Book_Hisotry.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            Book_Hisotry.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Book_Hisotry.EnableHeadersVisualStyles = false;
            Book_Hisotry.DefaultCellStyle.BackColor = Color.LightSteelBlue;

            Delete_Book_History.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            Delete_Book_History.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Delete_Book_History.EnableHeadersVisualStyles = false;
            Delete_Book_History.DefaultCellStyle.BackColor = Color.LightPink;

            sqlcon.Open();
            dataBookHis();
            dataBookRemove();
            sqlcon.Close();
        }
        public void dataBookHis()
        {
            sqlcom = new SqlCommand("SELECT Book.*, Bookgenre FROM Book INNER JOIN Book_GenreName ON Book.Book_ID = Book_GenreName.Book_ID WHERE Book_Status = 1", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            dt.Clear();
            sda.Fill(dt);
            Book_Hisotry.DataSource = dt;
        }
        public void dataBookRemove()
        {
            sqlcom2 = new SqlCommand("SELECT Book.*, Bookgenre FROM Book LEFT JOIN Book_GenreName ON Book.Book_ID = Book_GenreName.Book_ID WHERE Book_Status = 0", sqlcon);
            SqlDataAdapter sdar = new SqlDataAdapter(sqlcom2);
            dt2.Clear();
            sdar.Fill(dt2);
            Delete_Book_History.DataSource = dt2;
        }

        private void Confirm_BID_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            if (RConfirm_BookID.Text == "")
            {
                MessageBox.Show("Please input ID value first");
            }
            else
            {
                sqlcom = new SqlCommand("SELECT Book_Status FROM Book WHERE Book_ID = @EMPID", sqlcon);
                sqlcom.Parameters.AddWithValue("@EMPID", RConfirm_BookID.Text);

                SqlDataReader rdr = sqlcom.ExecuteReader();
                if (rdr.Read())
                {
                    stat = Convert.ToInt16(rdr.GetValue(0));
                }
                rdr.Close();

                if (stat == 1)
                {
                    if (MessageBox.Show("Do you want to confirm this ID?", "Confirm Book ID", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        checkBRM = true;

                        sqlcom = new SqlCommand("SELECT Book.*, Bookgenre FROM Book INNER JOIN Book_GenreName ON Book.Book_ID = Book_GenreName.Book_ID" +
                            " WHERE Book.Book_ID = @BID", sqlcon);
                        sqlcom.Parameters.AddWithValue("@BID", RConfirm_BookID.Text);

                       SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                        dt.Clear();
                        sda.Fill(dt);
                        Book_Hisotry.DataSource = dt;
                    }

                }
                else
                {
                    MessageBox.Show("Book Already Inactive");
                }

            }


            sqlcon.Close();
        }
    }
}
