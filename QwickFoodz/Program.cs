using System;
using System.IO;
namespace QwickFoodz;
class Program{
    public static void Main(string[] args)
    {
        //Call Default Value
        //Filehandling.Create();
        //Operations.AddDefaultValue();
        Filehandling.ReadFromCsv();
        //Call Main Menu
        Operations.MainMenu();
        Filehandling.WriteToCsv();
    }
}
