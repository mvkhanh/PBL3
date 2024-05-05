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
        int Id { get; }
        string Name { get; set; }
        DateTime Bith {  get; set; }
        string Email {  get; set; }
        string Phone { get; set; }
        DateTime RegistDay { get; set; }
        int Lessons {  get; set; }
        int Tests {  get; set; }

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
