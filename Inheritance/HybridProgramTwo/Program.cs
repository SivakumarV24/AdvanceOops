using System;
namespace HybridProgramTwo;
class Program{
    public static void Main(string[] args)
    {
        SavingAccount savingAccount=new SavingAccount("Saving","SBI","SBI1001","Chennai",20000,"SMWED4459","12394940403","ASDJ3458O","sivakumar","Vairamuthu",new DateTime(2001,12,24),"9080745399",Gender.Male,"9488948766");
        savingAccount.BalanceCheck();
        savingAccount.Deposit();
        savingAccount.BalanceCheck();
        savingAccount.Withdraw();
        savingAccount.BalanceCheck();

    }
}
