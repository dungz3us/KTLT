// Nguyễn Quang Dũng - 20206277
using System;

namespace WEEK_4_20206277_2_1
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            Console.WriteLine("Length of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter element " + (i + 1) + ": ");
                a[i] = Convert.ToDouble(Console.ReadLine());
            }

            fixed (double* p1 = &a[n - 1])
            {
                double* p2 = p1;
                Console.Write("Reverse array: ");
                for (int i = n; i > 0; i--)
                {
                    Console.Write(*p2 + " " );
                    p2--;
                }
            }
            Console.ReadLine();
        }
    }
}
