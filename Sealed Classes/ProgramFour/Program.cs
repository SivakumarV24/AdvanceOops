using System;
namespace ProgramFour;
class Program{
    public static void Main(string[] args)
    {
        CircleCalculator circleCalculator=new CircleCalculator();
        circleCalculator.Area(4);
        CylinderCalculator cylinderCalculator=new CylinderCalculator();
        cylinderCalculator.Area(8);
    }
}