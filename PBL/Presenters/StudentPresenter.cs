using PBL.Models;
using PBL.Views.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Presenters
{
    public class StudentPresenter
    {
        //Fields
        private IStudentView view;
        private IStudentRepository repository;
        private BindingSource studentsBindingSource;
        private IEnumerable<StudentModel> studentList;

        //Constructor
        public StudentPresenter(IStudentView view, IStudentRepository repository)
        {
            this.studentsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchStudent;
            this.view.AddNewEvent += AddNewStudent;
            this.view.EditEvent += LoadSelectedStudentToEdit;
            this.view.DeleteEvent += DeleteSelectedStudent;
            this.view.SaveEvent += SaveStudent;
            this.view.CancelEvent += CancelAction;
            //Set students binding source
            this.view.SetStudentListBindingSource(studentsBindingSource);
            //Load student list view
            LoadAllStudentList();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllStudentList()
        {
            studentList = this.repository.GetAll();
            studentsBindingSource.DataSource = studentList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveStudent(object sender, EventArgs e)
        {
            var model = new StudentModel();
            model.Id = view.StudentId;
            model.Name = view.StudentName;
            model.Email = view.StudentEmail;
            model.Phone = view.StudentPhone;
            model.RegistDay = view.StudentRegistDay;
            model.Birth = view.StudentBirth;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Student edited successfully";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Student added successfully";
                }
                view.IsSuccessful = true;
                LoadAllStudentList();
                CleanViewFields();
            }
            catch(Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.StudentId = 0;
            view.StudentName = view.StudentPhone = view.StudentEmail = "";
            view.StudentBirth = view.StudentRegistDay = DateTime.Today;
        }

        private void DeleteSelectedStudent(object sender, EventArgs e)
        {
            try
            {
                var model = (StudentModel)studentsBindingSource.Current;
                repository.Delete(model.Id);
                view.IsSuccessful = true;
                view.Message = "Student deleted successfully";
                LoadAllStudentList();
            }
            catch(Exception)
            {
                view.IsSuccessful=false;
                view.Message = "An error occured, could not delete student";
            }
        }

        private void LoadSelectedStudentToEdit(object sender, EventArgs e)
        {
            if (studentsBindingSource.Current == null) throw new Exception("An error occured, could not edit student");
            var student = (StudentModel)studentsBindingSource.Current;
            view.StudentId = student.Id;
            view.StudentName = student.Name;
            view.StudentEmail = student.Email;
            view.StudentPhone = student.Phone;
            view.StudentBirth = student.Birth;
            view.StudentRegistDay = student.RegistDay;
            view.IsEdit = true;
        }

        private void AddNewStudent(object sender, EventArgs e)
        {
            this.view.IsEdit = false;
        }

        private void SearchStudent(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.view.SearchValue))
            {
                studentList = repository.GetAll();
            }
            else studentList = repository.GetByValue(this.view.SearchValue);
            studentsBindingSource.DataSource = studentList;
        }

    }
}
