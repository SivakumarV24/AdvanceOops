using System;
namespace ProgramTwo;
class Program{
    public static void Main(string[] args)
    {
        // Create a object for polymorphism
        Polymorphism polymorphism=new Polymorphism();
        polymorphism.Square(2);
        polymorphism.Square(2.0F);
        polymorphism.Square(3.0);
        polymorphism.Square(2788444889);
    }
}
