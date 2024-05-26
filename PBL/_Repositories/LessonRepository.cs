using PBL.Models;
using PBL.Models.Lesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL._Repositories
{
    public class LessonRepository : ILessonRepository
    {
        public void Add(LessonModel lessonModel)
        {
            using (var ctx = new PBLContext())
            {
                ctx.Lessons.Add(new LessonModel
                {
                    Name = lessonModel.Name,
                    PublishDay = lessonModel.PublishDay,
                    Content = lessonModel.Content,
                    Views = lessonModel.Views,
                    Id_Teacher = lessonModel.Id_Teacher
                });
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var ctx = new PBLContext();
            var lesson = ctx.Lessons.Find(id);
            ctx.Lessons.Remove(lesson);
            ctx.SaveChanges();
        }

        public void Edit(LessonModel lessonModel)
        {
            var ctx = new PBLContext();
            var lesson = ctx.Lessons.Find(lessonModel.Id);
            lesson.Name = lessonModel.Name;
            lesson.PublishDay = lessonModel.PublishDay;
            lesson.Content = lessonModel.Content;
            lesson.Id_Teacher = lessonModel.Id_Teacher;
            ctx.SaveChanges();
        }

        public IEnumerable<LessonModel> GetAll()
        {
            return new PBLContext().Lessons.ToList();
        }

        public IEnumerable<LessonModel> GetByValue(string search)
        {
            int LessonId = int.TryParse(search, out _) ? Convert.ToInt32(search) : 0;
            if (LessonId > 0) return new PBLContext().Lessons.Where(p => p.Id == LessonId).ToList();
            else return new PBLContext().Lessons.Where(p => p.Name.Contains(search)).ToList();
        }
    }
}
