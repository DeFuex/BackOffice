namespace GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabKunden = new System.Windows.Forms.TabPage();
            this.kundeList1 = new GUI.KundeList();
            this.tabKontakte = new System.Windows.Forms.TabPage();
            this.kontaktList1 = new GUI.KontaktList();
            this.tabAngebote = new System.Windows.Forms.TabPage();
            this.angebotList1 = new GUI.AngebotList();
            this.tabProjekte = new System.Windows.Forms.TabPage();
            this.projektList1 = new GUI.ProjektList();
            this.tabAusgangsrechnungen = new System.Windows.Forms.TabPage();
            this.ausgangsrechnungList1 = new GUI.AusgangsrechnungList();
            this.tabEingangsrechnungen = new System.Windows.Forms.TabPage();
            this.eingangsrechnungList1 = new GUI.EingangsrechnungList();
            this.tabRechnungszeilen = new System.Windows.Forms.TabPage();
            this.rechnungszeileList1 = new GUI.RechnungszeileList(); 
            this.tabBuchungszeilen = new System.Windows.Forms.TabPage();
            this.buchungszeileList1 = new GUI.BuchungszeileList();
            this.tabZeiterfassung = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabKunden.SuspendLayout();
            this.tabAngebote.SuspendLayout();
            this.tabProjekte.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabKunden);
            this.tabControl1.Controls.Add(this.tabKontakte);
            this.tabControl1.Controls.Add(this.tabAngebote);
            this.tabControl1.Controls.Add(this.tabProjekte);
            this.tabControl1.Controls.Add(this.tabAusgangsrechnungen);
            this.tabControl1.Controls.Add(this.tabEingangsrechnungen);
            this.tabControl1.Controls.Add(this.tabRechnungszeilen);
            this.tabControl1.Controls.Add(this.tabBuchungszeilen);
            this.tabControl1.Controls.Add(this.tabZeiterfassung);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(621, 409);
            this.tabControl1.TabIndex = 0;
            // 
            // tabKunden
            // 
            this.tabKunden.Controls.Add(this.kundeList1);
            this.tabKunden.Location = new System.Drawing.Point(4, 22);
            this.tabKunden.Name = "tabKunden";
            this.tabKunden.Size = new System.Drawing.Size(589, 358);
            this.tabKunden.TabIndex = 2;
            this.tabKunden.Text = "Kunden";
            this.tabKunden.UseVisualStyleBackColor = true;
            // 
            // kundeList1
            // 
            this.kundeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kundeList1.Location = new System.Drawing.Point(0, 0);
            this.kundeList1.Name = "kundeList1";
            this.kundeList1.Size = new System.Drawing.Size(589, 358);
            this.kundeList1.TabIndex = 0;
            // 
            // tabKontakte
            // 
            this.tabKontakte.Controls.Add(this.kontaktList1);
            this.tabKontakte.Location = new System.Drawing.Point(4, 22);
            this.tabKontakte.Name = "tabKontakte";
            this.tabKontakte.Size = new System.Drawing.Size(589, 358);
            this.tabKontakte.TabIndex = 2;
            this.tabKontakte.Text = "Kontakte";
            this.tabKontakte.UseVisualStyleBackColor = true;
            // 
            // kontaktList1
            // 
            this.kontaktList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kontaktList1.Location = new System.Drawing.Point(0, 0);
            this.kontaktList1.Name = "KontaktList1";
            this.kontaktList1.Size = new System.Drawing.Size(589, 358);
            this.kontaktList1.TabIndex = 0;
            // 
            // tabAngebote
            // 
            this.tabAngebote.Controls.Add(this.angebotList1);
            this.tabAngebote.Location = new System.Drawing.Point(4, 22);
            this.tabAngebote.Name = "tabAngebote";
            this.tabAngebote.Size = new System.Drawing.Size(589, 358);
            this.tabAngebote.TabIndex = 2;
            this.tabAngebote.Text = "Angebote";
            this.tabAngebote.UseVisualStyleBackColor = true;
            // 
            // angebotList1
            // 
            this.angebotList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.angebotList1.Location = new System.Drawing.Point(0, 0);
            this.angebotList1.Name = "angebotList1";
            this.angebotList1.Size = new System.Drawing.Size(589, 358);
            this.angebotList1.TabIndex = 0;
            // 
            // tabProjekte
            // 
            this.tabProjekte.Controls.Add(this.projektList1);
            this.tabProjekte.Location = new System.Drawing.Point(4, 22);
            this.tabProjekte.Name = "tabProjekte";
            this.tabProjekte.Size = new System.Drawing.Size(589, 358);
            this.tabProjekte.TabIndex = 2;
            this.tabProjekte.Text = "Projekte";
            this.tabProjekte.UseVisualStyleBackColor = true;
            // 
            // projektList1
            // 
            this.projektList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projektList1.Location = new System.Drawing.Point(0, 0);
            this.projektList1.Name = "projektList1";
            this.projektList1.Size = new System.Drawing.Size(589, 358);
            this.projektList1.TabIndex = 0;
            // 
            // tabAusgangsrechnungen
            // 
            this.tabAusgangsrechnungen.Controls.Add(this.ausgangsrechnungList1);
            this.tabAusgangsrechnungen.Location = new System.Drawing.Point(4, 22);
            this.tabAusgangsrechnungen.Name = "tabAusgangsrechnungen";
            this.tabAusgangsrechnungen.Size = new System.Drawing.Size(589, 358);
            this.tabAusgangsrechnungen.TabIndex = 2;
            this.tabAusgangsrechnungen.Text = "Ausgangsrechnungen";
            this.tabAusgangsrechnungen.UseVisualStyleBackColor = true;
            // 
            // ausgangsrechnungList1
            // 
            this.ausgangsrechnungList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ausgangsrechnungList1.Location = new System.Drawing.Point(0, 0);
            this.ausgangsrechnungList1.Name = "AusgangsrechnungList1";
            this.ausgangsrechnungList1.Size = new System.Drawing.Size(589, 358);
            this.ausgangsrechnungList1.TabIndex = 0;
            // 
            // tabEingangsrechnungen
            // 
            this.tabEingangsrechnungen.Controls.Add(this.eingangsrechnungList1);
            this.tabEingangsrechnungen.Location = new System.Drawing.Point(4, 22);
            this.tabEingangsrechnungen.Name = "tabEingangsrechnungen";
            this.tabEingangsrechnungen.Size = new System.Drawing.Size(589, 358);
            this.tabEingangsrechnungen.TabIndex = 2;
            this.tabEingangsrechnungen.Text = "Eingangsrechnungen";
            this.tabEingangsrechnungen.UseVisualStyleBackColor = true;
            // 
            // eingangsrechnungList1
            // 
            this.eingangsrechnungList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eingangsrechnungList1.Location = new System.Drawing.Point(0, 0);
            this.eingangsrechnungList1.Name = "EingangsrechnungList1";
            this.eingangsrechnungList1.Size = new System.Drawing.Size(589, 358);
            this.eingangsrechnungList1.TabIndex = 0;
            // 
            // tabRechnungszeilen
            // 
            this.tabRechnungszeilen.Controls.Add(this.rechnungszeileList1);
            this.tabRechnungszeilen.Location = new System.Drawing.Point(4, 22);
            this.tabRechnungszeilen.Name = "tabRechnungszeilen";
            this.tabRechnungszeilen.Size = new System.Drawing.Size(589, 358);
            this.tabRechnungszeilen.TabIndex = 2;
            this.tabRechnungszeilen.Text = "Rechnungszeilen";
            this.tabRechnungszeilen.UseVisualStyleBackColor = true;
            // 
            // rechnungszeileList1
            // 
            this.rechnungszeileList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rechnungszeileList1.Location = new System.Drawing.Point(0, 0);
            this.rechnungszeileList1.Name = "EingangsrechnungList1";
            this.rechnungszeileList1.Size = new System.Drawing.Size(589, 358);
            this.rechnungszeileList1.TabIndex = 0;
            // 
            // tabBuchungszeilen
            // 
            this.tabBuchungszeilen.Controls.Add(this.buchungszeileList1);
            this.tabBuchungszeilen.Location = new System.Drawing.Point(4, 22);
            this.tabBuchungszeilen.Name = "tabBuchungszeilen";
            this.tabBuchungszeilen.Size = new System.Drawing.Size(589, 358);
            this.tabBuchungszeilen.TabIndex = 2;
            this.tabBuchungszeilen.Text = "Buchungszeilen";
            this.tabBuchungszeilen.UseVisualStyleBackColor = true;
            // 
            // buchungszeileList1
            // 
            this.buchungszeileList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buchungszeileList1.Location = new System.Drawing.Point(0, 0);
            this.buchungszeileList1.Name = "EingangsrechnungList1";
            this.buchungszeileList1.Size = new System.Drawing.Size(589, 358);
            this.buchungszeileList1.TabIndex = 0;
            // 
            // tabZeiterfassung
            // 
            this.tabZeiterfassung.Location = new System.Drawing.Point(4, 22);
            this.tabZeiterfassung.Name = "tabZeiterfassung";
            this.tabZeiterfassung.Size = new System.Drawing.Size(589, 358);
            this.tabZeiterfassung.TabIndex = 7;
            this.tabZeiterfassung.Text = "Zeiterfassung";
            this.tabZeiterfassung.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 409);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backoffice";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabKunden.ResumeLayout(false);
            this.tabKunden.PerformLayout();
            this.tabAngebote.ResumeLayout(false);
            this.tabProjekte.ResumeLayout(false);
            this.tabProjekte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKunden;
        private System.Windows.Forms.TabPage tabKontakte;
        private System.Windows.Forms.TabPage tabAngebote;
        private System.Windows.Forms.TabPage tabProjekte;
        private System.Windows.Forms.TabPage tabAusgangsrechnungen;
        private System.Windows.Forms.TabPage tabEingangsrechnungen;
        private System.Windows.Forms.TabPage tabRechnungszeilen;
        private System.Windows.Forms.TabPage tabBuchungszeilen;
        private System.Windows.Forms.TabPage tabZeiterfassung;
        private AngebotList angebotList1;
        private ProjektList projektList1;
        private KundeList kundeList1;
        private KontaktList kontaktList1;
        private AusgangsrechnungList ausgangsrechnungList1;
        private EingangsrechnungList eingangsrechnungList1;
        private RechnungszeileList rechnungszeileList1;
        private BuchungszeileList buchungszeileList1;

    }
}

