using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public ObservableCollection<Nagetier> nagerListe { get; set; } = new ObservableCollection<Nagetier>();
        public ObservableCollection<Fisch> fischListe { get; set; } = new ObservableCollection<Fisch>();
        public ObservableCollection<Vogel> vogelListe { get; set; } = new ObservableCollection<Vogel>();
        public ObservableCollection<Futter> futterListe { get; set; } = new ObservableCollection<Futter>();
        public ObservableCollection<Käfig> käfigListe { get; set; } = new ObservableCollection<Käfig>();
        public ObservableCollection<Pflegeprodukte> pflegeprodukteListe { get; set; } = new ObservableCollection<Pflegeprodukte>();
        public ObservableCollection<Spielzeug> spielzeugListe { get; set; } = new ObservableCollection<Spielzeug>();

        public MainWindow()
        {
            InitializeComponent();


            //Testdateien für die Konsole. 

            //Produkt testProdukt = new Produkt("Test", 10, true);
            //Trace.WriteLine(testProdukt.toString());
            //Nagetier testNagetier = new Nagetier("Hamster", 15, true, "Weibchen", "Einfach", "Gemüse", 500, 4, 3, false, false);
            //Trace.WriteLine(testNagetier.toString());
            //Fisch testFisch = new Fisch("Clownfisch", 15, true, "Männchen", "Einfach", "Fischfutter", 200, 4, 2, false, 1, 3);
            //Trace.WriteLine(testFisch.toString()); 
            //Vogel testVogel= new Vogel("Schwalbe", 15, true, "?", "Einfach", "Körner", 250, 4, 1, true, 5);
            //Trace.WriteLine(testVogel.toString());
            //Futter testFutter = new Futter("Fischfutter", 15, "Goldfische", "25.10.2022");
            //Käfig testKäfig = new Käfig("Aquarium", 100, 1);
            //Pflegeprodukte testPflegeprodukte = new Pflegeprodukte("Krallenschere", 9, "Nagetiere", "");
            //Spielzeug testSpielzeug = new Spielzeug("Laufrad", 20, "Fisch");

            testVogel.saveToFile("1"); 
            //testFisch.saveToFile("2");      

            this.DataContext = this; //Wichtig, damit der View die Daten aufrufen kann.
        }

        private void ShowLogin()
        {
            //Elemente werden sichbar und unsichbar
            LoginWindow.Visibility = Visibility.Visible;
            ShopWindow.Visibility = Visibility.Hidden;
        }

        private void HideLogin()
        {
            //Elemente werden sichbar und unsichbar
            LoginWindow.Visibility = Visibility.Hidden;
            ShopWindow.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Unterscheided zwischen Kunden und Mitarbeiter Modus, indem Knöpfe gezeigt/versteckt und Daten editierbar/nur lesbar  gemacht werden´.
        /// </summary>
        /// <param name="readOnly">Lesbarkeit boolean</param>
        private void setReadOnly(bool readOnly)
        {
            if (readOnly)
            {
                btnAdd.Visibility = Visibility.Hidden;
                btnDelete.Visibility = Visibility.Hidden;
                btnSaveSingle.Visibility = Visibility.Hidden;
                btnExportAllData.Visibility = Visibility.Hidden;
                btnGenerateData.Visibility = Visibility.Hidden;

                btnBuy.Visibility = Visibility.Visible;
            }
            else
            {
                btnAdd.Visibility = Visibility.Visible;
                btnDelete.Visibility = Visibility.Visible;
                btnSaveSingle.Visibility = Visibility.Visible;
                btnExportAllData.Visibility = Visibility.Visible;
                btnGenerateData.Visibility = Visibility.Visible;

                btnBuy.Visibility = Visibility.Hidden;
            }

            //DataGrid readonly
            NagetiereDG.IsReadOnly = readOnly;
            FischeDG.IsReadOnly = readOnly;
            VögelDG.IsReadOnly = readOnly;
            FutterDG.IsReadOnly = readOnly;
            KäfigDG.IsReadOnly = readOnly;
            PflegeprodukteDG.IsReadOnly = readOnly;
            SpielzeugDG.IsReadOnly = readOnly;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Login Button Verhalten je nach Mitarbeiter oder Kunde
            System.Windows.Controls.Button myBtn = (System.Windows.Controls.Button)sender;
            if (myBtn.Name == "mitarbeiterLogin")
            {
                setReadOnly(false);
                HideLogin();

            }
            else if (myBtn.Name == "kundenLogin")
            {
                setReadOnly(true);
                HideLogin();
            }
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            ShowLogin();
        }

        /// <summary>
        /// Fügt Beispieldatensätze zu den Kategorien hinzu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerateData_Click(object sender, RoutedEventArgs e)
        {
            Nagetier testNagetier = new Nagetier("Hamster", 15, true, "Weibchen", "Einfach", "Gemüse", 500, 4, 3, false, false);
            nagerListe.Add(testNagetier);
            testNagetier = new Nagetier("Feldmaus", 5, true, "Weibchen", "Mittel", "Feld", 150, 4, 3, true, false);
            nagerListe.Add(testNagetier);

            Fisch testFisch = new Fisch("Clownfisch", 15, true, "Männchen", "Einfach", "Fischfutter", 200, 4, 2, false, 1, 3);
            fischListe.Add(testFisch);

            Vogel testVogel = new Vogel("Schwalbe", 15, true, "?", "Einfach", "Körner", 250, 4, 1, true, 5);
            vogelListe.Add(testVogel);

            Futter testFutter = new Futter("Fischfutter", 15, "Goldfische" , "25.10.2022");
            futterListe.Add(testFutter);

            Käfig testKäfig = new Käfig("Aquarium", 100, 1);
            käfigListe.Add(testKäfig);

            Pflegeprodukte testPflegeprodukte = new Pflegeprodukte("Krallenschere", 9, "Nagetiere", "");
            pflegeprodukteListe.Add(testPflegeprodukte);

            Spielzeug testSpielzeug = new Spielzeug("Laufrad", 20, "Hamster");
            spielzeugListe.Add(testSpielzeug);

        }

        /// <summary>
        /// Öffnet FileSaveDialog und exportiert alle kategoriendaten an angewählten Speicherplart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportAllData_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == true)
            {
                string allDataText = "";

                allDataText += "Nagetiere: \n[";
                foreach (Nagetier i in nagerListe) //Für jedes Element in der Liste, die toString Methode ausführen und den gesamt Datensatz hinzufügen.
                {
                    allDataText += "\n" + i.toString();
                }
                allDataText += "\n]\n";

                allDataText += "\nFische: \n[";
                foreach (Fisch i in fischListe) 
                {
                    allDataText += "\n" + i.toString();
                }
                allDataText += "\n]\n";

                allDataText += "\nVogel: \n[";
                foreach (Vogel i in vogelListe)
                {
                    allDataText += "\n" + i.toString();
                }
                allDataText += "\n]\n";

                allDataText += "\nFutter: \n[";
                foreach (Futter i in futterListe)
                {
                    allDataText += "\n" + i.toString();
                }
                allDataText += "\n]\n";

                allDataText += "\nKäfig: \n[";
                foreach (Käfig i in käfigListe)
                {
                    allDataText += "\n" + i.toString();
                }
                allDataText += "\n]\n";

                allDataText += "\nPflegeprodukte: \n[";
                foreach (Pflegeprodukte i in pflegeprodukteListe)
                {
                    allDataText += "\n" + i.toString();
                }
                allDataText += "\n]\n";

                allDataText += "\nSpielzeug: \n[";
                foreach (Spielzeug i in spielzeugListe)
                {
                    allDataText += "\n" + i.toString();
                }
                allDataText += "\n]\n";

                File.WriteAllText(saveFileDialog.FileName, allDataText); //Schreibt die gesammelten Daten in das Zielverzeichnis.
            }

            

        }

        /// <summary>
        /// Gibt das aktuelle sichtbare DataGrid zurück.
        /// </summary>
        /// <returns>Name des sichtbaren DataGrid.</returns>
        private string getCurrentDG()
        {
            TabItem currentShopTab = (TabItem)ShopTabs.SelectedItem;
            TabItem currentTab;
            if (currentShopTab.Name == "TierTab")
            {
                currentTab = (TabItem)TierTabs.SelectedItem;
            }
            else
            {
                currentTab = (TabItem)TierbedarfTabs.SelectedItem;
            }
            if (currentTab == null) return ""; 

            string nameDG = currentTab.Name.Replace("Tab", "DG");//NagetierTab -> NagetierDG

            return nameDG; 
        }

        /// <summary>
        /// Fügt dem aktuellen DataGrid ein leeren Datensatz hinzu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string nameDG = getCurrentDG();

            if (nameDG == "NagetiereDG")
            {
                Nagetier nager = new Nagetier();
                nagerListe.Add(nager);
            }
            else if (nameDG == "FischeDG")
            {
                Fisch testFisch = new Fisch();
                fischListe.Add(testFisch);
            }
            else if (nameDG == "VögelDG")
            {
                Vogel testVogel = new Vogel();
                vogelListe.Add(testVogel);
            }
            else if (nameDG == "FutterDG")
            {
                Futter testFutter = new Futter();
                futterListe.Add(testFutter);
            }
            else if (nameDG == "KäfigDG")
            {
                Käfig testKäfig = new Käfig();
                käfigListe.Add(testKäfig);
            }
            else if (nameDG == "PflegeprodukteDG")
            {
                Pflegeprodukte testPflegeprodukte = new Pflegeprodukte();
                pflegeprodukteListe.Add(testPflegeprodukte);
            }
            else if (nameDG == "SpielzeugDG")
            {
                Spielzeug testSpielzeug = new Spielzeug();
                spielzeugListe.Add(testSpielzeug);
            }
        }

        /// <summary>
        /// Löscht, sofern zutreffend, das selektierte Element im aktuellen DataGrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string nameDG = getCurrentDG();

            DataGrid currentDG = (DataGrid)this.FindName(nameDG);
            if (currentDG == null || currentDG.SelectedItem == null) return; //Falls kein Element selektiert ist - Abbruch!

            if (nameDG == "NagetiereDG")
            {
                nagerListe.RemoveAt(currentDG.Items.IndexOf(currentDG.SelectedItem)); //Nimmt die Position des selektierten Elements und löscht die Daten an der gleichen Position in der Nagerliste.
            } 
            else if (nameDG == "FischeDG")
            {
                fischListe.RemoveAt(currentDG.Items.IndexOf(currentDG.SelectedItem));
            }
            else if (nameDG == "VögelDG")
            {
                vogelListe.RemoveAt(currentDG.Items.IndexOf(currentDG.SelectedItem));
            }
            else if (nameDG == "FutterDG")
            {
                futterListe.RemoveAt(currentDG.Items.IndexOf(currentDG.SelectedItem));
            }
            else if (nameDG == "KäfigDG")
            {
                käfigListe.RemoveAt(currentDG.Items.IndexOf(currentDG.SelectedItem));
            }
            else if (nameDG == "PflegeprodukteDG")
            {
                pflegeprodukteListe.RemoveAt(currentDG.Items.IndexOf(currentDG.SelectedItem));
            }
            else if (nameDG == "SpielzeugDG")
            {
                spielzeugListe.RemoveAt(currentDG.Items.IndexOf(currentDG.SelectedItem));
            }
        }

        /// <summary>
        ///Exportiert den aktuell selektierten Datensatz ins gewählte Verzeichnis. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveSingle_Click(object sender, RoutedEventArgs e)
        {
            string nameDG = getCurrentDG();
            DataGrid currentDG = (DataGrid)this.FindName(nameDG);
            if (currentDG == null || currentDG.SelectedItem == null) return; //Falls kein Element selektiert ist - Abbruch!

            string saveText = "";

            if (nameDG == "NagetiereDG")
            {
                saveText = nagerListe.ElementAt(currentDG.Items.IndexOf(currentDG.SelectedItem)).toString();
            }
            else if (nameDG == "FischeDG")
            {
                saveText = fischListe.ElementAt(currentDG.Items.IndexOf(currentDG.SelectedItem)).toString();
            }
            else if (nameDG == "VögelDG")
            {
                saveText = vogelListe.ElementAt(currentDG.Items.IndexOf(currentDG.SelectedItem)).toString();
            }
            else if (nameDG == "FutterDG")
            {
                saveText = futterListe.ElementAt(currentDG.Items.IndexOf(currentDG.SelectedItem)).toString();
            }
            else if (nameDG == "KäfigDG")
            {
                saveText = käfigListe.ElementAt(currentDG.Items.IndexOf(currentDG.SelectedItem)).toString();
            }
            else if (nameDG == "PflegeprodukteDG")
            {
                saveText = pflegeprodukteListe.ElementAt(currentDG.Items.IndexOf(currentDG.SelectedItem)).toString();
            }
            else if (nameDG == "SpielzeugDG")
            {
                saveText = spielzeugListe.ElementAt(currentDG.Items.IndexOf(currentDG.SelectedItem)).toString();
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, saveText);
        }

        /// <summary>
        /// Öffnet Kaufabfrage und exportiert Rechnung und enfernt gekauftes Produkt. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            string nameDG = getCurrentDG();
            DataGrid currentDG = (DataGrid)this.FindName(nameDG); //Sucht das DataGrid anhand des Namens.
            if (currentDG == null || currentDG.SelectedItem == null) return; //Falls kein Element selektiert ist - Abbruch!

            Produkt selected = null;

            if (nameDG == "NagetiereDG")
            {
                selected = nagerListe.ElementAt(currentDG.Items.IndexOf(currentDG.SelectedItem));
                
            }
            else if (nameDG == "FischeDG")
            {
                selected = fischListe.ElementAt(currentDG.Items.IndexOf(currentDG.SelectedItem));
            }
            else if (nameDG == "VögelDG")
            {
                selected = vogelListe.ElementAt(currentDG.Items.IndexOf(currentDG.SelectedItem));
            }
            else if (nameDG == "FutterDG")
            {
                selected = futterListe.ElementAt(currentDG.Items.IndexOf(currentDG.SelectedItem));
            }
            else if (nameDG == "KäfigDG")
            {
                selected = käfigListe.ElementAt(currentDG.Items.IndexOf(currentDG.SelectedItem));
            }
            else if (nameDG == "PflegeprodukteDG")
            {
                selected = pflegeprodukteListe.ElementAt(currentDG.Items.IndexOf(currentDG.SelectedItem));
            }
            else if (nameDG == "SpielzeugDG")
            {
                selected = spielzeugListe.ElementAt(currentDG.Items.IndexOf(currentDG.SelectedItem));
            }
            if (selected == null) return; //Kein selektiertes Element? - Abbruch!

            string saveText = selected.toString();

            //Kaufabfrage öffnen
            if (MessageBox.Show("Sind Sie sich sicher, dass Sie \"" + selected.bezeichnung + "\" kaufen möchten?", "Kaufen?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Rechnung speichern";
                saveFileDialog.Filter = "Text file (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == true)
                    File.WriteAllText(saveFileDialog.FileName, saveText);

                //Delete
                btnDelete_Click(null, null);
            }           
        }
    }
}
