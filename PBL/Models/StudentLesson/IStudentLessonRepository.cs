using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models.StudentLesson
{
    public interface IStudentLessonRepository
    {
        void Add(int studentId, int lessonId);
        void Delete(int studentId, int lessonId);
        IEnumerable<int> GetByLesson(int lessonId);
        IEnumerable<int> GetByStudent(int studentId);
    }
}
