using System;
namespace LinearSearching;
class Program{
    public static void Main(string[] args)
    {
        // Default values
        int[] number={45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77};
        string[]  employeeID={"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        char[] alphabets={'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d' };
        double[] numbers={1.1,65.3,93.9,55.5,3.5,6.9 };
        // Calling BinarySearching() mehtod for different Parameter
        int position=LinearSearching(number,66);
        int position1=LinearSearching(employeeID,"SF3067");
        int position2=LinearSearching(alphabets,'m');
        int position3=LinearSearching(numbers,3.5);
        // Printing the results:
        if(position>0)
        {
            Console.WriteLine($"Element Found at a index of {position}");
            
        }
        else
        {
            Console.WriteLine($"Eelement Not Found");
        }
        if(position1>0)
        {
            Console.WriteLine($"Element Found at a index of {position1}");
        }
        else
        {
            Console.WriteLine($"Eelement Not Found");
        }
        if(position2>0)
        {
            Console.WriteLine($"Element Found at a index of {position2}");
        }
        else
        {
            Console.WriteLine($"Eelement Not Found");
        }
        if(position3>0)
        {
            Console.WriteLine($"Element Found at a index of {position3}");
        }
        else
        {
            Console.WriteLine($"Eelement Not Found");
        }
    }
    static int LinearSearching(int[] input,int searchingElement)
    {
        for(int i=0;i<input.Length;i++)
        {
            if(input[i]==searchingElement)
            {
                return i;
            }
        }
        return -1;
    }
    static int LinearSearching(string[] input,string searchingElement)
    {
        for(int i=0;i<input.Length;i++)
        {
            if(input[i].Equals(searchingElement))
            {
                return i;
            }
        }
        return -1;
    }
    static int LinearSearching(char[] input,char searchingElement)
    {
        for(int i=0;i<input.Length;i++)
        {
            if(input[i]==searchingElement)
            {
                return i;
            }
        }
        return -1;
    }
    static int LinearSearching(double[] input,double searchingElement)
    {
        for(int i=0;i<input.Length;i++)
        {
            if(input[i]==searchingElement)
            {
                return i;
            }
        }
        return -1;
    }
}
