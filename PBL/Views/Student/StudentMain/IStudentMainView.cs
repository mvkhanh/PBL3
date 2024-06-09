using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Views.Student
{
    public interface IStudentMainView
    {
        //Properties
        int StudentId { get; set; }

        //EventHandler
        event EventHandler ShowProfileView;
        event EventHandler ShowLessonView;
        event EventHandler ShowTestView;
        event EventHandler ShowFavoriteLessonView;
        event EventHandler ShowPracticeHistoryView;
        event EventHandler LogOutEvent;

        void Show();
    }
}
