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
            Console.WriteLine("Acest program genereaza un numar aleator intre 1 si 1024. Ghiciti acest numar");
            Console.WriteLine();

            do
            {
                Console.Write("Introduceti numar: ");
                x = int.Parse(Console.ReadLine());
                if (x == numar)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Felicitari ! Numarul aleator este {numar}");
                    Console.WriteLine();
                    break;
                }
                if (x < numar)
                {
                    Console.WriteLine("Introduceti un numar mai MARE");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Introduceti un numar mai MIC");
                    Console.WriteLine();
                }
            } 
            while (x != numar);
        }      
    }
}
