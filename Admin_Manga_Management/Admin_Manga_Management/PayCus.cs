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
    public partial class PayCus : UserControl
    {
        public PayCus()
        {
            InitializeComponent();
            min_quan.Click += new EventHandler(MinButton_Click);
            plus_quan.Click += new EventHandler(AddButton_Click);
        }
        private decimal tcost, updatecost;
        private int quantity;

        public decimal gettcost { get { return tcost; }set { tcost = value; } }
        public int getQuantity { get { return quantity; } set { quantity = value; LabelQuan.Text = quantity.ToString(); }  }

        public void plus_quan_Click(object sender, EventArgs e)
        {
            updatecost = 0;
            quantity++;
            LabelQuan.Text = quantity.ToString();
            updatecost = gettcost * quantity;
        }

        public void min_quan_Click(object sender, EventArgs e)
        {
            updatecost = 0;
            CashierHome chome = new CashierHome();
            if(quantity > 1)
            {
               quantity--;
               LabelQuan.Text = quantity.ToString();
               updatecost = gettcost * quantity;
               
            } 
        }
        private void MinButton_Click(object sender, EventArgs e)
        {
            // Access the form's method to update the label
            if (this.ParentForm is CashierHome mainForm)
            {
                mainForm.TotalPrice.Text = updatecost.ToString();
                // Or directly access the label
                // mainForm.MyLabel.Text = "Button in user control clicked!";
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Access the form's method to update the label
            if (this.ParentForm is CashierHome mainForm)
            {
                mainForm.TotalPrice.Text = updatecost.ToString();
                // Or directly access the label
                // mainForm.MyLabel.Text = "Button in user control clicked!";
            }
        }
    }
}
