using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            Min_Quan.Click += new EventHandler(minButton_Click);
            Add_Quan.Click += new EventHandler(addButton_Click);
        }
        public static  Book_Cart bcart;
        SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        private int quantity;
        private int id;
        static decimal tcost;



        public int getquan { get { return quantity; } set { quantity = value; Quans.Text = value.ToString(); } }
        public int getID { get { return id; } set { id = value; } }
        public decimal gettcost { get { return tcost; } set { tcost = value; } }
        
        private void Min_Quan_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            bcart = new Book_Cart();
            sqlcom = new SqlCommand("SELECT Book_Price FROM Book WHERE Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@BID", getID);
            SqlDataReader rdr = sqlcom.ExecuteReader();
            if (quantity != 0)
            {
                if (rdr.Read())
                {
                    tcost = tcost - Convert.ToDecimal(rdr.GetValue(0));
                }

                rdr.Close();

                quantity--;
                Quans.Text = quantity.ToString();
               // gettcost = tcost;
                bcart.TTPrice.Text = tcost.ToString();
                MessageBox.Show(bcart.TTPrice.Text);
            }
            
            
            sqlcon.Close();
            
        }

        private void Add_Quan_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Book_Price FROM Book WHERE Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@BID", getID);
            SqlDataReader rdr = sqlcom.ExecuteReader();
           
                if (rdr.Read())
                {
                    tcost = tcost + Convert.ToDecimal(rdr.GetValue(0));
                }

                rdr.Close();

                quantity++;
                Quans.Text = quantity.ToString();
                //gettcost = tcost;
            sqlcon.Close();
        }
        private void minButton_Click(object sender, EventArgs e)
        {
            // Access the form's method to update the label
            if (this.ParentForm is Book_Cart mainForm)
            {
                mainForm.TTPrice.Text = tcost.ToString();
                Book_Cart.QuantityID.Insert(Book_Cart.BookID.IndexOf(getID), quantity);
                // Or directly access the label
                // mainForm.MyLabel.Text = "Button in user control clicked!";
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            // Access the form's method to update the label
            if (this.ParentForm is Book_Cart mainForm)
            {
                mainForm.TTPrice.Text = tcost.ToString();
                Book_Cart.QuantityID.Insert(Book_Cart.BookID.IndexOf(getID), quantity);
                // Or directly access the label
                // mainForm.MyLabel.Text = "Button in user control clicked!";
            }
        }

        private void Remove_Book_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this into your cart?", "Remove From Cart", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Book_Cart.QuantityID.Remove(Book_Cart.BookID.IndexOf(getID));
                Book_Cart.BookID.Remove(getID);
                this.Dispose();
            }
           
        }
    }
}
