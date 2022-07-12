// Nguyễn Quang Dũng - 20206277
using System;
using System.Text;

namespace quadratic_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double a, b, c, delta, x1, x2;
            Console.WriteLine("Nhập a =");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập b =");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập c =");
            c = Convert.ToDouble(Console.ReadLine());
            if(a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phương trình vô số nghiệm");
                    else
                        Console.WriteLine("Phương trình vô nghiệm");
                }
                else
                    Console.WriteLine( -c / b );
            }
            else
            {
                delta = b * b - (4 * a * c);
                if (delta > 0)
                {
                    x1 = ((-b + Math.Sqrt(delta)) / (2 * a));
                    x2 = ((-b - Math.Sqrt(delta)) / (2 * a));
                    Console.WriteLine("Nghiệm thứ nhẩt của phương trình: " + x1 );
                    Console.WriteLine("Nghiệm thứ hai của phương trình: " + x2 );
                }
                else
                {
                    if (delta == 0)
                    {
                        x1 = (-b / (2 * a));
                        Console.WriteLine("Phương trình có nghiệm kép: " + x1 );
                    }
                    else
                    {
                        Console.WriteLine("Nghiệm phức thứ nhất của phương trình: " + -b / (2 * a) + "+" + (Math.Sqrt(Math.Abs(delta)) / (2 * a)) + "i");
                        Console.WriteLine("Nghiệm phức thứ hai của phương trình: " + -b / (2 * a) + "-" + (Math.Sqrt(Math.Abs(delta)) / (2 * a)) + "i");
                    }
                }
                Console.ReadLine();
            }
        }
    }
}