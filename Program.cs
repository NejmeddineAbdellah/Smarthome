using GestionBibFormGhoudan.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Connection.getSqlConnection() != null)
                Application.Run(new Form1());
            else
                Console.WriteLine("Error Database");
        }
    }
}
