using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(TeacherModel teacherModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TeacherModel> GetAll()
        {
            var teacherList = new List<TeacherModel>();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from giangvien order by id desc";
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
            string teacherName = search, query;
            if(teacherId > 0) query = "Select * from giangvien where id = @id order by id desc";
            else query = "Select * from giangvien where ten like '%' + @name + '%' order by id desc";
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
