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
        /// Farbe des Möbelstückes
        /// </summary>
        public int Farbe { get; set; }

        /// <summary>
        /// Materialart des Möbelstückes: Holz,Stahl,Glas,Kunststoff
        /// </summary>
        public Material Materialart { get; set; }

    }
}
