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
    public partial class Cashier_Remove : Form
    {
        public Cashier_Remove()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\jessie\\Admin_Manga_Management\\Admin_Manga_Management\\Database1.mdf;Integrated Security=True");
        static SqlCommand sqlcom = new SqlCommand();
        static SqlCommand sqlcom2 = new SqlCommand();
        static DataTable Cashier_Users_Remove = new DataTable();
        static bool checker = false;

        private void Cashier_Remove_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT * FROM Cashier", sqlcon);
            SqlDataAdapter sqa = new SqlDataAdapter(sqlcom);
            sqa.Fill(Cashier_Users_Remove);
            Remove_CashierGrideView.DataSource = Cashier_Users_Remove;
            sqlcon.Close();

        }

        private void Remove_button_Cahsier_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            sqlcom = new SqlCommand("SELECT Cashier_ID FROM Cashier WHERE Cashier_ID = '" + Remove_CashierID_Tx.Text + "'", sqlcon);
            SqlDataReader reader = sqlcom.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("Not exist");
                checker = false;
            }
            else
            {
                checker = true;
            }

            reader.Close();

            if (checker == true)
            {
                sqlcom2 = new SqlCommand("DELETE FROM Cashier WHERE Cashier_ID = '" + Remove_CashierID_Tx.Text + "'", sqlcon);
                sqlcom2.ExecuteNonQuery();
                sqlcom = new SqlCommand("SELECT * FROM Cashier", sqlcon);
                SqlDataAdapter sda2 = new SqlDataAdapter(sqlcom);
                Cashier_Users_Remove.Clear();
                sda2.Fill(Cashier_Users_Remove);
                Remove_CashierGrideView.DataSource = Cashier_Users_Remove;

            }

            sqlcon.Close();
        }

        private void Close_Cashier_Remove_Click(object sender, EventArgs e)
        {
            StaffsHome stf = new StaffsHome();
            stf.Show();
            this.Hide();
        }
    }
}
