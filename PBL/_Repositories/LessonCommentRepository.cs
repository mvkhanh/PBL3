using PBL.Models.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL._Repositories
{
    public class LessonCommentRepository : ILessonCommentRepository
    {
        public void Add(LessonCommentModel comment)
        {
            using (var ctx = new PBLContext())
            {
                ctx.LessonComments.Add(comment);
                ctx.SaveChanges();
            }
        }

        public IEnumerable<LessonCommentModel> GetByLesson(int LessonId)
        {
            return new PBLContext().LessonComments.Where(p => p.LessonId == LessonId).ToList();
        }
    }
}
