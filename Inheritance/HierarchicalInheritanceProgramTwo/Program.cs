using System;
namespace HierarchicalInheritanceProgramTwo;
class Program{
    public static void Main(string[] args)
    {
        // create a object for classes
        PermanentEmployee permanentEmployee=new PermanentEmployee(10000,"May");
        TemporaryEmployee temporaryEmployee=new TemporaryEmployee(10000,"May");
        // Display their Salary
        Console.WriteLine($"********PermanentEmployee*********");
        permanentEmployee.ShowSalary();
        Console.WriteLine();
        Console.WriteLine($"********TemporaryEmployee*********");
        temporaryEmployee.ShowSalary();   
    }
}