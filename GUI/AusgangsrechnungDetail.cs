using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL;
using Domain;
using Domain.Utils;

namespace GUI
{
    public partial class AusgangsrechnungDetail : Form
    {
        Ausgangsrechnung a = null;
        RechnungBuchung b = new RechnungBuchung();
        Binding.DataBinder binder;
        Boolean neu = false;

        public AusgangsrechnungDetail()
        {
            InitializeComponent();
            this.a = new Ausgangsrechnung();
            binder = new Binding.DataBinder();
            this.Text = "Neue Ausgangsrechnung anlegen";
            cbBuchungszeilen.Enabled = false;
            btnNew.Enabled = false;
            btnDelete.Enabled = false;
            neu = true;
        }

        public AusgangsrechnungDetail(Ausgangsrechnung a)
        {
            InitializeComponent();
            this.a = a;
            binder = new Binding.DataBinder();
            cbBuchungszeilen.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            this.Text = "Ausgangsrechnung bearbeiten";
        }

        public void BindFrom()       //von einem vorhandenen Ausgangsrechnung werden die Daten beim bearbeiten angezeigt.
        {
            binder.StartBindFrom();
            a.Summe = binder.BindFrom_Double(tbSumme, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
            a.Datum = binder.BindFrom_DateTime(dtpDate, new Binding.ErrorMaintenance(), null);
            a.Beschreibung = binder.BindFrom_String(tbBeschreibung, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
            a.Gedruckt = binder.BindFrom_Checkbox(chkbGedruckt, new Binding.ErrorMaintenance(), null);
            a.Offen = binder.BindFrom_Checkbox(chkbOffen, new Binding.ErrorMaintenance(), null); 
            a.ProjektID = binder.BindFrom_ComboBox_Long(cbProjekte, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
            a.KundenID = binder.BindFrom_ComboBox_Long(cbKunden, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
        }

        public void BindFromlv()
        {
            b.RechnungsID = a.ID;
            b.Rechnungstyp = "Ausgang";
            b.BuchungszeilenID = binder.BindFrom_ComboBox_Long(cbBuchungszeilen, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
        }

        public void BindTo()         //erstellt ein neues Ausgangsrechnung aus den eingegebenen Daten...läd daten in die properties
        {
            binder.BindTo_ComboBox(cbKunden, BusinessLogic.Instance.GetAllKunden(), a.KundenID);
            binder.BindTo_ComboBox(cbProjekte, BusinessLogic.Instance.GetAllProjekte(), a.ProjektID);
            cbProjekte.DisplayMember = "Name";
            binder.BindTo_TextBox(tbBeschreibung, a.Beschreibung);
            binder.BindTo_TextBox(tbSumme, a.Summe);
            binder.BindTo_CheckBox(chkbOffen, a.Offen);
            binder.BindTo_CheckBox(chkbGedruckt, a.Gedruckt);
            binder.BindTo_ComboBox2(cbBuchungszeilen, BusinessLogic.Instance.GetAllBuchungszeilen(), a);
            cbBuchungszeilen.DisplayMember = "ID";
            binder.BindTo_ListView(lvBuchungszeilen, BusinessLogic.Instance.GetBuchungszeileByRechnung(a.ID, "Ausgang"), "");
            binder.BindTo_DateTimePicker(dtpDate, a.Datum);
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AusgangsrechnungDetail_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BindFrom();
            try
            {
                if (neu == true)
                {
                    BusinessLogic.Instance.AddAusgangsrechnung(a);
                }
                else
                {
                    BusinessLogic.Instance.UpdateAusgangsrechnung(a);
                }
                this.GetLogger().Info(string.Format("Added new Ausgangsrechnung(ID={0},Datum={1},Beschreibung={2},Summe={3},Gedruckt={4},Offen={5},ProjektID={6},KundenID={7}).", a.ID, a.Datum, a.Beschreibung, a.Summe, a.Gedruckt, a.Offen, a.ProjektID, a.KundenID));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            BindFromlv();
            try
            {
                BusinessLogic.Instance.AddRechnungBuchung(b);
                //this.GetLogger().Info(string.Format("Added new Ausgangsrechnung(ID={0},Datum={1},Beschreibung={2},Summe={3},Gedruckt={4},Offen={5},ProjektID={6},KundenID={7}).", a.ID, a.Datum, a.Beschreibung, a.Summe, a.Gedruckt, a.Offen, a.ProjektID, a.KundenID));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            BindTo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvBuchungszeilen.SelectedItems)
            {
                Buchungszeile bz = (Buchungszeile)lvi.Tag;
                BusinessLogic.Instance.DeleteRechnungBuchungAR(a, bz);
            }
            BindTo();
        }
    }
}