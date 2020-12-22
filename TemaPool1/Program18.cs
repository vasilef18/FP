using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program18
    {
        static void Main(string[] args)
        {
            //Afisati descompunerea in factori primi ai unui numar n.
            //De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2. 

            int n, m, contor;
            Console.WriteLine("Acest program afiseaza descompunerea in factori primi ai unui numar");
            Console.WriteLine();
            Console.Write("Numarul care urmeaza sa fie descompus este: ");
            n = int.Parse(Console.ReadLine());
            m = n;

            for (int divizor = 2;  divizor <= n / 2; divizor++)
            {
                if (m % divizor == 0)
                {
                    contor = 0;
                    while (m % divizor == 0)
                    {
                        contor++;
                        m = m / divizor;
                    }
                    Console.Write($"{divizor}^{contor}*");
                }

                if (m == 1)
                    break;
            }
            Console.WriteLine("1");
        }
    }
}
