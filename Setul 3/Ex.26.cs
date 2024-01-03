using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET3._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti primul numar:");
            string n1 = Console.ReadLine();
            Console.WriteLine("Introduceti al doilea numar:");
            string n2 = Console.ReadLine();
            AfiseazaRezultat("Suma", Aduna(n1, n2));
            AfiseazaRezultat("Diferenta", Scade(n1, n2));
            AfiseazaRezultat("Produs", Inmulteste(n1, n2));
            Console.ReadLine();
        }
        static void AfiseazaRezultat(string operatie, string rezultat)
        {
            Console.WriteLine($"{operatie}: {rezultat}");
        }

        static string Aduna(string n1, string n2) => AdunaScade(n1, n2, false);


        static string Scade(string n1, string n2) => AdunaScade(n1, n2, true);

        static string AdunaScade(string n1, string n2, bool scadere)
        {
            int lungimeMaxima = Math.Max(n1.Length, n2.Length);
            int carry = 0;
            string rezultat = "";
            for (int i = 1; i <= lungimeMaxima || carry > 0; i++)
            {
                int cifra1 = (i <= n1.Length) ? int.Parse(n1[n1.Length - i].ToString()) : 0;
                int cifra2 = (i <= n2.Length) ? int.Parse(n2[n2.Length - i].ToString()) : 0;
                int suma = scadere ? cifra1 - cifra2 - carry : cifra1 + cifra2 + carry;
                if (scadere)
                {
                    if (suma < 0)
                    {
                        suma += 10;
                        carry = 1;
                    }
                    else
                    {
                        carry = 0;
                    }
                }
                else
                {
                    carry = suma / 10;
                }
                rezultat = suma % 10 + rezultat;
            }
            return rezultat.TrimStart('0') == "" ? "0" : rezultat.TrimStart('0');
        }
        static string Inmulteste(string n1, string n2)
        {
            string produs = "0";
            for (int i = n2.Length - 1; i >= 0; i--)
            {
                int cifra2 = int.Parse(n2[i].ToString());
                int carry = 0;
                string partial = "";
                for (int j = n1.Length - 1; j >= 0 || carry > 0; j--)
                {
                    int cifra1 = (j >= 0) ? int.Parse(n1[j].ToString()) : 0;
                    int temp = cifra1 * cifra2 + carry;
                    partial = temp % 10 + partial;
                    carry = temp / 10;
                }
                partial += new string('0', n2.Length - 1 - i);
                produs = Aduna(produs, partial);
            }
            return produs;
        }
    }
}
