using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._16
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
            

            int gcd = GCDOfArray(vector);
            Console.WriteLine($"Cel mai mare divizor comun al elementelor vectorului este: {gcd}");
        }

        public static int GCD(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }

            public static int GCDOfArray(int[] array)
            {
                int result = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    result = GCD(result, array[i]);
                }
                return result;
            }
        
    }
}
