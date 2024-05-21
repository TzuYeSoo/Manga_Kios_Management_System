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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConntector.connector);
        static SqlCommand sqlcom = new SqlCommand();
        static DataTable transaction_table = new DataTable();

        private void Transaction_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.database1DataSet1.Customers);

            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT * FROM Customers", sqlcon);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
            transaction_table.Clear();
            adapter.Fill(transaction_table);
            Trans_GrideView.DataSource = transaction_table;
            sqlcon.Close();

        }

        private void Book_trans_Click(object sender, EventArgs e)
        {
            Book_Inv bv = new Book_Inv();
            bv.Show();
            this.Hide();
        }

        private void Settings_trans_Click(object sender, EventArgs e)
        {


        }

        private void Staffs_trans_Click(object sender, EventArgs e)
        {
            StaffsHome sth = new StaffsHome();
            sth.Show();
            this.Hide();

        }

        private void Dash_trans_Click(object sender, EventArgs e)
        {
            Dashboard_Home ds = new Dashboard_Home();
            ds.Show();
            this.Hide();
        }


        public void SearchBar(string CustomerT1)
        {
            if (Search_IDTrans.Text != "")
            {
                sqlcon.Open();
                sqlcom = new SqlCommand("SELECT * FROM Customers WHERE Customer_ID = '" + CustomerT1 + "' ", sqlcon);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
                transaction_table.Clear();
                adapter.Fill(transaction_table);
                Trans_GrideView.DataSource = transaction_table;
                sqlcon.Close();

            }else if(Search_DateTrans.Text != "")
            {
                sqlcon.Open();
                sqlcom = new SqlCommand("SELECT * FROM Customers WHERE Date = '" + Search_DateTrans.Text + "'", sqlcon);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
                transaction_table.Clear();
                adapter.Fill(transaction_table);
                Trans_GrideView.DataSource = transaction_table;
                sqlcon.Close();
            }else if(Search_NameTrans.Text != "")
            {
                sqlcon.Open();
                sqlcom = new SqlCommand("SELECT * FROM Customers WHERE Customer_Name = '" + CustomerT1 + "' ", sqlcon);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
                transaction_table.Clear();
                adapter.Fill(transaction_table);
                Trans_GrideView.DataSource = transaction_table;
                sqlcon.Close();

            }
            

        }
        public void SearchBar(string CustomerT1, string CustomerT2)
        {
            if (Search_IDTrans.Text == "")
            {
                sqlcon.Open();
                sqlcom = new SqlCommand("SELECT * FROM Customers WHERE Customer_Name = '" + CustomerT1 + "' AND Date = '" + Search_DateTrans.Text + "'", sqlcon);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
                transaction_table.Clear();
                adapter.Fill(transaction_table);
                Trans_GrideView.DataSource = transaction_table;
                sqlcon.Close();

            }
            else
            {
                sqlcon.Open();
                sqlcom = new SqlCommand("SELECT * FROM Customers WHERE Customer_ID = '" + CustomerT1 + "' ", sqlcon);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
                transaction_table.Clear();
                adapter.Fill(transaction_table);
                Trans_GrideView.DataSource = transaction_table;
                sqlcon.Close();
            }
        }
        

        private void SearchBut_Trans_Click(object sender, EventArgs e)
        {
            if(Search_DateTrans.Text == "" && Search_NameTrans.Text == "")
            {
                SearchBar(Search_IDTrans.Text);
            }else if(Search_DateTrans.Text == "" && Search_IDTrans.Text == "")
            {
                SearchBar(Search_NameTrans.Text);
            }else if(Search_NameTrans.Text == "" && Search_IDTrans.Text == "" && Search_DateTrans.Text != "")
            {
                SearchBar(Search_DateTrans.Text);
            }else if(Search_IDTrans.Text == "" && Search_DateTrans.Text != "" && Search_NameTrans.Text != "")
            {
                SearchBar(Search_NameTrans.Text, Search_DateTrans.Text);
            }else if (Search_IDTrans.Text == "" && Search_DateTrans.Text == "" && Search_NameTrans.Text == "")
            {
                SearchBar(Search_IDTrans.Text);
            }
        }
    }
}
