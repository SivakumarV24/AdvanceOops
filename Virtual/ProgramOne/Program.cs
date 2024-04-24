using System;
namespace ProgramOne;
class Program{
    public static void Main(string[] args)
    {
        VolumeCalculator volumeCalculator=new VolumeCalculator();
        volumeCalculator.Radius=4;
        volumeCalculator.Height=5;
        volumeCalculator.Calculate();
        AreaCalculator areaCalculator=new AreaCalculator();
        areaCalculator.Radius=3;
        areaCalculator.Calculate();
    }
}