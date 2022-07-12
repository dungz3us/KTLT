// Nguyễn Quang Dũng - 20206277
using System;
using System.Text;

namespace draw_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine(" Nhập 1 là cây thông \n Nhập 2 là cây tre \n Nhập 3 là cây xương rồng");
            int tree = Convert.ToInt32(Console.ReadLine());
            switch (tree)
            {
                case 1:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int k = 0; k < 10 - 1 - i; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write(" *");
                        }
                        Console.WriteLine();
                    }
                    for (int l = 0; l < 10 - 2; l++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("| |");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Write("\n");
                    for (int i = 0; i <= 9; i++)
                    {
                        Console.Write("          ");
                        Console.WriteLine("**");
                    }
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Write("\n");
                    for (int i = 0; i <= 4; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine("     **");
                        }
                        if (i % 2 == 1)
                        {
                            Console.WriteLine("    ****");
                        }
                    }
                    Console.WriteLine("     **");
                    Console.ReadLine();
                    break;
            }

        }
    }
}
    

