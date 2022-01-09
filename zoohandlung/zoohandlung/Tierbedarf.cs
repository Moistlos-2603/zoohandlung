using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoohandlung
{
    class Tierbedarf : Produkt
    {
        private string ablaufsDatum { get; set; }

        public Tierbedarf(string bezeichnung, int preis, string ablaufsDatum) : base(bezeichnung, preis, false)
        {

        }
    }
}
