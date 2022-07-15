// Nguyễn Quang Dũng - 20206277
using System;

namespace WEEK_6_20206277_1_5
{
    class Permution
    {
        public void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void printPermution(int[] array, int k, int m)
        {
            int i;
            if (k == m)
            {
                for (i = 0; i <= m; i++)
                    Console.Write(array[i]);
                Console.WriteLine("\n");
            }
            else
                for (i = k; i <= m; i++)
                {
                    swap(ref array[k], ref array[i]);
                    printPermution(array, k + 1, m);
                    swap(ref array[k], ref array[i]);
                }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Permution list= new Permution();
            int[] arr1 = new int[10];

            Console.Write("Input the number of elements to store in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input" + n + "number of elements in the array :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write(" element " + i + ": ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe Permutations with a combination of " + n + " digits are : \n\n");
            list.printPermution(arr1, 0, n - 1);
            Console.Write("\n\n");
            Console.ReadLine();
        }
    }
}
