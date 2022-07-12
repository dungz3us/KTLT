// Nguyễn Quang Dũng - 20206277
using System;

namespace WEEK_3_20206277_2_4
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            var Char = str.ToCharArray();
            int i = 0;
            fixed (char* p1 = &Char[0]) 
            {
                char* p2 = p1;
                while (*p2 != '\0')
                {
                    i++;
                    p2++;
                }
            }
            Console.WriteLine("Lenght of string is: " + i);
            Console.ReadLine();
        }
    }
}
