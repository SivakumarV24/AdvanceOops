using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaClassLibrary
{
    /// <summary>
    /// IBalance interface used to hiding the details
    /// </summary>
    public interface IBalance
    {
        // Property
        /// <summary>
        /// WalletBalance property used to walletBalance
        /// </summary>
        /// <value></value>
        double WalletBalance { get; set; }
        // Method
        /// <summary>
        /// WalletRecharge Method Decalration only
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>bool</returns>
        public bool WalletRecharge(double amount);
        /// <summary>
        /// DeductAmount method declaration only
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>bool</returns>
        public bool DeductAmount(double amount);     
        
    }
}