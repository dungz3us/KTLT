// Nguyễn Quang Dũng - 20206277
using System;
namespace tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the tree:");
            int height = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < height - 1 - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int l = 0; l < height - 2; l++)
            {
                Console.Write(" ");
            }
            Console.Write("| |");
            Console.ReadLine();
        }   
    }
}
