using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    /// <summary>
    /// Klasse Schubfach, die ein Schubfach für Schränke und Tische definiert
    /// </summary>
    public class Schubfach
    {
        #region Attribute
        // alle private Attribute generell kleingeschrieben
        private int laenge;
        private int breite;
        private int hoehe;
        private double gewicht;
        private string farbe;
        #endregion

        #region Eigenschaften
        
        /// <summary>
        /// Hoehe des Schubfaches in cm
        /// </summary>
        public int Hoehe
        {
            get
            {
                return hoehe;
            }

            set
            {
                hoehe = value;
            }
        }

        /// <summary>
        /// Laenge des Schubfaches in cm
        /// </summary>
        public int Laenge
        {
            get
            {
                return laenge;
            }

            set
            {
                Console.WriteLine("set Laenge");
                if (value > 0 && value <= 120)
                {
                    laenge = value;
                }
                else if (value > 120)
                {
                    laenge = 120;
                }
                else
                {
                    laenge = 0;
                }
            }
        }

        /// <summary>
        /// Breite des Schubfaches in cm
        /// </summary>
        public int Breite
        {
            get
            {
                return breite;
            }

            set
            {
                breite = value;
            }
        }

        /// <summary>
        /// Gewicht des Schubfaches in kg
        /// </summary>
        public double Gewicht
        {
            get
            {
                return gewicht;
            }

            set
            {
                gewicht = value;
            }
        }

        /// <summary>
        /// Farbe des Schubfaches
        /// </summary>
        public string Farbe
        {
            get
            {
                return farbe;
            }

            set
            {
                farbe = value;
            }
        }
        #endregion

        #region Konstruktoren

        // Weiterleitung an den Konstruktor dieser Klasse (this)
        /// <summary>
        /// Konstruktor, der Standardwerte setzt
        /// </summary>
        public Schubfach() : this(30,50,10/*,1.0,"hellbraun"*/)
        {
            Console.WriteLine("Schubfach()");
        }

        //Konstruktorüberladung:
        //gleicher Name, aber eine unterschiedliche Parameterliste        
        //Konstruktor mit optionalen Parametern
        // - optionale Parameter müssen immer am Ende stehen
        public Schubfach(int laenge, int breite, int hoehe, double gewicht=1.0, string farbe = "pink")
        {
            Console.WriteLine("Schubfach(5 Parameter)");
            //Setzen der Länge -> Aufruf der set-Methode der Eigenschaft
            Laenge = laenge;
            Breite = breite;
            Hoehe = hoehe;

            Gewicht = gewicht;
            Farbe = farbe;
        }
        

        #endregion

        /// <summary>
        /// berechnet das Volumen in cm³
        /// </summary>
        /// <returns>double - in cm³</returns>
        public double BerechneVolumen()
        {
            return Laenge*Breite*Hoehe;
        }

        //Syntax: Zugriffsmodifizierer Rückgabetyp Methodenname()
        /// <summary>
        /// gibt eine Kopie des aktuellen Objektes zurück
        /// </summary>
        /// <returns>BBW.Moebelverwaltung.Schubfach</returns>
        public Schubfach Clone()
        {
            // - MemberwiseClone() ist protected und kann nur von derselben Klasse sowie allen abgeleiteten Klassen aufgerufen werden
            // - MemberwiseClone() gibt ein Objekt vom Typ system.object zurück, d. h. Objekt muss in Kindklassenobjekt umgewandelt werden
            // - flache Kopie: alle Werttypen direkt kopiert, bei den Referenztypen nur die Referenzvariablen
            Schubfach sf1 = (Schubfach)MemberwiseClone();
            // string.Copy() gibt eine Kopie des übergebenen Strings zurück
            sf1.Farbe = string.Copy(Farbe);
            return sf1;
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
                Schubfach sf = (Schubfach)obj;
                //Farbe und AnzTischbeine, Gewicht nicht in VErgleich drin, da diese für unsere Zwecke nicht gebraucht werden
                return Laenge == sf.Laenge && Breite == sf.Breite && Hoehe == sf.Hoehe && Gewicht == sf.Gewicht && Farbe == sf.Farbe;
            }
        }

    }
}
