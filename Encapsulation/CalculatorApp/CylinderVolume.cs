using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CylinderVolume:CircleArea
    {
        // field
        private double height;
        //property
        public double Height { get{return  height;} set{height=value;} }
        internal double volume { get; set; }
        // Method
        public double CalculateVolume()
        {
            volume=Math.Round(CalculatorCircleArea()*Height);
            return volume;
        }

        
    }
}