using PBL.Models;
using PBL.Models.StudentTest;
using PBL.Models.Test;
using PBL.Resources.Components.TestHistory;
using PBL.Views.Student.StudentPracticeHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Presenters.Student
{
    public class StudentPracticeHistoryPresenter
    {
        private IStudentPracticeHistoryView view;
        private IStudentTestRepository studentTestRepository;
        private int studentId;

        public StudentPracticeHistoryPresenter(IStudentPracticeHistoryView view, IStudentTestRepository studentTestRepository, int studentId)
        {
            this.view = view;
            this.studentTestRepository = studentTestRepository;
            this.studentId = studentId;

            LoadAllTests();
        }

        private void LoadAllTests()
        {
            view.testList = new List<HistoryBox>();
            var studentTestList = studentTestRepository.GetByStudent(studentId);
            foreach(var studentTest in  studentTestList)
            {
                view.testList.Add(new HistoryBox
                {
                    TestName = studentTest.Test.Name,
                    TestDate = studentTest.TestDate,
                    TestResult = studentTest.Scores,
                    TestTime = studentTest.TestTime
                });
            }
        }
    }
}
