using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaClassLibrary
{
    /// <summary>
    /// UserDetail class inherit the Ibalance interface and PersonalDetails class
    /// </summary>
    public class UserDetails :PersonalDetails,IBalance
    {
        
        //Field
        /// <summary>
        /// static field s_usedID used to autoincreament the userId of the instance <see cref="UserDetails"/>
        /// </summary>
        private static int s_userID=1000;
        /// <summary>
        /// _balance used to store wallet balance of the user
        /// </summary>
        private double _balance;
        //  Property
        /// <summary>
        /// UserID property used to store UserID.
        /// </summary>
        /// <value></value>
        public string UserID { get;} //  Read Only
        /// <summary>
        /// WorkstationNumber property used to store WorkstationNumber
        /// </summary>
        /// <value></value>
        public string WorkStationNumber { get; set; }
        /// <summary>
        /// WalletBalance property used to store walletBalance of user
        /// </summary>
        /// <value></value>
        public double WalletBalance { get{return _balance;} set{_balance=value;} }      
        // constructor
        /// <summary>
        /// User Details constructor used to initialize default values to its Properties. <see cref="UserDetails"/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fatherName"></param>
        /// <param name="gender"></param>
        /// <param name="mobile"></param>
        /// <param name="mailID"></param>
        /// <param name="workStationNumber"></param>
        /// <param name="walletBalance"></param>
        /// <returns></returns>
        public UserDetails(string name,string fatherName,Gender gender,long mobile,string mailID,string workStationNumber,double walletBalance): base(name,fatherName,gender,mobile,mailID)
        {
            // Auto Increamentation
            s_userID++;
            // Assigning values to property
            UserID="SF"+s_userID;
            WorkStationNumber=workStationNumber;
            WalletBalance=walletBalance;
        }
        // Methods
        // WalletRecharge MEthod
        /// <summary>
        /// walletRecharge Mehtod used to Recharge the wallet.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>bool</returns>
        public bool WalletRecharge(double amount)
        {
            WalletBalance+=amount;
            return true;
        }
        // DeductAmount
        /// <summary>
        /// DeductAmount used to reduce the Balance
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>bool</returns>
        public bool DeductAmount(double amount)
        {
            WalletBalance-=amount;
            return true;
        }
    }
}