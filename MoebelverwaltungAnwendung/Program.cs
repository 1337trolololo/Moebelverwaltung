using BBW.Moebelverwaltung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoebelverwaltungAnwendung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klasse sowie deren Member müssen public sein, um sie in diesem Projekt verwenden zu können
            Tisch t1 = new Tisch();
            Console.WriteLine(t1.ToString());
        }
    }
}
