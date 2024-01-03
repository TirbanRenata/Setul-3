using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._4
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
                vector[i] = int.Parse(Console.ReadLine());
            }
            int min = vector[0];
            int max = vector[0];
            int k1= 0;
            int k2 = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] < min)
                {
                    min = vector[i];
                    k1 = 1;
                }
                else
                {
                    if (vector[i] == min)
                        k1++;
                }


                if (vector[i] > max)
                {
                    max = vector[i];
                }
                else
                {
                    if (vector[i] == max)

                        k2++;

                }
            }
            Console.WriteLine($"Cea mai mica valoare din vector este: {min} si apare de {k1} ori");
            Console.WriteLine($"Cea mai mare valoare din vector este: {max} si apare de {k2} ori");
        }
        
    }
}
