using System.Collections.Generic;
using evoveWallet.Data.Models;

namespace evoveWallet.Data.Interfaces
{
    public interface IUserAccountRepository
    {
        bool SaveChanges();

        IEnumerable<UserAccount> GetAllUsersAccount();
        UserAccount GetUserAccountById(int id);
        void CreateUserAccount(UserAccount userAccount);
        void UpdateUserAccount(UserAccount userAccount);
        void DeleteUserAccount(UserAccount userAccount);
                
    }
}
