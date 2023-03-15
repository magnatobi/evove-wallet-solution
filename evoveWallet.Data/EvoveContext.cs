using System;
using System.Collections.Generic;
using System.Text;

namespace evoveWallet.Data
{
    public class EvoveContext : DbContext
    {
        public EvoveContext(DbContextOptions<EvoveContext> options) : base(options)
        {
            
        }

        public DbSet<UserAccount> UserAccount { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
    }
}
