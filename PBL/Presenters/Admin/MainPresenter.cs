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
using PBL.Views.Admin.Tests;
using PBL.Models.Test;
using PBL.Models.Question;
using PBL.Models.Answer;
using PBL.Presenters.Shared;
using PBL.Views.Shared;

namespace PBL.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private static bool check = false;
        public MainPresenter(IMainView mainView)
        {
            this.mainView = mainView;
            if (!check)
            {
                this.mainView.ShowTeacherView += ShowTeachersView;
                this.mainView.ShowStudentView += ShowStudentsView;
                this.mainView.ShowLessonView += ShowLessonsView;
                this.mainView.ShowTestView += ShowTestsView;
                this.mainView.LogOutEvent += LogOutAction;
                check = true;
            }
            this.mainView.Show();
        }

        private void LogOutAction(object sender, EventArgs e)
        {
            new LoginPresenter(LoginView.GetInstance(), new TeacherRepository(), new StudentRepository());
        }

        private void ShowTeachersView(object sender, EventArgs e)
        {
            new TeacherPresenter(TeacherView.GetInstance(), new TeacherRepository());
        }

        private void ShowStudentsView(object sender, EventArgs e)
        {
            new StudentPresenter(StudentView.GetInstance(), new StudentRepository());
        }

        private void ShowLessonsView(object sender, EventArgs e)
        {
            new LessonPresenter(LessonView.GetInstance(), new LessonRepository());
        }

        private void ShowTestsView(object sender, EventArgs e)
        {
            new TestPresenter(TestView.GetInstance(), new TestRepository(), new QuestionRepository(), new AnswerRepository());
        }
    }
}
