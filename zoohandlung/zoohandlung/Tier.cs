using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoohandlung
{
    public class Tier : Produkt
    {
        //Viele Klassenproperties mussten wir wegen der Anbindung ans WPF DataGrid zu public setzten, ansonsten wäre es zu kompliziert geworden. Wir wissen aber, dass man die eigentlich Privat setzt und mit Getter und Setter freigibt. Haben Symbolisch aber getter und setter gesetzt.

        public string klasse { get; set; }
        public string geschlecht { get; set; }
        public string haltungsSchwierigkeit { get; set; }
        public string nahrung { get; set; }
        public int gewicht { get; set; }
        public int lebensErwartung { get; set; }
        public int alter { get; set; }

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

        public Tier() : base()
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
            ausgabe += "\nKlasse: " + this.klasse.ToString();
            ausgabe += "\nGeschlecht : " + this.geschlecht.ToString();
            ausgabe += "\nHaltungsSchwierigkeit: " + this.haltungsSchwierigkeit.ToString();
            ausgabe += "\nNahrung: " + this.nahrung.ToString();
            ausgabe += "\nGewicht: " + this.gewicht.ToString();
            ausgabe += "\nLebenserwartung: " + this.lebensErwartung.ToString();
            ausgabe += "\nAlter: " + this.alter.ToString();
            return ausgabe;
        }
    }
}
