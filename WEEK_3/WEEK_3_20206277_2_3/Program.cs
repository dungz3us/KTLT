// Nguyễn Quang Dũng - 20206277
using System;
 
namespace WEEK_3_20206277_2_3
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            Console.WriteLine("length of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[n];
            double sum = 0;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("enter element " + (i + 1) + ": ");
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            fixed (double* p1 = &a[0])
                {
                double* p2 = p1;
                for (int i = 0; i < n; i++)
                    {
                        sum = sum + *p2;
                        p2++;
                    }
                }
            Console.WriteLine("The sum is: " + sum);
            Console.ReadLine();
        }
    }
}
