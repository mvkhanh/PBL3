using PBL._Repositories;
using PBL.Models;
using PBL.Views.Shared;
using PBL.Views.Shared.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Presenters.Shared
{
    public class RegisterPresenter
    {
        private IStudentRepository repository;
        private IRegisterView view;
        private static bool check = false;
        public RegisterPresenter(IRegisterView view, IStudentRepository repository)
        {
            this.repository = repository;
            this.view = view;
            //Subscribe event handler methods to view events
            if (!check)
            {
                this.view.SignUpEvent += SignUpAction;
                this.view.ReturnEvent += ReturnAction;
                check = true;
            }
            //Show view
            this.view.Show();
        }

        private void ReturnAction(object sender, EventArgs e)
        {
            CleanViewFields();
            new LoginPresenter(LoginView.GetInstance(), new TeacherRepository(), new StudentRepository());
        }

        private void SignUpAction(object sender, EventArgs e)
        {
            var model = new StudentModel();
            model.Name = view.UserName;
            model.Email = view.Email;
            model.Account = view.Account;
            model.Password = view.Password;
            model.RegistDay = DateTime.Today.Date;
            model.Birth = DateTime.Today;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                repository.Add(model);
                view.IsSuccessful = true;
                view.Message = "Sign up successfully";
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.Account = view.Password = view.UserName = view.Email = "";
        }
    }
}
