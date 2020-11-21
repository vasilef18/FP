using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program8
    {
        static void Main(string[] args)
        {
            //(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
            //Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare. 

            Console.ForegroundColor = ConsoleColor.Cyan;
            int a, b;
            Console.WriteLine("Acest program inverseaza valoarea lui a cu cea a lui b FARA a folosi o variabila suplimentara");
            Console.WriteLine();
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Dupa schimb a={b} si b={a}"); 
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Dupa schimb a={a} si b={b}");
        }
    }
}
