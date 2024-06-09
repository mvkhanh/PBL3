using PBL.Resources.Components.Lesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Views.Student.StudentLessonView
{
    public interface IStudentLessonView
    {
        //Properties
        byte[] LessonContent { get; set; }
        List<LessonBox> Lessons { get; set; }
        List<LessonBox> CurrentLessons { get; set; }
        string SearchValue {  get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler OpenEvent;

        //Methods
        void Show();
        void AssociateAndRaiseViewEvents();
        void InitLessonView();
    }
}
