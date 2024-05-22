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
    public partial class Edit_BookInv : Form
    {
        public Edit_BookInv()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(sqlConnector.connector);
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
