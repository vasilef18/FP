using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program17
    {
        static void Main(string[] args)
        {
            // Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere.
            //Folositi algoritmul lui Euclid.

            int a, b, c, d, cmmmc=0, produs;
            Console.WriteLine("Acest program determina cel mai mare divizor comun si cel mai mic multiplu comun a doua numere.");
            Console.WriteLine();
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            c = a;
            d = b;
            //CMMDC
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
                Console.WriteLine($"Cel Mai Mare Divizor Comun este: {a}");
            
            /*while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            Console.WriteLine($"Cel Mai Mare Divizor Comun este: {a}");
            */
            //CMMMC
            produs = c * d;
            while (c != d)
            {
                if (c > d)
                    c = c - d;
                else
                    d = d - c;
            }
            cmmmc = produs / d;
            Console.WriteLine($"Cel Mai Mic Multiplu Comun este: {cmmmc}");
        }
    }
}
