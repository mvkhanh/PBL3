using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL._Repositories
{
    static public class AccountRepository
    {
        public static bool CheckAccount(string account)
        {
            using(var ctx = new PBLContext())
            {
                if (ctx.Teachers.Where(p => p.Account == account).Any() || ctx.Students.Where(p => p.Account == account).Any()) return true;
                return false;
            }
        }
    }
}
