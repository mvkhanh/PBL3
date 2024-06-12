using PBL.Resources.Components.Test.TestQuestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Views.Student.StudentDoTest
{
    public interface IStudentDoTestView
    {
        //Properties
        List<int> Parts { get; set; }
        List<List<TestQuestionBox>> TestQuestionBoxes {  get; set; }
        int Minutes {  get; set; }
        int TestTime { get; set; }
        byte[] Audio { get; set; }

        //Events
        event EventHandler SubmitTestEvent;

        //Methods
        void Show();
    }
}
