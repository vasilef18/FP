using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program16
    {
        static void Main(string[] args)
        {
            //Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri).

            int a, b, c, d, e, stocare;
            Console.WriteLine("Acest program ordoneaza crescator 5 numere introduse de la tastatura");
            Console.WriteLine();
            Console.Write("a=");
            Random rnd = new Random(a);
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());
            Console.Write("d=");
            d = int.Parse(Console.ReadLine());
            Console.Write("e=");
            e = int.Parse(Console.ReadLine());

            if (a > b)
            {
                stocare = a; a = b; b = stocare;
            }
            if (a > c)
            {
                stocare = a; a = c; c = stocare;
            }
            if (a > d)
            {
                stocare = a; a = d; d = stocare;
            }
            if (a > e)
            {
                stocare = a; a = e; e = stocare;
            }
            if (b > c)
            {
                stocare = b; b = c; c = stocare;
            }
            if (b > d)
            {
                stocare = b; b = d; d = stocare;
            }
            if (b > e)
            {
                stocare = b; b = e; e = stocare;
            }
            if (c > d)
            {
                stocare = c; c = d; d = stocare;
            }
            if (c > e)
            {
                stocare = c; c = e; e = stocare;
            }
            if (d > e)
            {
                stocare = d; d = e; e = stocare;
            }
            Console.WriteLine($"Numerele ordonate crescator sunt: {a} , {b} , {c} , {d} , {e}");
        }
    }
}
