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
    public partial class Setting_Admin : Form
    {
        public Setting_Admin()
        {
            InitializeComponent();
        }

        private void Log_Out_Click(object sender, EventArgs e) 
        {
            if(MessageBox.Show("Do you want to log out?", "Log Out", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                LogIn log = new LogIn();
                log.Show();
                this.Hide();
            }
        }

        private void TransHis_Click(object sender, EventArgs e)
        {
            Transaction ts = new Transaction();
            ts.Show();
            this.Hide();
        }

        private void Book_Inv_Click(object sender, EventArgs e)
        {
            Book_Inv book = new Book_Inv();
            book.Show();
            this.Hide();
        }

        private void Staffs_Click(object sender, EventArgs e)
        {
            StaffsHome sth = new StaffsHome();
            sth.Show();
            this.Hide();    
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard_Home dh = new Dashboard_Home  ();
            dh.Show();  
            this.Hide();    
        }
    }
}
