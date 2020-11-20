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
            int k, numar;
            Console.WriteLine("Aceast program afiseaza a k-a cifra de la sfarsitul unui numar");
            Console.WriteLine();
            Console.Write($"Numarul introdus este : ");
            numar = int.Parse(Console.ReadLine());
            Console.Write("A cata cifra sa fie extrasa ");
            k = int.Parse(Console.ReadLine());
            //532106
            for (int i = 1; i < k; i++)
            {
                numar = numar / 10;
            }
            numar = numar % 10;
            Console.WriteLine($"A {k}-a cifra de la capatul numarului este: {numar}");
            //Console.WriteLine($"A {k}-a cifra de la capatul numarului este: {numar%10}");     //varianta 2 -> se sterge rand 29+30
        }
    }
}
