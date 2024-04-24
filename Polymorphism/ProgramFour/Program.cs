using System;
namespace ProgramFour;
class Program{
    public static void Main(string[] args)
    {
        // create a object for syncfusion and Free lancer and call display method
        Syncfusion syncfusion=new Syncfusion("chennai","Software Engineer",5,"sivakumar","Vairamuthu",Gender.Male,"B.E -Mechanical");
        syncfusion.Display();
        Console.WriteLine();
        FreeLancer freeLancer=new FreeLancer("Software Engineer",5,"sivakumar","Vairamuthu",Gender.Male,"B.E -Mechanical");
        freeLancer.Display();
        

    }
}
