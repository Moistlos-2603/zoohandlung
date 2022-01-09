using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoohandlung
{
    public class Futter : Tierbedarf
    {
        public Futter(string bezeichnung, int preis, string zielgruppe, string ablaufsDatum) : base(bezeichnung, preis, zielgruppe, ablaufsDatum)
        {

        }

        public Futter() : base()
        {

        }

        public override string toString()
        {
            string ausgabe = base.toString();
            return ausgabe;
        }
    }
}
