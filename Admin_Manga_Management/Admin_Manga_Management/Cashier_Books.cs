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
    public partial class Cashier_Books : UserControl
    {
        public Cashier_Books()
        {
            InitializeComponent();
        }

        private void bookim_Click(object sender, EventArgs e)
        {
            CashierHome ch = new CashierHome();
            PayCus pay = new PayCus();
            pay.Bname.Text = Bname.Text;
            pay.OrderPrice.Text = Bprice.Text;
            pay.Cname.Text = "New Customer";
            pay.LabelQuan.Text = "1";
            ch.Newcust.Controls.Add(pay);
        }
    }
}
