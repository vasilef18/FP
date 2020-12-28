using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool2
{
    class Program03
    {
        static void Main(string[] args)
        {
            //Calculati suma si produsul numerelor de la 1 la n.

            int i, nrNumere, suma = 0;
            double produs = 1;
            Console.WriteLine("Programul calculeaza suma si produsul numerelor de la 1 la n");
            Console.WriteLine();
            Console.Write("Secventa de numere va incepe de la 1 si va contine elemente pana la :");
            nrNumere = int.Parse(Console.ReadLine());

            Console.Write("Numerele din serie sunt: ");
            for (i = 1; i < nrNumere; i++)
            {
                Console.Write($"{i} ");
                suma = suma + i;
                produs = produs * i;
            }
            Console.WriteLine();
            Console.WriteLine($"Suma numerelor din secventa este :{suma}");
            Console.WriteLine($"Produsul numerelor din secventa este :{produs}");
        }
    }
}
