using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroApllication
{
    /// <summary>
    /// Interface IBalnce used to store the balance property and walletRecharge,DeductBalance Method <see cref="IBalance"/>
    /// </summary>
    public interface IBalance
    {
        // property
        /// <summary>
        /// Balance property is used to Balance.
        /// </summary>
        /// <value></value>
        double Balance { get; set; }
        //Method Declaration
        // Wallet Recharge
        public bool WalletRecharge(double amount);
        // DeductBalance 
        public bool DeductBalance(double amount);
    }
}