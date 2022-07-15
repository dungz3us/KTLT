// Nguyễn Quang Dũng - 20206277
using System;
using System.Collections;
using System.Text;

namespace WEEK_8_20206277_1_1
{

    class Program
    {
        public class Text_editor
        {
            static Stack Undo = new Stack();

            static Stack Redo = new Stack();

            static void Write(Stack Undo, char x)
            {
                Undo.Push(x);
            }
            static void undo(Stack Undo, Stack Redo)
            {
                if (Undo.Count == 0)
                {
                    Console.WriteLine("Stack is empty");
                }
                else
                {
                    char x = (char)Undo.Peek();
                    Undo.Pop();
                    Redo.Push(x);
                }
            }
            static void redo(Stack Undo, Stack Redo)
            {
                if (Redo.Count == 0)
                {
                    Console.WriteLine("Stack is empty");
                }
                else
                {
                    char x = (char)Redo.Peek();
                    Redo.Pop();
                    Undo.Push(x);
                }
            }
            static void print(Stack Undo)
            {
                if (Undo.Count == 0)
                {
                    Console.WriteLine("Stack is empty");
                }
                else
                {
                    Stack reverseOder = new Stack();
                    while (Undo.Count > 0)
                    {
                        reverseOder.Push(Undo.Peek());
                        Undo.Pop();
                    }
                    while (reverseOder.Count > 0)
                    {
                        Console.Write(reverseOder.Peek());
                        Undo.Push(reverseOder.Peek());
                        reverseOder.Pop();
                    }
                    Console.WriteLine("");
                }
            }
            public static void Text(string[] a)
            {
                int n = a.Length;
                for (int i = 0; i < n; i++)
                {
                    if (a[i] == "undo")
                    {
                        undo(Undo, Redo);
                    }
                    else if (a[i] == "redo")
                    {
                        redo(Undo, Redo);
                    }
                    else if (a[i] == "print")
                    {
                        print(Undo);
                    }
                    else
                    {
                        for(int j = 0; j < a[i].Length; j++)
                        {
                            Write(Undo, a[i][j]);
                        }
                    }
                }
            }
        }
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            // Console.WriteLine("Enter a string: ");
            // string s = Console.ReadLine();
            // string[] a = s.Split('/');
            string[] a = {"Nguyễn ", "Quang ", "Dũng", "undo", "print", "redo", "print" };
            Text_editor.Text(a);
            Console.ReadLine();
        }
    }
}
