using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models.Comment
{
    public interface ILessonCommentRepository
    {
        void Add(LessonCommentModel comment);
        IEnumerable<LessonCommentModel> GetByLesson(int LessonId);
    }
}
