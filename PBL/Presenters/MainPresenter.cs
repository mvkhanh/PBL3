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
using PBL.Views.Admin.Lessons;
using PBL.Models.Lesson;

namespace PBL.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        public MainPresenter(IMainView mainView)
        {
            this.mainView = mainView;
            this.mainView.ShowTeacherView += ShowTeachersView;
            this.mainView.ShowStudentView += ShowStudentsView;
            this.mainView.ShowLessonView += ShowLessonsView;
        }
        private void ShowTeachersView(object sender, EventArgs e)
        {
            ITeacherView view = TeacherView.GetInstance();
            ITeacherRepository repository = new TeacherRepository();
            new TeacherPresenter(view, repository);
        }

        private void ShowStudentsView(object sender, EventArgs e)
        {
            IStudentView view = StudentView.GetInstance();
            IStudentRepository repository = new StudentRepository();
            new StudentPresenter(view, repository);
        }

        private void ShowLessonsView(object sender, EventArgs e)
        {
            ILessonView view = LessonView.GetInstance();
            ILessonRepository repository = new LessonRepository();
            new LessonPresenter(view, repository);
        }
    }
}
