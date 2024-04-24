using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramOne
{
    public class Polymorphism
    {
        // methods
        public void Square(int number)
        {
            Console.WriteLine($"Square : {number*number}");
            
        }
        public void Square(int number,double number1)
        {
            Console.WriteLine($"Square : {number*number}, {number1*number1}");
            
        }
        public void Square(int number,int number1)
        {
            Console.WriteLine($"Square : {number*number} , {number1*number1}");
            
        }
        public void Square(int number,int number1,int number2)
        {
            Console.WriteLine($"Square : {number*number}, {number1*number1}, {number2*number2}");
            
        }
        public void Square(int number,double number1,float number2)
        {
            Console.WriteLine($"Square : {number*number},{number1*number1},{number2*number2}");
            
        }
    }
}