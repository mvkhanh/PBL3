using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models.StudentTest
{
    public interface IStudentTestRepository
    {
        void Add(StudentTestModel studentTestModel);
        void Delete(int studentId, int testId);
        IEnumerable<StudentTestModel> GetByTest(int testId);
        IEnumerable<StudentTestModel> GetByStudent(int studentId);
        StudentTestModel GetInfo(int studentId, int testId);
    }
}
