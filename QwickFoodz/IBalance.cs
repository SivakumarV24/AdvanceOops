using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    /// <summary>
    /// Interface IBalance
    /// </summary>
    public interface IBalance
    {
        //property
        /// <summary>
        /// WalletBalance property used to Store WalletBalance.
        /// </summary>
        /// <value></value>
        double WalletBalance{get;}
        // Method
        //Wallet Recarge
        /// <summary>
        /// WalletRecharge Method used to Recharge the UserWallet
        /// </summary>
        /// <param name="amount"></param>
        public void WalletRecharge(double amount);
        //DeductBalance
        /// <summary>
        /// DeductBalance Method used to Reduce the Wallet Balance from the user.
        /// </summary>
        /// <param name="amount"></param>
        public void DeductBalance(double amount);

    }
}