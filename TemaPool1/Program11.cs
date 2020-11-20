using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program11
    {
        static void Main(string[] args)
        {
            // Afisati in ordine inversa cifrele unui numar n. 

            int n;
            Console.WriteLine("Acest program afisati in ordine inversa cifrele unui numar introdus de la tastatura");
            Console.WriteLine();
            Console.Write("Numarul pe care urmeaza sa fie afisat invers este: ");
            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                Console.Write(n % 10);
                n = n / 10;
            }
            Console.WriteLine();
        }
    }
}
