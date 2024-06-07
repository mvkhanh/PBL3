using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Views.Common
{
    public interface ILoginView
    {
        //Properties
        string Account { get; set; }
        string Password { get; set; }

        bool isSuccessful {  get; set; }

        //Events
        event EventHandler LoginEvent;
        //Methods
        void Show();
    }
}
