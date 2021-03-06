﻿using BBW.Moebelverwaltung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoebelverwaltungAnwendung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klasse sowie deren Member müssen public sein, um sie in diesem Projekt verwenden zu können
            Tisch t1 = new Tisch();
            Console.WriteLine(t1.ToString());

            List<Tisch> tische = new List<Tisch>();
            tische.Add(new Tisch(100, 80, 90, "braun"));
            tische.Add(new Tisch(150, 80, 90, "hellbraun"));
            tische.Add(new Tisch(180, 80, 90, "rotbraun"));
            tische.Add(new Tisch(110, 80, 90, "blau"));
            tische.Add(new Tisch(200, 80, 90, "dunkelbraun"));
            tische.Add(new Tisch(170, 80, 90, "beige"));
            tische.Add(new Tisch(175, 100, 90, "grün"));

            foreach (var item in tische)
            {
                Console.WriteLine(item.ToString());
            }
            //Aufgabe: alle braunen Tische in einer separaten Liste speichern

            //Lösungsvariante 1:
            List<Tisch> listeBrauneTische = new List<Tisch>();
            foreach (var item in tische)
            {
                string farbe = item.Farbe;
                if (farbe.Contains("braun"))
                {
                    listeBrauneTische.Add(item);
                }
            }
            Console.WriteLine("braune Tische: ");
            for (int i = 0; i < listeBrauneTische.Count; i++)
            {
                Console.WriteLine(listeBrauneTische[i].ToString());
            }

            //Lösungsvariante 2:
            //Verwendung von LINQ (Language Intergrated Query)
            //Syntax:   from Bereichsvariable in Liste
            //          where Bedingung(en)
            //          select Bereichsvariable;
            //Rückgabe ist ein Objekt vom Typ IEnumerable<Tisch>
            //LINQ-Abfrage wird erst ausgeführt, wenn auf Ergebnismenge zugegriffen wird
            //  (wenn Liste mittels foreach durchlaufen wird)
            //Tische zusätzlich nach Länge sortiert
            //Bereichsvariable tisch wird hier definiert und initialisiert
            var listeBrauneTische2 = from tisch in tische
                                     where tisch.Farbe.Contains("braun")
                                     //absteigende Sortierung der Länge
                                     orderby tisch.Laenge descending
                                     select tisch;
            Console.WriteLine("Braune Tische -Variante2: ");
            foreach (var item in listeBrauneTische2)
            {
                Console.WriteLine(item.ToString());
            }

            //Lösungsvariante 3:
            //Erweiterungsmethodensyntax von LINQ
            //Verwendung von Labda-Ausdrücken
            //Syntax: MEthodenname((Parameternamen) => Parameter1.Eigenschaft == Value)
            var listeBrauneTische3 = tische
                                    .Where((tisch1) => tisch1.Farbe.Contains("braun")).OrderByDescending(tisch2 => tisch2.Laenge);
            Console.WriteLine("Braune Tische -Variante3: ");
            foreach (var item in listeBrauneTische3)
            {
                Console.WriteLine(item.ToString());
            }

            //Anzahl der braunen Tische ermitteln (Abfrage-Syntax)
            //Abfrage wird sofort ausgeführt
            int anzahlBrauneTische = (from tisch in tische
                                      where tisch.Farbe.Contains("braun")
                                      select tisch).Count();
            Console.WriteLine("Anzahl braune Tische: " + anzahlBrauneTische);

        }
    }
}
