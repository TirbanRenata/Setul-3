using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._6
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
                Console.Write($"Introduceti elementul {i } din vector: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Introduceti pozitia pe care doriti sa o stergeti: ");
            int k=Convert.ToInt32(Console.ReadLine());
            if(k<0 || k>=n)
            {
                Console.WriteLine("Pozitia introdusa nu exista.");
                return;
            }
            
            for (int i = k; i < n-1 ; i++)
            {
                vector[i] = vector[i + 1];
            }

            Array.Resize(ref vector, n-1 );

            Console.WriteLine("Vectorul rezultat este: ");
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(vector[i]+" ");
            }
        }
    }
}
