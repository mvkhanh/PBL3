using PBL.Models;
using PBL.Models.Lesson;
using PBL.Views.Admin.Lessons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.Presenters
{
    public class LessonPresenter
    {
        //Fields
        private ILessonView view;
        private ILessonRepository repository;
        private BindingSource lessonsBindingSource;
        private IEnumerable<LessonModel> lessonList;

        //Constructor
        public LessonPresenter(ILessonView view, ILessonRepository repository)
        {
            this.lessonsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchLesson;
            this.view.AddNewEvent += AddNewLesson;
            this.view.EditEvent += LoadSelectedLessonToEdit;
            this.view.DeleteEvent += DeleteSelectedLesson;
            this.view.SaveEvent += SaveLesson;
            this.view.CancelEvent += CancelAction;
            //Set Lessons binding source
            this.view.SetLessonListBindingSource(lessonsBindingSource);
            //Load Lesson list view
            LoadAllLessonList();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllLessonList()
        {
            lessonList = this.repository.GetAll();
            lessonsBindingSource.DataSource = lessonList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveLesson(object sender, EventArgs e)
        {
            var model = new LessonModel();
            model.Id = view.LessonId;
            model.Name = view.LessonName;
            model.PublishDay = view.LessonPublishDay;
            model.Content = view.LessonContent;
            model.Views = view.LessonViews;
            model.Id_Teacher = view.LessonId_Teacher;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Lesson edited successfully";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Lesson added successfully";
                }
                view.IsSuccessful = true;
                LoadAllLessonList();
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
            view.LessonId = 0;
            view.LessonName = view.LessonPhone = view.LessonEmail = view.LessonAccount = view.LessonPassword = "";
            view.LessonBirth = view.LessonRegistDay = DateTime.Today;
        }

        private void DeleteSelectedLesson(object sender, EventArgs e)
        {
            try
            {
                var model = (LessonModel)LessonsBindingSource.Current;
                repository.Delete(model.Id);
                view.IsSuccessful = true;
                view.Message = "Lesson deleted successfully";
                LoadAllLessonList();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "An error occured, could not delete Lesson";
            }
        }

        private void LoadSelectedLessonToEdit(object sender, EventArgs e)
        {
            if (LessonsBindingSource.Current == null) throw new Exception("An error occured, could not edit Lesson");
            var Lesson = (LessonModel)LessonsBindingSource.Current;
            view.LessonId = Lesson.Id;
            view.LessonName = Lesson.Name;
            view.LessonEmail = Lesson.Email;
            view.LessonPhone = Lesson.Phone;
            view.LessonBirth = Lesson.Birth;
            view.LessonRegistDay = Lesson.RegistDay;
            view.LessonAccount = Lesson.Account;
            view.LessonPassword = Lesson.Password;
            view.IsEdit = true;
        }

        private void AddNewLesson(object sender, EventArgs e)
        {
            this.view.IsEdit = false;
        }

        private void SearchLesson(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.view.SearchValue))
            {
                LessonList = repository.GetAll();
            }
            else LessonList = repository.GetByValue(this.view.SearchValue);
            LessonsBindingSource.DataSource = LessonList;
        }

    }
}
}
