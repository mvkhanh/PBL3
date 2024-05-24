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
        public TeacherRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(TeacherModel teacherModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into teacher (name, birth, email, phone, registday, lessons, tests)" +
                    " values(@name, @birth, @email, @phone, @regist, @lessons, @tests)";
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = teacherModel.Name;
                command.Parameters.Add("@birth", SqlDbType.Date).Value = teacherModel.Birth;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = teacherModel.Email;
                command.Parameters.Add("@phone", SqlDbType.VarChar).Value = teacherModel.Phone;
                command.Parameters.Add("@regist", SqlDbType.Date).Value = teacherModel.RegistDay;
                command.Parameters.Add("@lessons", SqlDbType.Int).Value = teacherModel.Lessons;
                command.Parameters.Add("@tests", SqlDbType.Int).Value = teacherModel.Tests;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from teacher where id = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        public void Edit(TeacherModel teacherModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update teacher set name = @name, birth = @birth, email = @email, phone = @phone where id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = teacherModel.Id;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = teacherModel.Name;
                command.Parameters.Add("@birth", SqlDbType.Date).Value = teacherModel.Birth;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = teacherModel.Email;
                command.Parameters.Add("@phone", SqlDbType.VarChar).Value = teacherModel.Phone;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<TeacherModel> GetAll()
        {
            var teacherList = new PBLContext().Teachers.ToList();
            return teacherList;
        }

        public IEnumerable<TeacherModel> GetByValue(string search)
        {

            var teacherList = new List<TeacherModel>();
            //int teacherId = int.TryParse(search, out _) ? Convert.ToInt32(search) : 0;
            //string teacherName = "%" + search + "%";
            //if(teacherId > 0) query = @"Select * from teacher where id = @id order by id desc";
            //else query = @"Select * from teacher where name like @name order by id desc";
            return teacherList;
        }
    }
}
