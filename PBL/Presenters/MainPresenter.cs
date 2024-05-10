using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.Models;
using PBL.Views;
using PBL._Repositories;
using System.Windows.Forms;
using PBL.Views.Student;
using PBL.Views.Admin.Students;

namespace PBL.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string mySqlConnectionString;

        public MainPresenter(IMainView mainView, string mySqlConnectionString)
        {
            this.mainView = mainView;
            this.mySqlConnectionString = mySqlConnectionString;
            this.mainView.ShowTeacherView += ShowTeachersView;
            this.mainView.ShowStudentView += ShowStudentsView;
        }

        private void ShowStudentsView(object sender, EventArgs e)
        {
            IStudentView view = StudentView.GetInstance();
            IStudentRepository repository = new StudentRepository(mySqlConnectionString);
            new StudentPresenter(view, repository);
        }

        private void ShowTeachersView(object sender, EventArgs e)
        {
            ITeacherView view = TeacherView.GetInstance();
            ITeacherRepository repository = new TeacherRepository(mySqlConnectionString);
            new TeacherPresenter(view, repository);
        }
    }
}
