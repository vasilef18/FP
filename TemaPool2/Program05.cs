using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPool2
{
    class Program05
    {
        static void Main(string[] args)
        {
            //Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.
            //Se considera ca primul element din secventa este pe pozitia 0.

            int lungimeSecventa, numar=0;
            Random aleator = new Random();
            Console.WriteLine("Programul afiseaza cate dintre elementele unei secvente sunt egale cu pozitia pe care apar");
            Console.WriteLine();
            Console.Write("Introduceti lungimea secventei: ");
            lungimeSecventa = int.Parse(Console.ReadLine());

            Console.Write("Elementele secventei sunt: ");
            string save="";
            for (int i = 0; i <= lungimeSecventa; i++)
            {
                numar = aleator.Next(lungimeSecventa);
                Console.Write($"{numar}, ");
                if (numar == i)
                {
                    save += $"\nElementul {numar} se afla pe pozitia {i}";
                }
            }
            Console.WriteLine();
            Console.WriteLine(save);
        }

    }
}
