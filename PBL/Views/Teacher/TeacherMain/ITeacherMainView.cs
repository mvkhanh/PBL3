using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Views.Teacher.TeacherMain
{
    public interface ITeacherMainView
    {
        //Properties
        int TeacherId { get; set; }
        string TeacherName { get; set; }

        //EventHandler
        event EventHandler ShowProfileView;
        event EventHandler ShowLessonView;
        event EventHandler ShowTestView;
        event EventHandler LogOutEvent;

        void Show();
    }
}
