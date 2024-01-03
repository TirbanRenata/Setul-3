using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._15
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
            EliminaDuplicate(vector);
            Console.WriteLine("Vectorul fara duplicate:");
            for (int i = 0; i < n; i++)
                if (vector[i] != 0)
                    Console.Write(vector[i] + " ");
            Console.WriteLine();


        }
        static void EliminaDuplicate(int[] vector)
        {
            int n = vector.Length;

            for (int i = 0; i < n; i++)
            {

                if (vector[i] != 0)
                {

                    for (int j = i + 1; j < n; j++)
                    {
                        if (vector[j] == vector[i])
                        {
                            vector[j] = 0; 
                        }
                    }
                }
            }
        }
       
    }
}