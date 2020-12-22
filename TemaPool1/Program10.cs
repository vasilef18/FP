using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program10
    {
        static void Main(string[] args)
        {
            //Test de primalitate: determinati daca un numar n este prim.

            int n, ok=0;
            Console.WriteLine("Acest program determina daca un numar este prim sau nu");
            Console.WriteLine();
            Console.Write("Numarul introdus pentru a fi verificat este :  ");
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                    Console.WriteLine(n);
                    ok = 1;
            }
            if (ok == 0)
                Console.WriteLine($"Numarul {n} este prim");
            else
                Console.WriteLine($"Numarul {n} NU este prim");
        }
    }
}
