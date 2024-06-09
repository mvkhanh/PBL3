using PBL._Repositories;
using PBL.Models;
using PBL.Models.Account;
using PBL.Presenters.Student;
using PBL.Views;
using PBL.Views.Common;
using PBL.Views.Shared;
using PBL.Views.Student;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Presenters.Shared
{
    public class LoginPresenter
    {
        private static bool check = false;
        ITeacherRepository teacherRepository;
        IStudentRepository studentRepository;
        IAccountRepository accountRepository;
        ILoginView view;

        public LoginPresenter(ILoginView view, ITeacherRepository teacherRepository, IStudentRepository studentRepository, IAccountRepository accountRepository)
        {
            this.teacherRepository = teacherRepository;
            this.studentRepository = studentRepository;
            this.accountRepository = accountRepository;
            this.view = view;
            //Subscribe event handler methods to view events
            if (!check)
            {
                this.view.LoginEvent += Login;
                this.view.SignUpEvent += SignUpAction;
                check = true;
            }
            //Show view
            this.view.Show();
        }

        private void SignUpAction(object sender, EventArgs e)
        {
            new RegisterPresenter(RegisterView.GetInstance(), new StudentRepository());
        }

        private void Login(object sender, EventArgs e)
        {
            int id_Account = accountRepository.GetAccount(view.Account, view.Password);
            if(id_Account == -1)
            {
                view.isSuccessful = false;
                view.Message = "Check your account and password";
                return;
            }
            int id = teacherRepository.GetByAccount(id_Account);
            if (id != -1)
            {
                if (id == 1)
                {
                    new MainPresenter(MainView.GetInstance());
                }
                else
                {
                    //Start teacher with their id
                }
            }
            else
            {
                new StudentMainPresenter(StudentMainView.GetInstance(), studentRepository.GetByAccount(id_Account));
            }
            view.isSuccessful = true;
            view.Message = "Login successfully";
        }
    }
}

