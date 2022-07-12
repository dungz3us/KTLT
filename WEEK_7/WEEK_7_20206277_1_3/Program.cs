using System;

namespace WEEK_7_20206277_1_3
{
    class Program
    {
        public class Array
        {
            public static int subarray(int[] arr, int n, int sum)
            {
                int currentsum, i, j;

                for (i = 0; i < n; i++)
                {
                    currentsum = arr[i];
                    for (j = i + 1; j <= n; j++)
                    {
                        if (currentsum == sum)
                        {
                            int p = j - 1;
                            Console.WriteLine("Subarray is: ");
                            for(int k = i; k <= p; k++)
                            {
                                Console.Write(arr[k] + " ");
                            }    
                            return 1;
                        }
                        if (currentsum > sum || j == n)
                            break;
                        currentsum = currentsum + arr[j];
                    }
                }
                Console.Write("No subarray found");
                return 0;
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
            Console.WriteLine("Enter sum: ");
            int sum = Convert.ToInt32(Console.ReadLine());
            Array.subarray(arr, n, sum);
            Console.ReadLine();
        }
    }
}
