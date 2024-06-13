using PBL.Models.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL._Repositories
{
    public class TestCommentRepository
    {
        public void Add(TestCommentModel comment)
        {
            using (var ctx = new PBLContext())
            {
                ctx.TestComments.Add(comment);
                ctx.SaveChanges();
            }
        }

        public IEnumerable<TestCommentModel> GetByTest(int TestId)
        {
            return new PBLContext().TestComments.Where(p => p.TestId == TestId).ToList();
        }
    }
}
