using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool3
{
    class Program06
    {
        static void Main(string[] args)
        {
            //Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector 
            //elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui 
            //se muta cu o pozitie spre stanga. 

            int lungimeVector, k;
            Random aleator = new Random();
            Console.WriteLine("Programul elimina un element din vector aflat pe pozitia citita de la tastatura\n");
            Console.Write("Introduceti numarul de elemente al vectorului: ");
            lungimeVector = int.Parse(Console.ReadLine());
            Console.Write("\nElementele vectorului sunt: ");
            int[] vector = new int[lungimeVector];

            for (int i = 0; i < lungimeVector; i++)
            {
                vector[i] = aleator.Next(-50, 50);
                Console.Write($"{vector[i]} ");
            }
            Console.Write("\n\nPozitia care urmeaza sa fie stearsa este: ");
            k = int.Parse(Console.ReadLine());
            Console.Write("\nVectorul final este: ");
            int[] vectorFinal = new int[lungimeVector - 1];
            for (int i = 0; i < lungimeVector-1; i++)
            {
                if (i == k)
                {
                    vectorFinal[i] = vector[i + 1];
                }
                else
                {
                    if (i < k)
                        vectorFinal[i] = vector[i];
                    else
                        vectorFinal[i] = vector[i+1];
                }
                Console.Write($"{vectorFinal[i]} ");
            }
            Console.WriteLine();
        }
    }
}
