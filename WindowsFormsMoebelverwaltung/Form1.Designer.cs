namespace WindowsFormsMoebelverwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAllgemein = new System.Windows.Forms.TabPage();
            this.btnAendern = new System.Windows.Forms.Button();
            this.labelHalloWelt = new System.Windows.Forms.Label();
            this.tabFormularTische = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAnzeigen = new System.Windows.Forms.Button();
            this.numHoehe = new System.Windows.Forms.NumericUpDown();
            this.labelTischbeine = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.txtAnzahl = new System.Windows.Forms.TextBox();
            this.labelFarbe = new System.Windows.Forms.Label();
            this.txtFarbe = new System.Windows.Forms.TextBox();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.txtGewicht = new System.Windows.Forms.TextBox();
            this.labelGewicht = new System.Windows.Forms.Label();
            this.labelHoehe = new System.Windows.Forms.Label();
            this.txtBreite = new System.Windows.Forms.TextBox();
            this.labelBreite = new System.Windows.Forms.Label();
            this.txtLaenge = new System.Windows.Forms.TextBox();
            this.labelLaenge = new System.Windows.Forms.Label();
            this.tabSeite3 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtAdresszeile = new System.Windows.Forms.TextBox();
            this.tabFormularSchraenke = new System.Windows.Forms.TabPage();
            this.btnSpeichernDatei = new System.Windows.Forms.Button();
            this.btnFarbauswahl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioSchrankStandard = new System.Windows.Forms.RadioButton();
            this.radioSchrankBlau = new System.Windows.Forms.RadioButton();
            this.radioSchrankRot = new System.Windows.Forms.RadioButton();
            this.btnSchrankReset = new System.Windows.Forms.Button();
            this.btnSchrankAnzeigen = new System.Windows.Forms.Button();
            this.numSchrankHoehe = new System.Windows.Forms.NumericUpDown();
            this.labelSchrankAnzahlBoeden = new System.Windows.Forms.Label();
            this.cmbSchrankMaterial = new System.Windows.Forms.ComboBox();
            this.txtSchrankAnzahlBoeden = new System.Windows.Forms.TextBox();
            this.labelSchrankFarbe = new System.Windows.Forms.Label();
            this.txtSchrankFarbe = new System.Windows.Forms.TextBox();
            this.labelSchrankMaterial = new System.Windows.Forms.Label();
            this.txtSchrankGewicht = new System.Windows.Forms.TextBox();
            this.labelSchrankGewicht = new System.Windows.Forms.Label();
            this.labelSchrankHoehe = new System.Windows.Forms.Label();
            this.txtSchrankBreite = new System.Windows.Forms.TextBox();
            this.labelSchrankBreite = new System.Windows.Forms.Label();
            this.txtSchrankLaenge = new System.Windows.Forms.TextBox();
            this.labelSchrankLaenge = new System.Windows.Forms.Label();
            this.chkFormular = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabAnzeige = new System.Windows.Forms.TabPage();
            this.listBoxDateiinhalt = new System.Windows.Forms.ListBox();
            this.btnDateiLesen = new System.Windows.Forms.Button();
            this.btnOeffnenExtern = new System.Windows.Forms.Button();
            this.tabDB = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDBAnzeigen = new System.Windows.Forms.Button();
            this.btnSpeichernDB = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAllgemein.SuspendLayout();
            this.tabFormularTische.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHoehe)).BeginInit();
            this.tabSeite3.SuspendLayout();
            this.tabFormularSchraenke.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSchrankHoehe)).BeginInit();
            this.tabAnzeige.SuspendLayout();
            this.tabDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAllgemein);
            this.tabControl1.Controls.Add(this.tabFormularTische);
            this.tabControl1.Controls.Add(this.tabSeite3);
            this.tabControl1.Controls.Add(this.tabFormularSchraenke);
            this.tabControl1.Controls.Add(this.tabAnzeige);
            this.tabControl1.Controls.Add(this.tabDB);
            this.tabControl1.Location = new System.Drawing.Point(12, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1061, 392);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabAllgemein
            // 
            this.tabAllgemein.Controls.Add(this.btnAendern);
            this.tabAllgemein.Controls.Add(this.labelHalloWelt);
            this.tabAllgemein.Location = new System.Drawing.Point(4, 22);
            this.tabAllgemein.Name = "tabAllgemein";
            this.tabAllgemein.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllgemein.Size = new System.Drawing.Size(1053, 366);
            this.tabAllgemein.TabIndex = 0;
            this.tabAllgemein.Text = "Allgemeines";
            this.tabAllgemein.UseVisualStyleBackColor = true;
            // 
            // btnAendern
            // 
            this.btnAendern.Location = new System.Drawing.Point(111, 107);
            this.btnAendern.Name = "btnAendern";
            this.btnAendern.Size = new System.Drawing.Size(75, 23);
            this.btnAendern.TabIndex = 1;
            this.btnAendern.Text = "Text ändern";
            this.btnAendern.UseVisualStyleBackColor = true;
            this.btnAendern.Click += new System.EventHandler(this.btnAendern_Click);
            // 
            // labelHalloWelt
            // 
            this.labelHalloWelt.AutoSize = true;
            this.labelHalloWelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHalloWelt.Location = new System.Drawing.Point(86, 60);
            this.labelHalloWelt.Name = "labelHalloWelt";
            this.labelHalloWelt.Size = new System.Drawing.Size(81, 20);
            this.labelHalloWelt.TabIndex = 0;
            this.labelHalloWelt.Text = "Hallo Welt";
            // 
            // tabFormularTische
            // 
            this.tabFormularTische.Controls.Add(this.btnReset);
            this.tabFormularTische.Controls.Add(this.btnAnzeigen);
            this.tabFormularTische.Controls.Add(this.numHoehe);
            this.tabFormularTische.Controls.Add(this.labelTischbeine);
            this.tabFormularTische.Controls.Add(this.cmbMaterial);
            this.tabFormularTische.Controls.Add(this.txtAnzahl);
            this.tabFormularTische.Controls.Add(this.labelFarbe);
            this.tabFormularTische.Controls.Add(this.txtFarbe);
            this.tabFormularTische.Controls.Add(this.labelMaterial);
            this.tabFormularTische.Controls.Add(this.txtGewicht);
            this.tabFormularTische.Controls.Add(this.labelGewicht);
            this.tabFormularTische.Controls.Add(this.labelHoehe);
            this.tabFormularTische.Controls.Add(this.txtBreite);
            this.tabFormularTische.Controls.Add(this.labelBreite);
            this.tabFormularTische.Controls.Add(this.txtLaenge);
            this.tabFormularTische.Controls.Add(this.labelLaenge);
            this.tabFormularTische.Location = new System.Drawing.Point(4, 22);
            this.tabFormularTische.Name = "tabFormularTische";
            this.tabFormularTische.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormularTische.Size = new System.Drawing.Size(1053, 366);
            this.tabFormularTische.TabIndex = 1;
            this.tabFormularTische.Text = "Formular Tische";
            this.tabFormularTische.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(178, 336);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAnzeigen
            // 
            this.btnAnzeigen.Location = new System.Drawing.Point(96, 337);
            this.btnAnzeigen.Name = "btnAnzeigen";
            this.btnAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.btnAnzeigen.TabIndex = 15;
            this.btnAnzeigen.Text = "Anzeigen";
            this.btnAnzeigen.UseVisualStyleBackColor = true;
            this.btnAnzeigen.Click += new System.EventHandler(this.btnAnzeigen_Click_1);
            // 
            // numHoehe
            // 
            this.numHoehe.Location = new System.Drawing.Point(96, 55);
            this.numHoehe.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numHoehe.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numHoehe.Name = "numHoehe";
            this.numHoehe.Size = new System.Drawing.Size(100, 20);
            this.numHoehe.TabIndex = 14;
            this.numHoehe.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // labelTischbeine
            // 
            this.labelTischbeine.AutoSize = true;
            this.labelTischbeine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTischbeine.Location = new System.Drawing.Point(565, 5);
            this.labelTischbeine.Name = "labelTischbeine";
            this.labelTischbeine.Size = new System.Drawing.Size(89, 20);
            this.labelTischbeine.TabIndex = 13;
            this.labelTischbeine.Text = "Tischbeine:";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(377, 31);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(121, 21);
            this.cmbMaterial.TabIndex = 12;
            // 
            // txtAnzahl
            // 
            this.txtAnzahl.Location = new System.Drawing.Point(655, 7);
            this.txtAnzahl.Name = "txtAnzahl";
            this.txtAnzahl.Size = new System.Drawing.Size(100, 20);
            this.txtAnzahl.TabIndex = 11;
            // 
            // labelFarbe
            // 
            this.labelFarbe.AutoSize = true;
            this.labelFarbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFarbe.Location = new System.Drawing.Point(287, 56);
            this.labelFarbe.Name = "labelFarbe";
            this.labelFarbe.Size = new System.Drawing.Size(55, 20);
            this.labelFarbe.TabIndex = 10;
            this.labelFarbe.Text = "Farbe:";
            // 
            // txtFarbe
            // 
            this.txtFarbe.Location = new System.Drawing.Point(377, 58);
            this.txtFarbe.Name = "txtFarbe";
            this.txtFarbe.Size = new System.Drawing.Size(100, 20);
            this.txtFarbe.TabIndex = 9;
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterial.Location = new System.Drawing.Point(287, 29);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(69, 20);
            this.labelMaterial.TabIndex = 8;
            this.labelMaterial.Text = "Material:";
            // 
            // txtGewicht
            // 
            this.txtGewicht.Location = new System.Drawing.Point(377, 5);
            this.txtGewicht.Name = "txtGewicht";
            this.txtGewicht.Size = new System.Drawing.Size(100, 20);
            this.txtGewicht.TabIndex = 7;
            // 
            // labelGewicht
            // 
            this.labelGewicht.AutoSize = true;
            this.labelGewicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGewicht.Location = new System.Drawing.Point(287, 3);
            this.labelGewicht.Name = "labelGewicht";
            this.labelGewicht.Size = new System.Drawing.Size(71, 20);
            this.labelGewicht.TabIndex = 6;
            this.labelGewicht.Text = "Gewicht:";
            // 
            // labelHoehe
            // 
            this.labelHoehe.AutoSize = true;
            this.labelHoehe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoehe.Location = new System.Drawing.Point(6, 55);
            this.labelHoehe.Name = "labelHoehe";
            this.labelHoehe.Size = new System.Drawing.Size(52, 20);
            this.labelHoehe.TabIndex = 4;
            this.labelHoehe.Text = "Höhe:";
            // 
            // txtBreite
            // 
            this.txtBreite.Location = new System.Drawing.Point(96, 31);
            this.txtBreite.Name = "txtBreite";
            this.txtBreite.Size = new System.Drawing.Size(100, 20);
            this.txtBreite.TabIndex = 3;
            // 
            // labelBreite
            // 
            this.labelBreite.AutoSize = true;
            this.labelBreite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBreite.Location = new System.Drawing.Point(6, 29);
            this.labelBreite.Name = "labelBreite";
            this.labelBreite.Size = new System.Drawing.Size(55, 20);
            this.labelBreite.TabIndex = 2;
            this.labelBreite.Text = "Breite:";
            // 
            // txtLaenge
            // 
            this.txtLaenge.Location = new System.Drawing.Point(96, 5);
            this.txtLaenge.Name = "txtLaenge";
            this.txtLaenge.Size = new System.Drawing.Size(100, 20);
            this.txtLaenge.TabIndex = 1;
            // 
            // labelLaenge
            // 
            this.labelLaenge.AutoSize = true;
            this.labelLaenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaenge.Location = new System.Drawing.Point(6, 3);
            this.labelLaenge.Name = "labelLaenge";
            this.labelLaenge.Size = new System.Drawing.Size(58, 20);
            this.labelLaenge.TabIndex = 0;
            this.labelLaenge.Text = "Länge:";
            // 
            // tabSeite3
            // 
            this.tabSeite3.Controls.Add(this.webBrowser1);
            this.tabSeite3.Controls.Add(this.txtAdresszeile);
            this.tabSeite3.Location = new System.Drawing.Point(4, 22);
            this.tabSeite3.Name = "tabSeite3";
            this.tabSeite3.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeite3.Size = new System.Drawing.Size(1053, 366);
            this.tabSeite3.TabIndex = 2;
            this.tabSeite3.Text = "Seite3";
            this.tabSeite3.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(6, 30);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1041, 321);
            this.webBrowser1.TabIndex = 1;
            // 
            // txtAdresszeile
            // 
            this.txtAdresszeile.Location = new System.Drawing.Point(7, 4);
            this.txtAdresszeile.Name = "txtAdresszeile";
            this.txtAdresszeile.Size = new System.Drawing.Size(1040, 20);
            this.txtAdresszeile.TabIndex = 0;
            this.txtAdresszeile.Text = "http://";
            this.txtAdresszeile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdresszeile_KeyDown);
            // 
            // tabFormularSchraenke
            // 
            this.tabFormularSchraenke.Controls.Add(this.btnSpeichernDB);
            this.tabFormularSchraenke.Controls.Add(this.btnSpeichernDatei);
            this.tabFormularSchraenke.Controls.Add(this.btnFarbauswahl);
            this.tabFormularSchraenke.Controls.Add(this.panel1);
            this.tabFormularSchraenke.Controls.Add(this.btnSchrankReset);
            this.tabFormularSchraenke.Controls.Add(this.btnSchrankAnzeigen);
            this.tabFormularSchraenke.Controls.Add(this.numSchrankHoehe);
            this.tabFormularSchraenke.Controls.Add(this.labelSchrankAnzahlBoeden);
            this.tabFormularSchraenke.Controls.Add(this.cmbSchrankMaterial);
            this.tabFormularSchraenke.Controls.Add(this.txtSchrankAnzahlBoeden);
            this.tabFormularSchraenke.Controls.Add(this.labelSchrankFarbe);
            this.tabFormularSchraenke.Controls.Add(this.txtSchrankFarbe);
            this.tabFormularSchraenke.Controls.Add(this.labelSchrankMaterial);
            this.tabFormularSchraenke.Controls.Add(this.txtSchrankGewicht);
            this.tabFormularSchraenke.Controls.Add(this.labelSchrankGewicht);
            this.tabFormularSchraenke.Controls.Add(this.labelSchrankHoehe);
            this.tabFormularSchraenke.Controls.Add(this.txtSchrankBreite);
            this.tabFormularSchraenke.Controls.Add(this.labelSchrankBreite);
            this.tabFormularSchraenke.Controls.Add(this.txtSchrankLaenge);
            this.tabFormularSchraenke.Controls.Add(this.labelSchrankLaenge);
            this.tabFormularSchraenke.Location = new System.Drawing.Point(4, 22);
            this.tabFormularSchraenke.Name = "tabFormularSchraenke";
            this.tabFormularSchraenke.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormularSchraenke.Size = new System.Drawing.Size(1053, 366);
            this.tabFormularSchraenke.TabIndex = 3;
            this.tabFormularSchraenke.Text = "Formular Schränke";
            this.tabFormularSchraenke.UseVisualStyleBackColor = true;
            // 
            // btnSpeichernDatei
            // 
            this.btnSpeichernDatei.Location = new System.Drawing.Point(259, 336);
            this.btnSpeichernDatei.Name = "btnSpeichernDatei";
            this.btnSpeichernDatei.Size = new System.Drawing.Size(105, 23);
            this.btnSpeichernDatei.TabIndex = 36;
            this.btnSpeichernDatei.Text = "in Datei speichern";
            this.btnSpeichernDatei.UseVisualStyleBackColor = true;
            this.btnSpeichernDatei.Click += new System.EventHandler(this.btnSpeichernDatei_Click);
            // 
            // btnFarbauswahl
            // 
            this.btnFarbauswahl.Location = new System.Drawing.Point(798, 310);
            this.btnFarbauswahl.Name = "btnFarbauswahl";
            this.btnFarbauswahl.Size = new System.Drawing.Size(97, 23);
            this.btnFarbauswahl.TabIndex = 35;
            this.btnFarbauswahl.Text = "Farbe auswählen";
            this.btnFarbauswahl.UseVisualStyleBackColor = true;
            this.btnFarbauswahl.Click += new System.EventHandler(this.btnFarbauswahl_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioSchrankStandard);
            this.panel1.Controls.Add(this.radioSchrankBlau);
            this.panel1.Controls.Add(this.radioSchrankRot);
            this.panel1.Location = new System.Drawing.Point(947, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 78);
            this.panel1.TabIndex = 34;
            // 
            // radioSchrankStandard
            // 
            this.radioSchrankStandard.AutoSize = true;
            this.radioSchrankStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSchrankStandard.Location = new System.Drawing.Point(3, 3);
            this.radioSchrankStandard.Name = "radioSchrankStandard";
            this.radioSchrankStandard.Size = new System.Drawing.Size(93, 24);
            this.radioSchrankStandard.TabIndex = 31;
            this.radioSchrankStandard.TabStop = true;
            this.radioSchrankStandard.Text = "Standard";
            this.radioSchrankStandard.UseVisualStyleBackColor = true;
            this.radioSchrankStandard.CheckedChanged += new System.EventHandler(this.radioSchrankStandard_CheckedChanged);
            // 
            // radioSchrankBlau
            // 
            this.radioSchrankBlau.AutoSize = true;
            this.radioSchrankBlau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSchrankBlau.ForeColor = System.Drawing.Color.Blue;
            this.radioSchrankBlau.Location = new System.Drawing.Point(3, 49);
            this.radioSchrankBlau.Name = "radioSchrankBlau";
            this.radioSchrankBlau.Size = new System.Drawing.Size(59, 24);
            this.radioSchrankBlau.TabIndex = 33;
            this.radioSchrankBlau.TabStop = true;
            this.radioSchrankBlau.Text = "Blau";
            this.radioSchrankBlau.UseVisualStyleBackColor = true;
            this.radioSchrankBlau.CheckedChanged += new System.EventHandler(this.radioSchrankBlau_CheckedChanged);
            // 
            // radioSchrankRot
            // 
            this.radioSchrankRot.AutoSize = true;
            this.radioSchrankRot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSchrankRot.ForeColor = System.Drawing.Color.Red;
            this.radioSchrankRot.Location = new System.Drawing.Point(3, 26);
            this.radioSchrankRot.Name = "radioSchrankRot";
            this.radioSchrankRot.Size = new System.Drawing.Size(53, 24);
            this.radioSchrankRot.TabIndex = 32;
            this.radioSchrankRot.TabStop = true;
            this.radioSchrankRot.Text = "Rot";
            this.radioSchrankRot.UseVisualStyleBackColor = true;
            this.radioSchrankRot.CheckedChanged += new System.EventHandler(this.radioSchrankRot_CheckedChanged);
            // 
            // btnSchrankReset
            // 
            this.btnSchrankReset.Location = new System.Drawing.Point(178, 336);
            this.btnSchrankReset.Name = "btnSchrankReset";
            this.btnSchrankReset.Size = new System.Drawing.Size(75, 23);
            this.btnSchrankReset.TabIndex = 30;
            this.btnSchrankReset.Text = "Reset";
            this.btnSchrankReset.UseVisualStyleBackColor = true;
            this.btnSchrankReset.Click += new System.EventHandler(this.btnSchrankReset_Click);
            // 
            // btnSchrankAnzeigen
            // 
            this.btnSchrankAnzeigen.Location = new System.Drawing.Point(96, 337);
            this.btnSchrankAnzeigen.Name = "btnSchrankAnzeigen";
            this.btnSchrankAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.btnSchrankAnzeigen.TabIndex = 29;
            this.btnSchrankAnzeigen.Text = "Anzeigen";
            this.btnSchrankAnzeigen.UseVisualStyleBackColor = true;
            this.btnSchrankAnzeigen.Click += new System.EventHandler(this.btnSchrankAnzeigen_Click);
            // 
            // numSchrankHoehe
            // 
            this.numSchrankHoehe.Location = new System.Drawing.Point(96, 55);
            this.numSchrankHoehe.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSchrankHoehe.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSchrankHoehe.Name = "numSchrankHoehe";
            this.numSchrankHoehe.Size = new System.Drawing.Size(100, 20);
            this.numSchrankHoehe.TabIndex = 28;
            this.numSchrankHoehe.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // labelSchrankAnzahlBoeden
            // 
            this.labelSchrankAnzahlBoeden.AutoSize = true;
            this.labelSchrankAnzahlBoeden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchrankAnzahlBoeden.Location = new System.Drawing.Point(565, 5);
            this.labelSchrankAnzahlBoeden.Name = "labelSchrankAnzahlBoeden";
            this.labelSchrankAnzahlBoeden.Size = new System.Drawing.Size(113, 20);
            this.labelSchrankAnzahlBoeden.TabIndex = 27;
            this.labelSchrankAnzahlBoeden.Text = "Anzahl Böden:";
            // 
            // cmbSchrankMaterial
            // 
            this.cmbSchrankMaterial.FormattingEnabled = true;
            this.cmbSchrankMaterial.Location = new System.Drawing.Point(377, 31);
            this.cmbSchrankMaterial.Name = "cmbSchrankMaterial";
            this.cmbSchrankMaterial.Size = new System.Drawing.Size(121, 21);
            this.cmbSchrankMaterial.TabIndex = 26;
            // 
            // txtSchrankAnzahlBoeden
            // 
            this.txtSchrankAnzahlBoeden.Location = new System.Drawing.Point(684, 7);
            this.txtSchrankAnzahlBoeden.Name = "txtSchrankAnzahlBoeden";
            this.txtSchrankAnzahlBoeden.Size = new System.Drawing.Size(100, 20);
            this.txtSchrankAnzahlBoeden.TabIndex = 25;
            // 
            // labelSchrankFarbe
            // 
            this.labelSchrankFarbe.AutoSize = true;
            this.labelSchrankFarbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchrankFarbe.Location = new System.Drawing.Point(287, 56);
            this.labelSchrankFarbe.Name = "labelSchrankFarbe";
            this.labelSchrankFarbe.Size = new System.Drawing.Size(55, 20);
            this.labelSchrankFarbe.TabIndex = 24;
            this.labelSchrankFarbe.Text = "Farbe:";
            // 
            // txtSchrankFarbe
            // 
            this.txtSchrankFarbe.Location = new System.Drawing.Point(377, 58);
            this.txtSchrankFarbe.Name = "txtSchrankFarbe";
            this.txtSchrankFarbe.Size = new System.Drawing.Size(100, 20);
            this.txtSchrankFarbe.TabIndex = 23;
            this.txtSchrankFarbe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSchrankFarbe_KeyDown);
            this.txtSchrankFarbe.Leave += new System.EventHandler(this.txtSchrankFarbe_Leave);
            // 
            // labelSchrankMaterial
            // 
            this.labelSchrankMaterial.AutoSize = true;
            this.labelSchrankMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchrankMaterial.Location = new System.Drawing.Point(287, 29);
            this.labelSchrankMaterial.Name = "labelSchrankMaterial";
            this.labelSchrankMaterial.Size = new System.Drawing.Size(69, 20);
            this.labelSchrankMaterial.TabIndex = 22;
            this.labelSchrankMaterial.Text = "Material:";
            // 
            // txtSchrankGewicht
            // 
            this.txtSchrankGewicht.Location = new System.Drawing.Point(377, 5);
            this.txtSchrankGewicht.Name = "txtSchrankGewicht";
            this.txtSchrankGewicht.Size = new System.Drawing.Size(100, 20);
            this.txtSchrankGewicht.TabIndex = 21;
            // 
            // labelSchrankGewicht
            // 
            this.labelSchrankGewicht.AutoSize = true;
            this.labelSchrankGewicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchrankGewicht.Location = new System.Drawing.Point(287, 3);
            this.labelSchrankGewicht.Name = "labelSchrankGewicht";
            this.labelSchrankGewicht.Size = new System.Drawing.Size(71, 20);
            this.labelSchrankGewicht.TabIndex = 20;
            this.labelSchrankGewicht.Text = "Gewicht:";
            // 
            // labelSchrankHoehe
            // 
            this.labelSchrankHoehe.AutoSize = true;
            this.labelSchrankHoehe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchrankHoehe.Location = new System.Drawing.Point(6, 55);
            this.labelSchrankHoehe.Name = "labelSchrankHoehe";
            this.labelSchrankHoehe.Size = new System.Drawing.Size(52, 20);
            this.labelSchrankHoehe.TabIndex = 19;
            this.labelSchrankHoehe.Text = "Höhe:";
            // 
            // txtSchrankBreite
            // 
            this.txtSchrankBreite.Location = new System.Drawing.Point(96, 31);
            this.txtSchrankBreite.Name = "txtSchrankBreite";
            this.txtSchrankBreite.Size = new System.Drawing.Size(100, 20);
            this.txtSchrankBreite.TabIndex = 18;
            // 
            // labelSchrankBreite
            // 
            this.labelSchrankBreite.AutoSize = true;
            this.labelSchrankBreite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchrankBreite.Location = new System.Drawing.Point(6, 29);
            this.labelSchrankBreite.Name = "labelSchrankBreite";
            this.labelSchrankBreite.Size = new System.Drawing.Size(55, 20);
            this.labelSchrankBreite.TabIndex = 17;
            this.labelSchrankBreite.Text = "Breite:";
            // 
            // txtSchrankLaenge
            // 
            this.txtSchrankLaenge.Location = new System.Drawing.Point(96, 5);
            this.txtSchrankLaenge.Name = "txtSchrankLaenge";
            this.txtSchrankLaenge.Size = new System.Drawing.Size(100, 20);
            this.txtSchrankLaenge.TabIndex = 16;
            // 
            // labelSchrankLaenge
            // 
            this.labelSchrankLaenge.AutoSize = true;
            this.labelSchrankLaenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchrankLaenge.Location = new System.Drawing.Point(6, 3);
            this.labelSchrankLaenge.Name = "labelSchrankLaenge";
            this.labelSchrankLaenge.Size = new System.Drawing.Size(58, 20);
            this.labelSchrankLaenge.TabIndex = 15;
            this.labelSchrankLaenge.Text = "Länge:";
            // 
            // chkFormular
            // 
            this.chkFormular.AutoSize = true;
            this.chkFormular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFormular.Location = new System.Drawing.Point(16, 445);
            this.chkFormular.Name = "chkFormular";
            this.chkFormular.Size = new System.Drawing.Size(184, 24);
            this.chkFormular.TabIndex = 1;
            this.chkFormular.Text = "Formulare beabeiten?";
            this.chkFormular.UseVisualStyleBackColor = true;
            this.chkFormular.CheckedChanged += new System.EventHandler(this.chkFormular_CheckedChanged);
            // 
            // tabAnzeige
            // 
            this.tabAnzeige.Controls.Add(this.btnOeffnenExtern);
            this.tabAnzeige.Controls.Add(this.btnDateiLesen);
            this.tabAnzeige.Controls.Add(this.listBoxDateiinhalt);
            this.tabAnzeige.Location = new System.Drawing.Point(4, 22);
            this.tabAnzeige.Name = "tabAnzeige";
            this.tabAnzeige.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnzeige.Size = new System.Drawing.Size(1053, 366);
            this.tabAnzeige.TabIndex = 4;
            this.tabAnzeige.Text = "Anzeige Schränke";
            this.tabAnzeige.UseVisualStyleBackColor = true;
            // 
            // listBoxDateiinhalt
            // 
            this.listBoxDateiinhalt.FormattingEnabled = true;
            this.listBoxDateiinhalt.Location = new System.Drawing.Point(6, 6);
            this.listBoxDateiinhalt.Name = "listBoxDateiinhalt";
            this.listBoxDateiinhalt.Size = new System.Drawing.Size(451, 303);
            this.listBoxDateiinhalt.TabIndex = 0;
            // 
            // btnDateiLesen
            // 
            this.btnDateiLesen.Location = new System.Drawing.Point(6, 337);
            this.btnDateiLesen.Name = "btnDateiLesen";
            this.btnDateiLesen.Size = new System.Drawing.Size(112, 23);
            this.btnDateiLesen.TabIndex = 1;
            this.btnDateiLesen.Text = "Dateiinhalt anzeigen";
            this.btnDateiLesen.UseVisualStyleBackColor = true;
            this.btnDateiLesen.Click += new System.EventHandler(this.btnDateiLesen_Click);
            // 
            // btnOeffnenExtern
            // 
            this.btnOeffnenExtern.Location = new System.Drawing.Point(138, 337);
            this.btnOeffnenExtern.Name = "btnOeffnenExtern";
            this.btnOeffnenExtern.Size = new System.Drawing.Size(142, 23);
            this.btnOeffnenExtern.TabIndex = 2;
            this.btnOeffnenExtern.Text = "externes Programm öffnen";
            this.btnOeffnenExtern.UseMnemonic = false;
            this.btnOeffnenExtern.UseVisualStyleBackColor = true;
            this.btnOeffnenExtern.Click += new System.EventHandler(this.btnOeffnenExtern_Click);
            // 
            // tabDB
            // 
            this.tabDB.Controls.Add(this.btnDBAnzeigen);
            this.tabDB.Controls.Add(this.dataGridView1);
            this.tabDB.Location = new System.Drawing.Point(4, 22);
            this.tabDB.Name = "tabDB";
            this.tabDB.Padding = new System.Windows.Forms.Padding(3);
            this.tabDB.Size = new System.Drawing.Size(1053, 366);
            this.tabDB.TabIndex = 5;
            this.tabDB.Text = "Anzeige DB";
            this.tabDB.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDBAnzeigen
            // 
            this.btnDBAnzeigen.Location = new System.Drawing.Point(722, 101);
            this.btnDBAnzeigen.Name = "btnDBAnzeigen";
            this.btnDBAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.btnDBAnzeigen.TabIndex = 1;
            this.btnDBAnzeigen.Text = "Anzeigen";
            this.btnDBAnzeigen.UseVisualStyleBackColor = true;
            this.btnDBAnzeigen.Click += new System.EventHandler(this.btnDBAnzeigen_Click);
            // 
            // btnSpeichernDB
            // 
            this.btnSpeichernDB.Location = new System.Drawing.Point(370, 336);
            this.btnSpeichernDB.Name = "btnSpeichernDB";
            this.btnSpeichernDB.Size = new System.Drawing.Size(100, 23);
            this.btnSpeichernDB.TabIndex = 37;
            this.btnSpeichernDB.Text = "in DB speichern";
            this.btnSpeichernDB.UseVisualStyleBackColor = true;
            this.btnSpeichernDB.Click += new System.EventHandler(this.btnSpeichernDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 516);
            this.Controls.Add(this.chkFormular);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAllgemein.ResumeLayout(false);
            this.tabAllgemein.PerformLayout();
            this.tabFormularTische.ResumeLayout(false);
            this.tabFormularTische.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHoehe)).EndInit();
            this.tabSeite3.ResumeLayout(false);
            this.tabSeite3.PerformLayout();
            this.tabFormularSchraenke.ResumeLayout(false);
            this.tabFormularSchraenke.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSchrankHoehe)).EndInit();
            this.tabAnzeige.ResumeLayout(false);
            this.tabDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAllgemein;
        private System.Windows.Forms.TabPage tabFormularTische;
        private System.Windows.Forms.Label labelHalloWelt;
        private System.Windows.Forms.Button btnAendern;
        private System.Windows.Forms.TabPage tabSeite3;
        private System.Windows.Forms.NumericUpDown numHoehe;
        private System.Windows.Forms.Label labelTischbeine;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.TextBox txtAnzahl;
        private System.Windows.Forms.Label labelFarbe;
        private System.Windows.Forms.TextBox txtFarbe;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.TextBox txtGewicht;
        private System.Windows.Forms.Label labelGewicht;
        private System.Windows.Forms.Label labelHoehe;
        private System.Windows.Forms.TextBox txtBreite;
        private System.Windows.Forms.Label labelBreite;
        private System.Windows.Forms.TextBox txtLaenge;
        private System.Windows.Forms.Label labelLaenge;
        private System.Windows.Forms.Button btnAnzeigen;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox chkFormular;
        private System.Windows.Forms.TabPage tabFormularSchraenke;
        private System.Windows.Forms.NumericUpDown numSchrankHoehe;
        private System.Windows.Forms.Label labelSchrankAnzahlBoeden;
        private System.Windows.Forms.ComboBox cmbSchrankMaterial;
        private System.Windows.Forms.TextBox txtSchrankAnzahlBoeden;
        private System.Windows.Forms.Label labelSchrankFarbe;
        private System.Windows.Forms.TextBox txtSchrankFarbe;
        private System.Windows.Forms.Label labelSchrankMaterial;
        private System.Windows.Forms.TextBox txtSchrankGewicht;
        private System.Windows.Forms.Label labelSchrankGewicht;
        private System.Windows.Forms.Label labelSchrankHoehe;
        private System.Windows.Forms.TextBox txtSchrankBreite;
        private System.Windows.Forms.Label labelSchrankBreite;
        private System.Windows.Forms.TextBox txtSchrankLaenge;
        private System.Windows.Forms.Label labelSchrankLaenge;
        private System.Windows.Forms.Button btnSchrankReset;
        private System.Windows.Forms.Button btnSchrankAnzeigen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioSchrankStandard;
        private System.Windows.Forms.RadioButton radioSchrankBlau;
        private System.Windows.Forms.RadioButton radioSchrankRot;
        private System.Windows.Forms.Button btnFarbauswahl;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtAdresszeile;
        private System.Windows.Forms.Button btnSpeichernDatei;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabAnzeige;
        private System.Windows.Forms.Button btnDateiLesen;
        private System.Windows.Forms.ListBox listBoxDateiinhalt;
        private System.Windows.Forms.Button btnOeffnenExtern;
        private System.Windows.Forms.TabPage tabDB;
        private System.Windows.Forms.Button btnDBAnzeigen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSpeichernDB;
    }
}

