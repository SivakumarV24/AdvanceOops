using System;
namespace ProgramTwo;
class Program{
    public static void Main(string[] args)
    {
        Rectangle rectangle=new Rectangle();
        rectangle.Length=4;
        rectangle.Height=5;
        rectangle.DisplayArea();
        Sphere sphere=new Sphere();
        sphere.Radius=6;
        sphere.DisplayArea();
        Dimension dimension=new Dimension();
        dimension.Value1=2;
        dimension.Value2=3;
        dimension.DisplayArea();
    }
}