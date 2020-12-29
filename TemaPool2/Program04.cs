using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool2
{
    class Program04
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a.
            //Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla
            //in secventa raspunsul va fi -1. 

            int numar, lungimeSecventa, nrCautat = 0;
            string pozitie="";
            Random aleator = new Random();
            Console.WriteLine("Programul determina pe ce pozitie se afla in secventa un numar a");
            Console.WriteLine();
            Console.Write("Introduceti lungimea secventei: ");
            lungimeSecventa = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Elementul cautat este: ");
            nrCautat = int.Parse(Console.ReadLine());
            Console.Write("Elementele secventei sunt: ");
            for (int i = 0; i <= lungimeSecventa; i++)
            {
                numar = aleator.Next(5);
                Console.Write($"{ numar}, ");
                if (nrCautat == numar)
                {
                    pozitie += $"{i}, ";
                }
            }
            Console.WriteLine();
            if (pozitie != "")
            {
                Console.Write($"Elementul cautat este pe pozitia {pozitie}");
            }
            else
            {
                Console.WriteLine($"-1");
            }
            Console.WriteLine();
        }
    }
}
