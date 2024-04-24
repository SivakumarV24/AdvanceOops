using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramTwo
{
    public class Polymorphism
    {
        // Method
        public void  Square(int number)
        {
            Console.WriteLine($"Square : {number*number}");
            
        }
        public void  Square(float number)
        {
            Console.WriteLine($"Square : {number*number}");
            
        }
        public void  Square(double number)
        {
            Console.WriteLine($"Square : {number*number}");
            
        }
        public void  Square(long number)
        {
            Console.WriteLine($"Square : {number*number}");
            
        }
    }
}