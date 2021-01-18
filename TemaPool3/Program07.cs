using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool3
{
    class Program07
    {
        static void Main(string[] args)
        {
            //Reverse. Se da un vector cu n elemente. Se cere sa se inverseze ordinea elementelor din vector.
            //Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.

            int lungimeVector;
            Random aleator = new Random();
            Console.WriteLine("Programul inverseaza ordina elementelor din vector astfel primul" +
                " element devine ultimul, al doilea devine penultimul, etc.\n");
            Console.Write("Dati numarul de elemente al vectorului: ");
            lungimeVector = int.Parse(Console.ReadLine());
            int[] vector = new int[lungimeVector];
            Console.Write("Elementele vectorului sunt: ");
            for (int i = 0; i < lungimeVector; i++)
            {
                vector[i] = aleator.Next(-50, 50);
                Console.Write($"{vector[i]} ");
            }
            Console.WriteLine();
            revers(vector,lungimeVector);

            int p = 1;
            for (int i = 0; i < lungimeVector; i++)
            {
                vector[i] = vector[lungimeVector - p];
                p++;
                Console.Write($"{vector[i]} ");
            }
        }
        private static void revers(int []vector, int lungimeVector)
        {
            Array.Reverse(vector);
            Console.Write("Vectorul invers este: ");
            for (int i = 0; i < lungimeVector; i++)
            {
                Console.Write($"{vector[i]} ");
            }
            Console.WriteLine();
        }
    }
}
