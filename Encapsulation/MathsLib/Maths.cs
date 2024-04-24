using System.Diagnostics;
using System.Net.NetworkInformation;

namespace MathsLib;

public class Maths
{
    // field
    protected internal double PI=3.14;
    internal double g=3.14;
    // Method
    public void CalculateWeight(double mass)
    {
        Console.WriteLine($"{Math.Round(mass*g,2)}");
    }

}
