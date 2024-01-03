using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._5
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
           
            Console.WriteLine("Introduceti pozitia k: ");
            int k=Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Introduceti noua valoare:");
             int e = Convert.ToInt32(Console.ReadLine());

            if (k < 0 || k > n)
            {
                Console.WriteLine("Pozitia nu exista.");
                return;
            }

            
            int[] VectorNou = new int[n + 1];

            for (int i = 0; i < k; i++)
            {
                VectorNou[i] = vector[i];
            }

            VectorNou[k] = e;

            for (int i = k + 1; i < n + 1; i++)
            {
                VectorNou[i] = vector[i - 1];
            }

            Console.WriteLine("Vectorul rezultat dupa inserare este:");
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write(VectorNou[i] + " ");
            }
            Console.WriteLine();
        }
    
    }
}
