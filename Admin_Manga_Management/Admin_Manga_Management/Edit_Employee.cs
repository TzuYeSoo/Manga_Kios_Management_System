﻿using System;
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
    public partial class Edit_Employee : Form
    {
        public Edit_Employee()
        {
            InitializeComponent();
        }
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        static DataTable dt = new DataTable();
        static string Empuser, Emppass, Empcon, Empname;
        static bool chechcon = false;

        private void Edit_Employee_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            datahis();
            sqlcon.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            if(chechcon = true)
            {
                if (textBoxEmpID.Text != "")
                {
                    if (MessageBox.Show("Do you want to continue the edit?", "Continue Edit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        sqlcom = new SqlCommand("UPDATE Admin SET Emp_UserName = @empuser, Emp_Password = @emppass, Emp_Contact = @empcon," +
                            " Emp_Position = @empos, Emp_Name = @empname WHERE Employee_ID = @empID", sqlcon);
                        sqlcom.Parameters.AddWithValue("@empuser", textBoxEmpuser.Text);
                        sqlcom.Parameters.AddWithValue("@emppass", textBoxEmppass.Text);
                        sqlcom.Parameters.AddWithValue("@empcon", textBoxEmpcon.Text);
                        sqlcom.Parameters.AddWithValue("@empID", textBoxEmpID.Text);
                        sqlcom.Parameters.AddWithValue("@empname", textBoxEmpname.Text);
                        sqlcom.Parameters.AddWithValue("@empos", comboBoxEmpPos.SelectedItem);
                        sqlcom.ExecuteNonQuery();

                        datahis();
                        chechcon = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please Reconfirm your ID");
                    chechcon = false;
                }

            }
            
            sqlcon.Close();
        }

        public void datahis()
        {
            sqlcom = new SqlCommand("SELECT * FROM Admin WHERE Emp_Status = 1", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);

            dt.Clear();
            sda.Fill(dt);
            dataEditHis.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sqlcom = new SqlCommand("SELECT * FROM Admin WHERE Emp_Status = 1 AND " +
                "Employee_ID LIKE '@emipd' OR" +
                "Emp_UserName LIKE '%@empuser%' OR" +
                "Emp_Name LIKE '%@empname%'", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);

            dt.Clear();
            sda.Fill(dt);
            dataEditHis.DataSource = dt;
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this site", " Close Edit Employee", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                StaffsHome sth = new StaffsHome();
                sth.Show();
                this.Hide();
            }
        }

        private void Confirm_ID_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                if (textBoxEmpID.Text != "")
                {
                    if (MessageBox.Show("Do you want to confirm the ID?", "Confirm to edit this staff", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        sqlcom = new SqlCommand("SELECT * FROM Admin WHERE Employee_ID = @empID", sqlcon);
                        sqlcom.Parameters.AddWithValue("@empID", textBoxEmpID.Text);

                        SqlDataReader rdr = sqlcom.ExecuteReader();
                        if (rdr.Read())
                        {
                            Empuser = (string)rdr.GetValue(1);
                            Emppass = (string)rdr.GetValue(2);
                            if (rdr.GetValue(3).ToString() != "")
                            {
                                Empcon = (string)rdr.GetValue(3);
                            }

                            Empname = (string)rdr.GetValue(6);
                            comboBoxEmpPos.Text = (string)rdr.GetValue(4);

                        }
                        rdr.Close();
                        chechcon = true;
                    }
                    textBoxEmpcon.Text = Empcon;
                    textBoxEmppass.Text = Emppass;
                    textBoxEmpuser.Text = Empuser;
                    textBoxEmpname.Text = Empname;

                }
                sqlcon.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Not Existing Account");
            }
           
        }
    }
}
