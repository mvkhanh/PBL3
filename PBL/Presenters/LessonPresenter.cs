using PBL._Repositories;
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
            //Load Teachers to CBB
            LoadTeachersCBB();
            //Show view
            this.view.Show();

        }

        private void LoadTeachersCBB()
        {
            var teacherList = new TeacherRepository().GetAll();
            foreach (var teacher in teacherList)
            {
                this.view.Teachers.Add(new CBBItem { Value = teacher.Id, Text = teacher.Name });
            }
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
            if(!string.IsNullOrEmpty(view.LessonContentPath))
                model.Content = ConvertPathToContent(view.LessonContentPath);
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

        private byte[] ConvertPathToContent(string lessonContentPath)
        {
            throw new NotImplementedException();
        }

        private void CleanViewFields()
        {
            view.LessonId = 0;
            view.LessonName = "";
            view.LessonViews = 0;
            view.LessonContentPath = "";
            view.LessonPublishDay = DateTime.Today;
        }

        private void DeleteSelectedLesson(object sender, EventArgs e)
        {
            try
            {
                var lesson = (LessonModel)lessonsBindingSource.Current;
                repository.Delete(lesson.Id);
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
            if (lessonsBindingSource.Current == null) throw new Exception("An error occured, could not edit Lesson");
            var lesson = (LessonModel)lessonsBindingSource.Current;
            view.LessonId = lesson.Id;
            view.LessonName = lesson.Name;
            view.LessonViews = lesson.Views;
            view.LessonPublishDay = lesson.PublishDay;
            view.LessonId_Teacher = lesson.Id_Teacher;
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
                lessonList = repository.GetAll();
            }
            else lessonList = repository.GetByValue(this.view.SearchValue);
            lessonsBindingSource.DataSource = lessonList;
        }

    }
}
