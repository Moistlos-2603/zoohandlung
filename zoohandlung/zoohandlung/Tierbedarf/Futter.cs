﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoohandlung
{
    public class Futter : Tierbedarf
    {
        public Futter(string bezeichnung, int preis, string zielgruppe, string ablaufsDatum) : base(bezeichnung, preis, zielgruppe, ablaufsDatum)
        {

        }

        public Futter() : base()
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
            return ausgabe;
        }
    }
}
