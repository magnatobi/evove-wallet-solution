using System;
using System.Collections.Generic;
using System.Linq;
using evoveWallet.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace evoveWallet.Data.Repositories
{
    public class UserAccountRepository : IUserAccountRepository
    {
        private readonly EvoveContext _context; 
        public UserAccountRepository(EvoveContext context)
        {
            _context = context;
        }

        public void CreateUserAccount(UserAccount userAccount)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteUserAccount(UserAccount userAccount)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UserAccount> GetAllUsersAccount()
        {
            return _context.UserAccounts.ToList();
        }

        public UserAccount GetUserAccountById(Guid id)
        {
            return _context.UserAccounts.FirstOrDefault(user => user.Id == id);
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateUserAccount(UserAccount userAccount)
        {
            throw new System.NotImplementedException();
        }
    }
}
