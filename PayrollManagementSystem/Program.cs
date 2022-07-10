using PayrollSystemLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConnectionString.CnnString = ConfigurationManager.ConnectionStrings["PayrollDb"].ConnectionString;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new AdminUI.Login());
            //Application.Run(new AdminUI.PaySlip());
            Application.Run(new ClientUI.Login());
        }
    }
}
