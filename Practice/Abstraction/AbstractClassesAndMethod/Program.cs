using System;
namespace AbstractClassesAndMethod;
class Program{
    public static void Main(string[] args)
    {
        // Create a object for Syncfusion class.
        Employee syncfusion=new Syncfusion();
        syncfusion.Name="Luffy";
        Console.WriteLine($"{syncfusion.Display()}");
        Console.WriteLine($"{syncfusion.Salary(30)}");

        Employee zoho=new Zoho();
        zoho.Name="Dragon";
        Console.WriteLine($"{zoho.Display()}");
        Console.WriteLine($"{zoho.Salary(30)}");
        
    }
}