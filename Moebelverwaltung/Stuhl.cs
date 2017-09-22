using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    // eine Klasse kann eine andere Klasse erweitern und beliebig viele INterfaces implementieren
    // Syntax: class Klasse : Basisklasse, IInterface1, ...
    public class Stuhl : Moebelstueck, ISitzgelegenheit
    {
        //wir kein eigener Konstruktor definiert, wird ein Konstruktor ohne Parameter bereitgestellt,
        // der automatisch den Konstruktoren ohne Parameter seiner Basisklasse aufruft
                
        public Stuhl() : this(150, 100, 180, 10.0, "braun", Material.Holz)
        {
            Console.WriteLine("Stuhl()");
        }

        public Stuhl(int laenge, int breite, int hoehe, double gewicht, string farbe, Material materialart) : base(laenge, breite, hoehe, gewicht, farbe, materialart)
        {
            // ^ Weiterleitung an den Konstruktor der direkten Basisklasse,
            // wird weder base noch this angegeben, wird an den Konstruktor der Basisklasse weitergeleitet, der keine Parameter hat

            Console.WriteLine("Stuhl(alle Parameter)");
        }

        public bool Polster
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override double BerechnePreis()
        {
            throw new NotImplementedException();
        }

        public string Sitzen(string qualität)
        {
            throw new NotImplementedException();
        }
    }
}
