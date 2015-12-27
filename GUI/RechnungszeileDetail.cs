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
    public partial class RechnungszeileDetail : Form
    {
        Rechnungszeile a = null;
        Binding.DataBinder binder;
        Boolean neu = false;

        public RechnungszeileDetail()
        {
            InitializeComponent();
            this.a = new Rechnungszeile();
            binder = new Binding.DataBinder();
            this.Text = "Neue Rechnungszeile anlegen";
            neu = true;
        }

        public RechnungszeileDetail(Rechnungszeile a)
        {
            InitializeComponent();
            this.a = a;
            binder = new Binding.DataBinder();
            this.Text = "Rechnungszeile bearbeiten";
        }

        public void BindFrom()       //von einem vorhandenen Rechnungszeile werden die Daten beim bearbeiten angezeigt.
        {
            binder.StartBindFrom();
            a.Bezeichnung = binder.BindFrom_String(tbBezeichnung, new Binding.ErrorMaintenance(), new Binding.RequiredInputRule());
            a.Betrag = binder.BindFrom_Double(tbBetrag, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
            a.AngebotID = binder.BindFrom_ComboBox_Long(cbAngebote, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
            a.AusgangsrechnungID = binder.BindFrom_ComboBox_Long(cbAusgangsrechnungen, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
        }

        public void BindTo()         //erstellt ein neues Rechnungszeile aus den eingegebenen Daten...läd daten in die properties
        {
            binder.BindTo_TextBox(tbBezeichnung, a.Bezeichnung);
            binder.BindTo_TextBox(tbBetrag, a.Betrag.ToString());
            binder.BindTo_ComboBox(cbAngebote, BusinessLogic.Instance.GetAllAngebote(), a.AngebotID);
            cbAngebote.DisplayMember = "ID";
            binder.BindTo_ComboBox(cbAusgangsrechnungen, BusinessLogic.Instance.GetAllAusgangsrechnungen(), a.AusgangsrechnungID);
            cbAusgangsrechnungen.DisplayMember = "ID";
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BindFrom();
            try
            {
                if (neu == true)
                {
                    BusinessLogic.Instance.AddRechnungszeile(a);
                }
                else
                {
                    BusinessLogic.Instance.UpdateRechnungszeile(a);
                }
                this.GetLogger().Info(string.Format("Added new Rechnungszeile(ID={0},AngebotID={1},AusgangsrechnungsID={2},Bezeichnung={3},Betrag={4}).", a.ID, a.AngebotID, a.AusgangsrechnungID, a.Bezeichnung, a.Betrag));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RechnungszeileDetail_Load(object sender, EventArgs e)
        {
            BindTo();
        }
    }
}