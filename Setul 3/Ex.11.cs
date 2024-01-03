using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._11
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
            
                bool[] estePrim = new bool[n + 1];

                for (int i = 0; i <= n; i++)
                {
                    estePrim[i] = true;
                }

                for (int p = 2; p * p <= n; p++)
                {

                    if (estePrim[p] == true)
                    {

                        for (int i = p * p; i <= n; i += p)
                        {
                            estePrim[i] = false;
                        }
                    }
                }
                Console.WriteLine($"Numerele prime mai mici sau egale cu {n} sunt:");
                for (int i = 2; i <= n; i++)
                {
                    if (estePrim[i])
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
        }
        
    }
}
