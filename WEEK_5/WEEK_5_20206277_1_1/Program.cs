// Nguyễn Quang Dũng - 20206277
using System;

namespace WEEK_5_20206277_1_1
{
    class Program
    {   
        static void printArray(double[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("");
        } 
        static void insertionSort(double[] array)
        {
            double tmp;
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        tmp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = tmp;
                    }
                }
            }
            Console.Write("Sorted array using insertion sort : ");
        }

        static void selectionSort( double[] array)
        {
            double tmp;
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                tmp = array[i];
                array[i] = array[min];
                array[min] = tmp;
            }
            Console.Write("Sorted array using selection sort : ");
        }

        static void bubbleSort( double[] array)
        {
            double tmp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
            Console.Write("Sorted array using bubble sort : ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element: ");
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            insertionSort(array);
            printArray(array);
            selectionSort(array);
            printArray(array);
            bubbleSort(array);
            printArray(array);
            Console.ReadLine();
        }
    }
}
