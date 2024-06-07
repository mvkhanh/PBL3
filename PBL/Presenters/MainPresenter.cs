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
            this.mainView.ShowTestView += ShowTestsView;

            this.mainView.Show();
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

        private void ShowTestsView(object sender, EventArgs e)
        {
            ITestView view = TestView.GetInstance();
            ITestRepository testRepository = new TestRepository();
            IQuestionRepository questionRepository = new QuestionRepository();
            IAnswerRepository answerRepository = new AnswerRepository();
            new TestPresenter(view, testRepository, questionRepository, answerRepository);
        }
    }
}
