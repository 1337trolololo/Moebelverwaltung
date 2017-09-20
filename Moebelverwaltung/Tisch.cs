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

            //setzen der Tischbeinanzahl nur in der selben Klasse möglich
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
    }
}
