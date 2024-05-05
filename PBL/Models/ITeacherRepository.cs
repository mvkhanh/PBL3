using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models
{
    public interface ITeacherRepository
    {
        void Add(TeacherModel teacherModel);
        void Edit(TeacherModel teacherModel);
        void Delete(int id);
        IEnumerable<TeacherModel> GetAll();
        IEnumerable<TeacherModel> GetByValue(string search);
    }
}
