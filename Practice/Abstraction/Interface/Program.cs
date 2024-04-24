using System;
namespace Interface;
class Program{
    public static void Main(string[] args)
    {
        // create a object for square
        Square square=new Square();
        square.Number=8;
        int area=square.Calculate();
        Console.WriteLine($"{area}");
        Circle circle=new Circle();
        circle.Number=4;
        Console.WriteLine($"{circle.Calculate()}");
    }
}