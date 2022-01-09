using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoohandlung
{
    class Spielzeug : Tierbedarf 
    {
        public Spielzeug(string bezeichnung, int preis) : base(bezeichnung, preis, "")
        {

        }
    }
}
