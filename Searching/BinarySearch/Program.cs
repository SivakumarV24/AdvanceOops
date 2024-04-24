using System;
using System.Drawing;
namespace BinarySearch;
class Program{
    public static void Main(string[] args)
    {
        int[] value={23,12,34,34,55,77};
        Array.Sort(value);
        if(BinarySearch(value,89)>0)
        {
            Console.WriteLine($"Element has found at a index of  {BinarySearch(value,89)}");
        }
        else
        {
            Console.WriteLine($"Element not found");
        }

    }
    static int BinarySearch(int [] value ,int searchElement)
    {
        int left=0; int right=value.Length-1;
        while(left<=right)
        {
            int middle=left+((right-left)/2);
            if(value[middle]==searchElement)
            {
                return middle;
            }
            else if(value[middle]<searchElement)
            {
                // Searching in right half by changing value of left
                left=middle+1;
            }
            else
            {
                //Searching in left half bu changing value of  right;
                right=middle-1;
            }
        }
        // Element not present return -1;
        return -1;
    }
}