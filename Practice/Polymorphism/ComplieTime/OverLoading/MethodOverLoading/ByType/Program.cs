using System;
namespace ByType;
class Program{
    public static void Main(string[] args)
    {
        // MethodOverloading -->By type
        int result=Add(1,2);
        double result1=Add(1,3);
        string result3=Add("1","3");
       
    }
    public static int Add(int a ,int b)
    {
        return a+b;
    }
    public static string Add(string a,string b)
    {
        return a+b;
    }
    public static double Add(double a ,double b)
    {
        return a+b;
    }

}