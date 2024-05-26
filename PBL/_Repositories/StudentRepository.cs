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
    public class StudentRepository : IStudentRepository
    {
        public void Add(StudentModel studentModel)
        {
            using (var ctx = new PBLContext())
            {
                ctx.Students.Add(new StudentModel
                {
                    Name = studentModel.Name,
                    Email = studentModel.Email,
                    Birth = studentModel.Birth,
                    Phone = studentModel.Phone,
                    RegistDay = studentModel.RegistDay,
                    Account = studentModel.Account,
                    Password = studentModel.Password
                });
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
                student.Account = studentModel.Account;
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
    }
}
