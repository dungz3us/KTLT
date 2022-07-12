// Nguyễn Quang Dũng - 20206277
using System;

namespace WEEK_3_20206277_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Input a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b: ");
            b = Convert.ToDouble(Console.ReadLine());
            unsafe
            {
                double* p1, p2;
                p1 = &a;
                p2 = &b;
                Console.WriteLine("Sum a and b: " + (*p1 + *p2));
                Console.ReadLine();
            }
        }
    }
}
