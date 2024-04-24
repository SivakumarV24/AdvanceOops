using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectionSorting
{
    public class SelectionSorting
    {
        // Ascending Method
        public static void AscendingSelectionSort(int[] array)
        {
            int min=0;
            for(int i=0;i<array.Length;i++)
            {
                min=i;
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[min]>array[j])
                    {
                        min=j;
                    }
                }
                int temp=array[min];
                array[min]=array[i];
                array[i]=temp;
            }
        }
         public static void AscendingSelectionSort(char[] array)
        {
            int min=0;
            for(int i=0;i<array.Length;i++)
            {
                min=i;
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[min]>array[j])
                    {
                        min=j;
                    }
                }
                char temp=array[min];
                array[min]=array[i];
                array[i]=temp;
            }
        }
         public static void AscendingSelectionSort(double[] array)
        {
            int min=0;
            for(int i=0;i<array.Length;i++)
            {
                min=i;
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[min]>array[j])
                    {
                        min=j;
                    }
                }
                double temp=array[min];
                array[min]=array[i];
                array[i]=temp;
            }
        }
         public static void AscendingSelectionSort(string[] array)
        {
            int min=0;
            for(int i=0;i<array.Length;i++)
            {
                min=i;
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[min].CompareTo(array[j]) > 0)
                    {
                        min=j;
                    }
                }
                string temp=array[min];
                array[min]=array[i];
                array[i]=temp;
            }
        }
        // Descending Sorting
         public static void DescendingSelectionSort(int[] array)
        {
            int min=0;
            for(int i=0;i<array.Length;i++)
            {
                min=i;
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[min]<array[j])
                    {
                        min=j;
                    }
                }
                int temp=array[min];
                array[min]=array[i];
                array[i]=temp;
            }
        }
         public static void DescendingSelectionSort(char[] array)
        {
            int min=0;
            for(int i=0;i<array.Length;i++)
            {
                min=i;
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[min]<array[j])
                    {
                        min=j;
                    }
                }
                char temp=array[min];
                array[min]=array[i];
                array[i]=temp;
            }
        }
         public static void DescendingSelectionSort(double[] array)
        {
            int min=0;
            for(int i=0;i<array.Length;i++)
            {
                min=i;
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[min]<array[j])
                    {
                        min=j;
                    }
                }
                double temp=array[min];
                array[min]=array[i];
                array[i]=temp;
            }
        }
         public static void DescendingSelectionSort(string[] array)
        {
            int min=0;
            for(int i=0;i<array.Length;i++)
            {
                min=i;
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[min].CompareTo(array[j]) < 0)
                    {
                        min=j;
                    }
                }
                string temp=array[min];
                array[min]=array[i];
                array[i]=temp;
            }
        }
    }
}