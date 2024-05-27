using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Views.Admin.Tests
{
    public interface ITestView
    {
        //Properties
        int TestId { get; set; }
        string TestName { get; set; }
        DateTime TestPublishDay { get; set; }
        string TestDescription { get; set; }
        int TestCount { get; set; }
        int TestId_Teacher { get; set; }
        List<CBBItem> Teachers { get; set; }

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
