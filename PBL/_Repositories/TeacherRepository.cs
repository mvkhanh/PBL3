using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.Models;

namespace PBL._Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        public void Add(TeacherModel teacherModel)
        {
            using (var ctx = new PBLContext())
            {
                if (ctx.Accounts.Where(p => p.Account.Equals(teacherModel.Account.Account)).ToList().Count != 0) throw new Exception("Account exist");
                ctx.Teachers.Add(teacherModel);
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var ctx = new PBLContext())
            {
                var teacher = ctx.Teachers.Find(id);
                var account = ctx.Accounts.Where(p => p.Id == teacher.Id_Account).FirstOrDefault();
                ctx.Accounts.Remove(account);
                ctx.SaveChanges();
            }
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
                teacher.Account.Password = teacherModel.Account.Password;
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

        public int GetByAccount(int id_Account)
        {
            var teacherModel = new PBLContext().Teachers.Where(p => p.Id_Account == (int)id_Account).FirstOrDefault();
            if (teacherModel == null) return -1;
            return teacherModel.Id;
        }
    }
}
