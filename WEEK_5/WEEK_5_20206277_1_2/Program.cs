// Nguyễn Quang Dũng - 20206277
using System;

namespace WEEK_5_20206277_1_2
{
    class Program
    {
        static void merge(double[] array, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;
            double[] L = new double[n1];
            double[] R = new double[n2];
            for (i = 0; i < n1; i++)
                L[i] = array[l + i];
            for (j = 0; j < n2; j++)
                R[j] = array[m + 1 + j];
            i = 0;
            j = 0;
            k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                array[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                array[k] = R[j];
                j++;
                k++;
            }
        }
        static void mergeSort(double[] array, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                mergeSort(array, l, m);
                mergeSort(array, m + 1, r);
                merge(array, l, m, r);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element: ");
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            mergeSort(array, 0, array.Length - 1);
            Console.WriteLine("Sorted array using merge sort : ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.ReadLine();
        }
    }
  
}

