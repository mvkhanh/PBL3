using PBL._Repositories;
using PBL.Models;
using PBL.Models.StudentTest;
using PBL.Models.Test;
using PBL.Resources.Components.Lesson;
using PBL.Resources.Components.Test;
using PBL.Resources.Components.Test.TestQuestion;
using PBL.Views.Student.StudentTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Presenters.Student
{
    public class StudentTestPresenter
    {
        private IStudentTestView view;
        private ITestRepository testRepository;
        private IStudentTestRepository studentTestRepository;
        private IEnumerable<TestModel> tests;
        private int StudentId;

        public StudentTestPresenter(IStudentTestView view, ITestRepository testRepository, IStudentTestRepository studentTestRepository, int id)
        {
            this.view = view;
            this.testRepository = testRepository;
            this.studentTestRepository = studentTestRepository;
            this.StudentId = id;
            //Events
            this.view.SearchEvent += SearchAction;
            this.view.OpenEvent += OpenAction;
            this.view.DoTestEvent += DoTestAction;
            LoadAllTests();
        }

        private void DoTestAction(object sender, EventArgs e)
        {
            new StudentDoTestPrersenter(this, StudentDoTestView.GetInstance(), new TestRepository(), new QuestionRepository(), view.CurrentTestId, view.part, view.Minutes);
        }

        private void OpenAction(object sender, EventArgs e)
        {
            view.Done = studentTestRepository.GetInfo(StudentId, view.CurrentTestId) != null;
        }

        private void SearchAction(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(view.SearchValue)) view.CurrentTests = view.Tests;
            else view.CurrentTests = view.Tests.Where(p => p.TestName.ToUpper().Contains(view.SearchValue.ToUpper())).ToList();
        }

        private void LoadAllTests()
        {
            tests = testRepository.GetAll();
            view.Tests = new List<TestBox>();
            foreach (var test in tests)
            {
                view.Tests.Add(new TestBox
                {
                    TestId = test.Id,
                    TestName = test.Name,
                    TestCount = test.Count,
                    TestDescription = test.Description,
                    TestPublishDay = test.PublishDay,
                    TestTeacher = test.Teacher.Name
                });
            }
            view.CurrentTests = view.Tests;
        }
        public void Submit(List<List<TestQuestionBox>> list, int testTime, bool isFullTest, List<int> Parts)
        {
            int scores = 0, num = 0;
            foreach(var part in list) foreach(var test in part)
                {
                    if (test.QuestionChooseAnswer == test.QuestionAnswer) scores++;
                    num++;
                }
            if (!view.Done && isFullTest)
            {
                studentTestRepository.Add(new StudentTestModel
                {
                    StudentId = StudentId,
                    TestId = view.CurrentTestId,
                    TestDate = DateTime.Today.Date,
                    TestTime = testTime,
                    Scores = scores
                });
            }
            view.ShowResult(list, scores, num, testTime, Parts);
            var model = testRepository.GetByValue(view.CurrentTestId.ToString()).First();
            model.Count++;
            testRepository.Edit(model);
        }
    }
}
