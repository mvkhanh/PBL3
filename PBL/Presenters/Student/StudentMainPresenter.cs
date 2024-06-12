using PBL._Repositories;
using PBL.Models;
using PBL.Presenters.Shared;
using PBL.Views;
using PBL.Views.Shared;
using PBL.Views.Student;
using PBL.Views.Student.StudentProfile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Presenters.Student
{
    public class StudentMainPresenter
    {
        private IStudentMainView mainView;
        private static bool check = false;
        public StudentMainPresenter(IStudentMainView mainView, int studentId)
        {
            this.mainView = mainView;
            this.mainView.StudentId = studentId;
            if (!check)
            {
                this.mainView.ShowProfileView += ShowProfileView;
                this.mainView.ShowLessonView += ShowLessonsView;
                this.mainView.ShowTestView += ShowTestsView;
                //Show lich su test
                this.mainView.LogOutEvent += LogOutAction;
                check = true;
            }
            this.mainView.Show();
        }

        private void ShowTestsView(object sender, EventArgs e)
        {
            new StudentTestPresenter(StudentTestView.GetInstance(), new TestRepository(), new StudentTestRepository(), this.mainView.StudentId);
        }

        private void ShowLessonsView(object sender, EventArgs e)
        {
            new StudentLessonPresenter(StudentLessonView.GetInstance(), new LessonRepository(), new StudentLessonRepository(), this.mainView.StudentId);
        }

        private void LogOutAction(object sender, EventArgs e)
        {
            new LoginPresenter(LoginView.GetInstance(), new TeacherRepository(), new StudentRepository());
        }

        private void ShowProfileView(object sender, EventArgs e)
        {
            new StudentProfilePresenter(StudentProfileView.GetInstance(), new StudentRepository(), this.mainView.StudentId);
        }
    }
}
