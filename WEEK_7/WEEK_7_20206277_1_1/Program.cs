// Nguyễn Quang Dũng - 20206277
using System;

namespace WEEK_7_20206277_1_1
{
    class Program
    {
        static public double averageDistance(int[] arr, int n)
        {
            double sum = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    sum += Math.Abs(arr[i] - arr[j]);
                    count++;
                }
            }
            return sum / count;
        } 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter " + n + " numbers");
            for(int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            double average = averageDistance(arr, n);
            Console.WriteLine("Average distance between elements in the array is: " + average);
            Console.ReadLine();
        }
    }
}
