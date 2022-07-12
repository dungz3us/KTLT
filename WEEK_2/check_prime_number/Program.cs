// Nguyễn Quang Dũng - 20206277
using System;
using System.Text;

namespace check_prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int number , count;
            count = 0;
            Console.WriteLine("Nhập số: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 2)
            {
                Console.WriteLine(number + " không phải số nguyên tố");
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        count++ ;
                        break;
                    }
                }
                if (count == 0) { Console.WriteLine(number + " là số nguyên tố"); }
                else { Console.WriteLine(number + " không phải số nguyên tố"); }
            }
            
            Console.ReadKey();
        }
    }
}
