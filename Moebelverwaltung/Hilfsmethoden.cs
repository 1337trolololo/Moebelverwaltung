﻿using System;
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
                    moebelstuecke.Add(new Tisch(100 + i, 40 + i, 100 + i, "braun"));
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
                        Console.Write("Tisch");
                    }
                    else {
                        Console.Write("unbekannt: ");
                    }
                    Console.WriteLine("{0} cm x {1} cm x {2} cm", item.Laenge, item.Breite, item.Hoehe);
                }
            }
            else
            {
                Console.WriteLine("ungültige Anzahl");
            }
        }
    }
}
