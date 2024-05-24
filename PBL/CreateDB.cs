using PBL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL
{
    public class CreateDB : DropCreateDatabaseIfModelChanges<PBLContext>
    {
        protected override void Seed(PBLContext context)
        {
            //Giang vien
            context.Teachers.AddRange(new TeacherModel[]
            {
                new TeacherModel {Id = 1, Name = "Mai Van Khanh", Birth = Convert.ToDateTime("10/02/2004"), Email = "mvkhanh100204@gmail.com", Lessons = 0, Tests = 0, RegistDay = DateTime.Now, Phone = "0364441833", Account = "maivankhanh", Password = "Mvkhanh181@"},
                new TeacherModel {Id = 2, Name = "Nguyen Viet Huy", Birth = Convert.ToDateTime("10/02/2004"), Email = "nguyenvietheo2004@gmail.com", Lessons = 0, Tests = 0, RegistDay = DateTime.Now, Phone = "1234567890", Account = "nguyenviethuy", Password = "Nvhuy2004@"}
            });
            //Student
        }
    }
}
