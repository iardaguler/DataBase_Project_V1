using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_DataBase_Project_V1
{
    internal static class Program
    {

        public static string ID, IdentifyNumber, Name, Surname, PhoneNumber, City, Birthyear;
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAdminLogin());
        }
    }
}
