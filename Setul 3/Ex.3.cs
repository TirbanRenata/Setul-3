using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti lungimea vectorului: ");
            int n=int.Parse(Console.ReadLine());
             int[ ] vector= new int[n];
             for (int i = 0; i < n; i++)
             {
              Console.Write($"Introduceti elementul {i + 1} din vector: ");
                 vector[i]=int.Parse(Console.ReadLine());
            
            }
            int min = vector[0];
            int max = vector[0];
            int minindex=0;
            int maxindex=0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] < min)
                {
                    min = vector[i];
                    minindex = i + 1;
                }
                if (vector[i] > max)
                {
                    max = vector[i];
                    maxindex = i+1;
                }
            }
            Console.WriteLine($"Cel mai mic element este : {min}" );
            Console.WriteLine($"Poziția celui mai mic element este: {minindex}");
            Console.WriteLine($"Cel mai mare element este:{max} ");
            Console.WriteLine($"Poziția celui mai mare element este: {maxindex}");

        }
    }
}
