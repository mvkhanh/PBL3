using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into teacher (name, birth, email, phone, registday, lessons, tests)" +
                    " values(@name, @birth, @email, @phone, @regist, @lessons, @tests)";
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = teacherModel.Name;
                command.Parameters.Add("@birth", MySqlDbType.Date).Value = teacherModel.Birth;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = teacherModel.Email;
                command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = teacherModel.Phone;
                command.Parameters.Add("@regist", MySqlDbType.Date).Value = teacherModel.RegistDay;
                command.Parameters.Add("@lessons", MySqlDbType.Int32).Value = teacherModel.Lessons;
                command.Parameters.Add("@tests", MySqlDbType.Int32).Value = teacherModel.Tests;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
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
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update teacher set name = @name, birth = @birth, email = @email, phone = @phone where id = @id";
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = teacherModel.Id;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = teacherModel.Name;
                command.Parameters.Add("@birth", MySqlDbType.Date).Value = teacherModel.Birth;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = teacherModel.Email;
                command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = teacherModel.Phone;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<TeacherModel> GetAll()
        {
            var teacherList = new List<TeacherModel>();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from teacher order by id desc";
                using(var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var teacherModel = new TeacherModel();
                        teacherModel.Id = (int)reader[0];
                        teacherModel.Name = reader[1].ToString();
                        teacherModel.Birth = Convert.ToDateTime(reader[2]);
                        teacherModel.Email = reader[3].ToString();
                        teacherModel.Phone = reader[4].ToString();
                        teacherModel.RegistDay = Convert.ToDateTime(reader[5]);
                        teacherModel.Lessons = (int)reader[7];
                        teacherModel.Tests = (int)reader[8];
                        teacherList.Add(teacherModel);
                    }
                }
            }
            return teacherList;
        }

        public IEnumerable<TeacherModel> GetByValue(string search)
        {

            var teacherList = new List<TeacherModel>();
            int teacherId = int.TryParse(search, out _) ? Convert.ToInt32(search) : 0;
            string teacherName = "%" + search + "%", query;
            if(teacherId > 0) query = @"Select * from teacher where id = @id order by id desc";
            else query = @"Select * from teacher where name like @name order by id desc";
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = query;
                command.Parameters.AddWithValue("@name", teacherName);
                command.Parameters.AddWithValue("@id", teacherId);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var teacherModel = new TeacherModel();
                        teacherModel.Id = (int)reader[0];
                        teacherModel.Name = reader[1].ToString();
                        teacherModel.Birth = Convert.ToDateTime(reader[2]);
                        teacherModel.Email = reader[3].ToString();
                        teacherModel.Phone = reader[4].ToString();
                        teacherModel.RegistDay = Convert.ToDateTime(reader[5]);
                        teacherModel.Lessons = (int)reader[7];
                        teacherModel.Tests = (int)reader[8];
                        teacherList.Add(teacherModel);
                    }
                }
            }
            return teacherList;
        }
    }
}
