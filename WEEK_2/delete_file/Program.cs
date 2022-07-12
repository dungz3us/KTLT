// Nguyễn Quang Dũng - 20206277
using System;
using System.IO;
using System.Text;


namespace delete_file
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string path = @"D:\C#\KTLT\WEEK_2\delete_file.txt";
            string blank = "";
            File.WriteAllText(path, blank);
            Console.ReadLine();
        }
    }
}
