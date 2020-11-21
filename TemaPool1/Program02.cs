using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program2
    {
        static void Main(string[] args)
        {
            //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, 
            //unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.

            Console.ForegroundColor = ConsoleColor.Cyan;
            double a, b, c, x1, x2, delta;
            Console.WriteLine("Aceast program rezolva o ecuatie de grad II cu o necunoscuta x, ax^2 + bx + c = 0");
            Console.WriteLine();
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine($"Ecuatia este: {a}x^2 + {b}x + {c}");
            Console.WriteLine();

            delta = Math.Sqrt(b * b - 4 * a * c);

            x1 = (-b + delta) / (2 * a);
            x2 = (-b - delta) / (2 * a);

            if (delta>0)
            {
                Console.WriteLine($"Delta={delta:0.00}");
                Console.WriteLine($"Ecuatia are 2 radaci diferite x1= {x1:0.00} si x2= {x2:0.00}");
            }
            else
                if (delta==0)
            {
                Console.WriteLine($"Delta={delta:0.00}");
                Console.WriteLine($"Ecuatia are radacinile x1={x1:0.00} si x2={x2:0.00} ");
            }
            else
                Console.WriteLine("Ecuatia nu are solutii reale");
                
        }
    }
}
