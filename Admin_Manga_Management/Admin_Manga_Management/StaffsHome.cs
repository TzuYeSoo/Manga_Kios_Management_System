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
    public partial class StaffsHome : Form
    {
        public StaffsHome()
        {
            InitializeComponent();
        }
        static DataTable dt1 = new DataTable();
        static DataTable dt2 = new DataTable();
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom1 = new SqlCommand();
        static SqlCommand sqlcom2 = new SqlCommand();
        private void StaffsHome_Load(object sender, EventArgs e)
        {
           

            sqlcon.Open();
            sqlcom1 = new SqlCommand("SELECT * FROM Admin WHERE Emp_Status = 1", sqlcon);
            SqlDataAdapter adp1 = new SqlDataAdapter(sqlcom1);
            dt1.Clear();
            adp1.Fill(dt1);
            Employee_Data.DataSource = dt1;
            sqlcon.Close();



        }

        private void Dash_Staffs_Click(object sender, EventArgs e)
        {
            Dashboard_Home dsh = new Dashboard_Home();
            dsh.Show();
            this.Hide();
        }

        private void BookInv_Staffs_Click(object sender, EventArgs e)
        {
            Book_Inv bsh = new Book_Inv();
            bsh.Show();
            this.Hide();
        }

        private void Trans_Staffs_Click(object sender, EventArgs e)
        {
            Transaction tr = new Transaction();
            tr.Show();
            this.Hide();
        }

        private void Add_User_Admin_Click(object sender, EventArgs e)
        {
            Add_Admin ad = new Add_Admin();
            ad.Show();
            this.Hide();
        }

        private void Remove_User_Admin_Click(object sender, EventArgs e)
        {
            Remove_Admin ad = new Remove_Admin();
            ad.Show();
            this.Hide();
        }

        private void Edit_User_Admin_Click(object sender, EventArgs e)
        {
            Edit_Employee empEdit = new Edit_Employee();
            empEdit.Show();
            this.Hide();
        }

        private void Settings_Staffs_Click(object sender, EventArgs e)
        {
            Setting_Admin sa = new Setting_Admin();
            sa.Show();
            this.Hide();
        }

    }
}
