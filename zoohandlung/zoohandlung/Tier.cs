using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoohandlung
{
    class Tier : Produkte
    {
        public string rasse;
        public string name;
        public bool saeugetier;
        public string geschlecht;
        public Tier(string bezeichnung) : base(bezeichnung)
        {

        }
    }
}
