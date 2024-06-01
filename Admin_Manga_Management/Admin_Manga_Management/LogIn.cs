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
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom = new SqlCommand();
        static bool isLogin = false;
        static Encap enc;
        private void Log_but_Click(object sender, EventArgs e)
        {
                sqlcon.Open();
                sqlcom = new SqlCommand("SELECT Emp_Username, Emp_Password, Emp_Name FROM Admin WHERE Emp_Status = 1", sqlcon);
                SqlDataReader reader = sqlcom.ExecuteReader();

                while (reader.Read())
                {
                    enc = new Encap((string)reader.GetValue(0), (string)reader.GetValue(1), (string)reader.GetValue(2));

                    if (enc.Username.Equals(Admin_Username.Text) && enc.Password.Equals(Admin_Password.Text))
                    {

                        isLogin = true;
                        break;
                    }
                    else
                    {
                        isLogin = false;
                    }
                }
                if (isLogin)
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
                isLogin = false;
                sqlcon.Close();


            }


        

        private void Admin_Username_TextChanged(object sender, EventArgs e)
        {
            Admin_Username.ForeColor = Color.Black;
        }

        private void Admin_Password_TextChanged(object sender, EventArgs e)
        {
            Admin_Password.ForeColor = Color.Black;
            Admin_Password.PasswordChar = '*';
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
