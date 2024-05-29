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
using static System.Windows.Forms.AxHost;

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
        public static bool checkRM, checkRT;
        

        private void Remove_Admin_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            EmpdataHis();
            EmpdataHisR();
            sqlcon.Close();

        }

        private void Remove_Remove_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            if (checkRM == true) { 

                if (AdminID_Remove.Text != "")
                {
                    if (MessageBox.Show("Remove This Account", "Remove Account", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        sqlcom = new SqlCommand("UPDATE Admin SET Emp_Status = 0 WHERE Employee_ID = @AID", sqlcon);
                        sqlcom.Parameters.AddWithValue("@AID", AdminID_Remove.Text);
                        sqlcom.ExecuteNonQuery();

                        EmpdataHis();
                        EmpdataHisR();
                        checkRM = false;
                        AdminID_Remove.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Verify your ID first");
            }
            
           
            sqlcon.Close();

        }

        private void Close_Remove_Admin_Click(object sender, EventArgs e)
        {
            StaffsHome sh = new StaffsHome();
            sh.Show();
            this.Hide();
        }

        private void ConfirmID_Click(object sender, EventArgs e)
        {
            int stat = 0;
            sqlcon.Open();
            try
            {
                

                sqlcom = new SqlCommand("SELECT Emp_Status FROM Admin WHERE Employee_ID = @empID",sqlcon);
                sqlcom.Parameters.AddWithValue("@empID", AdminID_Remove.Text);
                SqlDataReader rdr = sqlcom.ExecuteReader();

                if (rdr.Read())
                {
                    stat = (int)rdr.GetValue(0);
                }
                rdr.Close();
                    if (stat == 1)
                    {
                        if (AdminID_Remove.Text != "")
                        {
                            checkRM = true;
                            if (MessageBox.Show("Confirm this ID?", "Confirm ID", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {

                                sqlcom = new SqlCommand("SELECT * FROM Admin WHERE Employee_ID = @ID AND Emp_Status = 1", sqlcon);
                                sqlcom.Parameters.AddWithValue("@ID", AdminID_Remove.Text);

                                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                                dt.Clear();
                                sda.Fill(dt);
                                Remove_Admin_GrideView.DataSource = dt;

                            }
                        }
                        else
                        {
                            MessageBox.Show("Input ID First");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Account is already Inactive");
                    }

            }
            catch (SqlException)
            {
                MessageBox.Show("Not Exisiting Account!");
                sqlcon.Close();
            }
            sqlcon.Close();
        }
        public void EmpdataHis()
        {

            sqlcom2 = new SqlCommand("SELECT * FROM Admin WHERE Emp_Status = 1", sqlcon);
            SqlDataAdapter sda1 = new SqlDataAdapter(sqlcom2);
            dt.Clear();
            sda1.Fill(dt);
            Remove_Admin_GrideView.DataSource = dt;


        }
        public void EmpdataHisR()
        {
            sqlcom = new SqlCommand("SELECT * FROM Admin WHERE Emp_Status = 0", sqlcon);
            SqlDataAdapter sda1 = new SqlDataAdapter(sqlcom);
            dt1.Clear();
            sda1.Fill(dt1);
            Delete_His.DataSource = dt1;
        }

        private void RConfirm_ID_Click(object sender, EventArgs e)
        {
            int stat = 0;
            sqlcon.Open();
            try
            {


                sqlcom = new SqlCommand("SELECT Emp_Status FROM Admin WHERE Employee_ID = @empID", sqlcon);
                sqlcom.Parameters.AddWithValue("@empID", RRemoveBox.Text);
                SqlDataReader rdr = sqlcom.ExecuteReader();

                if (rdr.Read())
                {
                    stat = (int)rdr.GetValue(0);
                }
                rdr.Close();
                if (stat == 0)
                {
                    if (RRemoveBox.Text != "")
                    {
                        checkRT = true;
                        if (MessageBox.Show("Confirm this ID?", "Confirm ID", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {

                            sqlcom = new SqlCommand("SELECT * FROM Admin WHERE Employee_ID = @ID AND Emp_Status = 0", sqlcon);
                            sqlcom.Parameters.AddWithValue("@ID", RRemoveBox.Text);

                            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                            dt1.Clear();
                            sda.Fill(dt1);
                            Delete_His.DataSource = dt1;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Input ID First");
                    }
                }
                else
                {
                    MessageBox.Show("The Account is already Inactive");
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Not Exisiting Account!");
                sqlcon.Close();
            }
            sqlcon.Close();

        }

        private void Retrieve_EM_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            if (checkRT == true)
            {

                if (RRemoveBox.Text != "")
                {
                    if (MessageBox.Show("Retrieve This Account", "Retrieve Account", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        sqlcom = new SqlCommand("UPDATE Admin SET Emp_Status = 1 WHERE Employee_ID = @AID", sqlcon);
                        sqlcom.Parameters.AddWithValue("@AID", RRemoveBox.Text);
                        sqlcom.ExecuteNonQuery();

                        EmpdataHis();
                        EmpdataHisR();
                        checkRT = false;
                        RRemoveBox.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please Reconfirm your ID");
                    checkRT = false;
                }
            }
            else
            {
                MessageBox.Show("Please Verify your ID first");
            }


            sqlcon.Close();
        }
    }
}
