using evoveWallet.Data.Models;
using System;
using System.Collections.Generic;

namespace evoveWallet.Data.Interfaces
{
    public interface IWalletRepository
    {
        bool SaveChanges();

        IEnumerable<Wallet> GetAllWalletAccount();
        Wallet GetWalletById(int id);
        void CreateWallet(Wallet Wallet);
        void FundWallet(Wallet Wallet);
        void ValidateExisitingWalletByCurrency(Currency Currency);
        void UpdateWallet(Wallet Wallet);
        void DeleteWallet(Wallet Wallet);
    }
}
