using PBL.Resources.Components.TestHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Views.Student.StudentPracticeHistory
{
    public interface IStudentPracticeHistoryView
    {
        //Properties
        List<HistoryBox> testList { get; set; }
        //Events
        //Methods
        void Show();
    }
}
