// Nguyễn Quang Dũng - 20206277
using System;

namespace WEEK_4_20206277_1_2
{
    class Program
    {
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
            int left = 0;
            int right = n - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (array[mid] == x)
                {
                    Console.WriteLine("Element found at position: " + (mid + 1));
                    break;
                }
                else if (array[mid] < x)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            
            if (left > right)
            {
                Console.WriteLine("Element not found");
            }
            Console.ReadLine();
        }
    }
}
