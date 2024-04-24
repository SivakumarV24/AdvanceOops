using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramOne
{
    public class Cubes:Shape
    {
         // property
        public override double Area { get; set; }
        public override double Volume { get ; set; }
        // Method
        public override void CalculateArea()
        {
            double area= 6*(Width*Width);
            Console.WriteLine($"Area : {area}");            
        }
        public override void CalculateVolume()
        {
            double Volume=Math.Pow(Width,3);
            Console.WriteLine($"Volume : {Volume}");            
        }
    }
}