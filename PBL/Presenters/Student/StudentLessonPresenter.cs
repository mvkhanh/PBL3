using PBL.Models;
using PBL.Models.Lesson;
using PBL.Models.StudentLesson;
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
        private ILessonRepository lessonRepository;
        private IStudentLessonRepository studentLessonRepository;
        private IStudentLessonView view;
        private IEnumerable<LessonModel> lessons;
        private int StudentId;
        public StudentLessonPresenter(IStudentLessonView view, ILessonRepository lessonRepository, IStudentLessonRepository studentLessonRepository, int id)
        {
            this.lessonRepository = lessonRepository;
            this.studentLessonRepository = studentLessonRepository;
            this.view = view;
            this.StudentId = id;
            this.view.OpenEvent += OpenAction;
            this.view.SearchEvent += SearchAction;
            this.view.SaveEvent += SaveAction;
            this.view.UnSaveEvent += UnSaveAction;
            LoadAllLessons();
        }

        private void SaveAction(object sender, EventArgs e)
        {
            var lessonBox = (LessonBox)sender;
            studentLessonRepository.Add(this.StudentId, lessonBox.LessonId);
        }

        private void UnSaveAction(object sender, EventArgs e)
        {
            var lessonBox = (LessonBox)sender;
            studentLessonRepository.Delete(this.StudentId, lessonBox.LessonId);
        }

        private void LoadAllLessons()
        {
            lessons = lessonRepository.GetAll();
            view.Lessons = new List<LessonBox>();
            var studentLessons = studentLessonRepository.GetByStudent(StudentId);
            foreach (var lesson in lessons)
            {
                view.Lessons.Add(new LessonBox
                {
                    LessonId = lesson.Id,
                    LessonName = lesson.Name,
                    LessonPublishDay = lesson.PublishDay,
                    LessonViews = lesson.Views,
                    LessonTeacher = lesson.Teacher.Name,
                    LessonSaved = studentLessons.Contains(lesson.Id) ? true : false 
                });
            }
            view.CurrentLessons = view.Lessons;
        }

        private void SearchAction(object sender, EventArgs e)
        {
            var lessonList = view.GetSaved == false ? view.Lessons : view.Lessons.Where(p => p.LessonSaved == true).ToList();
            if (string.IsNullOrEmpty(view.SearchValue)) view.CurrentLessons = lessonList;
            else view.CurrentLessons = lessonList.Where(p => p.LessonName.ToUpper().Contains(view.SearchValue.ToUpper())).ToList();
        }

        private void OpenAction(object sender, EventArgs e)
        {
            var lessonBox = (LessonBox)sender;
            view.LessonContent = lessonRepository.GetByValue(lessonBox.LessonId.ToString()).First().Content;
            lessonBox.LessonViews++;
            var lessonModel = lessons.Where(p => p.Id == lessonBox.LessonId).FirstOrDefault();
            lessonModel.Views++;
            lessonRepository.Edit(lessonModel);
        }
    }
}
