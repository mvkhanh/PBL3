using PBL.Models.StudentTest;
using PBL.Views.Student.StudentTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL._Repositories
{
    public class StudentTestRepository : IStudentTestRepository
    {
        public void Add(StudentTestModel studentTestModel)
        {
            using(var ctx = new PBLContext())
            {
                ctx.StudentTests.Add(studentTestModel);
                ctx.SaveChanges();
            }
        }

        public void Delete(int studentId, int testId)
        {
            using(var ctx = new PBLContext())
            {
                var studentTest = ctx.StudentTests.Find(studentId, testId);
                ctx.StudentTests.Remove(studentTest);
                ctx.SaveChanges();
            }
        }

        public IEnumerable<StudentTestModel> GetByStudent(int studentId)
        {
            return new PBLContext().StudentTests.Where(p => p.StudentId == studentId).ToList();
        }

        public IEnumerable<StudentTestModel> GetByTest(int testId)
        {
            return new PBLContext().StudentTests.Where(p => p.TestId == testId).ToList();
        }

        public StudentTestModel GetInfo(int studentId, int testId)
        {
            return new PBLContext().StudentTests.Find(studentId, testId);
        }
    }
}
