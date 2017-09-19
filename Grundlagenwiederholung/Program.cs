using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagenwiederholung
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("vorher: b={0}", b);
            //&& ist ein Kurzschlussoperator: VErgleich mit && wird abgebrochen, wenn erste Bedingung false ergibt,
            // wird nur mit & verwendet, werden alle Bedingungen geprüft
            if (a < 0 && b++ < 20)
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("nicht ok");
            }
            Console.WriteLine("nachher: b={0}", b);


            Console.WriteLine("Variante2");
            Console.WriteLine("vorher: b={0}", b);
            if (a < 0 & b++ < 20)
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("nicht ok");
            }
            Console.WriteLine("nachher: b={0}", b);
        }
    }
}
