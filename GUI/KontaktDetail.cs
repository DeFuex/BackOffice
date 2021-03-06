﻿using System;
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
    public partial class KontaktDetail : Form
    {
        Kontakt a = null;
        Binding.DataBinder binder;
        Boolean neu = false;

        public KontaktDetail()
        {
            InitializeComponent();
            this.a = new Kontakt();
            binder = new Binding.DataBinder();
            this.Text = "Neuen Kontakt anlegen";
            neu = true;
        }

        public KontaktDetail(Kontakt a)
        {
            InitializeComponent();
            this.a = a;
            binder = new Binding.DataBinder();
            this.Text = "Kontakt bearbeiten";
        }

        public void BindFrom()       //von einem vorhandenen Kontakt werden die Daten beim bearbeiten angezeigt.
        {
            binder.StartBindFrom();
            a.Vorname = binder.BindFrom_String(tbVorname, new Binding.ErrorMaintenance(), new Binding.RequiredInputRule());
            a.Nachname = binder.BindFrom_String(tbNachname, new Binding.ErrorMaintenance(), new Binding.RequiredInputRule());
            a.Adresse = binder.BindFrom_String(tbAdresse, new Binding.ErrorMaintenance(), new Binding.RequiredInputRule());
            a.Ort = binder.BindFrom_String(tbOrt, new Binding.ErrorMaintenance(), new Binding.RequiredInputRule());
            a.Plz = binder.BindFrom_Int(tbPLZ, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
            a.Telefon = binder.BindFrom_String(tbTelefon, new Binding.ErrorMaintenance(), new Binding.RequiredInputRule());
            a.Email = binder.BindFrom_String(tbEmail, new Binding.ErrorMaintenance(), new Binding.RequiredInputRule());
            a.Firmenname = binder.BindFrom_String(tbFirmenname, new Binding.ErrorMaintenance(), new Binding.RequiredInputRule());
            a.Bemerkungen = binder.BindFrom_String(tbBemerkungen, new Binding.ErrorMaintenance(), new Binding.RequiredInputRule());
        }

        public void BindTo()         //erstellt ein neues Kontakt aus den eingegebenen Daten...läd daten in die properties
        {
            binder.BindTo_TextBox(tbVorname, a.Vorname);
            binder.BindTo_TextBox(tbNachname, a.Nachname);
            binder.BindTo_TextBox(tbAdresse, a.Adresse);
            binder.BindTo_TextBox(tbOrt, a.Ort);
            binder.BindTo_TextBox(tbPLZ, a.Plz);
            binder.BindTo_TextBox(tbTelefon, a.Telefon);
            binder.BindTo_TextBox(tbEmail, a.Email);
            binder.BindTo_TextBox(tbFirmenname, a.Firmenname);
            binder.BindTo_TextBox(tbBemerkungen, a.Bemerkungen);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            BindFrom();
            try
            {
                if (neu == true)
                {
                    BusinessLogic.Instance.AddKontakt(a);
                }
                else
                {
                    BusinessLogic.Instance.UpdateKontakt(a);
                }
                this.GetLogger().Info(string.Format("Added new Kunde(ID={0},Vorame={1},Nachname={2},Adresse={3},Ort={4},PLZ={5},Telefon={6},E-Mail={7},Firmenname={8},Bemerkungen={9}).", a.ID, a.Vorname, a.Nachname, a.Adresse, a.Ort, a.Plz, a.Telefon, a.Email, a.Firmenname, a.Bemerkungen));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KontaktDetail_Load(object sender, EventArgs e)
        {
            BindTo();
        }
    }
}