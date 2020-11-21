using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program06
    {
        static void Main(string[] args)
        {
            //Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.

            Console.ForegroundColor = ConsoleColor.Cyan;
            int a, b, c;
            Console.WriteLine("Acest program determina daca 3 numere pozitive pot fi lungimile laturilor unui triunghi");
            Console.WriteLine();
            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            c = int.Parse(Console.ReadLine());
            if (a <= b + c && b <= a + c && c <= a + b)
                Console.WriteLine("Se poate forma un triunghi");
            else
                Console.WriteLine("NU se poate forma triunghi");
        }
    }
}
