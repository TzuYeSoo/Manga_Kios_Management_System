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
        static SqlConnection sqlcon = new SqlConnection(sqlConntector.connector);
        static SqlCommand sqlcom1 = new SqlCommand();
        static SqlCommand sqlcom2 = new SqlCommand();
        private void StaffsHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet3.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.database1DataSet3.Admin);
            // TODO: This line of code loads data into the 'database1DataSet2.Cashier' table. You can move, or remove it, as needed.
            this.cashierTableAdapter.Fill(this.database1DataSet2.Cashier);

            sqlcon.Open();
            sqlcom1 = new SqlCommand("SELECT * FROM Admin", sqlcon);
            SqlDataAdapter adp1 = new SqlDataAdapter(sqlcom1);
            dt1.Clear();
            adp1.Fill(dt1);
            Admin_GridView.DataSource = dt1;
            sqlcon.Close();

            sqlcon.Open();
            sqlcom2 = new SqlCommand("SELECT * FROM Cashier",sqlcon);
            SqlDataAdapter adp2 = new SqlDataAdapter(sqlcom2);
            dt2.Clear();
            adp2.Fill(dt2);
            Cashier_GrideView.DataSource = dt2;
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

        private void Add_User_Cash_Click(object sender, EventArgs e)
        {
            Cashier_ADD cs = new Cashier_ADD();
            cs.Show();
            this.Hide();
        }

        private void Delete_User_Cash_Click(object sender, EventArgs e)
        {
            Cashier_Remove cr = new Cashier_Remove();
            cr.Show();
            this.Hide();
        }
    }
}
