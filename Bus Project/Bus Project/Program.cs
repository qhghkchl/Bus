using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusProject.Data;
using EFLibrary;

namespace Bus_Project
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

            DbContextCreator.Context = () => new BusSystemEntities();

            Application.Run(new Mainscreen());

        }
    }
}
