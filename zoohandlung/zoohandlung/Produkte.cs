using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoohandlung
{
    class Produkte
    {
        public static int id_produkte { get; set; }
        public string bezeichnung { get; private set; }
        
        public Produkte(string bezeichnung)
        {
            id_produkte++;
            this.bezeichnung = bezeichnung;

        }
        public string getbezeichnung()
        {
            return this.bezeichnung;
        }
  
    }
}
