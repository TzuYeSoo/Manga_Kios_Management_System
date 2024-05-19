using System;
using System.Collections;
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
    public partial class Remove_Admin : Form
    {
        public Remove_Admin()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\jessie\\Admin_Manga_Management\\Admin_Manga_Management\\Database1.mdf;Integrated Security=True");
        static SqlCommand sqlcom = new SqlCommand();
        static SqlCommand sqlcom2 = new SqlCommand();
        static DataTable dt = new DataTable();
        static bool checker;
        

        private void Remove_Admin_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT * FROM Admin",sqlcon);
            SqlDataAdapter sda1 = new SqlDataAdapter(sqlcom);
            dt.Clear();
            sda1.Fill(dt);
            Remove_Admin_GrideView.DataSource = dt;
            sqlcon.Close();

        }

        private void Remove_Remove_Click(object sender, EventArgs e)
        {
            
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Admin_ID FROM Admin WHERE Admin_ID = '" + AdminID_Remove.Text + "'", sqlcon);
            SqlDataReader reader = sqlcom.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("Not exist");
                checker = false;
            }
            else
            {
                checker = true;
            }

            reader.Close();

            if (checker == true)
            {
                sqlcom2 = new SqlCommand("DELETE FROM Admin WHERE Admin_ID = '" + AdminID_Remove.Text + "'", sqlcon);
                sqlcom2.ExecuteNonQuery();
                sqlcom = new SqlCommand("SELECT * FROM Admin", sqlcon);
                SqlDataAdapter sda2 = new SqlDataAdapter(sqlcom);
                dt.Clear();
                sda2.Fill(dt);
                Remove_Admin_GrideView.DataSource = dt;

            }

            sqlcon.Close();


        }

        private void Close_Remove_Admin_Click(object sender, EventArgs e)
        {
            StaffsHome sh = new StaffsHome();
            sh.Show();
            this.Hide();
        }
    }
}
