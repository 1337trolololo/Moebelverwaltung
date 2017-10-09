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
            ////Erstellung einer Variable vom Typ der Klasse Schubfach

            ////sf1 ist eine Referenzvaribable, die später auf ein Schubfach-Objekt verweisen soll
            //Schubfach sf1;

            ////Erzeugung eines Objektes (Instanz) der Klasse Schubfach
            ////Aufruf des Konstruktors ohne Parameter
            //sf1 = new Schubfach();

            ////Nutzung des Konstruktors mit optionalen Parametern
            ////Verwendung von bennanten Parametern
            //Schubfach sf2 = new Schubfach(laenge: 40, hoehe: 15, breite: 50);
            //Schubfach sf3 = new Schubfach(40, 50, 15, farbe: "schwarz");

            //Console.WriteLine("Schubfach sf1: ");

            ////Aufruf der get-Methoden der jeweiligen Eigenschaften für die Instanz sf1
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", sf1.Laenge, sf1.Breite, sf1.Hoehe);

            ////Gewicht mit 3 Nachkommastellen ausgeben (Formatierungsangaben auch in der Methode Format() von string verwendbar)
            //Console.WriteLine("Gewichtin kg: {0:F3} in kg", sf1.Gewicht);
            //Console.WriteLine("Farbe: " + sf1.Farbe);


            //Console.WriteLine("Schubfach sf2: ");

            ////Aufruf der get-Methoden der jeweiligen Eigenschaften für die Instanz sf2
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", sf2.Laenge, sf2.Breite, sf2.Hoehe);

            ////Gewicht mit 3 Nachkommastellen ausgeben (Formatierungsangaben auch in der Methode Format() von string verwendbar)
            //Console.WriteLine("Gewichtin kg: {0:F3} in kg", sf2.Gewicht);
            //Console.WriteLine("Farbe: " + sf2.Farbe);


            //Console.WriteLine("Schubfach sf3: ");

            ////Aufruf der get-Methoden der jeweiligen Eigenschaften für die Instanz sf3
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", sf3.Laenge, sf3.Breite, sf3.Hoehe);

            ////Gewicht mit 3 Nachkommastellen ausgeben (Formatierungsangaben auch in der Methode Format() von string verwendbar)
            //Console.WriteLine("Gewichtin kg: {0:F3} in kg", sf3.Gewicht);
            //Console.WriteLine("Farbe: " + sf3.Farbe);
            //Console.WriteLine("Volumen {0:F3} cm³", sf3.BerechneVolumen());

            //Schubfach sf4 = sf3.Clone();

            //Console.WriteLine("Schubfach sf3: ");
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", sf3.Laenge, sf3.Breite, sf3.Hoehe);

            //Console.WriteLine("Schubfach sf4: ");
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", sf4.Laenge, sf4.Breite, sf4.Hoehe);

            //sf4.Laenge = 80;

            //Console.WriteLine("Schubfach sf3: ");
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", sf3.Laenge, sf3.Breite, sf3.Hoehe);

            //Console.WriteLine("Schubfach sf4: ");
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", sf4.Laenge, sf4.Breite, sf4.Hoehe);

            //Tisch t1 = new Tisch();
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", t1.Laenge, t1.Breite, t1.Hoehe);
            //Console.WriteLine("Farbe: " + t1.Farbe);
            //Console.WriteLine("Material: " + t1.Materialart);

            //Tisch t2 = new Tisch(150,80,90,"rot");
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", t2.Laenge, t2.Breite, t2.Hoehe);
            //Console.WriteLine("Farbe: " + t2.Farbe);
            //Console.WriteLine("Material: " + t2.Materialart);

            ////Schrank s1 = new Schrank();
            ////Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", s1.Laenge, s1.Breite, s1.Hoehe);
            ////Console.WriteLine("Farbe: " + s1.Farbe);
            ////Console.WriteLine("Material: " + s1.Materialart);
            ////Console.WriteLine("Anzahl der Türen: " + s1.Anz.Schranktueren);

            ////Schrank s2 = new Schrank(100, 50, 200, "pink");
            ////Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", s2.Laenge, s2.Breite, s2.Hoehe);
            ////Console.WriteLine("Farbe: " + s2.Farbe);
            ////Console.WriteLine("Material: " + s2.Materialart);
            ////Console.WriteLine("Anzahl der Türen: " + s2.Anz.Schranktueren);

            //Schrank s1 = new Schrank();
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", s1.Laenge, s1.Breite, s1.Hoehe);
            //Console.WriteLine("Farbe: " + s1.Farbe);
            //Console.WriteLine("Materialart: " + s1.Materialart);
            //Console.WriteLine("Anzahl Einlegeböden: " + s1.AnzEinlegeboeden);

            //Schrank s2 = new Schrank(220, 100, 180);
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", s2.Laenge, s2.Breite, s2.Hoehe);
            //Console.WriteLine("Farbe: " + s2.Farbe);
            //Console.WriteLine("Materialart: " + s2.Materialart);
            //Console.WriteLine("Anzahl Einlegeböden: " + s2.AnzEinlegeboeden);

            //Schrank s3 = new Schrank(250, 100, 200, 12.0, "beige", Material.Kunststoff, 10);
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", s3.Laenge, s3.Breite, s3.Hoehe);
            //Console.WriteLine("Farbe: " + s3.Farbe);
            //Console.WriteLine("Materialart: " + s3.Materialart);
            //Console.WriteLine("Anzahl Einlegeböden: " + s3.AnzEinlegeboeden);

            //Tisch neuerTisch = new Tisch();
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);

            //// Aufruf der Methode Aendern()
            //neuerTisch.Aendern(80);
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);

            ////Aufruf der überladenen Methode Aendern() mit 2 Parametern
            //neuerTisch.Aendern(100, 90);
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);

            ////Aufruf der überladenen Methode Aendern() mit 2 string-Parametern
            //neuerTisch.Aendern("120", "100");
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);

            ////Aufruf der überladenen Methode Aendern(int, string)
            //neuerTisch.Aendern(110, "95");
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);
            ////Aufruf der überladenen Methode Aendern(int, string)
            //neuerTisch.Aendern(110, "95e");
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);

            ////Aufruf der überladenen Methode Aendern(string, int)
            //neuerTisch.Aendern("80", 100);
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);
            ////Aufruf der überladenen Methode Aendern(string, int)
            //neuerTisch.Aendern("75a", 110);
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);

            ////Aufruf der überladenen Methode Aendern2(string, int)
            //bool ergebnis = neuerTisch.Aendern2("150", 120);
            //if (ergebnis)
            //{
            //    Console.WriteLine("Neuer Tisch erfolgreich gebaut:");
            //    Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);
            //}
            //else
            //{
            //    Console.WriteLine("Breite nicht geändert!");
            //    Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);
            //}

            //Schrank neuerSchrank = new Schrank();
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", neuerSchrank.Laenge, neuerSchrank.Breite, neuerSchrank.Hoehe);

            //// Aufruf der Methode Aendern()
            //neuerSchrank.Aendern(120, 200);
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", neuerSchrank.Laenge, neuerSchrank.Breite, neuerSchrank.Hoehe);

            ////Aufruf der überladenen Methode Aendern() mit 2 Parametern
            //neuerSchrank.Aendern(210);
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", neuerSchrank.Laenge, neuerSchrank.Breite, neuerSchrank.Hoehe);

            ////Aufruf der überladenen Methode Aendern() mit 2 Parametern
            //neuerSchrank.Aendern(180);
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", neuerSchrank.Laenge, neuerSchrank.Breite, neuerSchrank.Hoehe);

            //// Aufruf der überschriebenen Methode Herstellen von Tisch
            //Console.WriteLine(neuerTisch.Herstellen("Ikea"));
            ////Aufruf der geerbten MEthode Herstellen von SchrAnk
            //Schrank schrank = new Schrank();
            //Console.WriteLine(schrank.Herstellen("Ikea"));

            //Kommode kom = new Kommode();
            //kom.Schubfaecher.Add(new Schubfach());
            //kom.Schubfaecher.Add(new Schubfach());
            //kom.Schubfaecher.Add(new Schubfach());
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", kom.Laenge, kom.Breite, kom.Hoehe);
            //Console.WriteLine("Anzahl Schubfächer: "+kom.Schubfaecher.Count);
            //Console.WriteLine(kom.Herstellen("koMModen AG", "Dresden"));
            //Console.WriteLine(kom.BerechnePreis());

            //Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            //Kommode kom2 = new Kommode(100,50,70,12.0,"pink",Material.Kunststoff,4, new List<Schubfach> { new Schubfach() });
            //kom2.Schubfaecher.Add(new Schubfach());
            //kom2.Schubfaecher.Add(new Schubfach());
            //kom2.Schubfaecher.Add(new Schubfach());
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm", kom2.Laenge, kom2.Breite, kom2.Hoehe);
            //Console.WriteLine("Anzahl Schubfächer: " + kom2.Schubfaecher.Count);           
            //Console.WriteLine(kom2.BerechnePreis());

            //Kommode kom = new Kommode();
            //Console.WriteLine("Preis: {0:F2} EUR", kom.BerechnePreis());
            //Console.WriteLine(kom.Herstellen("Ikea"));
            //Console.WriteLine(kom.Herstellen("Ikea", "Düsseldorf"));

            //Schubfach schubfach1 = new Schubfach(30, 40, 10, 1, "grün");
            //Kommode kom2 = new Kommode(120, 40, 100,3.0,"weiß", Material.Holz,3,schubfach1, schubfach1, schubfach1, schubfach1);
            //Console.WriteLine("alle Schubfächer haben folgende Maße:");
            //Console.WriteLine("Schubfach: {0} cm x {1} cm x {2} cm", kom2.Schubfach1.Laenge, kom2.Schubfach1.Breite, kom2.Schubfach1.Hoehe);

            //Schreibtisch st = new Schreibtisch();            
            //Console.WriteLine(st.ToString());
            //Console.WriteLine($"Preis {st.BerechnePreis():F2} EUR");

            //Stuhl stuhl = new Stuhl();
            //Console.WriteLine(stuhl);
            //Console.WriteLine(stuhl.Sitzen("sehr gut"));

            //// Aufruf des Standardkonstruktors von Rollstuhl
            //Rollstuhl rollstuhl = new Rollstuhl();
            //// Anwendung der geerbten ToString()-Methode
            //Console.WriteLine(rollstuhl);
            //// Aufruf der implementierten Methode Fahren() aus dem Interface
            //Console.WriteLine(rollstuhl.Fahren());

            //FahrenderSessel sessel = new FahrenderSessel();
            //Console.WriteLine(sessel.Fahren());
            //Console.WriteLine(sessel.Sitzen("sehr gut"));

            Tisch tisch1 = new Tisch();
            Tisch tisch2 = new Tisch(180, 70, 90, 5, 5.0, "dunkelbraun", Material.Holz);
            Schreibtisch schreibtisch1 = new Schreibtisch();
            Schreibtisch schreibtisch2 = new Schreibtisch(180, 70, 90, 5, 5.0, "dunkelbraun", Material.Holz, 3, new Schubfach(), new Steckdosenleiste());

            //Speichern der Tische in einer Liste
            // Liste vom Typ List<Tisch> kann Tisch-Objekte und von Tisch abgeleitete Objekte (z. B. Couchtisch-Objekte) speichern

            // dem Konstruktor kann als Parameter auch eine Anfangskapazität übergeben werden
            List<Tisch> listeTische = new List<Tisch>(5);
            listeTische.Add(tisch1);
            listeTische.Add(tisch2);
            listeTische.Add(schreibtisch1);
            listeTische.Add(schreibtisch2);

            Console.WriteLine("Anzahl Elemente: " + listeTische.Count);
            Console.WriteLine("Kapazität: " + listeTische.Capacity);

            //Hinzufügen eines neuen Tisches
            listeTische.Add(new Tisch(100, 100, 80, "weiß"));

            Console.WriteLine("Anzahl Elemente neu: " + listeTische.Count);
            Console.WriteLine("Kapazität neu: " + listeTische.Capacity);

            //Hinzufügen eines Couchtisches
            listeTische.Add(new Couchtisch());

            Console.WriteLine("Anzahl Elemente neu: " + listeTische.Count);
            Console.WriteLine("Kapazität neu: " + listeTische.Capacity);

            //Durchlaufen der Liste vom Typ List<Tisch>
            //Verwendung des automatischen Typrückschlusses
            foreach (var tisch in listeTische)
            {
                //Nutzung der überschriebenen ToString() - Methode
                Console.WriteLine("{0}", tisch);

                //Anzeige, ob es sich um einen Tisch oder einen Schreibtisch handelt
                if (tisch is Schreibtisch)
                {
                    Console.WriteLine("Art: ein Schreibisch");
                    //mittels as Umwandlung des Tisch-Objektes in ein Schreibtisch-Objekt
                    (tisch as Schreibtisch).Reparieren(true);
                    
                }
                else if (tisch is Couchtisch)
                {
                    Console.WriteLine("Art: ein anderer Tisch");
                }
                else
                {
                    Console.WriteLine("eine normaler Tisch-Art");
                }
            }

            //prüfen ob tisch1 ein Moebelstueck ist
            //is prüft, ob tisch1 ein Moebelstueck ist oder davon abgeleitet ist oder ein bestimmtes Interface implementiert
            if (tisch1 is Moebelstueck)
                Console.WriteLine("Der Tisch ist ein Möbelstück");
            else
                Console.WriteLine("Der Tisch ist kein Möbelstück");

            Schubfach schubfach1 = new Schubfach();
            if (schubfach1 is Moebelstueck)
                Console.WriteLine("Ein Schubfach ist ein Möbelstück");
            else
                Console.WriteLine("Ein Schubfach ist kein Möbelstück");

            //Prüfen, ob ein bestimmtes Element in der Liste ist
            if (listeTische.Contains(tisch2))
            {
                Console.WriteLine("Tisch2 ist in Liste.");
                string eingabe;
                Console.Write("Willst du den Tisch entfernen?: ");
                eingabe = Console.ReadLine();
                //eingabe.ToLower() wandelt eingegebene Bustaben in Kleinbuchstaben um
                //prüfen, ob "ja" oder "j" eingeben wurde
                if (eingabe.ToLower() == "ja" || eingabe.ToLower() == "j")
                {
                    //Tisch mittels Remove entfernen, erstes Vorkommen von tisch2 wird entfernt
                    // RemoveAll() löscht alle Vorkommen des übergebenen Elements
                    listeTische.Remove(tisch2);

                }                
            }
            else
            {
                Console.WriteLine("Objekt ist nicht vorhanden");
            }

            Console.WriteLine("Anzahl Elemente: " + listeTische.Count);

            //neue Liste mit einer vorhandenen Liste initialisieren
            List<Tisch> tische2016 = new List<Tisch>(listeTische);

            List<Tisch> tische2017 = new List<Tisch>(listeTische);
            tische2017.Add(new Tisch(150, 90, 90, "rot"));
            tische2017.Add(new Tisch(180, 90, 90, "blau"));
            tische2017.Add(new Schreibtisch());
            tische2017.Add(new Couchtisch());

            //beide Listen in einem Dictionary speichern
            //Dictionary speichert Schlüssel-Wert-Paare
            //Dictionary<Key,Value>
            Dictionary<string, List<Tisch>> aktuelleTische;
            aktuelleTische = new Dictionary<string, List<Tisch>>();







        }
    }
}
