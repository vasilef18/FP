using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program14
    {
        static void Main(string[] args)
        {
            //Determianti daca un numar n este palindrom.
            //(un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 

            int n, rezultat=0, cifra, invers;
            Console.WriteLine("Acest program determina daca un numar este palindrom");
            Console.WriteLine("De exemplu 12321, dar 123456 NU este palindrom");
            Console.WriteLine("");
            Console.Write("Se va verifica numarul: ");
            n = int.Parse(Console.ReadLine());
            //invers = n;

            while (n>0)
            {
                cifra = n % 10;
                n = n / 10;
                rezultat = rezultat  * 10 + cifra;
            }
            if (rezultat == n)
            {
                Console.WriteLine($"Numarul {rezultat} este palindrom");
            }
            else
                Console.WriteLine($"Numarul {rezultat} NU este palindrom");
        }
    }
}
