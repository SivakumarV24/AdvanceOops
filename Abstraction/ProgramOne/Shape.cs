using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramOne
{
    public abstract class Shape
    {
        // Abstract Property
        public abstract double Area { get; set; }
        public abstract double Volume { get; set; }
        // Normal Property
        public double Radius { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        // Abstract  Method
        public abstract void CalculateArea();
        public abstract void CalculateVolume();
        
        
        
    }
}