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

namespace Admin_Manga_Management
{
    public partial class WalkIn_Rec : Form
    {
        public WalkIn_Rec()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        static decimal totalcost;
        private void WalkIn_Rec_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < CashierHome.getBIDS.Count; i++)
            {
                reciept(Convert.ToInt32(CashierHome.getBIDS[i]), Convert.ToInt32(CashierHome.getQuantity[i]));
            }
            Tcost.Text = totalcost.ToString();

        }
        public void reciept(int id, int quan)
        {
            sqlcom = new SqlCommand("SELECT Book_Name, Book_Price FROM Book WHERE Book_ID = @BID", sqlcon);
            sqlcom.Parameters.AddWithValue("@BID", id);

            SqlDataReader rdr = sqlcom.ExecuteReader();
            if (rdr.Read())
            {
                Bname.Text += "\n" + (string)rdr.GetValue(0);
                Price.Text += "\n" + rdr.GetValue(1).ToString();
                Quan.Text += "\n" + quan.ToString();
                totalcost += (quan * Convert.ToDecimal(rdr.GetValue(1)));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashierHome cr = new CashierHome();
            cr.removeVals();
            cr.Show();
            this.Close();
        }
    }
}
