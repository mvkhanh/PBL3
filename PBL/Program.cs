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
using PBL.Views.Common;
using PBL.Presenters.Shared;

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

            new LoginPresenter(LoginView.GetInstance(), new TeacherRepository(), new StudentRepository());

            Application.Run(LoginView.GetInstance());
            //Application.Run(new StudentMainView());
        }
    }
}
