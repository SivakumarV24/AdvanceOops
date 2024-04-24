using System;
namespace HybridProgramOne;
class Program{
    public static void Main(string[] args)
    {
        // Create a object for class
        MarkSheet markSheet=new MarkSheet(new int[6]{60,70,80,50,90,80},new int[6]{60,70,80,50,90,80},new int[6]{60,70,80,50,90,80},new int[6]{60,70,80,50,90,80},"Sivakumar","Vairamuthu",new DateTime(2002,12,24),"9080745399",Gender.Male);
        // calling Methods
        markSheet.ShowUGMarkSheet();
        
    }
}
