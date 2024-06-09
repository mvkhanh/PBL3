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
    public class StudentRepository : IStudentRepository
    {
        public void Add(StudentModel studentModel)
        {
            using (var ctx = new PBLContext())
            {
                if (ctx.Accounts.Where(p => p.Account.Equals(studentModel.Account.Account)).ToList().Count != 0) throw new Exception("Account exist");
                ctx.Students.Add(studentModel);
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var ctx = new PBLContext())
            {
                var student = ctx.Students.Find(id);
                var account = ctx.Accounts.Where(p => p.Id == student.Id_Account).FirstOrDefault();
                ctx.Accounts.Remove(account);
                ctx.SaveChanges();
            }
        }

        public void Edit(StudentModel studentModel)
        {
            using (var ctx = new PBLContext())
            {
                var student = ctx.Students.Find(studentModel.Id);
                student.Phone = studentModel.Phone;
                student.Name = studentModel.Name;
                student.Birth = studentModel.Birth;
                student.Email = studentModel.Email;
                student.Account.Password = studentModel.Account.Password;
                ctx.SaveChanges();
            }
        }

        public IEnumerable<StudentModel> GetAll()
        {
            return new PBLContext().Students.ToList();
        }

        public IEnumerable<StudentModel> GetByValue(string search)
        {
            int StudentId = int.TryParse(search, out _) ? Convert.ToInt32(search) : 0;
            if (StudentId > 0) return new PBLContext().Students.Where(p => p.Id == StudentId).ToList();
            else return new PBLContext().Students.Where(p => p.Name.Contains(search)).ToList();
        }

        public int GetByAccount(int id_Account)
        {
            var studentModel = new PBLContext().Students.Where(p => p.Id_Account == (int)id_Account).FirstOrDefault();
            if (studentModel == null) return -1;
            return studentModel.Id;
        }
    }
}
