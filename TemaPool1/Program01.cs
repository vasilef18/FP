using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program01
    {
        static void Main(string[] args)
        {
            //Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 

            Console.ForegroundColor = ConsoleColor.Cyan;
            float a, b, x;
            Console.WriteLine("Aceast program rezolva o ecuatie de grad I ax+b=0 ");
            Console.WriteLine();
            Console.Write("a=");
            a = float.Parse(Console.ReadLine());
            Console.Write("b=");
            b = float.Parse(Console.ReadLine());
            x = -b / a;
            Console.WriteLine();
            Console.WriteLine($"Ecuatia este {a}x + b");
            Console.WriteLine($"x = {x} ");
           
        }
    }
}
