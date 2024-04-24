using System;
namespace SelectionSorting;
class Program{
    public static void Main(string[] args)
    {
        // Default values
        int[] number={45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77};
        string[]  employeeID={"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        char[] alphabets={'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d' };
        double[] numbers={1.1,65.3,93.9,55.5,3.5,6.9 };
        // call Ascebding sorting method
        SelectionSorting.AscendingSelectionSort(number);
        SelectionSorting.AscendingSelectionSort(employeeID);
        SelectionSorting.AscendingSelectionSort(alphabets);
        SelectionSorting.AscendingSelectionSort(numbers);
        // printing Sorted Array
        Console.Write($"Ascending Interger Array : ");
        foreach (int num in number)
        {
            Console.Write ($"{num} ");            
        }
        Console.WriteLine();
        Console.Write($"Ascending String  Array : ");
        foreach (string num in employeeID)
        {
            Console.Write ($"{num} ");            
        }
        Console.WriteLine();
        Console.Write($"Ascending Alphabets Array : ");
        foreach (char num in alphabets)
        {
            Console.Write ($"{num} ");            
        }
        Console.WriteLine();
        Console.Write($"Ascending double Array : ");
        foreach (double num in numbers)
        {
            Console.Write ($"{num} ");            
        }
        
        // Calling Descending Sorting
        SelectionSorting.DescendingSelectionSort(number);
        SelectionSorting.DescendingSelectionSort(employeeID);
        SelectionSorting.DescendingSelectionSort(alphabets);
        SelectionSorting.DescendingSelectionSort(numbers);
        // Printing Descending Sorting Array
        Console.WriteLine();
        Console.Write($"Descending int Array : ");
        foreach (int num in number)
        {
            Console.Write ($"{num} ");            
        }
         Console.WriteLine();
        Console.Write($"Descending String  Array : ");
        foreach (string num in employeeID)
        {
            Console.Write ($"{num} ");            
        }
        Console.WriteLine();
        Console.Write($"Descending Alphabets Array : ");
        foreach (char num in alphabets)
        {
            Console.Write ($"{num} ");            
        }
        Console.WriteLine();
        Console.Write($"Descending double Array : ");
        foreach (double num in numbers)
        {
            Console.Write ($"{num} ");            
        }
    }
}