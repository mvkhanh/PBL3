using PBL.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL._Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public int GetAccount(string account, string password)
        {
            var accountModel = new PBLContext().Accounts.Where(p => p.Account ==  account && p.Password == password).FirstOrDefault();
            if (accountModel == null) return -1;
            return accountModel.Id;
        }
    }
}
