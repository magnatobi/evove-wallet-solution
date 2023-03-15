using evoveWallet.Data.Models;
using System;
using System.Collections.Generic;

namespace evoveWallet.Data.Interfaces
{
    public interface IUserRoleRepository
    {
        bool SaveChanges();

        IEnumerable<UserRole> GetAllUsersRole();
        UserRole GetUserRoleById(int id);
        void AddNewUserRole(UserRole UserRole);
        void ChangeUserRole(UserRole UserRole);
        void RemoveUserRole(UserRole UserRole);
    }
}
