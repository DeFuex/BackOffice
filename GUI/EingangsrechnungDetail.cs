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
    public partial class EingangsrechnungDetail : Form
    {
        Eingangsrechnung a = null;
        RechnungBuchung b = new RechnungBuchung();
        Binding.DataBinder binder;
        Boolean neu = false;

        public EingangsrechnungDetail()
        {
            InitializeComponent();
            this.a = new Eingangsrechnung();
            binder = new Binding.DataBinder();
            this.Text = "Neue Eingangsrechnung anlegen";
            cbBuchungszeilen.Enabled = false;
            btnNew.Enabled = false;
            btnDelete.Enabled = false;
            neu = true;
        }

        public EingangsrechnungDetail(Eingangsrechnung a)
        {
            InitializeComponent();
            this.a = a;
            binder = new Binding.DataBinder();
            this.Text = "Eingangsrechnung bearbeiten";
            cbBuchungszeilen.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
        }

        public void BindFrom()       //von einem vorhandenen Eingangsrechnung werden die Daten beim bearbeiten angezeigt.
        {
            binder.StartBindFrom();
            a.Summe = binder.BindFrom_Double(tbSumme, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
            a.Datum = binder.BindFrom_DateTime(dtpDate, new Binding.ErrorMaintenance(), null);
            a.Beschreibung = binder.BindFrom_String(tbBeschreibung, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
            a.Offen = binder.BindFrom_Checkbox(chkbOffen, new Binding.ErrorMaintenance(), null);
            a.KontaktID = binder.BindFrom_ComboBox_Long(cbKontakte, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
        }

        public void BindFromlv()
        {
            b.RechnungsID = a.ID;
            b.Rechnungstyp = "Eingang";
            b.BuchungszeilenID = binder.BindFrom_ComboBox_Long(cbBuchungszeilen, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
        }

        public void BindTo()         //erstellt ein neues Eingangsrechnung aus den eingegebenen Daten...läd daten in die properties
        {
            binder.BindTo_ComboBox(cbKontakte, BusinessLogic.Instance.GetAllKontakte(), a.KontaktID);
            binder.BindTo_TextBox(tbBeschreibung, a.Beschreibung);
            binder.BindTo_TextBox(tbSumme, a.Summe);
            binder.BindTo_CheckBox(chkbOffen, a.Offen);
            binder.BindTo_ComboBox2(cbBuchungszeilen, BusinessLogic.Instance.GetAllBuchungszeilen(), a.ID);
            cbBuchungszeilen.DisplayMember = "ID";
            binder.BindTo_ListView(lvBuchungszeilen, BusinessLogic.Instance.GetBuchungszeileByRechnung(a.ID, "Eingang"), "");
            binder.BindTo_DateTimePicker(dtpDate, a.Datum);
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EingangsrechnungDetail_Load(object sender, EventArgs e)
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
                    BusinessLogic.Instance.AddEingangsrechnung(a);
                }
                else
                {
                    BusinessLogic.Instance.UpdateEingangsrechnung(a);
                }
                this.GetLogger().Info(string.Format("Added new Eingangsrechnung(ID={0},Datum={1},Beschreibung={2},Summe={3},Offen={4},KontaktID={5}).", a.ID, a.Datum, a.Beschreibung, a.Summe, a.Offen, a.KontaktID));
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
                //this.GetLogger().Info(string.Format("Added new Eingangsrechnung(ID={0},Datum={1},Beschreibung={2},Summe={3},Gedruckt={4},Offen={5},ProjektID={6},KundenID={7}).", a.ID, a.Datum, a.Beschreibung, a.Summe, a.Gedruckt, a.Offen, a.ProjektID, a.KundenID));
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
                BusinessLogic.Instance.DeleteRechnungBuchungER(a, bz);
            }
            BindTo();
        }
    }
}