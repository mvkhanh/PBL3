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
            //Teacher
            context.Teachers.AddRange(new TeacherModel[]
            {
                new TeacherModel {Id = 1, Name = "Mai Van Khanh", Birth = Convert.ToDateTime("10/02/2004"), Email = "mvkhanh100204@gmail.com", RegistDay = DateTime.Now, Phone = "0364441833", Account = "maivankhanh", Password = "Mvkhanh181@"},
                new TeacherModel {Id = 2, Name = "Nguyen Viet Huy", Birth = Convert.ToDateTime("10/02/2004"), Email = "nguyenvietheo2004@gmail.com", RegistDay = DateTime.Now, Phone = "1234567890", Account = "nguyenviethuy", Password = "Nvhuy2004@"}
            });
            //Student
            context.Students.AddRange(new StudentModel[]
            {
                new StudentModel {Id = 1, Name = "Nguyen Thanh Tai", Birth = Convert.ToDateTime("1/1/2004"), Email = "an602777@gmail.com", RegistDay = DateTime.Now, Phone = "0987654321", Account = "nguyenthanhtai", Password = "Nthanhtai123*"}
            });
            //Lesson
            context.Lessons.AddRange(new LessonModel[]
            {
                new LessonModel {Id = 1, Name = "Ngu phap TOEIC", Id_Teacher = 1, PublishDay = DateTime.Now, Views = 1000, Content = null}
            });
        }
    }
}
