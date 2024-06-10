using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models
{
    public interface IStudentRepository
    {
        void Add(StudentModel studentModel);
        void Edit(StudentModel studentModel);
        void Delete(int id);
        IEnumerable<StudentModel> GetAll();
        IEnumerable<StudentModel> GetByValue(string value);
        int GetByAccount(string account, string password);
    }
}
