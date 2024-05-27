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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        SqlCommand sqlcom;
        DataTable dt = new DataTable();


        private void Form1_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            dataTrans();


            sqlcon.Close();
;        }
        public void dataTrans()
        {
            
            sqlcom = new SqlCommand("SELECT Customers.*, Book.Book_Name FROM Customers INNER JOIN Book ON Customers.Book_ID = Book.Book_ID", sqlcon);
            SqlDataAdapter sqda = new SqlDataAdapter(sqlcom);
            dt.Clear();
            sqda.Fill(dt);
            Trans_HisGrid.DataSource = dt;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            if (textBoxCustomersID.Text != null)
            {
                if(MessageBox.Show("","", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    sqlcom = new SqlCommand("SELECT Customers.*, Book_Name FROM Customers INNER JOIN Book ON Customers.Book_ID = Book.Book_ID WHERE Customer_ID = '" + textBoxCustomersID.Text +"'", sqlcon);

                    SqlDataReader rdr = sqlcom.ExecuteReader();

                    if (rdr.Read())
                    {
                        textBoxCustomersID.Text = (string)rdr.GetValue(0);
                        textBoxCustomerName.Text = (string)rdr.GetValue(1);
                        textBoxOrderNumber.Text = (string)rdr.GetValue(2);
                        if(rdr.GetValue(3).ToString() != "")
                        {
                            textBoxCashierID.Text = (string)rdr.GetValue(3);
                        }
                        textBoxBookID.Text = (string)rdr.GetValue(4);
                        textBoxBookQuantity.Text = rdr.GetValue(5).ToString();
                        textBoxDate.Text = (string)rdr.GetValue(6);

                    }

                    SqlDataAdapter sqda = new SqlDataAdapter(sqlcom);
                    rdr.Close();
                    dt.Clear();
                    sqda.Fill(dt);
                    Trans_HisGrid.DataSource = dt;

                }
               
            }
            else
            {
                MessageBox.Show("Input Customer_ID First");
            }
        }
    }
}
