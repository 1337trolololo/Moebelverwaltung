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
            string hoehe = txtHoehe.Value.ToString();
            string anzahl = txtAnzahl.Text;
            string gewicht = txtGewicht.Text;
            string farbe = txtFarbe.Text;
            //ausgewählten Wert aus der ComboBox in String umwandeln
            string material = cmbMaterial.SelectedValue.ToString();
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
            }
        }

        //private void labelHalloWelt_Click(object sender, EventArgs e)
        //{

        //}
    }
}
