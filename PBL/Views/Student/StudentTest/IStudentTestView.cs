using PBL.Resources.Components.Test;
using PBL.Resources.Components.Test.TestQuestion;
using System;
using System.Collections.Generic;

namespace PBL.Views.Student.StudentTest
{
    public interface IStudentTestView
    {
        //Properties
        List<TestBox> Tests { get; set; }
        List<TestBox> CurrentTests { get; set; }
        string SearchValue { get; set; }
        List<int> part { get; set; }
        int Minutes { get; set; }
        int CurrentTestId { get; set; }
        bool Done {  get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler OpenEvent;
        event EventHandler DoTestEvent;

        //Methods
        void Show();
        void ShowResult(List<List<TestQuestionBox>> AnswerList, int scores, int num, int testTime, List<int> Parts);
    }
}
