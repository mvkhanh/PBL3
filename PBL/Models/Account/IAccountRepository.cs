using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models.Account
{
    public interface IAccountRepository
    {
        int GetAccount(string account, string password);
    }
}
