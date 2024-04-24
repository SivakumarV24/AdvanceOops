using System;
namespace ProgramEight;
class Program{
    public static void Main(string[] args)
    {
        // creating four object for Calculator
        Calculator sem1=new Calculator(new int[]{89,90,89,74,89,90});
        Calculator sem2=new Calculator(new int[]{90,90,100,90,65,89});
        Calculator sem3=new Calculator(new int[]{75,89,78,69,83,90});
        Calculator sem4=new Calculator(new int[]{68,70,80,88,89,98});
        // Adding Total Mark of all Semster
        Calculator result1=sem1+sem2;
        Calculator result2=sem3+sem4;
        Calculator result=result1+result2;
        //result.CalculateTotalMarkAndPercentage();
        Console.WriteLine($"Total Mark : {result.TotalMark}");
        Console.WriteLine($"Percentage : {Math.Round((double)result.TotalMark/24,2)}%");
    }
}