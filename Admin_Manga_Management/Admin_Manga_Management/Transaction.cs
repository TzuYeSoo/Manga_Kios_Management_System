using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Manga_Management
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.database1DataSet1.Customers);

        }

        private void Book_trans_Click(object sender, EventArgs e)
        {
            Book_Inv bv = new Book_Inv();
            bv.Show();
            this.Hide();
        }

        private void Settings_trans_Click(object sender, EventArgs e)
        {


        }

        private void Staffs_trans_Click(object sender, EventArgs e)
        {
            StaffsHome sth = new StaffsHome();
            sth.Show();
            this.Hide();

        }

        private void Dash_trans_Click(object sender, EventArgs e)
        {
            Dashboard_Home ds = new Dashboard_Home();
            ds.Show();
            this.Hide();
        }
    }
}
