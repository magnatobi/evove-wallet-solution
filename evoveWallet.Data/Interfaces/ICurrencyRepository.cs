using evoveWallet.Data.Models;
using System;
using System.Collections.Generic;

namespace evoveWallet.Data.Interfaces
{
    public interface ICurrencyRepository
    {
        bool SaveChanges();

        IEnumerable<Currency> GetAllCurrencies();
        Currency GetCurrencyById(int id);
        void AddNewCurrency(Currency Currency);
        void UpdateCurrency(Currency Currency);
        void DeleteCurrency(Currency Currency);
    }
}
