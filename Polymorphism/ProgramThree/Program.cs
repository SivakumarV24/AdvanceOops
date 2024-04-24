using System;
namespace ProgramThree;
class Program{
    public static void Main(string[] args)
    {
        // create a object for EEEDepartment and Call SetBookInfo() And DisplayInfo() method
        EEEDepartment eEEDepartment=new EEEDepartment();
        eEEDepartment.SetBookInfo("kdfm","C++","dhfs","2010");
        eEEDepartment.DisplayInfo();
        Console.WriteLine();
        
        // create a object for CSEDepartment and Call SetBookInfo() And DisplayInfo() method
        CSEDepartment cSEDepartment=new CSEDepartment();
        cSEDepartment.SetBookInfo("kdfm","C++","dhfs","2010");
        cSEDepartment.DisplayInfo();
    }
}
