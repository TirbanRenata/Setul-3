using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti lungimea vectorului: ");
                int lungime=Convert.ToInt32(Console.ReadLine());
            int vector = new int[lungime];
            for (int i = 0; i < lungime; i++)
            {
                Console.WriteLine($"Introduceti elementul {i + 1}: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
                int suma = 0;
                for (int i = 0; i< lungime; i++)
                {
                    suma += vector[i];
                    Console.WriteLine($"Suma elementelor vectorului este:{suma}");
                }
            }
        }
    }
}
