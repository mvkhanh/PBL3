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

            ILoginView view = new LoginView();
            ITeacherRepository teacherRepository = new TeacherRepository();
            IStudentRepository studentRepository = new StudentRepository();
            new LoginPresenter(view, teacherRepository, studentRepository);

            Application.Run(new StudentProfileView());
        }
    }
}
