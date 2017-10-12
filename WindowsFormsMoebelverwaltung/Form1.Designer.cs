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
            this.txtHoehe = new System.Windows.Forms.NumericUpDown();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAnzeigen = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAllgemein.SuspendLayout();
            this.tabFormularTische.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoehe)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAllgemein);
            this.tabControl1.Controls.Add(this.tabFormularTische);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1061, 464);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAllgemein
            // 
            this.tabAllgemein.Controls.Add(this.btnAendern);
            this.tabAllgemein.Controls.Add(this.labelHalloWelt);
            this.tabAllgemein.Location = new System.Drawing.Point(4, 22);
            this.tabAllgemein.Name = "tabAllgemein";
            this.tabAllgemein.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllgemein.Size = new System.Drawing.Size(1053, 438);
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
            this.tabFormularTische.Controls.Add(this.txtHoehe);
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
            this.tabFormularTische.Size = new System.Drawing.Size(1053, 438);
            this.tabFormularTische.TabIndex = 1;
            this.tabFormularTische.Text = "Formular Tische";
            this.tabFormularTische.UseVisualStyleBackColor = true;
            // 
            // txtHoehe
            // 
            this.txtHoehe.Location = new System.Drawing.Point(99, 97);
            this.txtHoehe.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtHoehe.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtHoehe.Name = "txtHoehe";
            this.txtHoehe.Size = new System.Drawing.Size(100, 20);
            this.txtHoehe.TabIndex = 14;
            this.txtHoehe.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // labelTischbeine
            // 
            this.labelTischbeine.AutoSize = true;
            this.labelTischbeine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTischbeine.Location = new System.Drawing.Point(568, 47);
            this.labelTischbeine.Name = "labelTischbeine";
            this.labelTischbeine.Size = new System.Drawing.Size(89, 20);
            this.labelTischbeine.TabIndex = 13;
            this.labelTischbeine.Text = "Tischbeine:";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(380, 73);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(121, 21);
            this.cmbMaterial.TabIndex = 12;
            // 
            // txtAnzahl
            // 
            this.txtAnzahl.Location = new System.Drawing.Point(658, 49);
            this.txtAnzahl.Name = "txtAnzahl";
            this.txtAnzahl.Size = new System.Drawing.Size(100, 20);
            this.txtAnzahl.TabIndex = 11;
            // 
            // labelFarbe
            // 
            this.labelFarbe.AutoSize = true;
            this.labelFarbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFarbe.Location = new System.Drawing.Point(290, 98);
            this.labelFarbe.Name = "labelFarbe";
            this.labelFarbe.Size = new System.Drawing.Size(55, 20);
            this.labelFarbe.TabIndex = 10;
            this.labelFarbe.Text = "Farbe:";
            // 
            // txtFarbe
            // 
            this.txtFarbe.Location = new System.Drawing.Point(380, 100);
            this.txtFarbe.Name = "txtFarbe";
            this.txtFarbe.Size = new System.Drawing.Size(100, 20);
            this.txtFarbe.TabIndex = 9;
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterial.Location = new System.Drawing.Point(290, 71);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(69, 20);
            this.labelMaterial.TabIndex = 8;
            this.labelMaterial.Text = "Material:";
            // 
            // txtGewicht
            // 
            this.txtGewicht.Location = new System.Drawing.Point(380, 47);
            this.txtGewicht.Name = "txtGewicht";
            this.txtGewicht.Size = new System.Drawing.Size(100, 20);
            this.txtGewicht.TabIndex = 7;
            // 
            // labelGewicht
            // 
            this.labelGewicht.AutoSize = true;
            this.labelGewicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGewicht.Location = new System.Drawing.Point(290, 45);
            this.labelGewicht.Name = "labelGewicht";
            this.labelGewicht.Size = new System.Drawing.Size(71, 20);
            this.labelGewicht.TabIndex = 6;
            this.labelGewicht.Text = "Gewicht:";
            // 
            // labelHoehe
            // 
            this.labelHoehe.AutoSize = true;
            this.labelHoehe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoehe.Location = new System.Drawing.Point(9, 97);
            this.labelHoehe.Name = "labelHoehe";
            this.labelHoehe.Size = new System.Drawing.Size(52, 20);
            this.labelHoehe.TabIndex = 4;
            this.labelHoehe.Text = "Höhe:";
            // 
            // txtBreite
            // 
            this.txtBreite.Location = new System.Drawing.Point(99, 73);
            this.txtBreite.Name = "txtBreite";
            this.txtBreite.Size = new System.Drawing.Size(100, 20);
            this.txtBreite.TabIndex = 3;
            // 
            // labelBreite
            // 
            this.labelBreite.AutoSize = true;
            this.labelBreite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBreite.Location = new System.Drawing.Point(9, 71);
            this.labelBreite.Name = "labelBreite";
            this.labelBreite.Size = new System.Drawing.Size(55, 20);
            this.labelBreite.TabIndex = 2;
            this.labelBreite.Text = "Breite:";
            // 
            // txtLaenge
            // 
            this.txtLaenge.Location = new System.Drawing.Point(99, 47);
            this.txtLaenge.Name = "txtLaenge";
            this.txtLaenge.Size = new System.Drawing.Size(100, 20);
            this.txtLaenge.TabIndex = 1;
            // 
            // labelLaenge
            // 
            this.labelLaenge.AutoSize = true;
            this.labelLaenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaenge.Location = new System.Drawing.Point(9, 45);
            this.labelLaenge.Name = "labelLaenge";
            this.labelLaenge.Size = new System.Drawing.Size(58, 20);
            this.labelLaenge.TabIndex = 0;
            this.labelLaenge.Text = "Länge:";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1053, 438);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAnzeigen
            // 
            this.btnAnzeigen.Location = new System.Drawing.Point(158, 220);
            this.btnAnzeigen.Name = "btnAnzeigen";
            this.btnAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.btnAnzeigen.TabIndex = 15;
            this.btnAnzeigen.Text = "Anzeigen";
            this.btnAnzeigen.UseVisualStyleBackColor = true;
            this.btnAnzeigen.Click += new System.EventHandler(this.btnAnzeigen_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(240, 219);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 516);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAllgemein.ResumeLayout(false);
            this.tabAllgemein.PerformLayout();
            this.tabFormularTische.ResumeLayout(false);
            this.tabFormularTische.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoehe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAllgemein;
        private System.Windows.Forms.TabPage tabFormularTische;
        private System.Windows.Forms.Label labelHalloWelt;
        private System.Windows.Forms.Button btnAendern;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown txtHoehe;
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
    }
}

