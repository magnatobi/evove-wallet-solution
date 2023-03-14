using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace evoveWallet.Data.Models
{
    public class Transaction
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int WalletId { get; set; }
        public decimal Amount { get; set; }
        public Currency CurrencyType { get; set; }
        // public enum ActionType { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
