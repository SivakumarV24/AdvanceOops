using System;
namespace  ProgramFour;
class Program{
    public static void Main(string[] args)
    {
        // create a object and call display info method
        Ladieswear ladieswear=new Ladieswear();
        ladieswear.DisplayInfo();
        Menswear menswear=new Menswear();
        menswear.DisplayInfo();
    }
}
