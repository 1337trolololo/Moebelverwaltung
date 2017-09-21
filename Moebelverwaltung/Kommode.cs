using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    public class Kommode : Schrank
    {

        public Kommode() : this(100, 60, 80, 50.0, "braun", Material.Holz)
        {
            Console.WriteLine("Kommode()");

            Schubfach sf1 = new Schubfach();
            Schubfach sf2 = new Schubfach();
            Schubfach sf3 = new Schubfach();
            Schubfach sf4 = new Schubfach();

            Schubfach[] schubfaecher = new Schubfach[] { sf1, sf2, sf3, sf4};

        }

        public Kommode(int laenge, int breite, int hoehe, double gewicht, string farbe, Material materialart) : base(laenge, breite, hoehe, gewicht, farbe, materialart)
        {
            // ^ Weiterleitung an den Konstruktor der direkten Basisklasse,
            // wird weder base noch this angegeben, wird an den Konstruktor der Basisklasse weitergeleitet, der keine Parameter hat

            Console.WriteLine("Kommode(alle Parameter)");
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
            text = "Die Kommode wurde von " + firma + " in: " + ort + " hergestellt.";
            return text;
        }

    }
}
