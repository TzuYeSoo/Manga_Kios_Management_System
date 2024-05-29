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

        private void Log_but_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Admin_Username, Admin_Password FROM Admin", sqlcon);  
            SqlDataReader reader = sqlcom.ExecuteReader();

            while (reader.Read())
            {
                string Admin_User = (string)reader.GetValue(0);
                string Admin_Pass = (string)reader.GetValue(1);

                if(Admin_User.Equals(Admin_Username.Text) && Admin_Pass.Equals(Admin_Password.Text)) 
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

        private void button1_Click(object sender, EventArgs e)
        {
            CashierHome csh = new CashierHome();
            csh.Show();
            this.Hide();
        }
    }
}
