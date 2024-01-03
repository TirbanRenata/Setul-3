using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul vector: ");
            string vector1 = Console.ReadLine();

            Console.Write("Introduceti al doilea vector: ");
            string vector2 = Console.ReadLine();

            int rezultatComparare = string.Compare(vector1, vector2);

            if (rezultatComparare < 0)
            {
                Console.WriteLine($"Vectorul '{vector1}' este inainte de '{vector2}' in ordinea lexicografica.");
            }
            else if (rezultatComparare > 0)
            {
                Console.WriteLine($"Vectorul '{vector2}' este inainte de '{vector1}' in ordinea lexicografica.");
            }
            else
            {
                Console.WriteLine("Vectorii sunt identici din punct de vedere lexicografic.");
            }
        }
    }
}
