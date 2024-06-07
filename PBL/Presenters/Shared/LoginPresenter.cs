using PBL.Models;
using PBL.Views;
using PBL.Views.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Presenters.Shared
{
    public class LoginPresenter
    {
        ITeacherRepository teacherRepository;
        IStudentRepository studentRepository;
        ILoginView view;

        public LoginPresenter(ILoginView view, ITeacherRepository teacherRepository, IStudentRepository studentRepository)
        {
            this.teacherRepository = teacherRepository;
            this.studentRepository = studentRepository;
            this.view = view;
            //Subscribe event handler methods to view events
            this.view.LoginEvent += Login;
            //Show view
            this.view.Show();
        }

        private void Login(object sender, EventArgs e)
        {
            int id = teacherRepository.LoginCheck(view.Account, view.Password);
            if (id != -1)
            {
                if (id == 1)
                {
                    IMainView view = new MainView();
                    new MainPresenter(view);
                }
                else
                {
                    //Start teacher with their id
                }
                view.isSuccessful = true;
            }
            else
            {
                id = studentRepository.LoginCheck(view.Account, view.Password);
                if(id != -1)
                {
                    //start student with their id
                    view.isSuccessful = true;
                }
                else
                {
                    view.isSuccessful = false;
                }
            }
        }
    }
}
