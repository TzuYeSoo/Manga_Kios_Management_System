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
    public partial class SelectBook : UserControl
    {
        public SelectBook()
        {
            InitializeComponent();
        }

        public static int quantity = 1;
        private string name;
        private double price;

        public double Bp { get { return price; } set { price = value; BookP.Text = value.ToString(); } }
        public string BN { get { return name; } set { name = value; BookN.Text = value; } }
        public int Quan { get { return quantity;  } set { quantity = value; Quantity.Text = quantity.ToString(); } }
        private void AddQuan_Click(object sender, EventArgs e)
        {
            quantity++;
            Quantity.Text = quantity.ToString();
        }

        private void MinQuan_Click(object sender, EventArgs e)
        {
            if(quantity != 0)
            {
                quantity--;
                Quantity.Text = quantity.ToString();

            }
        }
    }
}
