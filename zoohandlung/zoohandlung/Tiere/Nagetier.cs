using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoohandlung
{
    class Nagetier : Tier
    {
        private bool nachtAktiv { get; set; }
        private bool rudelTier { get; set; }

        public Nagetier(string bezeichnung, int preis, bool ausleihbar, string geschlecht, string haltungsSchwierigkeit, string nahrung, int gewicht, int lebensErwartung, int alter, bool nachtAktiv, bool rudelTier) : base(bezeichnung, preis, ausleihbar, "Nagetier", geschlecht, haltungsSchwierigkeit, nahrung, gewicht, lebensErwartung, alter)
        {
            this.nachtAktiv = nachtAktiv;
            this.rudelTier = rudelTier;
        }

        public override string toString()
        {
            string ausgabe = base.toString();
            ausgabe += "\nNachtaktiv: " + this.nachtAktiv.ToString();
            ausgabe += "\nRudeltier: " + this.rudelTier.ToString();
            return ausgabe;
        }
    }
}

