using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorului: ");

            int n = int.Parse(Console.ReadLine());
            int[] vector=new int[n];
           
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1} din vector: ");
                vector[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("Introduceti elementul k: ");
            int k = int.Parse((string)Console.ReadLine());
          
            int position = -1;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == k)
                {
                    position = i;
                      break;
                }
                
            }

            Console.WriteLine($"Prima pozitie din vector pe care apare {k} este: {position}");
        }
    }
}
