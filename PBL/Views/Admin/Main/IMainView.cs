using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Views
{
    public interface IMainView
    {
        event EventHandler ShowTeacherView;
        event EventHandler ShowStudentView;
        event EventHandler ShowLessonView;
        event EventHandler ShowTestView;
        event EventHandler ShowDashBoardView;

        void Show();
    }
}
