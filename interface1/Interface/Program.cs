using System;
namespace Interface;
class Program{
    public static void Main(string[] args)
    {
        // create a object
        Dog dog=new Dog("Dog","hahahsl","hjjkd");
        Duck duck=new Duck("Duck","hgfdkds","kjfd");
        // calling Method
        dog.DisplayInfo();
        Console.WriteLine();
        duck.DisplayInfo();
        
    }
}