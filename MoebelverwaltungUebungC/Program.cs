using BBW.Moebelverwaltung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoebelverwaltungUebungC
{
    class Program
    {
        static void AusgabeSchraenke()
        {
            Schrank s1 = new Schrank();
            Schrank s2 = new Schrank(180, 70, 200, 15.0, "braun", Material.Holz, 4);
            Schrank s3 = new Schrank(250, 80, 200, 15.0, "rot", Material.Holz, 4);
            Schrank s4 = new Schrank(200, 70, 200, 15.0, "blau", Material.Holz, 4);
            Schrank s5 = new Schrank(250, 70, 220, 15.0, "beige", Material.Holz, 4);
            Schrank s6 = new Schrank(180, 80, 200, 15.0, "orange", Material.Holz, 4);
            Schrank s7 = new Schrank(165, 70, 180, 15.0, "weiß", Material.Holz, 4);
            Schrank s8 = new Schrank(180, 70, 200, 15.0, "braun", Material.Holz, 4);

            //Array mit Schrank-Objekten erstellen
            //Array ist NICHT dynamisch -> Größe kann während der LAufzeit nicht geändert werden (Größe muss zu Beginn angegeben werden)
            //Array hat 8 Elemente -> Elemente können nicht hinzugefügt oder entfernt werden
            //eindimensionales Array
            //List<> ist die dynamische VAriante eines eindimensionalen Arrays
            Schrank[] schraenke = new Schrank[8] {s1, s2, s3, s4, s5 ,s6, s7, s8 };
            Console.WriteLine("Anzahl Schränke: " + schraenke.Length);
            foreach (var item in schraenke)
            {
                //{3:F3} Ausgabe der Liter mit 3 NAchkommastellen
                Console.WriteLine("Schrank: {0} cm x {1} cm x {2} cm; Volumen: {3:F3} l; Farbe: {4}", item.Laenge, item.Breite, item.Hoehe, item.GetVolumen(), item.Farbe);
            }

            var ausgewaehlteSchraenke = from schrank in schraenke
                                        where schrank.Farbe == "braun" || schrank.Farbe == "blau" || schrank.Farbe == "rot"
                                        //bei gleichem Volumen zusätzlich nach Farbe aufsteigend
                                        orderby schrank.GetVolumen(), schrank.Farbe
                                        select schrank;
            Console.WriteLine("");
            foreach (var item in ausgewaehlteSchraenke)
            {
                //{3:F3} Ausgabe der Liter mit 3 NAchkommastellen
                Console.WriteLine("Schrank: {0} cm x {1} cm x {2} cm; Volumen: {3:F3} l; Farbe: {4}", item.Laenge, item.Breite, item.Hoehe, item.GetVolumen(), item.Farbe);
            }

            // LINQ-Abfrage mittels Erweiterungsmethodensyntax
            var listeSchraenke = schraenke.
                                        Where((schrank) => schrank.Farbe == "braun" || schrank.Farbe == "blau" || schrank.Farbe == "rot")
                                        //bei gleichem Volumen zusätzlich nach Farbe aufsteigend
                                        .OrderBy((schrank) => schrank.GetVolumen())
                                        .ThenBy((schrank) => schrank.Farbe);
            foreach (var item in listeSchraenke)
            {
                //{3:F3} Ausgabe der Liter mit 3 NAchkommastellen
                Console.WriteLine("Schrank: {0} cm x {1} cm x {2} cm; Volumen: {3:F3} l; Farbe: {4}", item.Laenge, item.Breite, item.Hoehe, item.GetVolumen(), item.Farbe);
            }

        }
        static void Main(string[] args)
        {
            AusgabeSchraenke();
        }
    }
}
