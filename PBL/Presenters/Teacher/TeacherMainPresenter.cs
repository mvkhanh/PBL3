using PBL._Repositories;
using PBL.Presenters.Shared;
using PBL.Views.Shared;
using PBL.Views.Teacher.TeacherMain;
using PBL.Views.Teacher.TeacherLessonView;
using PBL.Views.Teacher.TeacherTestView;
using System;
using PBL.Views.Teacher.TeacherProfile;

namespace PBL.Presenters.Teacher
{
    public class TeacherMainPresenter
    {
        private ITeacherMainView mainView;
        private static bool check = false;
        public TeacherMainPresenter(ITeacherMainView mainView, int TeacherId,string TeacherName)
        {
            this.mainView = mainView;
            this.mainView.TeacherId = TeacherId;
            this.mainView.TeacherName = TeacherName;
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

        private void ShowLessonsView(object sender, EventArgs e)
        {
            new TeacherLessonPresenter(TeacherLessonView.GetInstance(), new LessonRepository(), this.mainView.TeacherId, this.mainView.TeacherName);
        }
        private void ShowTestsView(object sender, EventArgs e)
        {
            new TeacherTestPresenter(TeacherTestView.GetInstance() ,new TestRepository() , new QuestionRepository() ,new AnswerRepository() , this.mainView.TeacherId, this.mainView.TeacherName);
        }
        private void LogOutAction(object sender, EventArgs e)
        {
            new LoginPresenter(LoginView.GetInstance(), new TeacherRepository(), new StudentRepository());
        }

        private void ShowProfileView(object sender, EventArgs e)
        {
            new TeacherProfilePresenter(TeacherProfileView.GetInstance(),new TeacherRepository(),new LessonRepository(),new TestRepository(), this.mainView.TeacherId);
        }
    }
}
