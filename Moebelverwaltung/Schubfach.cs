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
        public Schubfach() : this(30,50,20,1.0,"hellbraun")
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
        public double BerechneVolumen()
        {
            return Laenge*Breite*Hoehe;
        }

    }
}
