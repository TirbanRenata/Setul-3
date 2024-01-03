using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti vectorul s, separat prin spatiu: ");
            int[] s = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.Write("Introduceti vectorul p, separat prin spatiu): ");
            int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int rezultat = NrAparitii(s, p);
            Console.WriteLine($"Vectorul p apare in vectorul s de {rezultat} ori.");
        }

        private static int NrAparitii(int[] s, int[] p)
        {
            int nrAparitii = 0;

            if (s.Length < p.Length)
            {
                return 0; 
            }

            for (int i = 0; i <= s.Length - p.Length; i++)
            {
                bool sePotriveste = true;

                for (int j = 0; j < p.Length; j++)
                {
                    if (s[i + j] != p[j])
                    {
                        sePotriveste = false;
                        break;
                    }
                }

                if (sePotriveste)
                {
                    nrAparitii++;
                }
            }

            return nrAparitii;
        }
    }
}
