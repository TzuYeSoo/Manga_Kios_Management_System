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
using System.Windows.Forms.DataVisualization.Charting;

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
        private int quantity,cid;
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        public decimal gettcost { get { return tcost; }set { tcost = value; } }
        public int getQuantity { get { return quantity; } set { quantity = value; LabelQuan.Text = quantity.ToString(); }  }
        public int getCID { get {return cid; } set { cid = value; } }

        private void plus_quan_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Book_Price FROM Book WHERE Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@BID", cid);
            SqlDataReader rdr = sqlcom.ExecuteReader();

            if (rdr.Read())
            {
                gettcost = gettcost + Convert.ToDecimal(rdr.GetValue(0));
            }

            rdr.Close();

            quantity++;
            LabelQuan.Text = quantity.ToString();

            sqlcon.Close();
        }

        private void min_quan_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Book_Price FROM Book WHERE Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@BID", cid );
            SqlDataReader rdr = sqlcom.ExecuteReader();
            if (quantity > 1)
            {

                if (rdr.Read())
                {
                    gettcost = gettcost - Convert.ToDecimal(rdr.GetValue(0));
                }

                rdr.Close();

                quantity--;
                LabelQuan.Text = quantity.ToString();
            }
            
            sqlcon.Close();
        }
        private void MinButton_Click(object sender, EventArgs e)
        {
            // Access the form's method to update the label
            if (this.ParentForm is CashierHome mainForm)
            {
                mainForm.TotalPrice.Text = tcost.ToString();
                // Or directly access the label
                // mainForm.MyLabel.Text = "Button in user control clicked!";
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Access the form's method to update the label
            if (this.ParentForm is CashierHome mainForm)
            {
                
                
                    mainForm.TotalPrice.Text = tcost.ToString();
                
                
                // Or directly access the label
                // mainForm.MyLabel.Text = "Button in user control clicked!";
            }
        }
    }
}
