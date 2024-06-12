using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_Customer
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
            Application.Run(new Kiosk_Home());
        }
    }
    public class sqlConnector
    {
        public static string connector = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maxime\Documents\kiosk\Manga_Kios_Management_System\Admin_Manga_Management\Admin_Manga_Management\Database1.mdf;Integrated Security=True";

    }
}
