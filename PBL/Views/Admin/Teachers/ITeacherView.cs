using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Views
{
    public interface ITeacherView
    {
        //Properties
        int TeacherId { get; set; }
        string TeacherName { get; set; }
        DateTime TeacherBith { get; set; }
        string TeacherEmail { get; set; }
        string TeacherPhone { get; set; }
        DateTime TeacherRegistDay { get; set; }
        int TeacherLessons { get; set; }
        int TeacherTests { get; set; }
        string TeacherAccount { get; set; }
        string TeacherPassword {  get; set; }

        string SearchValue {  get; set; }
        bool IsEdit {  get; set; }
        bool IsSuccessful { get; set; }
        string Message {  get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetTeacherListBindingSource(BindingSource teacherList);
        void Show();//Optionally
    }
}
