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
        public virtual DbSet<TeacherModel> Teachers { get; set; }
        public virtual DbSet<AccountModel> Accounts { get; set; }
        
    }

    
}