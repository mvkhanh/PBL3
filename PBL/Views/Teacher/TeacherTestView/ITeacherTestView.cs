using PBL.Resources.Components.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Views.Teacher.TeacherTestView
{
    public interface ITeacherTestView
    {
        //Properties
        int TestId { get; set; }
        string TestName { get; set; }
        DateTime TestPublishDay { get; set; }
        string TestDescription { get; set; }
        string TestAudioPath { get; set; }
        byte[] TestAudio { get; set; }
        int TestCount { get; set; }
        int TeacherID { get; set; }
        string TeacherName { get; set; }
        List<List<QuestionBox>> Questions { get; set; }

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

        //Methods
        void SetTestListBindingSource(BindingSource TestList);
        void Show();
    }
}
