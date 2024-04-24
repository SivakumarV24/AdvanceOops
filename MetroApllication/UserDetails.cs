using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroApllication
{
    /// <summary>
    /// UserDetails used to create a instance of user <see cref="UserDetails"/>
    /// </summary>
    public class UserDetails:PersonalDetails,IBalance
    {
        /*Properties:
        •	CardNumber(Auto generation- CMRL1001)
        •	Balance
        Methods:
        •	WalletRecharge
        •	DeductBalance
        */
        //Field
        /// <summary>
        /// Static field cardnumber is used to autoincreament the cardNumber
        /// </summary>
        private static int s_cardNumber=1000;
        //Property
        /// <summary>
        /// CardNumber is used to store CardNumber
        /// </summary>
        /// <value></value>
        public string CardNumber { get; set; }
        /// <summary>
        /// Balance is used to store Balance 
        /// </summary>
        /// <value></value>
        public double Balance { get; set; }
        //constructor
        /// <summary>
        ///  UserDetails Constructor used to assign default value of the property <see cref="UserDetails"/>
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="userName"></param>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public UserDetails(double balance,string userName, long phoneNumber):base(userName,phoneNumber)
        {
            //Auto increamentation
            s_cardNumber++;
            // Assigning vaule to property
            CardNumber = "CMRL"+s_cardNumber;
            Balance = balance;
        }
        /// <summary>
        /// UserDetails constructor used to read the values from the file.
        /// </summary>
        /// <param name="user"></param>
        public UserDetails(string user)
        {
            string[] value=user.Split(",");
            s_cardNumber=int.Parse(value[0].Remove(0,4));
            CardNumber = value[0];
            UserName=value[1];
            PhoneNumber=long.Parse(value[2]);
            Balance = double.Parse(value[3]);
        }
        //Mehthods
        //WalletRecharge
        /// <summary>
        /// WalletRecharge method used to Recharge the user wallet <see cref="UserDetails"/>
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>bool</returns>
        public bool WalletRecharge(double amount)
        {
            Balance+=amount;
            return true;
        }
        // DeductBalance
        /// <summary>
        /// DeductBalance method used to reduce the userbalance <see cref="UserDetails"/>
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>bool</returns>
        public bool DeductBalance(double amount)
        {
            Balance-=amount;
            return true;
        }
    }
}