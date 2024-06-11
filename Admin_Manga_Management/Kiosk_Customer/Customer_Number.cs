using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_Customer
{
    public partial class Customer_Number : Form
    {
        public Customer_Number()
        {
            InitializeComponent();
        }

        private void Customer_Number_Load(object sender, EventArgs e)
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
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
