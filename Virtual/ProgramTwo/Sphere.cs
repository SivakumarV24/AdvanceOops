using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramTwo
{
    public class Sphere :  Dimension
    {
        //property
        public double Radius { get; set; }
        public override void DisplayArea()
        {
            Console.WriteLine($"Sphere Area: {Math.Round(4*3.14*Radius*Radius,2)}");            
        }
    }
}