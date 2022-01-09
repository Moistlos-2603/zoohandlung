using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoohandlung
{
    public class Pflegeprodukte : Tierbedarf
    {
        public Pflegeprodukte(string bezeichnung, int preis, string zielgruppe, string ablaufsDatum) : base(bezeichnung, preis, zielgruppe, ablaufsDatum)
        {

        }

        public Pflegeprodukte() : base()
        {

        }

        public override string toString()
        {
            string ausgabe = base.toString();
            return ausgabe;
        }
    }
}
