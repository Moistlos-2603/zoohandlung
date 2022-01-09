using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoohandlung
{
    public class Nagetier : Tier
    {
        public bool nachtAktiv { get; set; }
        public bool rudelTier { get; set; }

        public Nagetier(string bezeichnung, int preis, bool ausleihbar, string geschlecht, string haltungsSchwierigkeit, string nahrung, int gewicht, int lebensErwartung, int alter, bool nachtAktiv, bool rudelTier) : base(bezeichnung, preis, ausleihbar, "Nagetier", geschlecht, haltungsSchwierigkeit, nahrung, gewicht, lebensErwartung, alter)
        {
            this.nachtAktiv = nachtAktiv;
            this.rudelTier = rudelTier;
        }

        public Nagetier() : base()
        {

        }

        /// <summary>
        /// Eigene toString implementation mit allen Properties der Klasse. 
        /// Nutzt toString der Vererbenden Klasse.
        /// </summary>
        /// <returns>Properties und deren Wert als String (mehrzeilig)</returns>
        public override string toString()
        {
            string ausgabe = base.toString();
            ausgabe += "\nNachtaktiv: " + this.nachtAktiv.ToString();
            ausgabe += "\nRudeltier: " + this.rudelTier.ToString();
            return ausgabe;
        }
    }
}

