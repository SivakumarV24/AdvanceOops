using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    /// <summary>
    /// CustomerDetails class used to create a insatnce for user <see cref="CustomerDetails"/>
    /// </summary>

    public class CustomerDetails: PersonalDetails,IBalance
    {
        //Field
        /// <summary>
        /// Filed _balance used to stroe the walletBalance of user
        /// </summary>
        private double _balance;
        /// <summary>
        /// sataic field s_customerID is used to auto increament the CustomerID
        /// </summary>
        private static int s_customerID=1000;
        //property
        /// <summary>
        /// CustomerID used to store the CustomerID
        /// </summary>
        /// <value></value>
        public string CustomerID { get; } // Read Only
        /// <summary>
        /// Wallet Balance usedd to store Wallet Balance of user.
        /// </summary>
        /// <value></value>
        public double WalletBalance { get{return _balance;} }
        // constructor
        /// <summary>
        /// CustomerDetails constructor used to Assign the Default value to the property
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fatherName"></param>
        /// <param name="gender"></param>
        /// <param name="mobile"></param>
        /// <param name="dOB"></param>
        /// <param name="mailID"></param>
        /// <param name="location"></param>
        /// <param name="balance"></param>
        /// <returns></returns>
        public CustomerDetails(string name, string fatherName, Gender gender, string mobile, DateTime dOB, string mailID, string location, double balance):base(name,fatherName,gender,mobile,dOB,mailID,location)
        {
            //Auto increamentation
            s_customerID++;
            //Assigning value to property
            CustomerID ="CID"+s_customerID;
            _balance = balance;
        }
        /// <summary>
        /// CustomerDetails constructor used to Assign the Default value to the property
        /// </summary>
        /// <param name="customer"></param>
        public CustomerDetails(string customer)
        {
            string[] value=customer.Split(",");
            s_customerID=int.Parse(value[0].Remove(0,3));
            //Assigning value to property
            CustomerID =value[0];
            Name=value[1];
            FatherName=value[2];
            Gender=Enum.Parse<Gender>(value[3],true);
            DOB=DateTime.ParseExact(value[4],"dd/MM/yyyy",null);
            MailID=value[5];
            Location=value[6];
            _balance = int.Parse(value[7]);
        }
        // Method
        // Wallet Rechagre
        /// <summary>
        /// WalletRecharge used to recharge balance of the user
        /// </summary>
        /// <param name="amount"></param>
        public void WalletRecharge(double amount)
        {
            _balance+=amount;
        }
        // DeductBalance
        /// <summary>
        /// DeductBalance used to reduce the Balance of the user
        /// </summary>
        /// <param name="amount"></param>
        public void DeductBalance(double amount)
        {
            _balance-=amount;
        }

    }
}