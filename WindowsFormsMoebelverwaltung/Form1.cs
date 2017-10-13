using BBW.Moebelverwaltung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMoebelverwaltung
{
    //partielle Klassen verwendet, um den Quellcode einer Klasse in mehrere Dateien aufzuteilen    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAendern_Click(object sender, EventArgs e)
        {
            if (labelHalloWelt.Text == "Hallo Welt")
            {
                labelHalloWelt.Text = "Guten Tag";
            }
            else
            {
                labelHalloWelt.Text = "Hallo Welt";
            }
        }



        private void btnAnzeigen_Click_1(object sender, EventArgs e)
        {
            string laenge = txtLaenge.Text;
            string breite = txtBreite.Text;
            //txtHoehe ist vom Typ NumericUpDown
            //Eigenschaft Value gibt ein decimal-Wert zurück
            string hoehe = numHoehe.Value.ToString();
            string anzahl = txtAnzahl.Text;
            string gewicht = txtGewicht.Text;
            string farbe = txtFarbe.Text;
            //ausgewählten Wert aus der ComboBox in String umwandeln
            string material = cmbMaterial.SelectedItem.ToString();
            string text = String.Format("Tisch: {0} cm x {1} cm x {2} cm", laenge, breite, hoehe);
            text += " Farbe: " + farbe + " Material: " + material;
            MessageBox.Show(text);
        }

        //wird ausgeführt, bevor Formular angezeigt wird
        private void Form1_Load(object sender, EventArgs e)
        {
            Material m = Material.Holz;
            //Enum.GetNames() liefert alle Enum-Konstanten als string[] zurück
            //GetNames() muss ein Type-Objekt übergeben werden
            //GetType() ist eine Objektmethode
            //-> muss für ein Objekt aufgerufen werden
            
            foreach (var item in Enum.GetNames(m.GetType()))
            {
                //ComboBox hat Eigenschaft Items, der mittels Add() die Elemente hinzugefügt werden
                cmbMaterial.Items.Add(item);
                cmbSchrankMaterial.Items.Add(item);
            }
            chkFormular.Checked = true;
            cmbMaterial.Text = "Bitte auswählen";
            cmbSchrankMaterial.Text = "Bitte auswählen";
            radioSchrankStandard.Checked = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbMaterial.Text = "Bitte auswählen";            
            txtAnzahl.Text = "";
            txtBreite.Text = "";
            txtFarbe.Text = "";
            txtGewicht.Text = "";
            numHoehe.Value = 20;
            txtLaenge.Text = "";
        }

        //Ereignis wird ausgeführt,
        //wenn eine andere Registerseite geöffnet werden soll
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //wenn haken gesetzt ist und Register "Formular Tische" ausgewählt ist, soll Formular angezeigt werden
            if (chkFormular.Checked && tabControl1.SelectedTab == tabFormularTische)
            {
                //Anzeige des Formulares "Fomular Tische"
                tabControl1.SelectedTab = tabFormularTische;
            }
            else if ((chkFormular.Checked && tabControl1.SelectedTab == tabFormularSchraenke))
            {
                tabControl1.SelectedTab = tabFormularSchraenke;
            }
            else if ((!(chkFormular.Checked) && tabControl1.SelectedTab == tabFormularTische) || (!(chkFormular.Checked) && tabControl1.SelectedTab == tabFormularSchraenke))
            {               
                //Weiterleitung an "Seite3"
                tabControl1.SelectedTab = tabSeite3;
                MessageBox.Show("Keine Rechte zum Anzeigen");
            }             
            
        }

        private void chkFormular_CheckedChanged(object sender, EventArgs e)
        {
            if ((!(chkFormular.Checked) && tabControl1.SelectedTab == tabFormularTische) || (!(chkFormular.Checked) && tabControl1.SelectedTab == tabFormularSchraenke))
            {               
                tabControl1.SelectedTab = tabAllgemein;
            }
        }

        private void btnSchrankReset_Click(object sender, EventArgs e)
        {
            cmbSchrankMaterial.Text = "Bitte auswählen";
            txtSchrankAnzahlBoeden.Clear();
            txtSchrankBreite.Clear();
            txtSchrankFarbe.Clear();
            txtSchrankGewicht.Clear();
            numSchrankHoehe.Value = 20;
            txtSchrankLaenge.Clear();
        }

        private void btnSchrankAnzeigen_Click(object sender, EventArgs e)
        {
            string laenge = txtSchrankLaenge.Text;
            string breite = txtSchrankBreite.Text;
            string hoehe = numSchrankHoehe.Value.ToString();
            string anzahlBoeden = txtSchrankAnzahlBoeden.Text;
            string gewicht = txtSchrankGewicht.Text;
            string farbe = txtSchrankFarbe.Text;
            string material = cmbSchrankMaterial.SelectedItem.ToString();
            string text = String.Format("Schrank: {0} cm x {1} cm x {2} cm", laenge, breite, hoehe);
            text += " Farbe: " + farbe + " Material: " + material + " Einlegeböden: " + anzahlBoeden;
            MessageBox.Show(text);
        }

       

        private void radioSchrankStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSchrankStandard.Checked)
            {
                SchrankSchriftFarbeAendern(Color.Black);
            }
        }



        private void radioSchrankRot_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSchrankRot.Checked)
            {
                SchrankSchriftFarbeAendern(Color.Red);
            }
        }

        private void radioSchrankBlau_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSchrankBlau.Checked)
            {
                SchrankSchriftFarbeAendern(Color.Blue);
            }
        }

        private void SchrankSchriftFarbeAendern(Color f)
        {
            //txtSchrankLaenge.ForeColor = f;
            //txtSchrankBreite.ForeColor = f;
            //numSchrankHoehe.ForeColor = f;
            //txtSchrankAnzahlBoeden.ForeColor = f;
            //txtSchrankGewicht.ForeColor = f;
            //txtSchrankFarbe.ForeColor = f;
            //cmbSchrankMaterial.ForeColor = f;

            foreach (var item in tabFormularSchraenke.Controls)
            {
                if (item is Label)
                {
                    (item as Label).ForeColor = f;
                }
                else if (item is TextBox)
                {
                    (item as TextBox).ForeColor = f;
                }
                else if (item is NumericUpDown)
                {
                    (item as NumericUpDown).ForeColor = f;
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).ForeColor = f;
                }
            }
        }

        private void btnFarbauswahl_Click(object sender, EventArgs e)
        {
            //legt fest, ob benutzerdefinierte farben erstellt werden können
            colorDialog1.AllowFullOpen = true;
            //legt vorausgewählte Farbe fest
            //Hintergrundfarbe des Tabs
            colorDialog1.Color = tabFormularSchraenke.BackColor;

            //prüft, ob Schaltfläche "OK" geklickt wurde
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //Hintergrundfarbe für das Tab setzen
                tabFormularSchraenke.BackColor = colorDialog1.Color;
            }

        }

        private void txtSchrankFarbe_Leave(object sender, EventArgs e)
        {
            
                //Farbnamen werden kleingeschrieben, dürfen nur Buchstaben enthalten, mind. 3 Buchstaben
                //Prüfung mittels regulären Ausdrücken
                //{min,max}, {min,}, {,max}, {genaue Anzahl}
                string muster = "\\b[a-zäöüß]{3,}\\b";
                //Regex-Objekt benötigt, das mit dem regulären Ausdruck initialisiert wird
                Regex ausdruck = new Regex(muster);

                if (ausdruck.IsMatch(txtSchrankFarbe.Text))
                {
                    MessageBox.Show("passt");
                }
                else
                {
                    MessageBox.Show("Farbnamen müssen klein geschrieben werden, dürfen nur Buchstaben enthalten und müssen mindestens 3 Zeichen lang sein!");
                    txtFarbe.Text = "";
                }
            

        }

        private void txtSchrankFarbe_KeyDown(object sender, KeyEventArgs e)
        {
            //prüfen, ob Enter gedrückt wurde
            if (e.KeyCode == Keys.Enter)
            {
                //Farbnamen werden kleingeschrieben, dürfen nur Buchstaben enthalten, mind. 3 Buchstaben
                //Prüfung mittels regulären Ausdrücken
                //{min,max}, {min,}, {,max}, {genaue Anzahl}
                string muster = "\\b[a-zäöüß]{3,}\\b";
                //Regex-Objekt benötigt, das mit dem regulären Ausdruck initialisiert wird
                Regex ausdruck = new Regex(muster);

                if (ausdruck.IsMatch(txtSchrankFarbe.Text))
                {
                    MessageBox.Show("passt");
                }
                else
                {
                    MessageBox.Show("Farbnamen müssen klein geschrieben werden, dürfen nur Buchstaben enthalten und müssen mindestens 3 Zeichen lang sein!");
                    txtFarbe.Text = "";
                }
            }
        }

        private void txtAdresszeile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //zuweisen der Webadresse an den Browser
                webBrowser1.Url = new Uri(txtAdresszeile.Text);
            }
        }

        private void btnSpeichernDatei_Click(object sender, EventArgs e)
        {
            string laenge = txtSchrankLaenge.Text;
            string breite = txtSchrankBreite.Text;
            string hoehe = numSchrankHoehe.Value.ToString();
            string anzahlBoeden = txtSchrankAnzahlBoeden.Text;
            string gewicht = txtSchrankGewicht.Text;
            //gibt die Teilzeichenkette bis zum ersten Leerzeichen zurück
            string farbe;
            if (txtSchrankFarbe.Text.Contains(" "))
            {
                farbe = txtSchrankFarbe.Text.Substring(0, txtSchrankFarbe.Text.IndexOf(" "));
            }
            else
            {
                farbe = txtSchrankFarbe.Text;
            }
            
            string material = cmbSchrankMaterial.SelectedItem.ToString();

            //StringbUilder ist eine veränderliche Zeichenkette
            StringBuilder sb = new StringBuilder();
            

            sb.Append(laenge);
            sb.Append(";");
            sb.Append(breite);
            sb.Append(";");
            sb.Append(hoehe);
            sb.Append(";");
            sb.Append(anzahlBoeden);
            sb.Append(";");
            sb.Append(gewicht);
            sb.Append(";");
            sb.Append(farbe);
            sb.Append(";");
            sb.Append(material);
              

            saveFileDialog1.InitialDirectory = Application.StartupPath;

            //filtert die Auswahl von dateitypen
            //Syntax: "Anzeige für Benutzer(z. B. CSV-Dateien(*.csv)|*.Dateiendung)
            saveFileDialog1.Filter = "CSV-Dateien (*.csv)|*.csv|Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = null;
                //alle Anweisungen die Fehler verursachen könnten, werden in den try-Block geschrieben
                try
                {
                    //Dateipfad in einer VAriable speichern
                    string pfad = saveFileDialog1.FileName;
                    //erzeugt ein StreamWriter-Objekt
                    //2. PArameter gibt an, ob die Datei angehangen werden soll
                    //ist die Datei nicht vorhanden, wird diese angelegt
                    sw = new StreamWriter(pfad, true);
                    //Schreiben des StringBuilder-Objektes in die
                    sw.WriteLine(sb.ToString());
                }
                //catch-Blöcke behandeln Fehler
                //catch-Blöcke von der spezifischten zur allgemeinsten Exception ordnen
                catch (IOException ex)
                {
                    MessageBox.Show("Fehler bei Arbeit mit Dateien: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: " + ex.Message);
                    throw;
                }
                //finally-Block wird immer ausgeführt
                finally
                {
                    if (sw != null)
                    {
                        sw.Close();
                    }
                }
            }                        
        }

        private void btnDateiLesen_Click(object sender, EventArgs e)
        {
            //leeren der Listbox
            listBoxDateiinhalt.Items.Clear();
            //Erzeugen eines OpenFileDialoges
            OpenFileDialog dateiOeffnen = new OpenFileDialog();

            dateiOeffnen.InitialDirectory = Application.StartupPath;
            //filtert die Auswahl von dateitypen
            //Syntax: "Anzeige für Benutzer(z. B. CSV-Dateien(*.csv)|*.Dateiendung)
            dateiOeffnen.Filter = "CSV-Dateien (*.csv)|*.csv|Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*";
            if (dateiOeffnen.ShowDialog() == DialogResult.OK)
            {
                string dateiname = dateiOeffnen.FileName;
                //prüfen, ob es sich um Textdateien, CSV-Dateien handelt
                if (dateiname.EndsWith(".txt") || dateiname.EndsWith(".csv"))
                {
                    StreamReader sr = new StreamReader(dateiname);
                    string inhalt = "";
                    try
                    {
                        //Erzeugen des StreamReader-Objektes
                        sr = new StreamReader(dateiname);
                        if (sr != null)
                        {
                            while ((inhalt = sr.ReadLine()) != null)
                            {
                                listBoxDateiinhalt.Items.Add(inhalt);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fehler: " + ex.Message);
                    }
                    finally
                    {
                        if (sr != null)
                        {
                            sr.Close();
                        }
                    }
                }
            }

        }

        //private void labelHalloWelt_Click(object sender, EventArgs e)
        //{

        //}
    }
}
