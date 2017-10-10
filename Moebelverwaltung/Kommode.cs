using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    public class Kommode : Schrank
    {

        // Klasse Kommode hat mehrere Schubfach-Objekte
        // zwischen Klasse Kommode und Schubfach besteht eine "hat-eine" Beziehung (has-a-relationship)

        public Schubfach Schubfach1 { get; set; }
        public Schubfach Schubfach2 { get; set; }
        public Schubfach Schubfach3 { get; set; }
        public Schubfach Schubfach4 { get; set; }

        //public List<Schubfach> Schubfaecher { get; set; }


        //Konstruktoren

        /// <summary>
        /// Kommode, die eine Art kleinerer Schrank ist
        /// </summary>
        public Kommode() : this(120, 60, 90, 3.0, "braun", Material.Holz, 4, new Schubfach(), new Schubfach(), new Schubfach(), new Schubfach())
        {
            Console.WriteLine("Kommode()");
        }

        /// <summary>
        /// Konstruktor, der alle Werte für eine Kommode setzt
        /// </summary>
        /// <param name="laenge"></param>
        /// <param name="breite"></param>
        /// <param name="hoehe"></param>
        /// <param name="gewicht"></param>
        /// <param name="farbe"></param>
        /// <param name="materialart"></param>
        /// <param name="anzBoeden"></param>
        /// <param name="sf1">Schubfach links oben</param>
        /// <param name="sf2"></param>
        /// <param name="sf3"></param>
        /// <param name="sf4"></param>
        public Kommode(int laenge, int breite, int hoehe, double gewicht, string farbe, Material materialart, uint anzBoeden, Schubfach sf1, Schubfach sf2, Schubfach sf3, Schubfach sf4) : base(laenge, breite, hoehe, gewicht, farbe, materialart, anzBoeden)
        {
            // ^ Weiterleitung an den Konstruktor der direkten Basisklasse,
            // wird weder base noch this angegeben, wird an den Konstruktor der Basisklasse weitergeleitet, der keine Parameter hat

            Console.WriteLine("Kommode(alle Parameter)");
            
            Schubfach1 = sf1;
            Schubfach2 = sf2;
            Schubfach3 = sf3;
            Schubfach4 = sf4;
        }

        //public Kommode() : this(100, 60, 80, 50.0, "braun", Material.Holz, 6,new List<Schubfach> { new Schubfach() } )
        //{
        //    Console.WriteLine("Kommode()");            
        //}

        //public Kommode(int laenge, int breite, int hoehe, double gewicht, string farbe, Material materialart, uint anzBoeden, List<Schubfach> schubfaecher) : base(laenge, breite, hoehe, gewicht, farbe, materialart, anzBoeden)
        //{
        //    // ^ Weiterleitung an den Konstruktor der direkten Basisklasse,
        //    // wird weder base noch this angegeben, wird an den Konstruktor der Basisklasse weitergeleitet, der keine Parameter hat

        //    Console.WriteLine("Kommode(alle Parameter)");

        //    Schubfaecher = schubfaecher;
        //}

        // Methoden

        // Überschreiben der MEthode BerechnePreis() aus Schrank
        /// <summary>
        /// berechnet den Preis der Kommode abhängig von Material
        /// Preis in Euro inkl. 19% Mehrwertsteuer
        /// </summary>
        /// <returns>double</returns>
        public override double BerechnePreis()
        {
            double preis = 0.0;

            switch (Material)
            {
                case Material.Holz:
                    preis = 100.0;
                    break;
                case Material.Stahl:
                    preis = 200;
                    break;
                case Material.Glas:
                    preis = 150;
                    break;
                case Material.Kunststoff:
                    preis = 75.0;
                    break;
                // nicht ausgeführt, da alle Konstanten angegeben wurden
                default:
                    break;
            }

            // preis = preis * 1.19
            preis *= 1.19;
            
            return preis;
        }

        
        //public override double BerechnePreis()
        //{
        //    double materialPreis = 0.0, gesamtPreis = 0.0;
             
        //    switch (Materialart)
        //    {
        //        case Material.Holz:
        //            materialPreis = 13.37;
        //            break;
        //        case Material.Stahl:
        //            materialPreis = 19.99;
        //            break;
        //        case Material.Glas:
        //            materialPreis = 5.55;
        //            break;
        //        case Material.Kunststoff:
        //            materialPreis = 9.99;
        //            break;
        //        default:
        //            materialPreis = 1.0;
        //            break;
        //    }

        //    gesamtPreis = this.Schubfaecher.Count * materialPreis;
        //    gesamtPreis = gesamtPreis + (gesamtPreis * 0.19);
        //    return gesamtPreis;
        //}

        // überschriebene Methode Herstellen() aus Moebelstueck
        public override string Herstellen(string firma)
        {
            // Aufruf der geerbten Methode von Schrank
            string text = base.Herstellen(firma);
            // neuen Text an den String anhängen
            // text = text + "Der Firmensitz ist in Dresden."
            text += "Die Firma sitzt in Hamburg.";
            return text;
        }

        // überladene Methode Herstellen()
        public string Herstellen(string firma, string ort)
        {
            // mittels base.Methodenname Zugriff auf die gleichnamige Methode der Basisklasse
            string text = base.Herstellen(firma);
            // neuen Text an den String anhängen
            // text = text + "Der Firmensitz ist in Dresden."
            text = "Die Kommode wurde von " + firma + " in " + ort + " hergestellt.";
            return text;
        }

        public Kommode Clone()
        {
           //Aufruf der Methode Clone() der Basisklasse
            Kommode k1 = (Kommode)base.Clone();

            k1.Schubfach1 = Schubfach1.Clone();
            k1.Schubfach2 = Schubfach2.Clone();
            k1.Schubfach3 = Schubfach3.Clone();
            k1.Schubfach4 = Schubfach4.Clone();
            return k1;
        }

    }
}
