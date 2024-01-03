using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti gradul polinomului: "); 
            int n=int.Parse(Console.ReadLine());
            double[] coeficienti=new double[n+1];
            Console.WriteLine("Introduceti coeficientii polinomului de la cel mai mare la cel mai mic grad:");

            for (int i = n; i>=0; i--)
            {
                Console.Write($"Coeficient pentru x^{i}: ");
                coeficienti[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("Introduceti valoarea lui x in care sa se evalueze polinomul: ");
            double x = double.Parse(Console.ReadLine());
    
            double rezultat = CalculPolinom(coeficienti, x);
            Console.WriteLine($"Valoarea polinomului in punctul {x} este: {rezultat}");
        }

        private static double CalculPolinom(double[] coeficienti, double x)
        {
            double rezultat = 0;

            for (int i = 0; i < coeficienti.Length; i++)
            {
                rezultat += coeficienti[i] * Math.Pow(x, i);
            }

            return rezultat;
        }
    }
}
