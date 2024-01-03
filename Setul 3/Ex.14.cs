using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1} din vector: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());

            }
            SortareVector(vector);
          
            Console.WriteLine("\nVectorul sortat:");
            AfiseazaVector(vector);

        }


        private static void SortareVector(int[] vector)
        {
            int n = vector.Length;
            int index = 0;


            for (int i = 0; i < n; i++)
            {
                if (vector[i] != 0)
                {
                    int temp = vector[i];
                    vector[i] = vector[index];
                    vector[index] = temp;

                    index++;
                }
            }
        }
        static void AfiseazaVector(int[] vector)
        {
            foreach (var element in vector)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

    }
}
