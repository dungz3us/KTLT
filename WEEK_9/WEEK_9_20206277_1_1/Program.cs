using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WEEK_9_20206277_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = @"D:\C#\KTLT\WEEK_9\WEEK_9_20206277_1_1\input.txt";
            string outputFile = @"D:\C#\KTLT\WEEK_9\WEEK_9_20206277_1_1\output.txt";
            var elements = File.ReadAllLines(inputFile);
            BigInteger sum = new BigInteger(0);
            BigInteger product = new BigInteger(1);
            Decimal divide = new Decimal(1);
            BigInteger subtract = new BigInteger(0);
            foreach(var element in elements)
            {
                sum += BigInteger.Parse(element);
                product *= BigInteger.Parse(element);
                subtract = BigInteger.Parse(element) - subtract;
                divide  = (decimal)(BigInteger.Parse(element)) / divide;
            }
            string output = "Sum is: " + sum.ToString() + "\n" + "Subtraction is: " + subtract.ToString() + "\n" + "Product is: " + product.ToString() + "\n" + "Division is: " + divide.ToString() + "\n";
            File.WriteAllText(outputFile, output);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
