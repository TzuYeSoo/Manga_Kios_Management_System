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
            if(MessageBox.Show("Do you want to log out?", "Sing Out", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                LogIn log = new LogIn();
                log.Show();
                this.Hide();
            }
        }
    }
}
