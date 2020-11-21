using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program04
    {
        static void Main(string[] args)
        {
            //Detreminati daca un an y este an bisect. 

            Console.ForegroundColor = ConsoleColor.Cyan;
            int an;
            Console.WriteLine("Acest program determina daca un an dat de la tastarura este bisect sau nu");
            Console.WriteLine();
            Console.Write("Introduceti an : ");
            an = int.Parse(Console.ReadLine());

            if ((an % 4 == 0 && an % 100 != 0) || (an % 400 == 0))
            {
                Console.WriteLine($"Anul {an} este bisesct");
            }
            else
                Console.WriteLine($"Anul {an} NU este bisect");
        }
    }
}
