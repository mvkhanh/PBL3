using PBL.Models;
using PBL.Models.StudentLesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL._Repositories
{
    public class StudentLessonRepository : IStudentLessonRepository
    {
        public void Add(int studentId, int lessonId)
        {
            using(var ctx = new PBLContext())
            {
                ctx.StudentLessons.Add(new StudentLessonModel
                {
                    StudentId = studentId,
                    LessonId = lessonId
                });
                ctx.SaveChanges();
            }
        }

        public void Delete(int studentId, int LessonId)
        {
            using(var ctx = new PBLContext())
            {
                var studentLesson = ctx.StudentLessons.Find(studentId, LessonId);
                ctx.StudentLessons.Remove(studentLesson);
                ctx.SaveChanges() ;
            }
        }

        public IEnumerable<int> GetByLesson(int lessonId)
        {
            return new PBLContext().StudentLessons.Where(p => p.LessonId == lessonId).Select(p => p.StudentId).ToList();
        }

        public IEnumerable<int> GetByStudent(int studentId)
        {
            return new PBLContext().StudentLessons.Where(p => p.StudentId == studentId).Select(p => p.LessonId).ToList();
        }
    }
}
