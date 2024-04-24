using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramOne
{
    public class Cylinders:Shape
    {
        // property
        public override double Area { get; set; }
        public override double Volume { get ; set; }
        // Method
        public override void CalculateArea()
        {
            double area= 2*3.14*Radius*(Radius+Height);
            Console.WriteLine($"Area : {area}");            
        }
        public override void CalculateVolume()
        {
            double Volume=3.14*Radius*Height;
            Console.WriteLine($"Volume : {Volume}");            
        }
    }
}