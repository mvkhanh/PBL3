using PBL.Models.Lesson;
using PBL.Resources.Components.Lesson;
using PBL.Views.Student.StudentLessonView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PBL.Presenters.Student
{
    public class StudentLessonPresenter
    {
        private ILessonRepository repository;
        private IStudentLessonView view;
        public StudentLessonPresenter(IStudentLessonView view, ILessonRepository repository)
        {
            this.repository = repository;
            this.view = view;
            this.view.OpenEvent += OpenAction;
            this.view.SearchEvent += SearchAction;
            LoadAllLessons();
        }

        private void LoadAllLessons()
        {
            view.Lessons = new List<LessonBox>();
            foreach (var lesson in repository.GetAll())
            {
                view.Lessons.Add(new LessonBox
                {
                    LessonId = lesson.Id,
                    LessonName = lesson.Name,
                    LessonPublishDay = lesson.PublishDay,
                    LessonViews = lesson.Views,
                    LessonTeacher = lesson.Teacher.Name
                });
            }
        }

        private void SearchAction(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(view.SearchValue)) view.CurrentLessons = view.Lessons;
            view.CurrentLessons = view.Lessons.Where(p => p.LessonName.Contains(view.SearchValue)).ToList();
        }

        private void OpenAction(object sender, EventArgs e)
        {
            view.LessonContent = repository.GetByValue(((LessonBox)sender).LessonId.ToString()).First().Content;
        }
    }
}
