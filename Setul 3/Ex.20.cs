using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul sir de margele: ");
            string s1 = Console.ReadLine(); 
            Console.Write("Introduceti al doilea sir de margele: ");
            string s2 = Console.ReadLine();

           int numarSuprapuneri = NumarSuprapuneri(s1, s2);
            Console.WriteLine($"Numarul de suprapuneri posibile este: {numarSuprapuneri}");
        }

        private static int NumarSuprapuneri(string s1, string s2)
        {
            int nrTotal = 0;

            for (int rotatie = 0; rotatie < s1.Length; rotatie++)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    string suprapunere = s1.Substring(i) + s1.Substring(0, i);
                    for (int j = 0; j < s2.Length; j++)
                    {
                        if (suprapunere[j] == s2[j])
                        {
                            nrTotal++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return nrTotal;
        }
        
    }
}
