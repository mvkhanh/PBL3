using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Views.Shared.Register
{
    public interface IRegisterView
    {
        //Properties
        string Account {  get; set; }
        string UserName {  get; set; }
        string Password { get; set; }
        string Email { get; set; }
        
        bool IsSuccessful {  get; set; }
        string Message {  get; set; }

        //Events
        event EventHandler ReturnEvent;
        event EventHandler SignUpEvent;

        //Methods
        void Show();
    }
}
