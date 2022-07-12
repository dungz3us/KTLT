<<<<<<< HEAD
﻿// Nguyễn Quang Dũng - 20206277
using System;

namespace WEEK_5_20206277_2_1
{
    class Program
    {

        public class Complex
        {
            public double x1 = 0;
            public double x2 = 0;

            public Complex(double real, double imaginary)
            {
                x1 = real;
                x2 = imaginary;
            }

            public static Complex operator +(Complex a, Complex b)
            {
                return new Complex(a.x1 + b.x1, a.x2 + b.x2);
            }
            public static Complex operator -(Complex a, Complex b)
            {
                return new Complex(a.x1 - b.x1, a.x2 - b.x2);
            }
            public static Complex operator *(Complex a, Complex b)
            {
                return new Complex(a.x1 * b.x1 - a.x2 * b.x2, a.x1 * b.x2 + a.x2 * b.x1);
            }
            public static Complex operator /(Complex a, Complex b)
            {
                return new Complex((a.x1 * b.x1 + a.x2 * b.x2) / (b.x1 * b.x1 + b.x2 * b.x2), (a.x2 * b.x1 - a.x1 * b.x2) / (b.x1 * b.x1 + b.x2 * b.x2));
            }
        }

        
        
    static void Main(string[] args)
        {
            Complex a = new Complex(7.0, 6.0);
            Complex b = new Complex(3.0, 4.0);
 
            Complex c = a + b;
            Complex d = a - b;
            Complex e = a * b;
            Complex f = a / b;
            Console.WriteLine("a + b = {0} + {1}i", c.x1, c.x2);
            Console.WriteLine("a - b = {0} + {1}i", d.x1, d.x2);
            Console.WriteLine("a * b = {0} + {1}i", e.x1, e.x2);
            Console.WriteLine("a / b = {0} + {1}i", f.x1, f.x2);

            
            Console.ReadLine();
        }
    }
}
=======
﻿// Nguyễn Quang Dũng - 20206277
using System;

namespace WEEK_5_20206277_2_1
{
    class Program
    {

        public class Complex
        {
            public double x1 = 0;
            public double x2 = 0;

            public Complex(double real, double imaginary)
            {
                x1 = real;
                x2 = imaginary;
            }

            public static Complex operator +(Complex a, Complex b)
            {
                return new Complex(a.x1 + b.x1, a.x2 + b.x2);
            }
            public static Complex operator -(Complex a, Complex b)
            {
                return new Complex(a.x1 - b.x1, a.x2 - b.x2);
            }
            public static Complex operator *(Complex a, Complex b)
            {
                return new Complex(a.x1 * b.x1 - a.x2 * b.x2, a.x1 * b.x2 + a.x2 * b.x1);
            }
            public static Complex operator /(Complex a, Complex b)
            {
                return new Complex((a.x1 * b.x1 + a.x2 * b.x2) / (b.x1 * b.x1 + b.x2 * b.x2), (a.x2 * b.x1 - a.x1 * b.x2) / (b.x1 * b.x1 + b.x2 * b.x2));
            }
        }

        
        
    static void Main(string[] args)
        {
            Complex a = new Complex(7.0, 6.0);
            Complex b = new Complex(3.0, 4.0);
 
            Complex c = a + b;
            Complex d = a - b;
            Complex e = a * b;
            Complex f = a / b;
            Console.WriteLine("a + b = {0} + {1}i", c.x1, c.x2);
            Console.WriteLine("a - b = {0} + {1}i", d.x1, d.x2);
            Console.WriteLine("a * b = {0} + {1}i", e.x1, e.x2);
            Console.WriteLine("a / b = {0} + {1}i", f.x1, f.x2);

            
            Console.ReadLine();
        }
    }
}
>>>>>>> 9cca62e387898e17b7c45a8c941bfc56832ca4f8
