using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoohandlung
{
    class Pflegeprodukte : Tierbedarf
    {
        public Pflegeprodukte(string bezeichnung, int preis, string ablaufsDatum) : base(bezeichnung, preis, ablaufsDatum)
        {

        }
    }
}
