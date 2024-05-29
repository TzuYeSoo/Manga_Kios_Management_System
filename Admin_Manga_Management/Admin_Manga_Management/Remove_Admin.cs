using System;
using System.Collections;
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
    public partial class Remove_Admin : Form
    {
        public Remove_Admin()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom = new SqlCommand();
        static SqlCommand sqlcom2 = new SqlCommand();
        static DataTable dt = new DataTable();
        static DataTable dt1 = new DataTable();
        static bool checker;
        

        private void Remove_Admin_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            EmpdataHis();
            EmpdataHisR();
            sqlcon.Close();

        }

        private void Remove_Remove_Click(object sender, EventArgs e)
        {
            

        }

        private void Close_Remove_Admin_Click(object sender, EventArgs e)
        {
            StaffsHome sh = new StaffsHome();
            sh.Show();
            this.Hide();
        }

        private void ConfirmID_Click(object sender, EventArgs e)
        {
            if(AdminID_Remove.Text != "")
            {
                if(MessageBox.Show("Confirm this ID?","Confirm ID", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    sqlcon.Open();

                    sqlcom = new SqlCommand("SELECT * FROM Admin WHERE Admin_ID = @ID", sqlcon);
                    sqlcom.Parameters.AddWithValue("@ID", AdminID_Remove.Text);

                    SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                    dt.Clear();
                    sda.Fill(dt);
                    Remove_Admin_GrideView.DataSource = dt;

                    sqlcon.Close();
                }
            }
            else
            {
                MessageBox.Show("Input ID First");
            }
        }
        public void EmpdataHis()
        {

            sqlcom2 = new SqlCommand("SELECT * FROM Admin WHERE EM_Status = 1", sqlcon);
            SqlDataAdapter sda1 = new SqlDataAdapter(sqlcom2);
            dt1.Clear();
            sda1.Fill(dt1);
            Remove_Admin_GrideView.DataSource = dt1;


        }
        public void EmpdataHisR()
        {
            sqlcom = new SqlCommand("SELECT * FROM Admin WHERE EM_Status = 0", sqlcon);
            SqlDataAdapter sda1 = new SqlDataAdapter(sqlcom);
            dt.Clear();
            sda1.Fill(dt);
            Delete_His.DataSource = dt;
        }

        private void RConfirm_ID_Click(object sender, EventArgs e)
        {
            if(RRemoveBox.Text != "")
            {
                if(MessageBox.Show("Do you want to confirm the ID?", "Confirm ID", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    sqlcon.Open();
                    sqlcom = new SqlCommand("SELECT * FROM Admin WHERE Admin_ID = @ID AND EM_Status = 0", sqlcon);
                    sqlcom.Parameters.AddWithValue("@ID", RRemoveBox.Text);
                    SqlDataAdapter sda1 = new SqlDataAdapter(sqlcom);
                    dt.Clear();
                    sda1.Fill(dt);
                    Delete_His.DataSource = dt;
                    sqlcon.Close();

                }
            }

        }

        private void Retrieve_EM_Click(object sender, EventArgs e)
        {
        if(RRemoveBox.Text != "")
            {
                if(MessageBox.Show("Retrieve this Employee", "Retrieve Employee", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    sqlcon.Open();
                    sqlcom = new SqlCommand("UPDATE Admin SET EM_Status = 1 WHERE Admin_ID = @AID", sqlcon);
                    sqlcom.Parameters.AddWithValue("@AID",RRemoveBox.Text);

                    EmpdataHis();
                    EmpdataHisR();
                    sqlcon.Close();
                    RRemoveBox.Clear();
                }
            }
        }
    }
}
