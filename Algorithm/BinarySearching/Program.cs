using System;
namespace BinarySearching;
class Program
{
    public static void Main(string[] args)
    {
        // Default values
        int[] number = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 78, 22, 11, 44, 66, 88, 12, 35, 84, 93, 77 };
        string[] employeeID = { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        char[] alphabets = { 'c', 'a', 'f', 'b', 'k', 'h', 'j', 'I', 'i', 'z', 't', 'm', 'p', 'l', 'd' };
        double[] numbers = { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
        // Binary Search only work on sorted Array so we sorted above arrays
        Array.Sort(number);
        Array.Sort(employeeID);
        Array.Sort(alphabets);
        Array.Sort(numbers);
        // Calling BinarySearching() mehtod for different Parameter
        int position = BinarySearching(number, 66);
        int position1 = BinarySearching(employeeID, "SF3067");
        int position2 = BinarySearching(alphabets, 'm');
        int position3 = BinarySearching(numbers, 3.5);
        // Printing the results:
        if (position > 0)
        {
            Console.WriteLine($"Element Found at a index of {position}");

        }
        else
        {
            Console.WriteLine($"Eelement Not Found");
        }
        if (position1 > 0)
        {
            Console.WriteLine($"Element Found at a index of {position1}");
        }
        else
        {
            Console.WriteLine($"Eelement Not Found");
        }
        if (position2 > 0)
        {
            Console.WriteLine($"Element Found at a index of {position2}");
        }
        else
        {
            Console.WriteLine($"Eelement Not Found");
        }
        if (position3 > 0)
        {
            Console.WriteLine($"Element Found at a index of {position3}");
        }
        else
        {
            Console.WriteLine($"Eelement Not Found");
        }
    }
    static int BinarySearching(int[] value, int searchingElement)
    {
        int left = 0;
        int right = value.Length - 1;
        while (left <= right)
        {
            int middle = left + ((right - left) / 2);
            if (value[middle] == searchingElement)
            {
                return middle;
            }
            else if (value[middle] < searchingElement)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }
        return -1;
    }
    static int BinarySearching(string[] value, string searchingElement)
    {
        int left = 0;
        int right = value.Length - 1;
        while (left <= right)
        {
            int middle = left + ((right - left) / 2);
            if (value[middle].Equals( searchingElement))
            {
                return middle;
            }
            else if (CompareTo(value[middle],searchingElement)<0)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }
        return -1;
    }
    static int BinarySearching(char[] value, char searchingElement)
    {
        int left = 0;
        int right = value.Length - 1;
        while (left <= right)
        {
            int middle = left + ((right - left) / 2);
            if (value[middle] == searchingElement)
            {
                return middle;
            }
            else if (value[middle] < searchingElement)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }
        return -1;
    }
    static int BinarySearching(double[] value, double searchingElement)
    {
        int left = 0;
        int right = value.Length - 1;
        while (left <= right)
        {
            int middle = left + ((right - left) / 2);
            if (value[middle] == searchingElement)
            {
                return middle;
            }
            else if (value[middle] < searchingElement)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }
        return -1;
    }
    static int CompareTo(string employyeID1,string employeeID2)
    {
        int result=employyeID1.CompareTo(employeeID2);
        return result;
    }
    
}