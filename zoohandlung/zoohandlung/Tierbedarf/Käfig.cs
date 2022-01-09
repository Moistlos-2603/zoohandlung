using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoohandlung
{
    public class Käfig : Tierbedarf
    {
        public decimal volumenInQM {get; set; }

        public Käfig(string bezeichnung, int preis, decimal volumenInQM) : base(bezeichnung, preis, "","")
        {
            this.volumenInQM = volumenInQM;
        }

        public Käfig() : base()
        {

        }

        public override string toString()
        {
            string ausgabe = base.toString();
            ausgabe += "\nVolumen: " + this.volumenInQM.ToString();
            return ausgabe;
        }
    }
}
