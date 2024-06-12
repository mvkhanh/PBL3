using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Views.Student.StudentProfile
{
    public interface IStudentProfileView
    {
        //Properties
        string StudentName { get; set; }
        DateTime StudentBirth { get; set; }
        string StudentEmail { get; set; }
        string StudentPhone { get; set; }
        string StudentCurrentPassword { get; set; }
        string StudentNewPassword {  get; set; }
        int StudentTests {  get; set; }
        int StudentAverageScores {  get; set; }
        bool IsSuccessful {  get; set; }
        string Message {  get; set; }
        //Events
        event EventHandler EditEvent;
        event EventHandler ChangePassEvent;
        event EventHandler CancelEvent;

        //Methods
        void Show();
    }
}
