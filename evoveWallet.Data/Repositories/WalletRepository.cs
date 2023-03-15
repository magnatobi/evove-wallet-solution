using evoveWallet.Data.Interfaces;
using evoveWallet.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace evoveWallet.Data.Repositories
{
    public class WalletRepository : IWalletRepository
    {
        public void CreateWallet(Wallet Wallet)
        {
            throw new NotImplementedException();
        }

        public void DeleteWallet(Wallet Wallet)
        {
            throw new NotImplementedException();
        }

        public void FundWallet(Wallet Wallet)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Wallet> GetAllWalletAccount()
        {
            throw new NotImplementedException();
        }

        public Wallet GetWalletById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateWallet(Wallet Wallet)
        {
            throw new NotImplementedException();
        }

        public void ValidateExisitingWalletByCurrency(Currency Currency)
        {
            throw new NotImplementedException();
        }
    }
}
