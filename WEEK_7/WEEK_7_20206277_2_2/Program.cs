// Nguyễn Quang Dũng - 20206277
using System;
using System.Text;
    class Node
    {
        public string data;
        public Node next;
        public Node(string d)
        {
            data = d;
            next = null;
        }
    }
    class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            head = null;
        }
        public void Add(string d)
        {
            Node newNode = new Node(d);
            newNode.next = head;
            head = newNode;
        }
        public void Print()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        public void Remove(string d)
        {
            Node temp = head;
            Node prev = null;
            while (temp != null)
            {
                if (temp.data == d)
                {
                    if (prev == null)
                    {
                        head = temp.next;
                    }
                    else
                    {
                        prev.next = temp.next;
                    }
                }
                prev = temp;
                temp = temp.next;
            }
        }
        public void RemoveAll(string d)
        {
            Node temp = head;
            Node prev = null;
            while (temp != null)
            {
                if (temp.data == d)
                {
                    if (prev == null)
                    {
                        head = temp.next;
                    }
                    else
                    {
                        prev.next = temp.next;
                    }
                }
                prev = temp;
                temp = temp.next;
            }
        }
        public void Update(string d, string newData)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == d)
                {
                    temp.data = newData;
                }
                temp = temp.next;
            }
        }
    }

namespace WEEK_7_20206277_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            LinkedList Student1 = new LinkedList();
            Console.WriteLine("Student's name: ");
            Student1.Add(Console.ReadLine());
            Console.WriteLine("Student's id: ");
            Student1.Add(Console.ReadLine());
            Console.WriteLine("Student's subject: ");
            Student1.Add(Console.ReadLine());
            Console.WriteLine("Student's grade: ");
            Student1.Add(Console.ReadLine());
            Student1.Print();
            Console.ReadLine();
        }
    }
}
