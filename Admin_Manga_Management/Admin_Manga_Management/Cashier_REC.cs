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
    public partial class Cashier_REC : Form
    {
        public Cashier_REC()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }
        public void addText(decimal price, string book, int quan)
        {
            Bname.Text += "\n" + book;
            Quan.Text += "\n" + quan;
            Price.Text += "\n" + price;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashierHome cashierHome = new CashierHome();
            cashierHome.Show();

            this.Close();
        }
    }
}
