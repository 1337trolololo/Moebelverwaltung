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
            //Aufruf des Konstruktors ohne Parameter
            sf1 = new Schubfach();

            //Nutzung des Konstruktors mit optionalen Parametern
            //Verwendung von bennanten Parametern
            Schubfach sf2 = new Schubfach(laenge: 40, hoehe: 15, breite: 50);
            Schubfach sf3 = new Schubfach(40, 50, 15, farbe: "schwarz");

            Console.WriteLine("Schubfach sf1: ");

            //Aufruf der get-Methoden der jeweiligen Eigenschaften für die Instanz sf1
            Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", sf1.Laenge, sf1.Breite, sf1.Hoehe);

            //Gewicht mit 3 Nachkommastellen ausgeben (Formatierungsangaben auch in der Methode Format() von string verwendbar)
            Console.WriteLine("Gewichtin kg: {0:F3} in kg", sf1.Gewicht);
            Console.WriteLine("Farbe: " + sf1.Farbe);


            Console.WriteLine("Schubfach sf2: ");

            //Aufruf der get-Methoden der jeweiligen Eigenschaften für die Instanz sf2
            Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", sf2.Laenge, sf2.Breite, sf2.Hoehe);

            //Gewicht mit 3 Nachkommastellen ausgeben (Formatierungsangaben auch in der Methode Format() von string verwendbar)
            Console.WriteLine("Gewichtin kg: {0:F3} in kg", sf2.Gewicht);
            Console.WriteLine("Farbe: " + sf2.Farbe);


            Console.WriteLine("Schubfach sf3: ");

            //Aufruf der get-Methoden der jeweiligen Eigenschaften für die Instanz sf3
            Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", sf3.Laenge, sf3.Breite, sf3.Hoehe);

            //Gewicht mit 3 Nachkommastellen ausgeben (Formatierungsangaben auch in der Methode Format() von string verwendbar)
            Console.WriteLine("Gewichtin kg: {0:F3} in kg", sf3.Gewicht);
            Console.WriteLine("Farbe: " + sf3.Farbe);
            Console.WriteLine("Volumen {0:F3} cm³", sf3.BerechneVolumen());

            Schubfach sf4 = sf3.Clone();

            Console.WriteLine("Schubfach sf3: ");
            Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", sf3.Laenge, sf3.Breite, sf3.Hoehe);

            Console.WriteLine("Schubfach sf4: ");
            Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", sf4.Laenge, sf4.Breite, sf4.Hoehe);

            sf4.Laenge = 80;

            Console.WriteLine("Schubfach sf3: ");
            Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", sf3.Laenge, sf3.Breite, sf3.Hoehe);

            Console.WriteLine("Schubfach sf4: ");
            Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", sf4.Laenge, sf4.Breite, sf4.Hoehe);

            Tisch t1 = new Tisch();
            Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", t1.Laenge, t1.Breite, t1.Hoehe);
            Console.WriteLine("Farbe: " + t1.Farbe);
            Console.WriteLine("Material: " + t1.Materialart);

            Tisch t2 = new Tisch(150,80,90, "rot");
            Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", t2.Laenge, t2.Breite, t2.Hoehe);
            Console.WriteLine("Farbe: " + t2.Farbe);
            Console.WriteLine("Material: " + t2.Materialart);
        }
    }
}
