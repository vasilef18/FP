using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program20
    {
        static void Main(string[] args)
        {
            //Afisati fractia m / n in format zecimal, cu perioada intre paranteze(daca e cazul).Exemplu: 13 / 30 = 0.4(3).

            int m, n;
            double rezultat;
            Console.WriteLine("Acest program afiseaza fractia m/n in format zecimal");
            Console.WriteLine();
            Console.Write("m=");
            m = int.Parse(Console.ReadLine());
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            rezultat = m / n;
            Console.WriteLine($"Rezultatul fractie {m}/{n} este {rezultat}");
        }
    }
}
