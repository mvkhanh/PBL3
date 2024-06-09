using PBL.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace PBL
{
    public class PBLContext : DbContext
    {
        public PBLContext()
            : base("name=TM")
        {
            Database.SetInitializer<PBLContext>(new CreateDB());
        }
        public virtual DbSet<AccountModel> Accounts { get; set; }
        public virtual DbSet<StudentModel> Students { get; set; }
        public virtual DbSet<TeacherModel> Teachers { get; set; }
        public virtual DbSet<LessonModel> Lessons { get; set; }
        public virtual DbSet<TestModel> Tests { get; set; }
        public virtual DbSet<QuestionModel> Questions { get; set; }
        public virtual DbSet<AnswerModel> Answers { get; set; }
        
    }

    
}