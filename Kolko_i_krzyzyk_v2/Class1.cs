using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolko_i_krzyzyk_v2
{
    class Class1
    {
        public static void Menu()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("=---------Kółko-i-krzyżyk---------=");
            Console.WriteLine("===================================");
            Console.WriteLine("-                                 -");
            Console.WriteLine("- 1. Graj na tym urządzeniu       -");
            Console.WriteLine("- 2. Graj online                  -");
            Console.WriteLine("-                                 -");
            Console.WriteLine("-----------------------------------");
            Console.Write("Wybór: ");
        }
        public static void DisplayBoard()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("| {0} | | {1} | | {2} |", Class2.Tab[1], Class2.Tab[2], Class2.Tab[3]);
            Console.WriteLine("-----------------");
            Console.WriteLine("| {0} | | {1} | | {2} |", Class2.Tab[4], Class2.Tab[5], Class2.Tab[6]);
            Console.WriteLine("-----------------");
            Console.WriteLine("| {0} | | {1} | | {2} |", Class2.Tab[7], Class2.Tab[8], Class2.Tab[9]);
            Console.WriteLine("-----------------");
        }
    }
}
