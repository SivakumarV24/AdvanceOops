using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    /// <summary>
    /// Interface 
    /// </summary>
    public interface IWallet
    {
        // property
        /// <summary>
        /// Wallet Balance used to Store balance
        /// </summary>
        /// <value></value>
        double WalletBalance { get; } // Read Only
        // Method
        /// <summary>
        /// WalletRecharge Method used to  recharge the wallet of user
        /// </summary>
        /// <param name="amount"></param>
        void WalletRecharge(double amount);
        /// <summary>
        /// DeductBalance method used to Deduct Balance from the Wallet
        /// </summary>
        /// <param name="amount"></param>
        public void DeductBalance(double amount);
        
    }
}