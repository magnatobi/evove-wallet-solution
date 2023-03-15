using System;

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
