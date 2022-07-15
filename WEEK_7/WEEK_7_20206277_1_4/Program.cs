// Nguyễn Quang Dũng - 20206277
using System;

namespace WEEK_7_20206277_1_4
{
    class Program
    {
        static void maxSubArraySum(int[] a, int size)
        {
            int max_so_far = a[0],
            max_ending_here = 0, start = 0,
            end = 0, s = 0;
            
            for (int i = 0; i < size; i++)
            {    
                if(a[i] > 0)
                {
                    max_ending_here += a[i];
                    if (max_so_far < max_ending_here)
                    {
                        max_so_far = max_ending_here;
                        start = s;
                        end = i;
                    }
                }
                else
                {
                    max_ending_here = 0;
                    s = i + 1;
                } 
            }
            Console.WriteLine("Maximum contiguous sum is " + max_so_far);
            Console.WriteLine("Positive subarray with largest sum is: ");
            for( int i = start; i <= end; i++ )
            {
                Console.Write(a[i] + " ");
            }    
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter " + n + " numbers");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            maxSubArraySum(arr, n);
            Console.ReadLine();
        }
    }
}
