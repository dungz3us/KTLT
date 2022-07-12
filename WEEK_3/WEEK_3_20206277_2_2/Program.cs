// Nguyễn Quang Dũng - 20206277
using System;

namespace WEEK_3_20206277_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, temp;
            Console.Write("Input a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b: ");
            b = Convert.ToDouble(Console.ReadLine());
            unsafe
            {
                double* p1, p2;
                p1 = &a;
                p2 = &b;
                temp = *p2;
                *p2 = *p1;
                *p1 = temp;
                Console.WriteLine("a after swapping: " + *p1);
                Console.WriteLine("b after swapping: " + *p2);
                Console.ReadLine();
            }
        }
    }
}

