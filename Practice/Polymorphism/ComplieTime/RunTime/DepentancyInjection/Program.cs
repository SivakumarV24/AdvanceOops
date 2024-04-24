using System;
using System.Collections.Generic;
namespace DepentancyInjection;
class Program{
    public static void Main(string[] args)
    {
        CCAccount cCAccount=new CCAccount()
        {
            AccountNumber=123,
            Name="siva",
            Balance=23456.6
        };
        SBAccount sBAccount=new SBAccount()
        {
            AccountNumber=456,
            Name="Kumar",
            Balance=4334.4
        };
        List<CCAccount> ccList=new List<CCAccount>();
        List<SBAccount> sbList=new List<SBAccount>();
        ccList.Add(cCAccount);
        sbList.Add(sBAccount);
        List<IAccount> list=new List<IAccount>();
        list.Add(cCAccount);
        list.Add(sBAccount);
    }
}