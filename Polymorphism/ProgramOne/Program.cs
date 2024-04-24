using System;
namespace ProgramOne;
class ProgramOne{
    public static void Main(string[] args)
    {
        // create a objecct for ploymorphism
        Polymorphism polymorphism=new Polymorphism();
        // calling square Method
        polymorphism.Square(2);
        polymorphism.Square(2,2);
        polymorphism.Square(2,2,2);
        polymorphism.Square(2,2.0);
        polymorphism.Square(2,2.0,3.0F);
    }
}