using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoohandlung
{
    public class Tierbedarf : Produkt
    {
        public string ablaufsDatum { get; set; }
        public string zielgruppe { get; set; }

        public Tierbedarf(string bezeichnung, int preis, string zielgruppe, string ablaufsDatum) : base(bezeichnung, preis, false)
        {
            this.zielgruppe = zielgruppe;
            this.ablaufsDatum = ablaufsDatum;
        }

        public Tierbedarf() : base()
        {

        }

        public override string toString()
        {
            string ausgabe = base.toString();
            ausgabe += "\nAblaufsDatum: " + this.ablaufsDatum.ToString();
            ausgabe += "\nZielgruppe : " + this.zielgruppe.ToString();
            return ausgabe;
        }
    }
}
