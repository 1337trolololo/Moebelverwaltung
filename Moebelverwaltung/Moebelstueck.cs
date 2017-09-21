using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    /// <summary>
    /// abstrakte Basisklasse, die Eigenschaften und MEthoden für ein Möbelstück definiert
    /// </summary>
    
    // von abstrakter Klasse keine Objekte erzeugbar
    // Klasse mus abgeleitet (vererbt) werden
    public abstract class Moebelstueck
    {
        #region Eigenschaften
        //generierter Code mittels Code-Snippet propfull + 2xTab
        private int laenge;        
        /// <summary>
        /// Länge des Möbelstückes in cm
        /// </summary>
        public int Laenge
        {
            get { return laenge; }
            set { laenge = value; }
        }

        //generierter Code mittels Code-Snippet prop + 2xTab
        /// <summary>
        /// Breite des Möbelstückes in cm
        /// </summary>
        public int Breite { get; set; }

        //generierter Code mittels Code-Snippet propg + 2xTab
        //Eigenschaft kann nur innerhalb der Klasse gesetzt werden
        //Eigenschaft außerhalb der Klasse nur lesbar 
        //public int MyProperty { get; private set; }

        /// <summary>
        /// Höhe des Möbelstückes in cm
        /// </summary>
        public int Hoehe { get; set; }

        /// <summary>
        /// Gewicht des Möbelstückes in kg
        /// </summary>
        public double Gewicht { get; set; }

        /// <summary>
        /// Farbe des Möbelstückes
        /// </summary>
        public string Farbe { get; set; }

        /// <summary>
        /// Materialart des Möbelstückes: Holz,Stahl,Glas,Kunststoff
        /// </summary>
        public Material Materialart { get; set; }
        #endregion

        protected Moebelstueck(int laenge, int breite, int hoehe, double gewicht, string farbe, Material materialart)
        {
            Console.WriteLine("Moebelstueck(alle Parameter)");
            Laenge = laenge;
            Breite = breite;
            Hoehe = hoehe;
            Gewicht = gewicht;
            Farbe = farbe;
            Materialart = materialart;
        }

        // voll implementierte Methode
        /// <summary>
        /// gibt einen String zurück, der angibt, in welcher Firma das Möbelstück hergestellt wird
        /// </summary>
        /// <param name="firma">String, der den Firmennamen enthält</param>
        /// <returns>string - Text inkl. Firmenname</returns>
        public virtual string Herstellen(string firma) // virtual kennzeichnet eine Methode als überschreibbar
        {
            return string.Format("Das Möbelstück wird von Fa. {0} hergestellt. ", firma);
        }

        // hack(1337): 57FU

        //4b57rak73 M37h0d3, die in abgeleiteten Klassen überschrieben werden muss
        //Syntax: public abstract Rückgabetyp Methodenname(Parameterliste);
        /// <summary>
        /// berechnet den Bruttopreis
        /// </summary>
        /// <returns>double - Bruttopreis</returns>
        public abstract double BerechnePreis();
        
    }
}
