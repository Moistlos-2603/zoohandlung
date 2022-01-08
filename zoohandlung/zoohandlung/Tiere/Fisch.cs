using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoohandlung
{
    class Fisch : Tier
    {
        private bool süßWasser { get; set; }
        private int rückenFlossen { get; set; }
        private int längeInCM { get; set; }

        public Fisch(string bezeichnung, int preis, bool ausleihbar, string geschlecht, string haltungsSchwierigkeit, string nahrung, int gewicht, int lebensErwartung, int alter, bool süßWasser, int rückenFlossen, int längeInCM) : base(bezeichnung, preis, ausleihbar, "Fisch", geschlecht, haltungsSchwierigkeit, nahrung, gewicht, lebensErwartung, alter)
        {
            this.süßWasser = süßWasser;
            this.rückenFlossen = rückenFlossen;
            this.längeInCM = längeInCM;
        }

        public override string toString()
        {
            string ausgabe = base.toString();
            ausgabe += "\nSüßwasser: " + this.süßWasser.ToString();
            ausgabe += "\nRückenflossen Anzahl : " + this.rückenFlossen.ToString();
            ausgabe += "\nLänge in CM: " + this.längeInCM.ToString();
            return ausgabe;
        }
    }
}

