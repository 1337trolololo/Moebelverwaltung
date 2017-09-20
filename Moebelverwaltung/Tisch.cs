using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    /// <summary>
    /// Klasse, die einen Tisch näher beschreibt
    /// </summary>
    /// 
    // Klasse Tisch erbt von Moebelstueck
    // -> Klasse Tisch ist ein Moebelstueck
    // Klasse Tisch erweitert die Klasse Moebelstueck
    // alle Eigenschaften und Methoden von Moebelstueck geerbet, die nicht private oder static sind
    public class Tisch : Moebelstueck
    {
        //todo(01): Estellung der Eigenschaften - ERLEDIGT


        private int anzTischbeine;


        /// <summary>
        /// gibt Anzahl der Tischbeine zurück
        /// </summary>
        public int AnzTischbeine
        {
            get { return anzTischbeine; }

            //Setzen der Tischbeinanzahl nur in der selben Klasse möglich
            private set
            {
                if (value > 0 && value <= 4)
                {
                    anzTischbeine = value;
                }
                else
                {
                    anzTischbeine = 0;
                }
                
            }
        }

        //Konstruktoren der Klasse Tisch
        public Tisch(): this(120,80,90,4,5.0,"braun",Material.Holz)
        {
            Console.WriteLine("Tisch()");
        }

        public Tisch(int laenge, int breite, int hoehe, string farbe) : this(laenge: laenge, breite: breite, hoehe: hoehe, farbe: farbe, gewicht:7.0, materialart:Material.Holz, anzTischbeine:4)
        {
            Console.WriteLine("Tisch(4 Parameter)");
        }
      

        public Tisch(int laenge, int breite, int hoehe, int anzTischbeine, double gewicht, string farbe, Material materialart)
        {
            Console.WriteLine("Tisch(7 Parameter)");
            // Zuweisung der lokalen Variable laenge an die Eigenschaft Laenge
            Laenge = laenge;
            Breite = breite;
            Hoehe = hoehe;
            AnzTischbeine = anzTischbeine;
            Gewicht = gewicht;
            Farbe = farbe;
            Materialart = materialart;
        }

        // Methode BerechnePreis() aus Moebelstueck wird überschrieben: Überschreiben von Methoden findet immer in abgeleiteter Klasse statt
        // beim Überschreiben zu beachten:
        // - gleicher Methodenname
        // - Schlüsselwortoverride muss angegeben werden
        // - gleiche Parameterliste
        // - gleicher Rückgabetyp
        // - gleicher oder breiterer Zugriffsmodifizierer (Reihenfolge: internal->protected->public)
        public override double BerechnePreis()
        {
            return 0.0;
        }
    }
}
