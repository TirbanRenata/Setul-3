using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul in baza 10: ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti baza b: ");
            int b=Convert.ToInt32(Console.ReadLine());
            if (b < 2 || b > 16)
            {
                Console.WriteLine("Baza introdusa trebuie sa fie intre 2 si 16.");
            }
                string rez = ConvertToBase(n, b);
                Console.WriteLine($"Numarul {n} convertit in baza {b} este: {rez} ");
            
        }

        private static string ConvertToBase(int n, int b)
        {
            char[] cifrePeste9 = "ABCDEF".ToCharArray();
            if (n == 0)
            {
                Console.WriteLine("Rezultatul este 0.");

            }
            string rez = "";
            while (n > 0)
            {
                int rest = n % b;
                if (rest > 9)
                {
                    rez = cifrePeste9[rest - 10] + rez;
                }
                else
                {
                    rez = rest + rez;
                }
                n /= b;
            }
            return rez;
        }
        
            
        

    }
}

