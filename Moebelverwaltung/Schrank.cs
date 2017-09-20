using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    /// <summary>
    /// Klasse, die einen Schrank näher beschreibt
    /// </summary>    
    public class Schrank : Moebelstueck
    {
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
        public Schrank(): this(100,40,180,8,5.0,"braun",Material.Stahl)
        {
            Console.WriteLine("Schrank()");
        }

        public Schrank(int laenge, int breite, int hoehe, string farbe) : this(laenge: laenge, breite: breite, hoehe: hoehe, farbe: farbe, gewicht:7.0, materialart:Material.Holz, anzSchranktueren:7)
        {
            Console.WriteLine("Schrank(4 Parameter)");
        }


        public Schrank(int laenge, int breite, int hoehe, int anzSchranktueren, double gewicht, string farbe, Material materialart)
        {
            Console.WriteLine("Schrank(7 Parameter)");
            // Zuweisung der lokalen Variable laenge an die Eigenschaft Laenge
            Laenge = laenge;
            Breite = breite;
            Hoehe = hoehe;
            AnzSchranktueren = anzSchranktueren;
            Gewicht = gewicht;
            Farbe = farbe;
            Materialart = materialart;
        }

        public override double BerechnePreis()
        {
            return 0.99;
        }
    }
}
