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
        static DataTable dt = new DataTable();
        static SqlConnection sqlcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\jessie\\Admin_Manga_Management\\Admin_Manga_Management\\Database1.mdf;Integrated Security=True");
        static SqlCommand sqlcom = new SqlCommand();
        private void StaffsHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet3.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.database1DataSet3.Admin);
            // TODO: This line of code loads data into the 'database1DataSet2.Cashier' table. You can move, or remove it, as needed.
            this.cashierTableAdapter.Fill(this.database1DataSet2.Cashier);


            sqlcom = new SqlCommand("SELECT * FROM Admin", sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter(sqlcom);
            dt.Clear();
            adp.Fill(dt);
            Admin_GridView.DataSource = dt;


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
    }
}
