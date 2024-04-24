using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HybridProgramTwo
{
    //enum
    public class SavingAccount:IDInfo,ICalculate,IBankInfo
    {       
        //field
        private static int s_accountNumber=1000;
       //property
       public string AccountNumber { get;}
       public string AccountType { get; set; }
       public string BankName { get; set; }
       public string IFSC { get; set; }
       public string Branch { get; set; } 
       public double Balance { get; set; }
       
        

    // constructor
        public SavingAccount(string accountType,string bankName,string iFSC,string branch,double balance,string voterID,string aadharID,string panNumber,string name, string fatherName, DateTime dob, string phone, Gender gender, string mobile):base(name,aadharID,panNumber,name,fatherName,dob,phone,gender,mobile)
        {
            //Auto increamentation
            s_accountNumber++;
            //Assigning value to property
            AccountNumber="AID"+s_accountNumber;
            AccountType=accountType;
            BankName=bankName;
            IFSC=iFSC;
            Branch=branch;
            Balance=balance;
        }
        // Methods
        public void Deposit()
        {
            Console.WriteLine($"Enter the Amount to Deposit : ");
            double amount=double.Parse(Console.ReadLine());            
            Balance+=amount;
        }
        public void Withdraw()
        {
            Console.WriteLine($"Enter the Amount to Withdraw : ");
            double amount=double.Parse(Console.ReadLine()); 
            Balance-=amount;
        }
        public void BalanceCheck()
        {
            Console.WriteLine($"Balance : {Balance}");
            
        }
    }
}