using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program9
    {
        static void Main(string[] args)
        {
            //Afisati toti divizorii numarului n.

            int n;
            Console.WriteLine("Acest program afisati toti divizorii numarului n");
            Console.WriteLine();
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write($"Divizori lui {n} sunt: ");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write($" , {i}");
                }
            }
            Console.WriteLine();
        }
    }
}
