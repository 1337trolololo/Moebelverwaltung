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

            Tisch t2 = new Tisch(150,80,90,"rot");
            Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", t2.Laenge, t2.Breite, t2.Hoehe);
            Console.WriteLine("Farbe: " + t2.Farbe);
            Console.WriteLine("Material: " + t2.Materialart);

            //Schrank s1 = new Schrank();
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", s1.Laenge, s1.Breite, s1.Hoehe);
            //Console.WriteLine("Farbe: " + s1.Farbe);
            //Console.WriteLine("Material: " + s1.Materialart);
            //Console.WriteLine("Anzahl der Türen: " + s1.Anz.Schranktueren);

            //Schrank s2 = new Schrank(100, 50, 200, "pink");
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", s2.Laenge, s2.Breite, s2.Hoehe);
            //Console.WriteLine("Farbe: " + s2.Farbe);
            //Console.WriteLine("Material: " + s2.Materialart);
            //Console.WriteLine("Anzahl der Türen: " + s2.Anz.Schranktueren);

            Schrank s1 = new Schrank();
            Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", s1.Laenge, s1.Breite, s1.Hoehe);
            Console.WriteLine("Farbe: " + s1.Farbe);
            Console.WriteLine("Materialart: " + s1.Materialart);
            Console.WriteLine("Anzahl Einlegeböden: " + s1.AnzEinlegeboeden);
            
            Schrank s2 = new Schrank(220, 100, 180);
            Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", s2.Laenge, s2.Breite, s2.Hoehe);
            Console.WriteLine("Farbe: " + s2.Farbe);
            Console.WriteLine("Materialart: " + s2.Materialart);
            Console.WriteLine("Anzahl Einlegeböden: " + s2.AnzEinlegeboeden);

            Schrank s3 = new Schrank(250, 100, 200, 12.0, "beige", Material.Kunststoff, 10);
            Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", s3.Laenge, s3.Breite, s3.Hoehe);
            Console.WriteLine("Farbe: " + s3.Farbe);
            Console.WriteLine("Materialart: " + s3.Materialart);
            Console.WriteLine("Anzahl Einlegeböden: " + s3.AnzEinlegeboeden);

        }



    }
}
