using System;
using OperatorOverloading;
namespace OperatorOverLoading;
class Program{
    public static void Main(string[] args)
    {
        // Calling Box Class Method
        Box box1=new Box(1.2,3.1,4.1);
        Box box2=new Box(2.2,4.1,5.1);
        Console.WriteLine($"{box1.CalculateVolume()}");
        Console.WriteLine($"{box2.CalculateVolume()}");
        Box box=Box.Add(box1,box2);
        Console.WriteLine($"{box.CalculateVolume()}");
        Box box4=box1+box2;
        Console.WriteLine($"{box.CalculateVolume()}");    
    }
}