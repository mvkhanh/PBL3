using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Views.Admin.DashBoard
{
    public interface IDashBoardView
    {
        List<KeyValuePair<string, int>> TopLessonList { get; set; }
        List<KeyValuePair<string, int>> TopTestList { get; set; }
        List<KeyValuePair<string, int>> TopTeacherList { get; set; }
        int totalStudent { get; set; }
        int totalTeacher { get; set; }
        int totalLesson { get; set; }
        int totalGrade { get; set; }
        int numberTest { get; set; }
        int numberLesson { get; set; }
        DateTime startDate { get; set; }
        DateTime endDate { get; set; }

        event EventHandler showToday;
        event EventHandler Show30Day;
        event EventHandler Show7day;
        event EventHandler Showcustomday;
        event EventHandler Showthismonth;

        void Show();
    }
}
