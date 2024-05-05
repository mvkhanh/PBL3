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
        void Deleete(int id);
        IEnumerable<TeacherModel> GetAll();
        IEnumerable<TeacherModel> GetByValue();
    }
}
