using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool3
{
    class Program03
    {
        static void Main(string[] args)
        {
            //Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.
            //Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 

            int lungimeVector, minim=0, maxim=0, pozitieMinim=0, pozitieMaxim=0;
            Random aleator = new Random();
            Console.WriteLine("Programul determina pozitiile pe care se afla in vector cel mai mic " +
                "si cel mai mare element");
            Console.WriteLine();
            Console.Write("Introduceti numarul de elemente al vectorului: ");
            lungimeVector = int.Parse(Console.ReadLine());
            int[] vector = new int[lungimeVector];

            Console.WriteLine("Elementele vectorului sunt: ");
            for (int i = 0; i < lungimeVector; i++)
            {
                vector[i] = aleator.Next(-100,100);
                Console.WriteLine(vector[i]);
                //vector[i] = int.Parse(Console.ReadLine());
                if (vector[i] < minim)
                {
                    minim = vector[i];
                    pozitieMinim = i;
                }
                if (vector[i] > maxim)
                {
                    maxim = vector[i];
                    pozitieMaxim = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Cel mai mic element este {minim} si se afla pe pozitia {pozitieMinim}");
            Console.WriteLine($"Cel mai mare element este {maxim} si se afla pe pozitia {pozitieMaxim}");
        }
    }
}
