using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace zoohandlung
{
    public class Produkt
    {
        private static int produktZähler { get; set; }
        public int produktNummer { get; set; }
        public string bezeichnung { get;  set; }
        public int preis { get; set; }
        public bool ausleihbar { get; set; }

        public Produkt(string bezeichnung, int preis, bool ausleihbar)
        {
            produktNummer = produktZähler;
            produktZähler++;
            this.bezeichnung = bezeichnung;
            this.preis = preis;
            this.ausleihbar = ausleihbar;

        }

        public Produkt()
        {

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
