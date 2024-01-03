using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex12
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

            SelectionSortAlgorithm(arr);

            Console.WriteLine("Algoritmul sortat:");
            PrintArray(arr);
        }

        static void SelectionSortAlgorithm(int[] arr)
        {
            int n = arr.Length;


            for (int i = 0; i < n - 1; i++)
            {

                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }


                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }


        static void PrintArray(int[] arr)
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