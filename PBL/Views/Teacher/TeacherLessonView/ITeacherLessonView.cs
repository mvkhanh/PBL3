using PBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Views.Teacher.TeacherLessonView
{
    public interface ITeacherLessonView
    {
        //Properties
        int LessonId { get; set; }
        string LessonName { get; set; }
        DateTime LessonPublishDay { get; set; }
        string LessonContentPath { get; set; }
        byte[] LessonContent { get; set; }
        int LessonViews { get; set; }
        int TeacherID { get; set; }
        string TeacherName { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler DeleteEvent;
        event EventHandler EditEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler ViewEvent;

        //Methods
        void SetLessonListBindingSource(BindingSource lessonList);
        void Show();
    }
}
