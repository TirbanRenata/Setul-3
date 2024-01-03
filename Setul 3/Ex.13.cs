using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti lungimea vectorului:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            InsertionSort(arr);

            Console.WriteLine("Algoritmul sortat:");
            PrintArray(arr);
        }

            private static void InsertionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; ++i)
            {
                int k = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > k)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
             
                arr[j + 1] = k;
            }
        }

        private static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
