using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool2
{
    class Program02
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.

            int nrNumere, numar, negativ=0, zero=0, pozitiv=0;
            Console.WriteLine("Programul determina cate dintre numerele introduse de la tastatura sunt" +
                " negative, zero sau pozitive");
            Console.WriteLine();
            Console.Write("Introduceti lungimea secventei de numere :");
            nrNumere = int.Parse(Console.ReadLine());

            for (int i = 1; i < nrNumere+1; i++)
            {
                Console.Write($"Numarul {i} este :");
                numar = int.Parse(Console.ReadLine());
                if (numar < 0)
                {
                    negativ++;
                }
                if (numar == 0)
                {
                    zero++;
                }
                if (numar > 0)
                {
                    pozitiv++;
                }
            }
            Console.WriteLine($"In secventa introdusa sunt {negativ} numere negative, {zero} numere zero si " +
                $" {pozitiv} numere pozitive");
        }
    }
}
