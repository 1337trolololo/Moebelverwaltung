using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
   public class Steckdosenleiste
    {
        //Attribute
        private uint anzSteckdosen;
        private string farbe;

        //Eigenschaften
        public uint AnzSteckdosen { get; set; }
        public string Farbe { get; set; }

        //Konstruktoren
        public Steckdosenleiste() : this(3, "weiß")
        {
            Console.WriteLine("Steckdosenleiste()");
        }

        //Konstruktorüberladung:
        //gleicher Name, aber eine unterschiedliche Parameterliste        
        //Konstruktor mit optionalen Parametern
        // - optionale Parameter müssen immer am Ende stehen
        public Steckdosenleiste(uint anzSteckdosen, string farbe)
        {
            Console.WriteLine("Schubfach(5 Parameter)");
            //Setzen der Länge -> Aufruf der set-Methode der Eigenschaft
            AnzSteckdosen = anzSteckdosen;
            Farbe = farbe;
            
        }

    }
}
