using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models.Lesson
{
    public interface ILessonRepository
    {   
        void Add(LessonModel lessonModel);
        void Edit(LessonModel lessonModel);
        void Delete(int id);
        IEnumerable<LessonModel> GetAll();
        IEnumerable<LessonModel> GetByValue(string search);
    }
}
