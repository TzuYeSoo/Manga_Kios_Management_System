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
    public partial class AddToCart : UserControl
    {
        public AddToCart()
        {
            InitializeComponent();
        }
        private string BN;
        private double BP;
        private int quantity;

        public string Bname { get { return BN; } set { BN = value; Bookn.Text = value; } }
        public double BookP { get { return BP; } set { BP = value; Bookp.Text = value.ToString(); } }
        public int getquan { get { return quantity; }set { quantity = value; Quantity.Text = value.ToString(); } }
        private void button2_Click(object sender, EventArgs e)
        {
            quantity++;
            Quantity.Text = quantity.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(quantity != 0)
            {
                quantity--;
                Quantity.Text = quantity.ToString();
            }
        }
    }
}
