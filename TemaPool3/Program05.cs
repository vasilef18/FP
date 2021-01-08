using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool3
{
    class Program05
    {
        static void Main(string[] args)
        {
            //Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e 
            //in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. 

            int lungimeVector, e=0, k=0, i;
            Random aleator = new Random();
            Console.WriteLine("Programul insereaza o valoare e pe o pozitie k intr-un vector");
            Console.WriteLine();
            Console.Write("Dati numarul de elemente al vectorului: ");
            lungimeVector = int.Parse(Console.ReadLine());
            int[] vectorInitial = new int[lungimeVector];
            
            Console.WriteLine("Vectorul initial este:");
            for (i = 0; i < lungimeVector; i++)
            {
                vectorInitial[i] = aleator.Next(0, 50);
                Console.WriteLine(vectorInitial[i]);
            }
            Console.Write("\nElementul dorit pentru inserare este: ");
            e = int.Parse(Console.ReadLine());
            Console.Write("Elementul va fi introdus pe pozitia: ");
            k = int.Parse(Console.ReadLine());
            int[] vectorFinal = new int[lungimeVector + 1];
            Console.WriteLine("\nVectorul final este:");
            for (i = 0; i < lungimeVector+1; i++)
            {
                if (i < k)
                {
                    vectorFinal[i] = vectorInitial[i];
                }
                else
                {
                    if (i==k)
                    {
                        vectorFinal[i] = e;
                    }
                    else
                    {
                        vectorFinal[i] = vectorInitial[i - 1];
                    }
                }
                Console.WriteLine(vectorFinal[i]);
            }
        }
    }
}
