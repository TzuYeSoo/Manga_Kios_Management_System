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
    public partial class Cashier_StockView : Form
    {
        public Cashier_StockView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Log out Account", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LogIn log = new LogIn();
                log.Show();
                this.Close();
            }
        }

        private void Kios_Cus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to leve this site?", "leave this site", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Cahsier_kios_Cus cus = new Cahsier_kios_Cus();
                cus.Show();
                this.Hide();
            }

        }

        private void Walkin_Click(object sender, EventArgs e)
        {
            CashierHome ch = new CashierHome();
            ch.Show();
            this.Hide();
        }
    }
}
