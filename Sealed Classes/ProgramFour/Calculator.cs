using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramFour
{
    public class Calculator
    {
        // Abstract Method
        public abstract void Area(double radius); //'Calculator.Area()' is abstract but it is contained in non-abstract type 'Calculator
        public abstract void Volume(); // 'Calculator.Volume()' is abstract but it is contained in non-abstract type 'Calculator'
    }
}