using PBL._Repositories;
using PBL.Models.Test;
using PBL.Models;
using PBL.Views.Admin.Tests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Presenters
{
    public class TestPresenter
    {
        //Fields
        private ITestView view;
        private ITestRepository repository;
        private BindingSource testsBindingSource;
        private IEnumerable<TestModel> testList;

        //Constructor
        public TestPresenter(ITestView view, ITestRepository repository)
        {
            this.testsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchTest;
            this.view.AddNewEvent += AddNewTest;
            this.view.EditEvent += LoadSelectedTestToEdit;
            this.view.DeleteEvent += DeleteSelectedTest;
            this.view.SaveEvent += SaveTest;
            this.view.CancelEvent += CancelAction;
            //Set Tests binding source
            this.view.SetTestListBindingSource(testsBindingSource);
            //Load Test list view
            LoadAllTestList();
            //Load Teachers to CBB
            LoadTeachersCBB();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadTeachersCBB()
        {
            var teacherList = new TeacherRepository().GetAll();
            foreach (var teacher in teacherList)
            {
                this.view.Teachers.Add(new CBBItem { Value = teacher.Id, Text = teacher.Name });
            }
        }

        private void LoadAllTestList()
        {
            testList = this.repository.GetAll();
            testsBindingSource.DataSource = testList;
        }

        private void SearchTest(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.view.SearchValue))
            {
                testList = repository.GetAll();
            }
            else testList = repository.GetByValue(this.view.SearchValue);
            testsBindingSource.DataSource = testList;
        }

        private void AddNewTest(object sender, EventArgs e)
        {
            this.view.IsEdit = false;
        }
        private void LoadSelectedTestToEdit(object sender, EventArgs e)
        {
            if (testsBindingSource.Current == null) throw new Exception("An error occured, could not edit Test");
            var test = (TestModel)testsBindingSource.Current;
            view.TestId = test.Id;
            view.TestName = test.Name;
            view.TestCount = test.Count;
            view.TestPublishDay = test.PublishDay;
            view.TestId_Teacher = test.Id_Teacher;
            view.TestDescription = test.Description;
            view.IsEdit = true;
        }
        private void SaveTest(object sender, EventArgs e)
        {
            var model = new TestModel();
            model.Id = view.TestId;
            model.Name = view.TestName;
            model.PublishDay = view.TestPublishDay;
            model.Description = view.TestDescription;
            model.Count = view.TestCount;
            model.Id_Teacher = view.TestId_Teacher;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Test edited successfully";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Test added successfully";
                }
                view.IsSuccessful = true;
                LoadAllTestList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void DeleteSelectedTest(object sender, EventArgs e)
        {
            try
            {
                var Test = (TestModel)testsBindingSource.Current;
                repository.Delete(Test.Id);
                view.IsSuccessful = true;
                view.Message = "Test deleted successfully";
                LoadAllTestList();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "An error occured, could not delete Test";
            }
        }

        private void CleanViewFields()
        {
            view.TestId = 0;
            view.TestName = "";
            view.TestCount = 0;
            view.TestDescription = "";
            view.TestPublishDay = DateTime.Today;
        }
    }
}
