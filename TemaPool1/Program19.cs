using System;

namespace TemaPool1
{
    class Program19
    {
        static void Main(string[] args)
        {
            //Determinati daca un numar e format doar cu 2 cifre care se pot repeta.
            //De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 

            Console.WriteLine("Acest program determina daca un numar este format doar din 2 cifre care se pot repeta");
            Console.WriteLine("De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt");
            Console.WriteLine();

            int n , cifra1=0 , cifra2=-1, cifra3=0;
            Console.Write("Numarul care urmeaza sa fie verificat este: ");
            n = int.Parse(Console.ReadLine());

            if (n < 9)
            {
                Console.WriteLine("Numarul introdus este format doar dintr-o cifra distincta");
            }
            else
            {
                cifra1 = n % 10;
                n = n / 10;

                cifra2 = n % 10;
                n = n / 10;
                while (cifra1 == cifra2 && n > 0)
                {
                    cifra2 = n % 10;
                    n = n / 10;
                }

                cifra3 = n % 10;
                n = n / 10;

                while ((cifra2 == cifra3 || cifra1 == cifra3) && n > 0)
                {
                    cifra3 = n % 10;
                    n = n / 10;
                }

                if (cifra1 != cifra2 && cifra1 != cifra3 && cifra2 != cifra3)
                {
                    Console.WriteLine("Numarul introdus NU este format doar din 2 cifre distincte");
                }
                else
                {
                    Console.WriteLine("Numarul introdus este format doar din 2 cifre distincte");
                }
            }
        }
    }
}
