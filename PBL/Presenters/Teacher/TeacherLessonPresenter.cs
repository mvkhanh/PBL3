using PBL.Models.Lesson;
using PBL.Models.StudentLesson;
using PBL.Views.Student.StudentLessonView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.Views.Teacher.TeacherLessonView;
using PBL._Repositories;
using PBL.Models;
using PBL.Views.Admin.Lessons;
using System.Windows.Forms;
using System.IO;

namespace PBL.Presenters.Teacher
{
    public class TeacherLessonPresenter
    {
        //Fields
        private ITeacherLessonView view;
        private ILessonRepository lessonRepository;
        private BindingSource lessonsBindingSource;
        private IEnumerable<LessonModel> lessonList;
        //Constructor
        public TeacherLessonPresenter(ITeacherLessonView view, ILessonRepository lessonRepository, int id,string name)
        {
            this.lessonsBindingSource = new BindingSource();
            this.view = view;
            this.lessonRepository = lessonRepository;
            //Load Teachers to CBB
            view.TeacherID = id;
            view.TeacherName = name;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchLesson;
            this.view.AddNewEvent += AddNewLesson;
            this.view.EditEvent += LoadSelectedLessonToEdit;
            this.view.DeleteEvent += DeleteSelectedLesson;
            this.view.SaveEvent += SaveLesson;
            this.view.CancelEvent += CancelAction;
            this.view.ViewEvent += ViewLesson;
            //Set Lessons binding source
            this.view.SetLessonListBindingSource(lessonsBindingSource);
            //Load Lesson list view
            LoadAllLessonList();

        }

        //Methods

        private void LoadAllLessonList()
        {
            lessonList = this.lessonRepository.GetAll().Where(x=> x.Id_Teacher == view.TeacherID).ToList();
            lessonsBindingSource.DataSource = lessonList;
        }

        private void SearchLesson(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.view.SearchValue))
            {
                lessonList = this.lessonRepository.GetAll().Where(x => x.Id_Teacher == view.TeacherID).ToList();
            }
            else lessonList = lessonRepository.GetByValue(this.view.SearchValue).Where(x => x.Id_Teacher == view.TeacherID).ToList();
            lessonsBindingSource.DataSource = lessonList;
        }

        private void AddNewLesson(object sender, EventArgs e)
        {
            this.view.IsEdit = false;
        }
        private void LoadSelectedLessonToEdit(object sender, EventArgs e)
        {
            if (lessonsBindingSource.Current == null) throw new Exception("An error occured, could not edit Lesson");
            var lesson = (LessonModel)lessonsBindingSource.Current;
            view.LessonId = lesson.Id;
            view.LessonName = lesson.Name;
            view.LessonViews = lesson.Views;
            view.LessonPublishDay = lesson.PublishDay;
            view.TeacherID = lesson.Id_Teacher;
            view.IsEdit = true;
        }
        private void SaveLesson(object sender, EventArgs e)
        {
            var model = new LessonModel();
            model.Id = view.LessonId;
            model.Name = view.LessonName;
            model.PublishDay = view.LessonPublishDay;
            if (!string.IsNullOrEmpty(view.LessonContentPath)) model.Content = File.ReadAllBytes(view.LessonContentPath);
            model.Views = view.LessonViews;
            model.Id_Teacher = view.TeacherID;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    lessonRepository.Edit(model);
                    view.Message = "Lesson edited successfully";
                }
                else
                {
                    lessonRepository.Add(model);
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
        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void DeleteSelectedLesson(object sender, EventArgs e)
        {
            try
            {
                var lesson = (LessonModel)lessonsBindingSource.Current;
                lessonRepository.Delete(lesson.Id);
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
        private void ViewLesson(object sender, EventArgs e)
        {
            var lesson = (LessonModel)lessonsBindingSource.Current;
            view.LessonContent = lesson.Content;
        }

        private void CleanViewFields()
        {
            view.LessonId = 0;
            view.LessonName = "";
            view.LessonViews = 0;
            view.LessonContentPath = "";
            view.LessonPublishDay = DateTime.Today;
        }
    }
}
