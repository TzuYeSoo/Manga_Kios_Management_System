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
    public partial class Add_Admin : Form
    {
        public Add_Admin()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom = new SqlCommand();
        static SqlCommand sqlcom2 = new SqlCommand();
        static DataTable Admin_Users = new DataTable();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            Datatable();
            PositionBox.Items.Add("Admin");
            PositionBox.Items.Add("Cashier");
            sqlcon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            try
            {

 

                if (AdminID_Add.Text == "" || AdminUsername_Add.Text == "" || AdminPass_Add.Text == "")
                {
                    MessageBox.Show("Please Input Every needed Credentials");
                }
                else
                {
                    if(MessageBox.Show("Are you sure you want to Add this Acount?", "Admin Add", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        sqlcom2 = new SqlCommand("INSERT INTO Admin VALUES(@emuser, @empass, @con, @empos, @emstat, @email) ", sqlcon);
                        sqlcom2.Parameters.AddWithValue("@emuser", AdminUsername_Add.Text);
                        sqlcom2.Parameters.AddWithValue("@empass", AdminPass_Add.Text);
                        sqlcom2.Parameters.AddWithValue("@con", AdminCon_Add.Text);
                        sqlcom2.Parameters.AddWithValue("@empos", PositionBox.SelectedItem);
                        sqlcom2.Parameters.AddWithValue("@emstat", 1);
                        sqlcom2.Parameters.AddWithValue("@empass", EmailBox.Text);
                        sqlcom2.ExecuteNonQuery();
                        Datatable();
                       

                    }



                }
            }catch (SqlException ex) 
            {
                MessageBox.Show("Existing Account!!");
            }
                sqlcon.Close();
           

        }

        private void Close_Button_Add_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to close this site","Close Add Employee", MessageBoxButtons.OKCancel)== DialogResult.OK)
            {

                StaffsHome shf = new StaffsHome();
                shf.Show();
                this.Hide();
            }
            
        }
        public void Datatable()
        {
            sqlcom = new SqlCommand("SELECT * FROM Admin", sqlcon);

            SqlDataAdapter sqlad = new SqlDataAdapter(sqlcom);
            Admin_Users.Clear();
            sqlad.Fill(Admin_Users);
            Admin_View_Add.DataSource = Admin_Users;
        }
    }
}
