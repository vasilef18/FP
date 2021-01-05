using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool3
{
    class Program02
    {
        static void Main(string[] args)
        {
            //Se da un vector cu n elemente si o valoare k. Se cere sa se determine 
            //prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. 

            int n, k, i, ok = 0, pozitie = 0;
            Random aleator = new Random();
            Console.WriteLine("Programul determina prima pozitie pe care apare in vector un element" +
                " k citit de la tastatura.");
            Console.WriteLine();
            Console.Write("Dati numarul de elemente al vectorului: ");
            n = int.Parse(Console.ReadLine());
            Console.Write($"Elementul cautat in vector este: ");
            k = int.Parse(Console.ReadLine());
            int[] vector = new int[n];

            Console.Write("Elementele vectorului sunt: ");
            for (i = 0; i < n; i++)
            {
                vector[i] = aleator.Next(0, 5);
                Console.Write($"{vector[i]} ");
                if (vector[i] == k)
                {
                    ok = 1;
                    pozitie = i;
                    break;
                }
            }
            Console.WriteLine();
            if (ok == 1)
            {
                Console.WriteLine($"Elementul {k} apare prima data in vector pe pozitia {pozitie}");
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
