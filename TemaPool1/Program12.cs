using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program12
    {
        static void Main(string[] args)
        {
            //Determinati cate numere intregi divizibile cu n se afla in intervalul [a, b]. 

            int a, b, n, nr=0;
            Console.WriteLine("Acest program determina cate numere intregi divizibile cu n se afla in intervalul [a, b]. ");
            Console.WriteLine();
            Console.Write("Limita stanga a intervalului este: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Limita dreapta a intervalului este: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Avem intervalul [{a}, {b}]");
            Console.WriteLine();
            Console.Write("Numarul care urmeaza sa se divida cu numerele din interval este: ");
            n = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                {
                    //Console.WriteLine($"{n} il divide pe {i}");       //metoda de verificare a numarului divizorilor
                    nr++;
                }
            }
            Console.WriteLine($"avem {nr} divizori");
        }
    }
}
