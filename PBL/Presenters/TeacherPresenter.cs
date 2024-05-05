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
            this.view.Show();
        }

        //Methods
        private void LoadAllTeacherList()
        {
            teacherList = repository.GetAll();
            teachersBindingSource.DataSource = teacherList;//Set data source
        }

        private void SaveTeacher(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.view.searchValue)) teacherList = repository.GetAll();
            else teacherList = repository.GetByValue(this.view.searchValue);
            teachersBindingSource.DataSource = teacherList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void DeleteSelectedTeacher(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedTeacherToEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewTeacher(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchTeacher(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
