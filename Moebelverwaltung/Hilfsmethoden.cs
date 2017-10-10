using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    //statische Klasse -> kann nicht abgeleitet werden
    public static class Hilfsmethoden
    {
        //statische Methode
        //Aufruf: Hilfsmethoden.ErstellenListe(5)
        //uint: unsigned int -> kleinster Wert ist 0
        public static void ErstellenListe(uint anzahl)
        {
            //Deklaration der benötigten Variablen
            List<Moebelstueck> moebelstuecke;
            List<Schrank> schraenke;
            List<Tisch> tische;

            if (anzahl > 0 && anzahl <= 100)
            {
                //Initialisieren der einzelnen Listen
                moebelstuecke = new List<Moebelstueck>(Convert.ToInt32(2 * anzahl));
                schraenke = new List<Schrank>(Convert.ToInt32(anzahl));
                tische = new List<Tisch>(Convert.ToInt32(anzahl));

                //füllen der ersten Liste mit Schränken und Tischen
                for (int i = 0; i < anzahl; i++)
                {
                    moebelstuecke.Add(new Schrank(100+i, 40+i, 100+i));
                    moebelstuecke.Add(new Tisch(100 + i, 40 + i, 90, "braun"));
                }
                //for (int i = 0; i < anzahl; i++)
                //{
                //    moebelstuecke.Add(new Tisch(100 + i, 40 + i, 100 + i, "braun"));
                //}
                //Durchlaufen der Liste List<Moebelstueck>
                foreach (var item in moebelstuecke)
                {
                    if (item is Schrank)
                    {
                        Console.Write("Schrank: ");
                    }
                    else if (item is Tisch)
                    {
                        Console.Write("Tisch: ");
                    }
                    else {
                        Console.Write("unbekannt: ");
                    }
                    Console.WriteLine("{0} cm x {1} cm x {2} cm", item.Laenge, item.Breite, item.Hoehe);
                }

                foreach (var item in moebelstuecke)
                {
                    //is überprüft, ob Objekt vom Typ dieser Klasse oder davon abgeleitet ist
                    if (item is Schrank)
                    {
                        //item vom Typ Moebelstueck in ein Kind-Klassen-Objekt (Objekt der abgeleiteten Klasse ) umwandeln
                        //Typecasting (Umwandlung) erfolgt mittels as - Operator
                        Schrank schrank = item as Schrank;
                        //Umwandlung erforderlich, da statt Moebelstueck ein Objekt vom Typ Schrank erwartet wird
                        schraenke.Add(schrank);
                    }
                    else if (item is Tisch)
                    {
                        //Tisch tisch = item as Tisch;
                        tische.Add(item as Tisch);
                    }
                }

                //Durchlaufen der beiden neuen Listen
                foreach (var item in schraenke)
                {
                    Console.WriteLine("Schrank: {0} cm x {1} cm x {2} cm", item.Laenge, item.Breite, item.Hoehe);
                }
                foreach (var item in tische)
                {
                    Console.WriteLine("Tisch: {0} cm x {1} cm x {2} cm, Farbe: {3}", item.Laenge, item.Breite, item.Hoehe, item.Farbe);
                }
            }
            else
            {
                Console.WriteLine("ungültige Anzahl");
            }
        }
    }
}
