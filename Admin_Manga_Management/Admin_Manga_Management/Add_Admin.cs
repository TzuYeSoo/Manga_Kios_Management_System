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
        static SqlConnection sqlcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\jessie\\Admin_Manga_Management\\Admin_Manga_Management\\Database1.mdf;Integrated Security=True");
        static SqlCommand sqlcom = new SqlCommand();
        static SqlCommand sqlcom2 = new SqlCommand();
        static DataTable Admin_Users = new DataTable();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet3.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.database1DataSet3.Admin);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            try
            {

 
                sqlcom2 = new SqlCommand("INSERT INTO Admin VALUES('" + AdminID_Add.Text + "', '" + AdminUsername_Add.Text + "', '" + AdminPass_Add.Text + "', '" + AdminCon_Add.Text + "');", sqlcon);

                if (AdminID_Add.Text == null || AdminUsername_Add.Text == null || AdminPass_Add.Text == null)
                {
                    MessageBox.Show("Please Input Every needed Credentials");
                }
                else
                {
                    sqlcom = new SqlCommand("SELECT * FROM Admin;", sqlcon);
                    sqlcom2.ExecuteNonQuery();
                    sqlcom.ExecuteNonQuery();
                    SqlDataAdapter sqlad = new SqlDataAdapter(sqlcom);
                    Admin_Users.Clear();
                    sqlad.Fill(Admin_Users);
                    Admin_View_Add.DataSource = Admin_Users;


                }
            }catch (SqlException ex) 
            {
                MessageBox.Show("Existing Account!!");
            }
                sqlcon.Close();
           

        }

        private void Close_Button_Add_Click(object sender, EventArgs e)
        {
            StaffsHome shf = new StaffsHome();
            shf.Show();
            this.Hide();
        }
    }
}
