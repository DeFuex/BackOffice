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
    public partial class AngebotDetail : Form
    {
        Angebot a = null;
        Binding.DataBinder binder;
        Boolean neu = false;

        public AngebotDetail()
        {
            InitializeComponent();
            this.a = new Angebot();
            binder = new Binding.DataBinder();
            this.Text = "Neues Angebot anlegen";
            neu = true;
        }

        public AngebotDetail(Angebot a)
        {
            InitializeComponent();
            this.a = a;
            binder = new Binding.DataBinder();
            this.Text = "Angebot bearbeiten";
        }

        public void BindFrom()       //von einem vorhandenen angebot werden die Daten beim bearbeiten angezeigt.
        {
            binder.StartBindFrom();
            a.Chance = (float)binder.BindFrom_Double(tbChance, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
            a.Dauer = binder.BindFrom_Int(tbDuration, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
            a.Summe = binder.BindFrom_Double(tbSum, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
            a.Datum = binder.BindFrom_DateTime(dtpDate, new Binding.ErrorMaintenance(), null);
            a.KundenID = binder.BindFrom_ComboBox_Long(cbCustomer, new Binding.ErrorMaintenance(), new Binding.RequiredInputRule());
            a.ProjektID = binder.BindFrom_ComboBox_Long(cbProject, new Binding.ErrorMaintenance(), new Binding.RequiredInputRule());
        }

        public void BindTo()         //erstellt ein neues angebot aus den eingegebenen Daten...läd daten in die properties
        {
            binder.BindTo_ComboBox(cbCustomer, BusinessLogic.Instance.GetAllKunden(), a.KundenID);
            binder.BindTo_ComboBox(cbProject, BusinessLogic.Instance.GetAllProjekte(), a.ProjektID);
            cbProject.ValueMember = "Name";
            binder.BindTo_TextBox(tbSum, a.Summe);
            binder.BindTo_TextBox(tbDuration, a.Dauer);
            binder.BindTo_TextBox(tbChance, a.Chance);
            binder.BindTo_DateTimePicker(dtpDate, a.Datum);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AngebotDetail_Load_1(object sender, EventArgs e)
        {
            BindTo();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            BindFrom();
            try
            {
                if (neu == true)
                {
                    BusinessLogic.Instance.AddAngebot(a);
                }
                else
                {
                    BusinessLogic.Instance.UpdateAngebot(a);
                }
                this.GetLogger().Info(string.Format("Added new Angebot(ID={0},Datum={1},Chance={2},Summe={3},Dauer={4},ProjektID={5},KundenID={6}).", a.ID, a.Datum, a.Chance, a.Summe, a.Dauer, a.ProjektID, a.KundenID));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}