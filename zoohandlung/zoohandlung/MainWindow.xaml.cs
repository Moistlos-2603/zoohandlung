using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using zoohandlung;

namespace zoohandlung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
            Produkt testProdukt = new Produkt("Test", 10, true);
            Trace.WriteLine(testProdukt.toString());
            Nagetier testNagetier = new Nagetier("Hamster", 15, true, "Frau", "Einfach", "Gemüse", 500, 4, 3, false, false);
            Trace.WriteLine(testNagetier.toString());
            Fisch testFisch = new Fisch("Clownfisch", 15, true, "Frau", "Einfach", "Fischfutter", 500, 4, 2, false, 1, 3);
            Trace.WriteLine(testFisch.toString()); 
            Vogel testVogel= new Vogel("Schwalbe", 15, true, "Frau", "Einfach", "Korn", 500, 4, 1, true, 5);
            Trace.WriteLine(testVogel.toString());
            Futter testFutter = new Futter("Fischfutter",15,"25.10.2022");
            Käfig testKäfig = new Käfig("Aquarium", 100);
            Pflegeprodukte testPflegeprodukte = new Pflegeprodukte("Krallenschere", 9, "");
            Spielzeug testSpielzeug = new Spielzeug("Laufrad", 20);

            testVogel.saveToFile("1"); 
            //testFisch.saveToFile("2");      

        }
    }
}
