using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    /// <summary>
    /// Klasse, die einen Standardschrank näher beschreibt
    /// </summary>    
    public class Schrank : Moebelstueck
    {

        // Datentyp uint: unsigned int: Ganzzahl ohne Vorzeichen
        public uint AnzEinlegeboeden { get; set; }
               

        private int anzSchranktueren;
        
        /// <summary>
        /// gibt Anzahl der Schranktüren zurück
        /// </summary>
        public int AnzSchranktueren
        {            
            get { return anzSchranktueren; }

            //Setzen der Schranktueren nur in der selben Klasse möglich
            private set
            {
                if (value > 0 && value <= 10)
                {
                    anzSchranktueren = value;
                }
                else
                {
                    anzSchranktueren = 0;
                }

            }
        }

        //Konstruktoren der Klasse Schrank

        public Schrank() : this(150, 100, 180, 10.0, "braun", Material.Holz, 6)
        {
            Console.WriteLine("Schrank()");
        }

        public Schrank(int laenge, int breite, int hoehe) : this(laenge, breite, hoehe, 10.0, "braun", Material.Holz, 6)
        {
            Console.WriteLine("Schrank(int, int, int)");
        }

                
        public Schrank(int laenge, int breite, int hoehe, double gewicht, string farbe, Material materialart, uint anzBoeden) : base(laenge, breite, hoehe, gewicht, farbe, materialart)
        {
            // ^ Weiterleitung an den Konstruktor der direkten Basisklasse,
            // wird weder base noch this angegeben, wird an den Konstruktor der Basisklasse weitergeleitet, der keine Parameter hat
            // this() -> DIESE-Klasse
            // base() -> BASIS-Klasse
            Console.WriteLine("Schrank(alle PArameter)");

            // Zuweisung der lokalen Variable laenge an die Eigenschaft Laenge
            //Laenge = laenge;
            //Breite = breite;
            //Hoehe = hoehe;
            //Gewicht = gewicht;
            //Farbe = farbe;
            //Materialart = materialart;
            AnzEinlegeboeden = anzBoeden;

        }

        //public Schrank() : this(100, 40, 180, 8, 5.0, "braun", Material.Kunststoff)
        //{
        //    Console.WriteLine("Schrank()");
        //}

        //public Schrank(int laenge, int breite, int hoehe, string farbe) : this(laenge: laenge, breite: breite, hoehe: hoehe, farbe: farbe, gewicht:7.0, materialart:Material.Holz, anzSchranktueren:7)
        //{
        //    Console.WriteLine("Schrank(4 Parameter)");
        //}


        //public Schrank(int laenge, int breite, int hoehe, int anzSchranktueren, double gewicht, string farbe, Material materialart)
        //{
        //    Console.WriteLine("Schrank(7 Parameter)");
        //    // Zuweisung der lokalen Variable laenge an die Eigenschaft Laenge
        //    Laenge = laenge;
        //    Breite = breite;
        //    Hoehe = hoehe;
        //    AnzSchranktueren = anzSchranktueren;
        //    Gewicht = gewicht;
        //    Farbe = farbe;
        //    Materialart = materialart;
        //}

        public override double BerechnePreis()
        {
            return 0.0;
        }

        public void Aendern(int breit, int hoch)
        {
            Console.WriteLine("Aendern(int, int)");
            Hoehe = hoch;
            Breite = breit;
        }

        public void Aendern(int hoch)
        {
            Console.WriteLine("Aendern(int)");

            if (Hoehe > hoch)
            {
                Console.WriteLine("Neue Hoehe kleiner als alte Höhe. Wert wird geändert!");
                Hoehe = hoch;
            }
            else
            {
                Console.WriteLine("Alte Hoehe ist nicht kleiner als neue Hoehe. Wert bleibt unverändert!");
            }
            
        }

        /// <summary>
        /// kopiert ein Schrank-Objekt
        /// </summary>
        /// <returns>Schrank</returns>
        public Schrank Clone()
        {
            //MemberwiseClone() von Object erstellt eine flache Kopie und gibt ein Objekt vom Typ object zurück
            //  -> muss in Kindklassen-Objekt umgewandelt werden
            //flacheKopie: Werttypen werden direkt kopiert, bei den Referenztypen werden nur die Referenzvariablen kopiert, nicht die Objekte, auf die diese verweisen
            Schrank s1 = (Schrank)MemberwiseClone();

            //Eigenschaften für Referenztypen festlegen
            //s1.Farbe = Farbe;
            s1.Material = Material;
            return s1;
        }

        public override bool Equals(object obj)
        {
            //gibt false zurück, falls übergebenes Objekt null ist oder die Datentypen der Objekte unterschiedlich sind
            //GetType().ToString() gibt Klassennamen inkl. Namespace als String zurück
            if (obj == null || GetType().ToString() != obj.GetType().ToString())
            {
                return false;
            }
            else
            {
                //eigentlicher Vergleich
                Schrank s = (Schrank)obj;                
                return Laenge == s.Laenge && Breite == s.Breite && Hoehe == s.Hoehe && Material == s.Material;
            }
        }

        public static bool operator == (Schrank s1, Schrank s2)
        {       
            return s1.Laenge == s2.Laenge && s1.Breite == s2.Breite && s1.Hoehe == s2.Hoehe && s1.Gewicht == s2.Gewicht && s1.Material == s2.Material && s1.Farbe == s2.Farbe && s1.AnzEinlegeboeden == s2.AnzEinlegeboeden;            
        }

        public static bool operator != (Schrank s1, Schrank s2)
        {            
            return !(s1==s2);
        }

    }
}
