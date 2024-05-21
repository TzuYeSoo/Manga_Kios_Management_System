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
    public partial class Cashier_ADD : Form
    {
        public Cashier_ADD()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConntector.connector);
        static SqlCommand sqlcom = new SqlCommand();
        static SqlCommand sqlcom2 = new SqlCommand();
        static DataTable Cashier_Users = new DataTable();

        private void Add_Cashier_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            try
            {


                sqlcom2 = new SqlCommand("INSERT INTO Cashier VALUES('" + Add_CashierID_Tx.Text + "', '" + Add_CashierUser_Tx.Text + "', '" + Add_CashierPass_Tx.Text + "', '" + Add_AdminID_Tx.Text + "', '" + Add_CashierName_Tx.Text + "');", sqlcon);

                if (Add_CashierID_Tx.Text == null || Add_CashierUser_Tx.Text == null || Add_CashierUser_Tx.Text == null || Add_CashierPass_Tx.Text == null )
                {
                    MessageBox.Show("Please Input Every needed Credentials");
                }
                else
                {
                    sqlcom = new SqlCommand("SELECT * FROM Cashier;", sqlcon);
                    sqlcom2.ExecuteNonQuery();
                    sqlcom.ExecuteNonQuery();
                    SqlDataAdapter sqlad = new SqlDataAdapter(sqlcom);
                    Cashier_Users.Clear();
                    sqlad.Fill(Cashier_Users);
                    Add_CashierGrideView.DataSource = Cashier_Users;


                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Existing Account!!");
            }
            sqlcon.Close();

        }

        private void Cashier_ADD_Load(object sender, EventArgs e)
        {
            sqlcom = new SqlCommand("SELECT * FROM Cashier", sqlcon);
            SqlDataAdapter sqlad2 = new SqlDataAdapter(sqlcom);
            Cashier_Users.Clear();
            sqlad2.Fill(Cashier_Users);
            Add_CashierGrideView.DataSource = Cashier_Users;

        }

        private void CloseAdd_Cashier_Click(object sender, EventArgs e)
        {
            StaffsHome st = new StaffsHome();
            st.Show();
            this.Close();
        }
    }
}
