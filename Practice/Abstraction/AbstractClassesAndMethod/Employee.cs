using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassesAndMethod
{
    public abstract class Employee  // Abstract Classs
    {
        /* Abstarct Class- partial Abstraction.
        It has fields,property,method,constructor,destructor,indexers,events
        Can have both abstract declaration and normal definitions 
        can only used with an inherited class
        Not support multiple  inheritance.
        it cannot be static class.*/
        // Normal Field
        protected string _name;
        // Abstract Property
        public abstract string Name { get; set; } // Abstract Method
        public double Amount { get; set; } // Normal Method

        // Normal Method
        public string Display()
        {
            return _name;
        }
        // Abstract Method - Only Declaration
        public abstract double Salary(int days);
        
        
        
        
    }
}