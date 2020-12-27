using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool2
{
    class Program01
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere.Sa se determine cate din ele sunt pare. 

            int nrnumere=0, numar=0,contor=0;
            Console.WriteLine("Programul determina cate dintre numerele introduse sunt pare");
            Console.WriteLine();
            Console.Write("Cate elemente va avea secventa de numere:");
            nrnumere = int.Parse(Console.ReadLine());

            for (int i = 1; i < nrnumere+1; i++)
            {
                Console.Write($"Numarul {i} este :");
                numar = int.Parse(Console.ReadLine());
                if (numar%2 == 0)
                {
                    contor++;
                }
            }
            
            Console.WriteLine($"Secventa introdusa contine {contor} numere pare");
        }
    }
}
