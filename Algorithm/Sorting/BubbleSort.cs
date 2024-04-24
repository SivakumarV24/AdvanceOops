using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSort
    {
        //Ascending Method
        public void AscendingBubbleSort(int[] value)
        {
            for (int i = 0; i < value.Length - 1; i++)
            {
                for (int j = 0; j < value.Length - 1; j++)
                {
                    if (value[j] > value[j + 1])
                    {
                        int temp = value[j + 1];
                        value[j + 1] = value[j];
                        value[j] = temp;
                    }
                }
            }
        }
        public void AscendingBubbleSort(char[] value)
        {
            for (int i = 0; i < value.Length - 1; i++)
            {
                for (int j = 0; j < value.Length - 1; j++)
                {
                    if (value[j] > value[j + 1])
                    {
                        char temp = value[j + 1];
                        value[j + 1] = value[j];
                        value[j] = temp;
                    }
                }
            }
        }
        public void AscendingBubbleSort(double[] value)
        {
            for (int i = 0; i < value.Length - 1; i++)
            {
                for (int j = 0; j < value.Length - 1; j++)
                {
                    if (value[j] > value[j + 1])
                    {
                        double temp = value[j + 1];
                        value[j + 1] = value[j];
                        value[j] = temp;
                    }
                }
            }
        }
        public void AscendingBubbleSort(string[] value)
        {
            for (int i = 0; i < value.Length - 1; i++)
            {
                for (int j = 0; j < value.Length - 1; j++)
                {
                    if (value[j].CompareTo(value[j + 1]) > 0)
                    {
                        string temp = value[j + 1];
                        value[j + 1] = value[j];
                        value[j] = temp;
                    }
                }
            }
        }
        // Descending Method
        public void DescendingBubbleSort(int[] value)
        {
            for (int i = 0; i < value.Length - 1; i++)
            {
                for (int j = 0; j < value.Length - 1; j++)
                {
                    if (value[j] < value[j + 1])
                    {
                        int temp = value[j + 1];
                        value[j + 1] = value[j];
                        value[j] = temp;
                    }
                }
            }
        }
        public void DescendingBubbleSort(char[] value)
        {
            for (int i = 0; i < value.Length - 1; i++)
            {
                for (int j = 0; j < value.Length - 1; j++)
                {
                    if (value[j] < value[j + 1])
                    {
                        char temp = value[j + 1];
                        value[j + 1] = value[j];
                        value[j] = temp;
                    }
                }
            }
        }
        public void DescendingBubbleSort(double[] value)
        {
            for (int i = 0; i < value.Length - 1; i++)
            {
                for (int j = 0; j < value.Length - 1; j++)
                {
                    if (value[j] < value[j + 1])
                    {
                        double temp = value[j + 1];
                        value[j + 1] = value[j];
                        value[j] = temp;
                    }
                }
            }
        }
        public void DescendingBubbleSort(string[] value)
        {
            for (int i = 0; i < value.Length - 1; i++)
            {
                for (int j = 0; j < value.Length - 1; j++)
                {
                    if (value[j].CompareTo(value[j + 1]) < 0)
                    {
                        string temp = value[j + 1];
                        value[j + 1] = value[j];
                        value[j] = temp;
                    }
                }
            }
        }
    }
}