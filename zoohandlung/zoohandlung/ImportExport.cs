using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace zoohandlung
{
    class ImportExport
    {
        //Für den JSON Import da, damit er weiß welche Form der Import hat.
        public ObservableCollection<Nagetier> nagerListe { get; set; } = new ObservableCollection<Nagetier>();
        public ObservableCollection<Fisch> fischListe { get; set; } = new ObservableCollection<Fisch>();
        public ObservableCollection<Vogel> vogelListe { get; set; } = new ObservableCollection<Vogel>();
        public ObservableCollection<Futter> futterListe { get; set; } = new ObservableCollection<Futter>();
        public ObservableCollection<Käfig> käfigListe { get; set; } = new ObservableCollection<Käfig>();
        public ObservableCollection<Pflegeprodukte> pflegeprodukteListe { get; set; } = new ObservableCollection<Pflegeprodukte>();
        public ObservableCollection<Spielzeug> spielzeugListe { get; set; } = new ObservableCollection<Spielzeug>();

        public ImportExport()
        {

        }
    }
}
