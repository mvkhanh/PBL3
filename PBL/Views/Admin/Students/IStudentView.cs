using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Views.Student
{
    public interface IStudentView
    {
        //Properties
        int StudentId {  get; set; }
        string StudentName {  get; set; }
        DateTime StudentBirth {  get; set; }
        string StudentEmail {  get; set; }
        string StudentPhone {  get; set; }
        DateTime StudentRegistDay {  get; set; }

        string SearchValue {  get; set; }
        bool IsEdit {  get; set; }
        bool IsSuccessful {  get; set; }
        string Message {  get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler DeleteEvent;
        event EventHandler EditEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetStudentListBindingSource(BindingSource studentList);
        void Show();
    }
}
