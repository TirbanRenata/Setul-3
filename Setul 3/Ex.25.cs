using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._25
{
    internal class Program
    {
            static void Main(string[] args)
           
            {
                Console.Write("Introduceti elementele primului vector:");
            int[] v1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Console.Write("Introduceti elementele celui de-al doilea vector:");
            int[] v2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int[] rezultat = Interclasare(v1, v2);
                Console.Write("Cel de-al treilea vector esre: " + string.Join(", ", rezultat));
                Console.ReadLine();
            }
            static int[] Interclasare(int[] v1, int[] v2)
            {
                int[] rezultat = new int[v1.Length + v2.Length];
                int i = 0, j = 0, k = 0;
                while (i < v1.Length && j < v2.Length)
                {
                    rezultat[k++] = (v1[i] < v2[j]) ? v1[i++] : v2[j++];
                }
                while (i < v1.Length)
                {
                    rezultat[k++] = v1[i++];
                }
                while (j < v2.Length)
                {
                    rezultat[k++] = v2[j++];
                }
                return rezultat;
            }
        
    }
}
    
