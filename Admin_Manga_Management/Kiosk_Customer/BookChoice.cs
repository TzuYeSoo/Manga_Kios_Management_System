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
    public partial class BookChoice : UserControl
    {
        public BookChoice()
        {
            InitializeComponent();
        }
        #region
        private string Bname;
        private double Bprice;
        private int BID;

        
        public string getBook { get { return Bname; } set { Bname = value; BookName.Text = value; } }
        public double getBookPrice { get { return Bprice; } set { Bprice = value; BookPrice.Text = value.ToString(); } }
        public int getBookID { get { return BID; } set { BID = value; } }



        #endregion

        private void BookChoice_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BookName_Click(object sender, EventArgs e)
        {

        }

        private void BookImage_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
