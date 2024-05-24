using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.Models;

namespace PBL._Repositories
{
    public class TeacherRepository : BaseRepository, ITeacherRepository
    {
        public void Add(TeacherModel teacherModel)
        {
            using (var ctx = new PBLContext())
            {
                ctx.Teachers.Add(new TeacherModel {
                    Name = teacherModel.Name,
                    Email = teacherModel.Email,
                    Birth = teacherModel.Birth,
                    Phone = teacherModel.Phone,
                    Lessons = teacherModel.Lessons,
                    Tests = teacherModel.Tests,
                    RegistDay = teacherModel.RegistDay,
                    Account = teacherModel.Account,
                    Password = teacherModel.Password
                });
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var ctx = new PBLContext();
            var teacher = ctx.Teachers.Find(id);
            ctx.Teachers.Remove(teacher);
            ctx.SaveChanges();
        }

        public void Edit(TeacherModel teacherModel)
        {
            using (var ctx = new PBLContext())
            {
                var teacher = ctx.Teachers.Find(teacherModel.Id);
                teacher.Phone = teacherModel.Phone;
                teacher.Name = teacherModel.Name;
                teacher.Birth = teacherModel.Birth;
                teacher.Email = teacherModel.Email;
                teacher.Account = teacherModel.Account;
                teacher.Password = teacherModel.Password;
                ctx.SaveChanges();
            }
        }

        public IEnumerable<TeacherModel> GetAll()
        {
            return new PBLContext().Teachers.ToList();
        }

        public IEnumerable<TeacherModel> GetByValue(string search)
        {
            int teacherId = int.TryParse(search, out _) ? Convert.ToInt32(search) : 0;
            if (teacherId > 0) return new PBLContext().Teachers.Where(p => p.Id == teacherId).ToList();
            else return new PBLContext().Teachers.Where(p => p.Name.Contains(search)).ToList();
        }
    }
}
