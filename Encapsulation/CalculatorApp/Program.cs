using System;
namespace CalculatorApp;
class Program{
    public static void Main(string[] args)
    {
        // Create a object for circle Area
        CircleArea circleArea=new CircleArea();
        circleArea.Radius=4;
        // create a object for  CylinderVolume.
        CylinderVolume cylinderVolume=new CylinderVolume();
        cylinderVolume.Height=8;
        cylinderVolume.Radius=4;
        Console.WriteLine($"circle Area : {circleArea.CalculatorCircleArea()}");
        Console.WriteLine($"cylinder volume : {cylinderVolume.CalculateVolume()}");
        
    }
}