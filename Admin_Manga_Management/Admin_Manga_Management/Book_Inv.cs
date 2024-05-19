using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Manga_Management
{
    public partial class Book_Inv : Form
    {
        public Book_Inv()
        {
            InitializeComponent();
        }

        private void Trans_book_Click(object sender, EventArgs e)
        {
            Transaction trans_Book = new Transaction();
            trans_Book.Show();
            this.Hide();
        }

        private void Staffs_Book_Click(object sender, EventArgs e)
        {
            StaffsHome sh   = new StaffsHome();
            sh.Show();
            this.Hide();
        }

        private void Dash_Book_Click(object sender, EventArgs e)
        {
            Dashboard_Home dsh = new Dashboard_Home();
            dsh.Show();
            this.Hide();
        }
    }
}
