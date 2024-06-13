using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Views.Teacher.TeacherProfile
{
    public interface ITeacherProfileView
    {
        //Properties
        string TeacherName { get; set; }
        DateTime TeacherBirth { get; set; }
        string TeacherEmail { get; set; }
        string TeacherPhone { get; set; }
        string TeacherCurrentPassword { get; set; }
        string TeacherNewPassword { get; set; }
        int TotalLesson {  get; set; }
        int TotalTest { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        //Events
        event EventHandler EditEvent;
        event EventHandler ChangePassEvent;
        event EventHandler CancelEvent;

        //Methods
        void Show();
    }
}
