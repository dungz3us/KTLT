// Nguyễn Quang Dũng - 20206277
using System;
using System.IO;
using System.Text;

namespace append_file
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string path = @"D:\C#\KTLT\WEEK_2\append_file.txt";
            Console.WriteLine("Add text: "); 
            string add = Console.ReadLine();
            File.AppendAllText(path, add);
            string readfile = File.ReadAllText(path);
            Console.WriteLine(readfile);
            Console.ReadLine();
        }
    }
}
