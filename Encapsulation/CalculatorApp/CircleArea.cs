using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using MathsLib;

namespace CalculatorApp
{
    public class CircleArea : Maths
    {
        //field
        protected double radius;
        // property
        public double Radius { get{return radius;} set{radius=value;} }
        internal double area { get; set; }
        //Method
        public double CalculatorCircleArea()
        {
            return Math.Round(PI*Radius *Radius,2);
        }
    }
}