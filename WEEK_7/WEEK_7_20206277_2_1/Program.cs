using System;

namespace WEEK_7_20206277_2_1
{
    class List
    {
        public int[] arr;
        public int size;
        public int capacity;
        public List( int a)
        {
            capacity = a;
            arr = new int[capacity];
            size = 0;
        }
        public void Add(int x)
        {
            if (size == capacity)
            {
                capacity *= 2;
                int[] temp = new int[capacity];
                for (int i = 0; i < size; i++)
                {
                    temp[i] = arr[i];
                }
                arr = temp;
            }
            arr[size] = x;
            size++;
        }
        public void Remove(int x)
        {
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == x)
                {
                    for (int j = i; j < size - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    size--;
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public int Find(int x)
        {
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == x)
                {
                    Console.WriteLine("Found at index: " + i);
                }
            }
            return -1;
        }
        public void Update(int x, int y)
        {
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == x)
                {
                    arr[i] = y;
                }
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            List l = new List(5);
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            l.Add(5);
            l.Add(6);
            l.Print();
            l.Remove(3);
            l.Print();
            l.Find(4);
            l.Update(1, 10);
            l.Print();
            Console.ReadLine();
        }
    }
}



