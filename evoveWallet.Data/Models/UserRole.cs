﻿using System;
using System.Collections.Generic;
using System.Text;

namespace evoveWallet.Data.Models
{
    public class UserRole
    {
        public int UserId { get; set; }
        public UserAccount User { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
