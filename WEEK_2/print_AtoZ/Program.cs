// Nguyễn Quang Dũng - 20206277
using System;

namespace print_AtoZ
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 26; i++)
            {
                Console.Write(Convert.ToChar(i + (int)'A') + " ");
            }
            Console.ReadKey();
        }
    }
}
