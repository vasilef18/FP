using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaLAB
{
    class Program
    {
        static void Main(string[] args)
        {
            //44.Să se scrie un program care memorează 100 de numere aleatoare cuprinse între 0 și 99
            //întrun tablou și care afișează numerele care se repetă în tablou.
            Console.WriteLine("Acest program program creeaza un vector care are valorile date aleator si afiseaza valorile care se repeta");
            Console.WriteLine();
            Console.Write("Elementele vectorului sunt : ");

            int min = 0 , max = 99;
            int[] vector = new int[100];
            Random aleator = new Random();
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = aleator.Next(min,  max);
                Console.Write($"{vector[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Elementele care se repeta sunt : ");
            verificare(vector);
        }

        private static void verificare(int[] vector)
        {
            int contor = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[i] == vector[j])
                    {
                        contor++;
                        Console.Write($"{vector[i]} ");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"In vector sunt {contor} elemente care se repeta");
            Console.WriteLine();
        }
    }
}
