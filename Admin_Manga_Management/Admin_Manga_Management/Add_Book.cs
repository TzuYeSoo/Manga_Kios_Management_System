﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Manga_Management
{
    public partial class Add_Book : Form
    {
        
        public Add_Book()
        {
           
            InitializeComponent();
        }
        private Image Book_Im;
        static SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        static SqlCommand sqlcom;
        static SqlCommand sqlcom2;
        static DataTable dt = new DataTable();
        static string BookOptionsts;
        static bool successImage = false;
        static string BGName;
        static int BookID;
        private void Add_Book_Load(object sender, EventArgs e)
        {
            

            sqlcon.Open();
            GridviewOutput();

            sqlcom2 = new SqlCommand("SELECT BookgenreNames FROM BookOPtions", sqlcon);
            SqlDataReader rdr = sqlcom2.ExecuteReader();
            

            while (rdr.Read())
            {
                GenreNames.Items.Add(rdr.GetValue(0));

            }

            rdr.Close();
            sqlcon.Close();


        }

        private void Add_Book_FROMADD_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = null;
            if(Book_Im != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    Book_Im.Save(ms, Book_Im.RawFormat);
                    imageBytes = ms.ToArray();
                }
            }
            if (Add_BookName_Add.Text != "" && Add_BookPrice_Add.Text != ""
                        && Add_BookQuantity_Add.Text != "" && Add_BookQuantity_Add.Text != "0" && successImage == true)
            {
                sqlcon.Open();
                //try
                //{
                    if (MessageBox.Show("Do you want to add this book?", "ADD THIS BOOK", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {

                    sqlcom = new SqlCommand("INSERT INTO Book VALUES(@name, @price, @quantity, @description,@bookstat ,@BookImage) ", sqlcon);
                    sqlcom.Parameters.AddWithValue("@name", Add_BookName_Add.Text);
                    sqlcom.Parameters.AddWithValue("@price", Add_BookPrice_Add.Text);
                    sqlcom.Parameters.AddWithValue("@quantity", Add_BookQuantity_Add.Text);
                    sqlcom.Parameters.AddWithValue("@description", Add_BookDescrip_Add.Text);
                    sqlcom.Parameters.AddWithValue("@bookstat", 1);
                    sqlcom.Parameters.AddWithValue("@BookImage", imageBytes ?? (object)DBNull.Value);
                    sqlcom.ExecuteNonQuery();
                    successImage = false;

                    for (int i = 0; i < GenreNames.Items.Count; i++)
                        {
                            if (GenreNames.GetItemChecked(i))
                            {
                                sqlcom = new SqlCommand("SELECT Book_ID FROM Book WHERE Book_Name = @bookn AND Book_Price = @bookPrice",sqlcon);
                                sqlcom.Parameters.AddWithValue("@bookn", Add_BookName_Add.Text);
                                sqlcom.Parameters.AddWithValue("@bookPrice", Convert.ToDouble(Add_BookPrice_Add.Text));
                                SqlDataReader rdr = sqlcom.ExecuteReader();
                                if (rdr.Read())
                                {
                                BookID = Convert.ToInt16(rdr.GetValue(0));
                                }
                                rdr.Close();
                                BGName = $"{GenreNames.Items[i]}"; ;
                                sqlcom2 = new SqlCommand("INSERT INTO Book_GenreName VALUES(@bookgenre, @book_ID )", sqlcon);
                                sqlcom2.Parameters.AddWithValue("@book_ID", BookID);
                                sqlcom2.Parameters.AddWithValue("@bookgenre", BGName);

                                sqlcom2.ExecuteNonQuery();
                            }
                        }
                        Add_BookID_Add.Clear();
                        Add_BookName_Add.Clear();
                        Add_BookQuantity_Add.Clear();
                        Add_BookDescrip_Add.Clear();
                        Add_BookPrice_Add.Clear();
                        Book_Image.Image.Dispose();
                        Book_Image.Image = null;
                        for (int i = 0; i < GenreNames.Items.Count; i++)
                        {
                            GenreNames.SetItemChecked(i, false);
                        }
                        GridviewOutput();



                    }
                   
                //}
                //catch (SqlException ex)
                //{
                   // MessageBox.Show("Existing Data Files");
                //}
                sqlcon.Close();

            }
            else
            {
                MessageBox.Show("Please Incomplete Details");
            }

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit this site? ", "Alert" ,MessageBoxButtons.YesNo);

            Book_Inv bo = new Book_Inv();
            bo.Show();
            this.Hide();
        }

        public void GridviewOutput()
        {
            sqlcom = new SqlCommand("SELECT Book.*, Bookgenre FROM Book LEFT JOIN Book_GenreName ON Book_GenreName.Book_ID = Book.Book_ID ", sqlcon);
            SqlDataAdapter sda2 = new SqlDataAdapter(sqlcom);
            dt.Clear();
            sda2.Fill(dt);
            Book_GrideView_BookADD.DataSource = dt;

        }

        private void Book_Image_Click(object sender, EventArgs e)
        {
            Book_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.bmp"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                successImage = true;
                string imagePath = ofd.FileName;
                Book_Im = Image.FromFile(ofd.FileName);
                Book_Image.Image = Book_Im;
                

            }

            
        }

        private void Add_BookQuantity_Add_TextChanged(object sender, EventArgs e)
        {
            Match match = Regex.Match(Add_BookQuantity_Add.Text, "^[0-9]+$", RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                Add_BookQuantity_Add.Clear();
            }
        }

        private void Add_BookPrice_Add_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(Add_BookPrice_Add.Text, out double number))
            {
                Add_BookPrice_Add.Clear();
            }
        }
    }
}
