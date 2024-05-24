using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.Models;
using PBL.Views;

namespace PBL.Presenters
{
    public class TeacherPresenter
    {
        //Fields
        private ITeacherView view;
        private ITeacherRepository repository;
        private BindingSource teachersBindingSource;
        private IEnumerable<TeacherModel> teacherList;

        //Constructor
        public TeacherPresenter(ITeacherView view, ITeacherRepository repository)
        {
            this.teachersBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchTeacher;
            this.view.AddNewEvent += AddNewTeacher;
            this.view.EditEvent += LoadSelectedTeacherToEdit;
            this.view.DeleteEvent += DeleteSelectedTeacher;
            this.view.SaveEvent += SaveTeacher;
            this.view.CancelEvent += CancelAction;
            //Set teachers binding source
            this.view.SetTeacherListBindingSource(teachersBindingSource);
            //Load teacher list view
            LoadAllTeacherList();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllTeacherList()
        {
            teacherList = repository.GetAll();
            teachersBindingSource.DataSource = teacherList.Select(p => new {p.Id, p.Name, p.Birth, p.Email, p.Phone, p.RegistDay, p.Account, p.Password}).ToList();//Set data source
        }

        private void SaveTeacher(object sender, EventArgs e)
        {
            var model = new TeacherModel();
            model.Id = view.TeacherId;
            model.Name = view.TeacherName;
            model.Email = view.TeacherEmail;
            model.Birth = view.TeacherBith;
            model.Phone = view.TeacherPhone;
            model.RegistDay = view.TeacherRegistDay;
            model.Account = view.TeacherAccount;
            model.Password = view.TeacherPassword;

            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit) //Edit model
                {
                    repository.Edit(model);
                    view.Message = "Teacher edited successfully";
                }
                else //Add model
                {
                    repository.Add(model);
                    view.Message = "Teacher added successfully";
                }
                view.IsSuccessful = true;
                LoadAllTeacherList();
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
            view.TeacherId = 0;
            view.TeacherName = "";
            view.TeacherEmail = "";
            view.TeacherBith = DateTime.Today;
            view.TeacherPhone = "";
            view.TeacherRegistDay = DateTime.Today;
            view.TeacherAccount = "";
            view.TeacherPassword = "";
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void DeleteSelectedTeacher(object sender, EventArgs e)
        {
            try
            {
                var teacher = (TeacherModel)teachersBindingSource.Current;
                repository.Delete(teacher.Id);
                view.IsSuccessful = true;
                view.Message = "Teacher deleted successfully";
                LoadAllTeacherList();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "An error occured, could not delete teacher";
            }
        }

        private void LoadSelectedTeacherToEdit(object sender, EventArgs e)
        {
            if (teachersBindingSource.Current == null) throw new Exception("An error occured, could not edit teacher");
            var teacher = (TeacherModel)teachersBindingSource.Current;
            view.TeacherId = teacher.Id;
            view.TeacherName = teacher.Name;
            view.TeacherEmail = teacher.Email;
            view.TeacherBith = teacher.Birth;
            view.TeacherPhone = teacher.Phone;
            view.TeacherRegistDay = teacher.RegistDay;
            view.TeacherAccount = teacher.Account;
            view.TeacherPassword = teacher.Password;
            view.IsEdit = true;
        }

        private void AddNewTeacher(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchTeacher(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.view.SearchValue)) teacherList = repository.GetAll();
            else teacherList = repository.GetByValue(this.view.SearchValue);
            teachersBindingSource.DataSource = teacherList;
        }
    }
}
