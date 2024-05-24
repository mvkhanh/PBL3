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
    public class StudentRepository : BaseRepository, IStudentRepository
    {
        public void Add(StudentModel StudentModel)
        {
            using (var ctx = new PBLContext())
            {
                ctx.Students.Add(new StudentModel
                {
                    Name = StudentModel.Name,
                    Email = StudentModel.Email,
                    Birth = StudentModel.Birth,
                    Phone = StudentModel.Phone,
                    RegistDay = StudentModel.RegistDay
                });
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var ctx = new PBLContext();
            var Student = ctx.Students.Find(id);
            ctx.Students.Remove(Student);
            ctx.SaveChanges();
        }

        public void Edit(StudentModel StudentModel)
        {
            var ctx = new PBLContext();
            var Student = ctx.Students.Find(StudentModel.Id);
            Student.Phone = StudentModel.Phone;
            Student.Name = StudentModel.Name;
            Student.Birth = StudentModel.Birth;
            Student.Email = StudentModel.Email;
            ctx.SaveChanges();
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
