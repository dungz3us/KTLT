// Nguyễn Quang Dũng - 20206277
using System;

namespace WEEK_4_20206277_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int tmp;
            int maxCount = 1, mostCount = array[0];
            int currCount = 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[i])
                    {
                        tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            for (int i = 1; i < n; i++) {
            if (array[i] == array[i - 1])
                currCount++;
            else
                currCount = 1;
 
            if (currCount > maxCount) {
                maxCount = currCount;
                mostCount = array[i - 1];
            }
        }
            Console.WriteLine("The most frequent element is: " + mostCount);
            Console.ReadLine();
        }
    }
}
