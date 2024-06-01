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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        static BookChoice BookS;

        public void BookShow()
        {
            sqlcom = new SqlCommand("SELECT Book_ID, Book_Name, Book_Price FROM Book", sqlcon);  
            SqlDataReader rdr = sqlcom.ExecuteReader();

            while (rdr.Read())
            {
                BookS = new BookChoice();


                BookS.getBookID = Convert.ToInt16(rdr.GetValue(0));
                BookS.getBook = (string)rdr.GetValue(1);
                BookS.getBookPrice = Convert.ToDouble(rdr.GetValue(2));

                Books.Controls.Add(BookS);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            BookShow();
            sqlcon.Close();
        }

    }
}
