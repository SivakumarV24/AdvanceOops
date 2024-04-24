using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    /// <summary>
    /// UserDetails class used to create a instance <see cref="UserDetails"/>
    /// </summary>
    public class UserDetails: PersonalDetails,IWallet
    {
        // Field
        /// <summary>
        /// private field _balance used to store WallentBalance.
        /// </summary>
        private double _balance;
        /// <summary>
        /// static field s_userID used to autoincreamentation for userID
        /// </summary>
        private static int s_userID=1000;
        // Property
        /// <summary>
        /// UserId used to Store UserID
        /// </summary>
        /// <value></value>
        public string UserID { get; } // ReadOnly
        /// <summary>
        /// WalletBalance is used to store userWalletBalance
        /// </summary>
        /// <value></value>
        public double WalletBalance { get{return _balance;} }
        // constructor
        /// <summary>
        /// userDetails is used to assign a default value for property
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="city"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="balance"></param>
        /// <returns></returns>
        public UserDetails(string name, int age, string city, string phoneNumber,double balance):base(name,age,city,phoneNumber)
        {
            // Auto increamentation
            s_userID++;
            // Assigning value to property
            UserID="UID"+s_userID;
            _balance = balance;
        }
        /// <summary>
        /// UserDetails Constrcutor used to asssign a value to the property.
        /// </summary>
        /// <param name="user"></param>
        public UserDetails(string user)
        {
            string[] value=user.Split(",");
            // Assigning value to property
            s_userID=int.Parse(value[0].Remove(0,3));
            UserID=value[0];
            Name=value[1];
            Age=int.Parse(value[2]);
            City=value[3];
            PhoneNumber=value[4];
            _balance = double.Parse(value[5]);
        }
        // Method
        //WalletBalance
        /// <summary>
        /// Walletrecharge method used to Recharge WalletBalance. 
        /// </summary>
        /// <param name="amount"></param>
        public void WalletRecharge(double amount)
        {
            _balance+=amount;
        }
        // Deduct balance
        /// <summary>
        /// Deduct Balance Method used to Deduct the amount from WalletBalance
        /// </summary>
        /// <param name="amount"></param>
        public void DeductBalance(double amount)
        {
            _balance-=amount;
        }
        
        
        
        


    }
}