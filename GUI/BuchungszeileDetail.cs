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
    public partial class BuchungszeileDetail : Form
    {
        Buchungszeile a = null;
        BuchungKategorie b = new BuchungKategorie();
        Kategorie kat = new Kategorie();
        Binding.DataBinder binder;
        Boolean neu = false;

        public BuchungszeileDetail()
        {
            InitializeComponent();
            this.a = new Buchungszeile();
            binder = new Binding.DataBinder();
            this.Text = "Neue Buchungszeile anlegen";
            cbKategorien.Enabled = false;
            btnNew.Enabled = false;
            btnDelete.Enabled = false;
            btnDelKat.Enabled = false;
            btnNewKat.Enabled = false;
            tbKategorie.Enabled = false;
            neu = true;
        }

        public BuchungszeileDetail(Buchungszeile a)
        {
            InitializeComponent();
            this.a = a;
            binder = new Binding.DataBinder();
            cbKategorien.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnDelKat.Enabled = true;
            btnNewKat.Enabled = true;
            tbKategorie.Enabled = true;
            this.Text = "Buchungszeile bearbeiten";
        }

        public void BindFrom()       //von einem vorhandenen Buchungszeile werden die Daten beim bearbeiten angezeigt.
        {
            binder.StartBindFrom();
            a.Bankkonto = binder.BindFrom_String(tbBankkonto, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
            a.Rechnungssumme = binder.BindFrom_Int(tbRechnungssumme, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
            a.Ust = binder.BindFrom_Int(tbUSt, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
       }

        public void BindFromlv()
        {
            b.BuchungszeilenID = a.ID;
            b.KategorieID = binder.BindFrom_ComboBox_Long(cbKategorien, new Binding.ErrorMaintenance(), new Binding.RequiredInputRule());
        }

        public void BindTo()         //erstellt ein neues Buchungszeile aus den eingegebenen Daten...läd daten in die properties
        {
            binder.BindTo_TextBox(tbUSt, a.Ust);
            binder.BindTo_TextBox(tbBankkonto, a.Bankkonto);
            binder.BindTo_TextBox(tbRechnungssumme, a.Rechnungssumme);
            binder.BindTo_ComboBox2(cbKategorien, BusinessLogic.Instance.GetAllKategorien(), a);
            cbKategorien.DisplayMember = "KategorieTyp";
            binder.BindTo_ListView(lvKategorien, BusinessLogic.Instance.GetKategorieByBuchung(a.ID), "");
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuchungszeileDetail_Load(object sender, EventArgs e)
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
                    BusinessLogic.Instance.AddBuchungszeile(a);
                }
                else
                {
                    BusinessLogic.Instance.UpdateBuchungszeile(a);
                }
                this.GetLogger().Info(string.Format("Added new Buchungszeile(ID={0},Bankkonto={1},Rechnungssumme={2},USt={3}).", a.ID, a.Bankkonto, a.Rechnungssumme, a.Ust));
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
                BusinessLogic.Instance.AddBuchungKategorie(b);
                //this.GetLogger().Info(string.Format("Added new Buchungszeile(ID={0},Datum={1},Beschreibung={2},Summe={3},Gedruckt={4},Offen={5},ProjektID={6},KundenID={7}).", a.ID, a.Datum, a.Beschreibung, a.Summe, a.Gedruckt, a.Offen, a.ProjektID, a.KundenID));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            BindTo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvKategorien.SelectedItems)
            {
                Kategorie kat = (Kategorie)lvi.Tag;
                BusinessLogic.Instance.DeleteBuchungKategorie(a, kat);
            }
            BindTo();
        }

        private void btnNewKat_Click(object sender, EventArgs e)
        {
            kat.KategorieTyp = tbKategorie.Text;
            BusinessLogic.Instance.AddKategorie(kat);
            BindTo();
        }

        private void btnDelKat_Click(object sender, EventArgs e)
        {
            kat.ID = binder.BindFrom_ComboBox_Long(cbKategorien, new Binding.ErrorMaintenance(), new Binding.RequiredInputRule());
            kat.KategorieTyp = cbKategorien.SelectedText;
            BusinessLogic.Instance.DeleteKategorie(kat);
            BindTo();
        }
    }
}