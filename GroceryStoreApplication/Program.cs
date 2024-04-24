using System;
namespace GroceryStoreApplication;
class Program{
    public static void Main(string[] args)
    {
        //ReadFile
        FileHandling.ReadFromCsv();
        //call default value
        //Operations.AddDefaultValue();
        // Call MainMenu
        Operations.MainMenu();
        //Call WriteToCsv
        FileHandling.WriteToCsv();
    }
}