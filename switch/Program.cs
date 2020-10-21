using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema pentru a alege afisare gradele Celsius sau grade Fahrenheit
            double gradeC, gradeF;
            Console.WriteLine("introduceti valoarea pentru temperatura");
            gradeC = double.Parse(Console.ReadLine());
            Console.WriteLine($"Ati introdus valoarea {gradeC}");
            Console.WriteLine("Pentru grade Celsius apasati tasta c iar pentru grade Fahrenheit apasati tasta f");
            string optiune=Console.ReadLine();
            gradeF = gradeC * 9/5 +32;

            //if(obtiune=="c")
            //{
            //    Console.WriteLine($"Valoarea in grade Fahrenheit este {gradeCelsius}");
            //}
            //else
            //    Console.WriteLine($"Valoarea in grade Fahrenheit este {gradeF}");

            switch (optiune)
            {
                case "f":
                    Console.WriteLine($"Valoarea in grade Fahrenheit este {gradeF}");
                    break;
                case "c":
                    Console.WriteLine($"Valoarea in grade Celsius este {gradeC}");
                    break;
                default:
                    Console.WriteLine("Nu ati introdus o optiunea corecta");
                    break;
            }
        }
    }
}
