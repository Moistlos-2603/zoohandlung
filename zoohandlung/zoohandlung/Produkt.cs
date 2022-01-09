using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace zoohandlung
{
    class Produkt
    {
        private static int produktZähler { get; set; }
        private int produktNummer { get; set; }
        private string bezeichnung { get;  set; }
        private int preis { get; set; }
        private bool ausleihbar { get; set; }

        public Produkt(string bezeichnung, int preis, bool ausleihbar)
        {
            produktNummer = produktZähler;
            produktZähler++;
            this.bezeichnung = bezeichnung;
            this.preis = preis;
            this.ausleihbar = ausleihbar;

        }
        public string getbezeichnung()
        {
            return this.bezeichnung;
        }

        public virtual string toString()
        {
            string ausgabe = "";
            ausgabe += "\nProduktnummer: " + this.produktNummer;
            ausgabe += "\nBezeichnung: " + this.bezeichnung;
            ausgabe += "\nPreis: " + this.preis;
            ausgabe += "\nAusleihbar: " + this.ausleihbar.ToString();
            return ausgabe;
        }

        public void saveToFile(string dateiName)
        {   
            string path = "ZoohandlungDaten";
            System.IO.Directory.CreateDirectory(path);

            string fileName = dateiName +".txt";
            path = System.IO.Path.Combine(path, fileName);
            File.WriteAllText(path, this.toString());
        }
    }
}
