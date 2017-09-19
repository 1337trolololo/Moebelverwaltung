using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erstellung einer Variable vom Typ der Klasse Schubfach

            //sf1 ist eine Referenzvaribable, die später auf ein Schubfach-Objekt verweisen soll
            Schubfach sf1;

            //Erzeugung eines Objektes (Instanz) der Klasse Schubfach
            sf1 = new Schubfach();

            //Nutzung des Konstruktors mit optionalen Parametern
            //Verwendung von bennanten Parametern
            Schubfach sf2 = new Schubfach(laenge: 40, hoehe: 15, breite: 50);
            Schubfach sf3 = new Schubfach(40, 50, 15, farbe: "schwarz");

        }
    }
}
