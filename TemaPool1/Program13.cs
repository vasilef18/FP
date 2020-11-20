using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool1
{
    class Program13
    {
        static void Main(string[] args)
        {
            //Determianti cati ani bisecti sunt intre anii y1 si y2.

            int an1, an2, ok=0;
            Console.WriteLine("Acest program determina cati ani bisecti sunt intre 2 ani introdusi de la tastatura");
            Console.WriteLine();
            Console.Write("Calculul v-a incepe de la anul: ");
            an1 = int.Parse(Console.ReadLine());
            Console.Write("Calculul se va incheia cu anul: ");
            an2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = an1; i <= an2; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
                {
                    //Console.WriteLine($"{i}");           //metoda de verificare
                    ok++;
                }
            }
            Console.WriteLine($"Intre anii {an1} si {an2} sunt {ok} ani bisecti");
        }
    }
}
