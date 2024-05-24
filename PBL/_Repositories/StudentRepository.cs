using PBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PBL._Repositories
{
    public class StudentRepository : BaseRepository, IStudentRepository
    {
        //Constructor
        public StudentRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        //Methods
        public void Add(StudentModel studentModel)
        {
            using(var connection = new SqlConnection(connectionString))
            using(var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into student (name, birth, email, phone, registday) " +
                    "values(@name, @birth, @email, @phone, @registday)";
                command.Parameters.AddWithValue("@name", studentModel.Name);
                command.Parameters.AddWithValue("@birth", studentModel.Birth);
                command.Parameters.AddWithValue("@email", studentModel.Email);
                command.Parameters.AddWithValue("@phone", studentModel.Phone);
                command.Parameters.AddWithValue("@registday", studentModel.RegistDay);
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
                command.CommandText = "delete from student where id = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        public void Edit(StudentModel studentModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "update student set name = @name, birth = @birth, phone = @phone, email = @email where id = @id";
                command.Parameters.AddWithValue("@id", studentModel.Id);
                command.Parameters.AddWithValue("@name", studentModel.Name);
                command.Parameters.AddWithValue("@birth", studentModel.Birth);
                command.Parameters.AddWithValue("@email", studentModel.Email);
                command.Parameters.AddWithValue("@phone", studentModel.Phone);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<StudentModel> GetAll()
        {
            var studentList = new List<StudentModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from student order by id desc";
                using(var reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        var studentModel = new StudentModel
                        {
                            Id = (int)reader[0],
                            Name = reader[1].ToString(),
                            Birth = Convert.ToDateTime(reader[2]),
                            Email = reader[3].ToString(),
                            Phone = reader[4].ToString(),
                            RegistDay = Convert.ToDateTime(reader[5])
                        };
                        studentList.Add(studentModel);
                    }
                }
                return studentList;
            }
        }

        public IEnumerable<StudentModel> GetByValue(string value)
        {
            var studentList = new List<StudentModel>();
            int studentId = int.TryParse(value, out _) ? int.Parse(value) : 0;
            string query, studentName = "%" + value + "%";
            if (studentId != 0) query = @"select * from student where id = @id order by id desc";
            else query = @"select * from student where name like @name order by id desc";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = query;
                command.Parameters.AddWithValue("@id", studentId);
                command.Parameters.AddWithValue("@name", studentName);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var studentModel = new StudentModel
                        {
                            Id = (int)reader[0],
                            Name = reader[1].ToString(),
                            Birth = Convert.ToDateTime(reader[2]),
                            Email = reader[3].ToString(),
                            Phone = reader[4].ToString(),
                            RegistDay = Convert.ToDateTime(reader[5])
                        };
                        studentList.Add(studentModel);
                    }
                }
                return studentList;
            }
        }
    }
}
