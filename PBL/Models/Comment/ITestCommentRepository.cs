using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models.Comment
{
    public interface ITestCommentRepository
    {
        void Add(TestCommentModel comment);
        IEnumerable<TestCommentModel> GetByLesson(int testId);
    }
}
