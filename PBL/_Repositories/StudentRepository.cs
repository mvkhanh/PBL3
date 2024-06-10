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
                if (AccountRepository.CheckAccount(studentModel.Account)) throw new Exception("Account exist");
                ctx.Students.Add(studentModel);
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var ctx = new PBLContext())
            {
                var student = ctx.Students.Find(id);
                ctx.Students.Remove(student);
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
                student.Password = studentModel.Password;
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

        public int GetByAccount(string account, string password)
        {
            var studentModel = new PBLContext().Students.Where(p => p.Account == account && p.Password == password).FirstOrDefault();
            if (studentModel == null) return -1;
            return studentModel.Id;
        }
    }
}
