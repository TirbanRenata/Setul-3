using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._9
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
            Console.WriteLine("Introduceti elementul k: ");
            int k=Convert.ToInt32(Console.ReadLine());
            int[] RotireVector = new int[vector.Length];
            for (int i = 0; i < vector.Length; i++)
            {
                int newIndex = (i + vector.Length - k) % vector.Length;

                RotireVector[newIndex] = vector[i];
            }
            foreach (int element in RotireVector)
            {
                Console.Write(element + " ");
            }
        }
    }
}
