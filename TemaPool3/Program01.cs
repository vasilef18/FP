using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool3
{
    class Program01
    {
        static void Main(string[] args)
        {
            //Calculati suma elementelor unui vector de n numere citite de la tastatura. 
            //Rezultatul se va afisa pe ecran.

            int n, i, suma = 0;
            Console.WriteLine("Programul calculeaza suma elementelor unui vector de n numere");
            Console.WriteLine();
            Console.Write("Numarul elementelor vectorului este: ");
            n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];

            Console.WriteLine("Elementele vectorului sunt: ");
            for (i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
                suma += vector[i];
            }
            Console.WriteLine($"Suma elementelor este: {suma}");
        }
    }
}
