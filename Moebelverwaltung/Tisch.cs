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
      

        public Tisch(int laenge, int breite, int hoehe, int anzTischbeine, double gewicht, string farbe, Material materialart) : base(laenge, breite, hoehe, gewicht, farbe, materialart)
        {
            // ^ Weiterleitung an den Konstruktor der direkten Basisklasse,
            // wird weder base noch this angegeben, wird an den Konstruktor der Basisklasse weitergeleitet, der keine Parameter hat

            Console.WriteLine("Tisch(7 Parameter)");
            // Zuweisung der lokalen Variable laenge an die Eigenschaft Laenge
            //Laenge = laenge;
            //Breite = breite;
            //Hoehe = hoehe;
            AnzTischbeine = anzTischbeine;
            //Gewicht = gewicht;
            //Farbe = farbe;
            //Materialart = materialart;
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

        // Überladen von Methoden:
        // beim Überladen zu beachten:
        // - nur die Signatur der Methode (Name, Parameterliste) betrachtet)
        // - Rückgabetyp und Zugriffsmodifizierer nicht betrachtet
        // - gleicher Name
        // - unterschiedliche Parameterliste:
        //   - eine unterschiedliche Anzahl von Parametern
        //   - unterschiedliche Datentypen der Parameter
        //   - eine unterschiedliche Reihenfolge der Parameter, wenn die Datentypen unterschiedlich sind

        /// <summary>
        /// schneidet die Tischoberfläche entsprechend zu,
        /// ändert Länge und Breite des Tischobjektes, für das 
        /// die Methode Aendern() aufgerufen wird
        /// </summary>
        /// <param name="lang">neuer Wert für Länge und Breite</param>
        public void Aendern(int lang)
        {
            Console.WriteLine("Aendern(int)");
            Laenge = lang;
            Breite = lang;
        }

        public void Aendern(int lang, int breit)
        {
            Console.WriteLine("Aendern(int, int)");
            Laenge = lang;
            Breite = breit;
        }

        public void Aendern(string lang, string breit)
        {
            Console.WriteLine("Aendern(string, string)");
            // Nutzung der Klasse Convert, um Zeichenketten zu konvertieren
            // Klasse Convert hat statische Methoden; Klassenname.Methodenname()
            Laenge = Convert.ToInt32(lang);
            //Nutzug der Struktur Int32 -> statische Methode Parse() verwendet
            Breite = int.Parse(breit);
        }

        public void Aendern(int lang, string breit)
        {
            Console.WriteLine("Aendern(int, string)");

            Laenge = lang;

            int breite = 0;
            // TryParse() gibt true oder false zurück
            // der Ausgabeparameter enthält Zahlenwerte (0 im Fehlerfall)
            if (int.TryParse(breit, out breite))
            {
                Console.WriteLine("Konvertierung erfolgreich");
                
            }
            else
            {
                Console.WriteLine("Konvertierung fehlgeschlagen");
            }
            Breite = breite;



        }

        public void Aendern(string breit, int lang)
        {
            Console.WriteLine("Aendern(string, int)");

            Laenge = lang;

            int breite = 0;
            if (int.TryParse(breit, out breite))
            {
                Console.WriteLine("Konvertierung erfolgreich");
                Breite = breite;
            }
            else
            {
                Console.WriteLine("Konvertierung fehlgeschlagen");
            }
        }

        // ungültiges Überladen:
        // da sich die Methode Aendern(string, int) nur durch den Rückgabetyp (statt void wird bool verwendet) unterscheidet,
        // ist es eine ungültige Überladung -> Compilerfehler
        //public bool Aendern(string breit, int lang){}

        // mögliche Fehlerkorrekturen: Änderung des Namens oder der Parameterliste, wird der Name geändert ist es eine komplett
        // neue Methode (Aendern2 statt Aendern)

        public bool Aendern2(string breit, int lang)
        {
            Console.WriteLine("Aendern2(string, int)");

            Laenge = lang;

            int breite = 0;
            if (int.TryParse(breit, out breite))
            {
                Console.WriteLine("Konvertierung erfolgreich");
                Breite = breite;
                return true;
            }
            else
            {
                Console.WriteLine("Konvertierung fehlgeschlagen");
                return false;
            }
        }

        // eine nicht abstrakte Methode aus Moebelstueck überschreiben:
        // public string Herstellen(string firma){}
        // Methode, die in abgeleiteter Methode überschrieben werden soll,
        // muss in der Basisklasse mit virtual versehen werden
        // beim Überschreiben zu beachten:
        // - in Basisklasse Methode mit virtual versehen
        // - in abgeleiteter Klasse MEthode mit override versehen
        // - gleicher Name
        // - gleicher Rückgabetyp
        // - gleiche Parameterliste (Anzahl und Datentpen müssen identisch sein)
        // - der gleiche oder ein breiterer Zugriffsmodifizierer

        public override string Herstellen(string firma)
        {
            // mittels base.Methodenname Zugriff auf die gleichnamige Methode der Basisklasse
            string text = base.Herstellen(firma);
            // neuen Text an den String anhängen
            // text = text + "Der Firmensitz ist in Dresden."
            text += "Der Firmensitz ist in Dresden.";
            return text;
        }

        //Methode ToString() aus Object überschreiben, um das aktuelle Objekt als String zurückzugeben
        //String in allen grafischen Anwendungen benötigt
        public override string ToString()
        {

            string text = string.Format("Maße: {0} cm x {1} cm x {2} cm", Laenge, Breite, Hoehe);
            text += " Farbe: " + Farbe;
            text += " Material: " + Material;
            text += $" Der Tisch hat {AnzTischbeine} Bein(e)";

            //return base.ToString();
            return text;
        }

        /// <summary>
        /// kopiert ein Tisch-Objekt
        /// </summary>
        /// <returns>Tisch</returns>
        public Tisch Clone()
        {
            //MemberwiseClone() von Object erstellt eine flache Kopie und gibt ein Objekt vom Typ object zurück
            //  -> muss in Kindklassen-Objekt umgewandelt werden
            //flacheKopie: Werttypen werden direkt kopiert, bei den Referenztypen werden nur die Referenzvariablen kopiert, nicht die Objekte, auf die diese verweisen
            Tisch t1 = (Tisch) MemberwiseClone();

            //Eigenschaften für Referenztypen festlegen
            //t1.Farbe = Farbe;
            //t1.Material = Material;
            return t1;
        }
    }
}
