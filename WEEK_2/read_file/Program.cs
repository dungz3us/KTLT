// Nguyễn Quang Dũng - 20206277
using System;
using System.Text;
using System.IO;

namespace readfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string path = @"D:\C#\KTLT\WEEK_2\file.txt";
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
            Console.ReadLine();
        }
    }
}