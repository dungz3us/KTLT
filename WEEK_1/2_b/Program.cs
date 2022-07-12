// Nguyễn Quang Dũng - 20206277
using System;
using System.Text;
namespace _2_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập tên của bạn:");
            string Name = Console.ReadLine();
            Console.WriteLine("Chào " + Name + ", mình đến với thế giới lập trình");
            Console.ReadLine();
        }
    }
}
