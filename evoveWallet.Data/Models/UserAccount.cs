using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using evoveWallet.Data.Models;

namespace evoveWallet.Data
{
    public class UserAccount
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string ProfilePictureUrl { get; set; }
        public bool isActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdated { get; set; }


        // Navigation properties
        public List<Wallet> Wallets { get; set; }
        public List<Transaction> Transactions { get; set; }

    }
}
