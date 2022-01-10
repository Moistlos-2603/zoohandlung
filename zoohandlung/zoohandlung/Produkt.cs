using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json;

namespace zoohandlung
{
    public class Produkt
    {
        //Viele Klassenproperties mussten wir wegen der Anbindung ans WPF DataGrid zu public setzten, ansonsten wäre es zu kompliziert geworden. Wir wissen aber, dass man die eigentlich Privat setzt und mit Getter und Setter freigibt. 
        //Haben Symbolisch aber getter und setter gesetzt.
        private static int produktZähler { get; set; } //Inkrementiert mit jedem generierten Produkt.
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
            //Leerdatensatz erzeugen (für DataGrid Insert)
        }

        /// <summary>
        /// Eigene toString implementation mit allen Properties der Klasse.
        /// Wird nicht mehr verwendet. Ersetzt von toJSON
        /// </summary>
        /// <returns>Properties und deren Wert als String (mehrzeilig)</returns>
        public virtual string toString()
        {
            string ausgabe = "";
            ausgabe += "\nProduktnummer: " + this.produktNummer;
            ausgabe += "\nBezeichnung: " + this.bezeichnung;
            ausgabe += "\nPreis: " + this.preis;
            ausgabe += "\nAusleihbar: " + this.ausleihbar.ToString();
            return ausgabe;
        }

        /// <summary>
        /// Wandelt Produkt in JSON um und returnd es als String.
        /// </summary>
        /// <returns></returns>
        public string toJSON()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }

        /// <summary>
        /// Speichert den durch toString erhaltenen Textblock in einer Datei.
        /// </summary>
        /// <param name="dateiName">Name der Zieldatei</param>
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
