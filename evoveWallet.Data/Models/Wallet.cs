using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace evoveWallet.Data.Models
{
    public class Wallet
    {
        public int Id { get; set; }
        [Required]
        public string CurrencyCode { get; set; }
        [Required]
        public decimal Balance { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdated { get; set; }

        // Navigation properties
        public int UserId { get; set; }
        public UserAccount User { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
