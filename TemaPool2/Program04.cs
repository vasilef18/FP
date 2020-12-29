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

            int numar, lungimeSecventa, nrCautat=0, pozitie=0;
            Random aleator = new Random();
            Console.WriteLine("Programul determina pe ce pozitie se afla in secventa un numar a");
            Console.WriteLine();
            Console.Write("Introduceti lungimea secventei: ");
            lungimeSecventa = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Elementul cautat este: ");
            nrCautat = int.Parse(Console.ReadLine());
            Console.Write("Elementele secventei sunt: ");
            for (int i = 0; i < lungimeSecventa; i++)
            {
                numar = aleator.Next(5);
                Console.Write($"{ numar}, ");
                if (nrCautat == numar)
                {
                    pozitie = i;
                    //TODO daca numarul se repeta sa afisez toate pozitiile pe care se repeta
                }
            }
            Console.WriteLine();
            if (pozitie>0)
            {
                Console.WriteLine($"Elementul cautat este pe pozitia {pozitie}");
            }
            else
            {
                Console.WriteLine($"Elementul cautat NU exista in secventa");
            }
        }
    }
}
