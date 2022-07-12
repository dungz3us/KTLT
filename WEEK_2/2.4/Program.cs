// Nguyễn Quang Dũng - 20026277
using System;
using System.Text;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a, b, x, y;
            do
            {
                Console.WriteLine("Nhập số thứ nhất: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập số thứ hai: ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            while (a <= 0 || b <= 0);
            x = a;
            y = b;
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            Console.WriteLine("Ước chung lớn nhất là: " + a);
            Console.WriteLine("Bội chung nhỏ nhất là: " + ((x * y) / a));
            Console.ReadLine();
        }
    }
}
