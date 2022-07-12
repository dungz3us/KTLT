// Nguyễn Quang Dũng - 20206277
using System;
using System.Text;
using System.IO;

namespace update_file
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string path = @"D:\C#\KTLT\WEEK_2\update_file.txt";
            string before = Console.ReadLine();
            string after = Console.ReadLine();
            string text = File.ReadAllText(path);
            text = text.Replace(before, after);
            File.WriteAllText(path, text);
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
            Console.ReadLine();
        }
    }
}
