using PBL.Views.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.Models;
using PBL.Presenters;
using PBL.Views;
using PBL._Repositories;
using System.Configuration;

namespace PBL
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

            string mySqlConnectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            IMainView view = new MainView();
            new MainPresenter(view, mySqlConnectionString);

            Application.Run((Form)view);
        }
    }
}
