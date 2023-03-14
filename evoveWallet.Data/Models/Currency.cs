using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace evoveWallet.Data.Models
{
    public class Currency
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }

        // Navigation properties
        public List<Wallet> Wallets { get; set; }
    }
}
