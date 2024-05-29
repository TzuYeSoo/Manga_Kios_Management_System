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

        private void Close_RBook_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("DO you want to close this site","Close Remove Book", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Book_Inv Binv = new Book_Inv();
                Binv.Show();
                this.Close();
            }
            
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm to remove this Book","Remove Book",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                sqlcon.Open();
                sqlcom = new SqlCommand("UPDATE Book SET Book_Status = 0 WHERE Book_ID = @Bid",sqlcon);
                sqlcom.Parameters.AddWithValue("@Bid", RConfirm_BookID.Text);
                sqlcom.ExecuteNonQuery();


                dataBookHis();
                dataBookRemove();

                RConfirm_BookID.Clear();
                sqlcon.Close();
            }
            
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
            if (MessageBox.Show("Confirm to access this book", "Access Book", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                
                sqlcom = new SqlCommand("SELECT Book.*, Bookgenre FROM Book RIGHT JOIN Book_GenreName ON Book.Book_ID = Book_GenreName.Book_ID WHERE Book.Book_ID ='" + RConfirm_BookID.Text + "' AND Book.Book_Status = 1", sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter (sqlcom);
                dt.Clear();
                sda.Fill(dt);
                Book_Hisotry.DataSource = dt;

            }
            sqlcon.Close();
        }
    }
}
