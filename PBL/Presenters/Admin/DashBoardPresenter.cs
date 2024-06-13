using PBL.Models.Lesson;
using PBL.Models.Test;
using PBL.Models;
using PBL.Views.Admin.DashBoard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.Models.StudentTest;

namespace PBL.Presenters.Admin
{
    public class DashBoardPresenter
    {
        //Fields
        private IDashBoardView view;
        private ILessonRepository lessonRepository;
        private ITeacherRepository teacherRepository;
        private IStudentRepository studentRepository;
        private ITestRepository testRepository;
        private IEnumerable<LessonModel> lessonList;
        private IStudentTestRepository studentTestRepository;
        public DashBoardPresenter(IDashBoardView view, ITeacherRepository teacherRepository, IStudentRepository studentRepository, ITestRepository testRepository, ILessonRepository lessonRepository,IStudentTestRepository studentTestRepository)
        {
            this.studentTestRepository = studentTestRepository;
            this.teacherRepository = teacherRepository;
            this.studentRepository = studentRepository;
            this.testRepository = testRepository;
            this.lessonRepository = lessonRepository;
            this.view = view;
            this.view.showToday += ShowToday;
            this.view.Show7day += Show7Day;
            this.view.Show30Day += Show30Day;
            this.view.Showthismonth += ShowThisMonth;
            this.view.Showcustomday += ShowCustomDay;
            GetOrderAnalisys();
        }

        private void GetOrderAnalisys()
        {
            CleanChart();
            view.totalLesson = lessonRepository.GetAll().Count();
            view.totalStudent = studentRepository.GetAll().Count();
            view.totalTeacher = teacherRepository.GetAll().Count();
            var test = testRepository.GetAll()
                        .Where(x => x.PublishDay.Date >= view.startDate.Date && x.PublishDay.Date <= view.endDate.Date)
                        .Select(x => x.Id)
                        .ToList();

            var grade = 0;
            foreach (var testId in test)
            {
                var studentTests = studentTestRepository.GetByTest(testId);
                grade += studentTests.Sum(g => g.Scores);
            }
            view.totalGrade = grade;
            view.numberLesson = lessonRepository.GetAll().Where(x => (x.PublishDay.Date >= view.startDate.Date && x.PublishDay.Date <= view.endDate.Date)).Count();
            view.numberTest = testRepository.GetAll().Where(x => (x.PublishDay.Date >= view.startDate.Date && x.PublishDay.Date <= view.endDate.Date)).Count();
            var topTeachers = lessonRepository.GetAll()
                .GroupBy(l => l.Id_Teacher)
                .Select(g => new { TeacherID = g.Key, LessonCount = g.Count() })
                .OrderByDescending(t => t.LessonCount)
                .Take(10)
                .Select(t => new KeyValuePair<string, int>(teacherRepository.GetByValue(t.TeacherID.ToString()).First().Name, t.LessonCount))
                .ToList();
            var topLessons = lessonRepository.GetAll().Where(x => (x.PublishDay.Date >= view.startDate.Date && x.PublishDay.Date <= view.endDate.Date)).OrderByDescending(x => x.Views).Take(10).Select(t => new KeyValuePair<string, int>(t.Name, t.Views)).ToList();
            view.TopLessonList.AddRange(topLessons);
            var topTest = testRepository.GetAll().Where(x => (x.PublishDay.Date >= view.startDate.Date && x.PublishDay.Date <= view.endDate.Date)).OrderByDescending(x => x.Count).Take(10).Select(t => new KeyValuePair<string, int>(t.Name, t.Count)).ToList();
            view.TopTestList.AddRange(topTest);
            this.view.TopTeacherList.AddRange(topTeachers);
            view.Show();
        }
        private void CleanChart()
        {
            this.view.TopTeacherList = new List<KeyValuePair<string, int>>();
            this.view.TopLessonList = new List<KeyValuePair<string, int>>();
            this.view.TopTestList = new List<KeyValuePair<string, int>>();
        }
        private void ShowToday(object sender, EventArgs e)
        {
            GetOrderAnalisys();
        }
        private void Show7Day(object sender, EventArgs e)
        {
            GetOrderAnalisys();
        }
        private void Show30Day(object sender, EventArgs e)
        {
            GetOrderAnalisys();
        }
        private void ShowThisMonth(object sender, EventArgs e)
        {
            GetOrderAnalisys();
        }
        private void ShowCustomDay(object sender, EventArgs e)
        {
            GetOrderAnalisys();
        }
    }
}
