using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program21
    {
        static void Main(string[] args)
        {
            //Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 

            int x, numar;
            Random aleator = new Random();
            numar = aleator.Next(1, 1025);
            Console.WriteLine("Acest program genereaza un numar aleator intre 1 si 1024. Ghiciti numarul");
            Console.WriteLine();

            do
            {
                x = int.Parse(Console.ReadLine());
                Console.WriteLine($"Numarul este mai mare sau egal decat {x}? ");
                if (x == numar)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Felicitari ! Numarul aleator este {numar}");
                    Console.WriteLine();
                    break;
                }
                if (x < numar)
                {
                    Console.WriteLine("DA");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("NU");
                    Console.WriteLine();
                }
            } 
            while (x != numar);
        }      
    }
}
