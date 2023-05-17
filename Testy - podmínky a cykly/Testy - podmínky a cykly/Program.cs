using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy___podmínky_a_cykly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš číslo od 1 do 4, jaký úkol chceš vidět vyřešený");
            int input = 0;
            input = Convert.ToInt32(Console.ReadLine()); 

            // Vypiš malou násobilku 8
            if (input == 1)
            {
                Console.WriteLine("Zde se vypíše řešení pro 1");
               
            }
            // Vypiš číslenou řadu 2 4 8 16 32 64 128 256
            if (input == 2)
            {
                Console.WriteLine("Zde se vypíše řešení pro 2");

            }

            // Vypiš řadu true faĺse true false true false true false
            if (input == 3)
            {
                Console.WriteLine("Zde se vypíše řešení pro 3");

            }

            /* Vypiš číslenou Fibbonachiho posloupnost (nové číslo je součet dvou předchozích)
               1 1 2 5 8 13 21 34 55 ... */
            if (input == 4)
            {
                Console.WriteLine("Zde se vypíše řešení pro 4");

            }


            // Zakončení


            Console.ReadLine();

        }
    }
}
