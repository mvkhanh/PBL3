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
            //Account
            context.Accounts.AddRange(new AccountModel[]
            {
                new AccountModel{Id = 1, Account = "mvkhanh", Password = "Khanh181@"},
                new AccountModel{Id = 2, Account = "ngvhuy", Password = "Khanh181@"},
                new AccountModel{Id = 3, Account = "nttking", Password = "Khanh181@"}
            });
            //Teacher
            context.Teachers.AddRange(new TeacherModel[]
            {
                new TeacherModel {Id = 1, Name = "Mai Van Khanh", Birth = Convert.ToDateTime("10/02/2004").Date, Email = "mvkhanh100204@gmail.com", RegistDay = DateTime.Now.Date, Phone = "0364441833", Id_Account = 1},
                new TeacherModel {Id = 2, Name = "Nguyen Viet Huy", Birth = Convert.ToDateTime("10/02/2004").Date, Email = "nguyenvietheo2004@gmail.com", RegistDay = DateTime.Now.Date, Phone = "1234567890", Id_Account = 2}
            });
            //Student
            context.Students.AddRange(new StudentModel[]
            {
                new StudentModel {Id = 1, Name = "Nguyen Thanh Tai", Birth = Convert.ToDateTime("1/1/2004").Date, Email = "an602777@gmail.com", RegistDay = DateTime.Now.Date, Phone = "0987654321", Id_Account = 3}
            });
        }
    }
}
