// Nguyễn Quang Dũng - 20206277
using System;
using System.Windows;
using System.Numerics;

namespace WEEK_4_20206277_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vector
            Vector v1 = new Vector(20, 30);
            Vector v2 = new Vector(40, 70);
            Vector vectorResult = new Vector();
            
            vectorResult = Vector.Add(v1, v2);
            Console.WriteLine("v1 + v2 = (" + vectorResult +")");

            vectorResult = Vector.Subtract(v1, v2);
            Console.WriteLine("v1 - v2 = (" + vectorResult +")");
            
            double angle = Vector.AngleBetween(v1, v2);
            Console.WriteLine("Angle between v1 and v2 = " + angle);
            
            vectorResult = Vector.Divide(v2, 4);
            Console.WriteLine("v2 / 4 = (" + vectorResult + ")");
            
            double dotProduct = Vector.Multiply(v1, v2);
            Console.WriteLine("Dot product of v1 and v2 = " + dotProduct);
            
            vectorResult = Vector.Multiply(v1, 2);
            Console.WriteLine("v1 * 2 = (" + vectorResult + ")");
            
            double crossProduct = Vector.CrossProduct(v1, v2);
            Console.WriteLine("Cross product of v1 and v2 = " + crossProduct);

            // Vector
            // Matrix
            Matrix3x2 m1 = new Matrix3x2(1, 2, 3, 4, 5, 6);
            Matrix3x2 m2 = new Matrix3x2(7, 8, 9, 10, 11, 12);
            Matrix3x2 matrixResult = new Matrix3x2();
            matrixResult = Matrix3x2.Add(m1, m2);
            Console.WriteLine("m1 + m2 = " + matrixResult );
            Console.ReadLine();
        }
    }
}
