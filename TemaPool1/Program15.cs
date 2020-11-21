using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program15
    {
        static void Main(string[] args)
        {
            //Se dau 3 numere. Sa se afiseze in ordine crescatoare.

            int a, b, c;
            Console.WriteLine("Acest program ordoneaza crescator 3 numere introduse de la tastatura");
            Console.WriteLine();
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());

            if (a < b && a < c)
                if (b < c)
                    Console.WriteLine($"Numerele ordonate crescator sunt: {a} , {b} , {c}");
                else
                    Console.WriteLine($"Numerele ordonate crescator sunt: {a} , {c} , {b}");
            if (b < a && b < c)
                if (a < c)
                    Console.WriteLine($"Numerele ordonate crescator sunt: {b} , {a} , {c}");
                else
                    Console.WriteLine($"Numerele ordonate crescator sunt: {b} , {c} , {a}");
            if (c < a && c < b)
                if (a < b)
                    Console.WriteLine($"Numerele ordonate crescator sunt: {c} , {a} , {b}");
                else
                    Console.WriteLine($"Numerele ordonate crescator sunt: {c} , {b} , {a}");
        }
    }
}
