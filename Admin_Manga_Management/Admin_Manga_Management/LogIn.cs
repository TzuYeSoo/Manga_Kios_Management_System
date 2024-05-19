using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Admin_Manga_Management
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\jessie\\Admin_Manga_Management\\Admin_Manga_Management\\Database1.mdf;Integrated Security=True");
        static SqlCommand sqlcom = new SqlCommand();

        private void Log_but_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Admin_Username, Admin_Password FROM Admin", sqlcon);  
            SqlDataReader reader = sqlcom.ExecuteReader();

            while (reader.Read())
            {
                string Admin_User = (string)reader.GetValue(0);
                string Admin_Pass = (string)reader.GetValue(1);

                if(Admin_Username.Text == Admin_User && Admin_Password.Text == Admin_Pass)
                {
                    Dashboard_Home DH = new Dashboard_Home();
                    DH.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Inputs" +
                        "\nPlease Try Again");
                }
            }
            sqlcon.Close();

        }
    }
}
