using System;
using System.IO;
using MetroApllication;
namespace MetroApplication;
class Program{
    public static void Main(string[] args)
    {
        // Calling Create method and  MainMenu method
        //FileHandling.Create();
        // Read a Data from csv
        FileHandling.ReadFromCsv();
        Operations.MainMenu();
        // Write a date to Csv;
        FileHandling.WriteToCsv();
    }
}