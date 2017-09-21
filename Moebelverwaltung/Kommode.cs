using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    public class Kommode : Schrank
    {
       public List<Schubfach> Schubfaecher { get; set; }
        public Kommode() : this(100, 60, 80, 50.0, "braun", Material.Holz, 6,new List<Schubfach> { new Schubfach() } )
        {
            Console.WriteLine("Kommode()");


        }

        public Kommode(int laenge, int breite, int hoehe, double gewicht, string farbe, Material materialart, uint anzBoeden, List<Schubfach> schubfaecher) : base(laenge, breite, hoehe, gewicht, farbe, materialart, anzBoeden)
        {
            // ^ Weiterleitung an den Konstruktor der direkten Basisklasse,
            // wird weder base noch this angegeben, wird an den Konstruktor der Basisklasse weitergeleitet, der keine Parameter hat

            Console.WriteLine("Kommode(alle Parameter)");

         
            Schubfaecher = schubfaecher;
        }

        public override string Herstellen(string firma)
        {
            // mittels base.Methodenname Zugriff auf die gleichnamige Methode der Basisklasse
            string text = base.Herstellen(firma);
            // neuen Text an den String anhängen
            // text = text + "Der Firmensitz ist in Dresden."
            text += "Der Firmensitz ist in Dresden.";
            return text;
        }

        public string Herstellen(string firma, string ort)
        {
            // mittels base.Methodenname Zugriff auf die gleichnamige Methode der Basisklasse
            string text = base.Herstellen(firma);
            // neuen Text an den String anhängen
            // text = text + "Der Firmensitz ist in Dresden."
            text = "Die Kommode wurde von " + firma + " in " + ort + " hergestellt.";
            return text;
        }

        public override double BerechnePreis()
        {
            double materialPreis, gesamtPreis;

            switch (this.Materialart)
            {
                case Material.Holz:
                    materialPreis = 13.37;                    
                    break;
                case Material.Stahl:
                    materialPreis = 19.99;
                    break;
                case Material.Glas:
                    materialPreis = 5.55;
                    break;
                case Material.Kunststoff:
                    materialPreis = 9.99;
                    break;
                default:
                    materialPreis = 1.0;
                    break;
            }

            gesamtPreis = this.Schubfaecher.Count * materialPreis;
            gesamtPreis = gesamtPreis + (gesamtPreis * 0.19);
            return gesamtPreis;
        }

    }
}
