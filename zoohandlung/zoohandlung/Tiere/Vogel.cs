using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoohandlung
{
    class Vogel : Tier
    {
        public bool flugFähig;
        public int flügelSpannweiteInCM;

        public Vogel(string bezeichnung, int preis, bool ausleihbar, string geschlecht, string haltungsSchwierigkeit, string nahrung, int gewicht, int lebensErwartung, int alter, bool flugFähig, int flügelSpannweiteInCM) : base(bezeichnung, preis, ausleihbar, "Vogel", geschlecht, haltungsSchwierigkeit, nahrung, gewicht, lebensErwartung, alter)
        {
            this.flugFähig = flugFähig;
            this.flügelSpannweiteInCM = flügelSpannweiteInCM;
        }
        public override string toString()
        {
            string ausgabe = base.toString();
            ausgabe += "\nFlugfähig: " + this.flugFähig.ToString();
            ausgabe += "\nFlügelspannweite in CM : " + this.flügelSpannweiteInCM.ToString();
            return ausgabe;
        }
    }
}
