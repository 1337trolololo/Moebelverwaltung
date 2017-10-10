using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    public class Schreibtisch : Tisch
    {
        // Klasse Schreibtisch hat genau ein Schubfach-Objekt
        public Schubfach Schubfach { get; set; }
        public Steckdosenleiste Steckdosenleiste { get; set; }

        //Konstruktoren

        /// <summary>
        /// Schreibtisch, der eine besonderer Tisch ist
        /// </summary>
        public Schreibtisch() : this(120, 80, 90, 4, 6.5, "braun", Material.Holz, 4, new Schubfach(120, 80, 90), new Steckdosenleiste(5, "pink"))
        {
            Console.WriteLine("Schreibtisch()");
        }

        /// <summary>
        ///  Konstruktor, der alle Werte für eine Schreibtisch setzt
        /// </summary>
        /// <param name="laenge"></param>
        /// <param name="breite"></param>
        /// <param name="hoehe"></param>
        /// <param name="anzTischbeine"></param>
        /// <param name="gewicht"></param>
        /// <param name="farbe"></param>
        /// <param name="materialart"></param>
        /// <param name="anzBoeden"></param>
        /// <param name="sf">Schubfach</param>
        /// <param name="sl">Steckdosenleiste</param>
        public Schreibtisch(int laenge, int breite, int hoehe, int anzTischbeine, double gewicht, string farbe, Material materialart, uint anzBoeden, Schubfach sf, Steckdosenleiste sl) : base(laenge, breite, hoehe, anzTischbeine, gewicht, farbe, materialart)
        {
            // ^ Weiterleitung an den Konstruktor der direkten Basisklasse,
            // wird weder base noch this angegeben, wird an den Konstruktor der Basisklasse weitergeleitet, der keine Parameter hat

            Console.WriteLine("Schreibtisch(alle Parameter)");

            Schubfach = sf;
            Steckdosenleiste = sl;

        }


        //Methoden

        public override double BerechnePreis()
        {
            double preis = 0.0;
            int flaeche = 0;
            
            switch (Material)
            {
                case Material.Holz:
                    preis = 100.0;
                    break;
                case Material.Stahl:
                    preis = 200.0;
                    break;
                case Material.Glas:
                    preis = 150.0;
                    break;
                case Material.Kunststoff:
                    preis = 75.0;
                    break;
                // nicht ausgeführt, da alle Konstanten angegeben wurden
                default:
                    break;
            }

            flaeche = (Laenge * Breite) / 10000;

            if (flaeche <= 2)
            {
                preis += 200.0;
            }
            else if (flaeche <= 5)
            {
                preis += 450.0;
            }
            else
            {
                preis += 600.0;
            }

            preis *= 1.19;

            return preis;
        }


        //Methode ToString() aus Object überschreiben, um das aktuelle Objekt als String zurückzugeben
        //String in allen grafischen Anwendungen benötigt
        public override string ToString()
        {
            string text = string.Format("Maße: {0} cm x {1} cm x {2} cm", Laenge, Breite, Hoehe);
            text += " Farbe: " + Farbe;
            text += " Material: " + Material;
            text += $" Der Schreibtisch hat {AnzTischbeine} Bein(e)";
            text += $" Der Schreibtisch hat {Steckdosenleiste.AnzSteckdosen} Steckdosen";

            return text;
        }

        public void Reparieren(bool fehlerhaft)
        {
            if (fehlerhaft)
                Console.WriteLine("Die Steckdosenleiste ist defekt und muss ausgetauscht werden");
            else
                Console.WriteLine("Es muss nichts repariert werden");
            
        }

        public new Schreibtisch Clone()
        {
            Schreibtisch st = (Schreibtisch)base.Clone();
            st.Schubfach = Schubfach.Clone();

            return st;
        }

        public override bool Equals(object obj)
        {
            //um Schubfach in Vergleich mit aufzunehmen, muss Equals() in Schubfach überschrieben werden
            Schreibtisch st = (Schreibtisch)obj;

            return base.Equals(st) && Steckdosenleiste == st.Steckdosenleiste;
            // && Schubfach.Equals(st.Schubfach);

        }

    }
}
