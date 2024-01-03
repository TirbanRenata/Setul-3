using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._10
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
            Console.Write("Introduceti elementul pentru care doriti sa gasiti pozitia k: ");
            int k = int.Parse(Console.ReadLine());


            int poz = CautareBinara(vector, k);


            if (poz != -1)
            {
                Console.WriteLine($"Elementul {k} se afla pe pozitia {poz + 1} in vector.");
            }
            else
            {
                Console.WriteLine($"Rezultatul este -1. ");
            }
        }

        static int CautareBinara(int[] vector, int k)
        {
            int stanga = 0;
            int dreapta = vector.Length - 1;

            while (stanga <= dreapta)
            {
                int mijloc = stanga + (dreapta - stanga) / 2;

              
                if (vector[mijloc] == k)
                {
                    return mijloc;
                }

                
                if (vector[mijloc] > k)
                {
                    dreapta = mijloc - 1;
                }
           
                else
                {
                    stanga = mijloc + 1;
                }
            }

           
            return -1;
        }
    }
}
