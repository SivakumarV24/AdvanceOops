using System;
using System.IO;
namespace MedicalStore;
class Program{
    public static void Main(string[] args)
    {
        // Calling ReadFromCsv method
        FileHandling.ReadFromCsv();
        // Calling MainMenu Method
        Operations.MainMenu();
        //Calling WriteToCsv Method.
        FileHandling.WriteToCsv();
    }
}