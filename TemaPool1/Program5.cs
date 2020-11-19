using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program5
    {
        static void Main(string[] args)
        {
            //Extrageti si afisati a k-a cifra de la sfarsitul unui numar.
            //Cifrele se numara de la dreapta la stanga. 

            Console.ForegroundColor = ConsoleColor.Cyan;
            int numar, k;
            string N;
            Console.WriteLine("Aceast program afiseaza a k-a cifra de la sfarsitul unui numar");
            Console.WriteLine();
            Console.Write($"Numarul introdus este : ");
            numar = int.Parse(Console.ReadLine());
            N = Convert.ToString(numar);
            Console.Write("A cata cifra sa fie extrasa ");
            k = int.Parse(Console.ReadLine());

            for (int i = 0; i <N.Count(); i++)
            {
                if (i == N.Count() - k)
                    Console.WriteLine($"A {k}-a cifra de la capatul numarului este: {N[i]}");
            }
        }
    }
}
