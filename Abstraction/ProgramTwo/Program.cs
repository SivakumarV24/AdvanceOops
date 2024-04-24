using System;
namespace ProgramTwo
{
    class Program{
        public static void Main(string[] args)
        {
            CSEDepartment cSEDepartment=new CSEDepartment();
            cSEDepartment.SetBookInfo("AAA","C Program","BBB","2004");
            cSEDepartment.DisplayInfo();
            EEEdepartment eEEdepartment=new EEEdepartment();
            eEEdepartment.SetBookInfo("DDDD","Java Program","CCC","2005");
            Console.WriteLine();            
            eEEdepartment.DisplayInfo();
        }
    }
}
