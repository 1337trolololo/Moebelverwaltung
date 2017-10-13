using BBW.Moebelverwaltung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        //private void labelHalloWelt_Click(object sender, EventArgs e)
        //{

        //}
    }
}
