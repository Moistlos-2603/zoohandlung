using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoohandlung
{
    class Tier : Produkt
    {
        
        private string klasse { get; set; }
        private string geschlecht { get; set; }
        private string haltungsSchwierigkeit { get; set; }
        private string nahrung { get; set; }
        private int gewicht { get; set; }
        private int lebensErwartung { get; set; }
        private int alter { get; set; }

        public Tier(string bezeichnung, int preis, bool ausleihbar, string klasse, string geschlecht, string haltungsSchwierigkeit, string nahrung, int gewicht, int lebensErwartung, int alter) : base(bezeichnung, preis, ausleihbar)
        {
            this.klasse = klasse;
            this.geschlecht = geschlecht;
            this.haltungsSchwierigkeit = haltungsSchwierigkeit;
            this.nahrung = nahrung;
            this.gewicht = gewicht;
            this.lebensErwartung = lebensErwartung;
            this.alter = alter;
        }
    }
}
