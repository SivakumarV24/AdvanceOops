using System;
namespace ProgramSix;
class Program{
    public static void Main(string[] args)
    {
        // create a object for  SBI and Call GEtIntereztInfo method
        SBI sBI=new SBI();
        Console.WriteLine($"SBI : {sBI.GetInterestInfo()}");
        // create a object for  ICIC and Call GEtIntereztInfo method
        ICIC iCIC=new ICIC();
        Console.WriteLine($"ICIC : {iCIC.GetInterestInfo()}");
        // create a object for  HDFC and Call GEtIntereztInfo method
        HDFC hDFC=new HDFC();
        Console.WriteLine($"HDFC :  {hDFC.GetInterestInfo()}");
        // create a object for  IDBI and Call GEtIntereztInfo method
        IDBI iDBI=new IDBI();
        Console.WriteLine($"IDBI : {iDBI.GetInterestInfo()}");
        

        
        
    }
}