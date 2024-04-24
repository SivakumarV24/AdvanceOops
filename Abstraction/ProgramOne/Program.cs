using System;
namespace ProgramOne;
class Program{
    public static void Main(string[] args)
    {
        Cylinders cylinders=new Cylinders();
        cylinders.Radius=3;
        cylinders.Height=5;
        Console.WriteLine($"****Cyliners****");
        cylinders.CalculateArea();
        cylinders.CalculateVolume();
        Cubes cubes=new Cubes();
        cubes.Width=3;
        Console.WriteLine($"******CUbes******");
        cubes.CalculateArea();
        cubes.CalculateVolume();
        
        
        
    }
}
