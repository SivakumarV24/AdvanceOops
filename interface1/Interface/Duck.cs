using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class Duck
    {
        //  Property
        public string Name { get; set;}
        public string Habitat { get; set; }
        public string EatingHabit { get; set; }
        // Constructor
        public Duck(string name,string habitat,string eatingHabit)
        {
            Name=name;
            Habitat=habitat;
            EatingHabit=eatingHabit;
        }
        //method
        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Habitat  : {Habitat}");
            Console.WriteLine($"EatingHabit : {EatingHabit}");                                  
        }
    }
}