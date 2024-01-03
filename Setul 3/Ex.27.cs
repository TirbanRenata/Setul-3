using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti elementele vectorului separate prin spatiu: ");
            int[] vector = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);


            Console.Write("Introduceti index-ul: ");
            int index = int.Parse(Console.ReadLine());


            if (index < 0 || index >= vector.Length)
            {
                Console.WriteLine("Index invalid. Programul se va opri.");
                return;
            }

            Array.Sort(vector);

            Console.WriteLine("Vectorul sortat: " + string.Join(" ", vector));

            Console.WriteLine($"Valoarea de la index-ul {index} dupa sortare este: {vector[index]}");
        }
    }
}
