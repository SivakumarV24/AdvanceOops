using System;
namespace PartialProgramTwo;
class Program{
    public static void Main(string[] args)
    {
        // create a object for studentClass
        Student student=new Student("Sivakumar V",Gender.Male,new DateTime(2001,12,24),"9080745399",90,80,90);
        student.CalculateTotalAndPercentage();
        Console.WriteLine();
        student.Display();
        
    }
}