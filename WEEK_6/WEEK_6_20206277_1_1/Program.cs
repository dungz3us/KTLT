// Nguyễn Quang Dũng - 20206277
using System;

namespace WEEK_6_20206277_1_1
{
    class Program
    {
        public static long Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci number is: " + Fib(n));
            Console.ReadLine();
        }
    }
}
