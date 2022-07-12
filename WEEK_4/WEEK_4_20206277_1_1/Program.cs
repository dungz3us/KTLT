// Nguyễn Quang Dũng - 20206277
using System;

namespace WEEK_4_20206277_1_1
{
    class Program
    {
        static double max, min;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element: ");
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Enter element to search: ");
            double x = Convert.ToDouble(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                if(i == 0)
                {
                    max = array[i];
                    min = array[i];
                }
                if(array[i] > max)
                {
                    max = array[i];
                }
                if(array[i] < min)
                {
                    min = array[i];
                }
            }
            bool contrains = false;
            for(int i = 0; i < n; i++)
            {
                if(array[i] == x)
                {
                    contrains = true;
                    break;
                }
            }
            if( contrains == true )
            {
                Console.WriteLine("Element found");
            }
            else
            {
                Console.WriteLine("Element not found");
            }
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.ReadLine();
        }
    }
}
