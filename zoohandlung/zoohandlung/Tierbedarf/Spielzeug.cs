using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoohandlung
{
    public class Spielzeug : Tierbedarf 
    {
        public Spielzeug(string bezeichnung, int preis, string zielgruppe) : base(bezeichnung, preis, zielgruppe, "")
        {

        }

        public Spielzeug() : base()
        {

        }

        public override string toString()
        {
            string ausgabe = base.toString();
            return ausgabe;
        }
    }
}
