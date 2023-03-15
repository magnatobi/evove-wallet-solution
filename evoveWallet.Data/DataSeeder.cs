using evoveWallet.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace evoveWallet.Data
{
    public class DataSeeder
    {
        private readonly EvoveContext _context;

        public DataSeeder(EvoveContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Currencies.Any())
            {
                var addCurrency = new List<Currency>()
                {
                    new Currency() { Code = "NGN", Name = "NAIRA", LogoUrl = "http://facebook.com/" },
                    new Currency() { Code = "USD", Name = "DOLLAR", LogoUrl = "http://facebook.com/" },
                    new Currency() { Code = "EUR", Name = "EURO", LogoUrl = "http://facebook.com/" },
                    new Currency() { Code = "GBP", Name = "POUNDS", LogoUrl = "http://facebook.com/" }
                };

                _context.Currencies.AddRange(addCurrency);
                _context.SaveChanges();
            }
        }
    }
}
