using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._7
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
                Console.Write($"Introduceti elementul {i+1} din vector: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            InverseazaVector(vector);


            Console.WriteLine("Vectorul inversat:");
            AfisareVector(vector);
        }

        static void InverseazaVector(int[] vector)
        {
            int n = vector.Length;
            for (int i = 0; i < n / 2; i++)
            {

                int temp = vector[i];
                vector[i] = vector[n - i - 1];
                vector[n - i - 1] = temp;
            }
        }
        static void AfisareVector(int[] vector)
        {
            foreach (var element in vector)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
    
}
