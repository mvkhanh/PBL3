using PBL._Repositories;
using PBL.Models;
using PBL.Presenters.Student;
using PBL.Presenters.Teacher;
using PBL.Views;
using PBL.Views.Common;
using PBL.Views.Shared;
using PBL.Views.Student;
using PBL.Views.Teacher.TeacherMain;
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
        ILoginView view;

        public LoginPresenter(ILoginView view, ITeacherRepository teacherRepository, IStudentRepository studentRepository)
        {
            this.teacherRepository = teacherRepository;
            this.studentRepository = studentRepository;
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
            int id = teacherRepository.GetByAccount(view.Account, view.Password);
            if (id != -1)
            {
                if (id == 1)
                {
                    new MainPresenter(MainView.GetInstance());
                }
                else
                {
                    string name = teacherRepository.GetByValue(id.ToString()).First().Name;
                    new TeacherMainPresenter(TeacherMainView.GetInstance(), id,name);
                }
                view.isSuccessful = true;
                view.Message = "Login successfully";
            }
            else
            {
                id = studentRepository.GetByAccount(view.Account, view.Password);
                if (id != -1)
                {
                    new StudentMainPresenter(StudentMainView.GetInstance(), id);
                    view.isSuccessful = true;
                    view.Message = "Login successfully";
                }
                else
                {
                    view.isSuccessful = false;
                    view.Message = "Check your account and password";
                }
            }
        }
    }
}

