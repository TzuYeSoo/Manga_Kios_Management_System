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
    public partial class Cart_Control : UserControl
    {
        public Cart_Control()
        {
            InitializeComponent();
        }
        private int quantity;
        
        private void Min_Quan_Click(object sender, EventArgs e)
        {
            if (quantity != 0)
            {
                quantity--;
                Quans.Text = quantity.ToString();

                if(Quans.Text == "0")
                {
                    Book_Cart bc = new Book_Cart();
                    bc.showBooks();
                }
                
            }
            
        }

        private void Add_Quan_Click(object sender, EventArgs e)
        {
            quantity++;
            Quans.Text = quantity.ToString();
        }
    }
}
