using System;
namespace SingleInheritanceProgramTwo;
class Program{
    public static void Main(string[] args)
    {
        // create a object for Account
        AccountInfo accountInfo=new AccountInfo("Chennai","HDFC2001",2000,"sivakumar","Vairamuthu","9080745399","siva@gmail.com",new DateTime(2001,12,24),Gender.Male);
        AccountInfo accountInfo1=new AccountInfo("Chennai","HDFC2001",2300,"Kumar","Siva","9953425367","Kumar@gmail.com",new DateTime(2001,10,05),Gender.Male);
        AccountInfo accountInfo2=new AccountInfo("Chennai","HDFC2001",2500,"Surya","Kumar","98756474483","Surya@gmail.com",new DateTime(2001,5,21),Gender.Male);
        
        Console.WriteLine($"******CUSTOMER dETAILS 1********");
        accountInfo.ShowAccountInfo();
        Console.WriteLine($"******CUSTOMER dETAILS 2********");
        accountInfo1.ShowAccountInfo();
        Console.WriteLine($"******CUSTOMER dETAILS 3********");
        accountInfo2.ShowAccountInfo();
        accountInfo.Withdraw(500);
        accountInfo.Deposit(20000);
        accountInfo.ShowBalance();
    }
}
