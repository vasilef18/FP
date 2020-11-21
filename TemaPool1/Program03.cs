using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program03
    {
        static void Main(string[] args)
        {
            //Determinati daca n se divide cu k, unde n si k sunt date de intrare. 

            Console.ForegroundColor = ConsoleColor.Cyan;
            int n, k;
            Console.WriteLine("Aceast program determina daca n il divide pe k");
            Console.WriteLine();
            Console.Write("n=");
            n=int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());

            if (n % k == 0)
                Console.WriteLine($"{n} se divide cu {k}");
            else
                Console.WriteLine($"{n} NU se divide cu {k}");
        }
    }
}
