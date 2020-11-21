using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program07
    {
        static void Main(string[] args)
        {
            //(Swap) Se dau doua variabile numerice a si b ale caror valori sunt date de intrare.
            //Se cere sa se inverseze valorile lor. 

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            int a, b, schimb;
            Console.WriteLine("Acest program inverseaza valoarea lui a cu cea a lui b");
            Console.WriteLine();
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            schimb = a;
            a = b;
            b = schimb;

            Console.WriteLine();
            Console.WriteLine($"Dupa schimb a={a} si b={b}");
        }
    }
}
