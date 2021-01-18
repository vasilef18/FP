using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool3
{
    class Program08
    {
        static void Main(string[] args)
        {
            //Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga.
            //Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 

            int lungimeVector, primulElement;
            Random aleator = new Random();
            Console.WriteLine("Programul roteste spre stanga elementele unui vector astfe " +
                "primul element devine ultimul, al doilea devine primul etc.\n");
            Console.Write("Numarul elementelor vectorului este: ");
            lungimeVector = int.Parse(Console.ReadLine());
            int[] vector = new int[lungimeVector];
            Console.Write("Elementele vectorului sunt: ");
            for (int i = 0; i < lungimeVector; i++)
            {
                vector[i] = aleator.Next(-50, 50);
                Console.Write($"{vector[i]} ");
            }
            Console.Write("\nDupa rotirea spre stanga elementele sunt: ");
            primulElement = vector[0];
            for (int i = 1; i < lungimeVector; i++)
            {
                vector[i-1] = vector[i];
            }
            vector[lungimeVector - 1] = primulElement;
            for (int i = 0; i < lungimeVector; i++)
            {
                Console.Write($"{vector[i]} ");
            }
            Console.WriteLine();
        }
    }
}
