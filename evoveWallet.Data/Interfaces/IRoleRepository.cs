using evoveWallet.Data.Models;
using System;
using System.Collections.Generic;

namespace evoveWallet.Data.Interfaces
{
    public interface IRoleRepository
    {
        bool SaveChanges();

        IEnumerable<Role> GetAllRoles();
        Role GetRoleById(int id);
        void CreateRole(Role role);
        void UpdateRole(Role role);
        void DeleteRole(Role role);
    }
}
