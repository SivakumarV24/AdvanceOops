using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritanceProgramTwo
{
    public class AccountInfo : PersonalInfo
    {
        // Field
        private static long s_accountNumber=202902903;
        /*AccountNumber, BranchName, IFSCCode, Balance*/
        // property
        public long AccountNumber { get;} // ReadOnly
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public double Balance { get; set; }
        // constructor
        public AccountInfo(string branchName,string iFSCCode,double balance,string name,string fatherName,string phone,string mail,DateTime dob,Gender gender):base(name,fatherName,phone,mail,dob,gender)
        {
            // Auto Increamentation
            s_accountNumber++;
            // Assigning value to property
            AccountNumber=s_accountNumber;
            BranchName=branchName;
            IFSCCode=iFSCCode;
            Balance=balance;
        }
        /*Methods: ShowAccountInfo, Deposit , Withdraw, ShowBalance.*/
        // ShowAccountInfo Mehods
        public void ShowAccountInfo()
        {
            Console.WriteLine($"*********Show Account Info**********");
            Console.WriteLine($"Account Number : {AccountNumber}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Father Name : {FatherName}");
            Console.WriteLine($"Phone Number : {Phone}");
            Console.WriteLine($"Date of Birth :  {DOB}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"BranchName : {BranchName}");
            Console.WriteLine($"IFSCCode : {IFSCCode}");            
            Console.WriteLine($"Account Balance : {Balance}");          
        }
        // Deposit 
        public void Deposit(double amount)
        {
            Balance+=amount;
            Console.WriteLine($"Deposit Successfully");
            
        }
        // Withdraw 
        public void Withdraw(double amount)
        {
            Balance-=amount;
            Console.WriteLine($"Withdraw Successfully");
        }
        // Show Balance
        public void ShowBalance()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"AccountNumber : {AccountNumber}");
            Console.WriteLine($"Account Balance : {Balance}");
            
        }
        
        
        
        
        
        
    }
}