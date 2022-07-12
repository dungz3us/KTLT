using System;

namespace WEEK_7_20206277_1_2
{
    class Program
    {
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
            for( int i = 0; i < n; i++ )
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        for (int k = j; k < n - 1; k++)
                        {
                            arr[k] = arr[k + 1];
                        }
                        n--;
                        j--;
                    }
                }
            }
            Console.WriteLine("\nArray elements after deletion of the duplicate elements: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + "  ");
            }    
            Console.ReadLine();
        }
    }
}