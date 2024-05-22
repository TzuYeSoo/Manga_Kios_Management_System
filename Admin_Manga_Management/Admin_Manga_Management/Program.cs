using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Manga_Management
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
        }
        
    }
    public class sqlConnector
    {
        public static string connector = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\STI-STUDENT\Desktop\Jessie\Admin_Manga_Management\Admin_Manga_Management\Database1.mdf;Integrated Security=True";
        }
}
