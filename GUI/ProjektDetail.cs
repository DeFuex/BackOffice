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
    public partial class ProjektDetail : Form
    {
        Projekt a = null;
        Binding.DataBinder binder;
        Boolean neu = false;

        public ProjektDetail()
        {
            InitializeComponent();
            this.a = new Projekt();
            binder = new Binding.DataBinder();
            this.Text = "Neues Projekt anlegen";
            neu = true;
        }

        public ProjektDetail(Projekt a)
        {
            InitializeComponent();
            this.a = a;
            binder = new Binding.DataBinder();
            this.Text = "Projekt bearbeiten";
        }

        public void BindFrom()       //von einem vorhandenen Projekt werden die Daten beim bearbeiten angezeigt.
        {
            binder.StartBindFrom();
            a.Name = binder.BindFrom_String(tbName, new Binding.ErrorMaintenance(), new Binding.RequiredInputRule());
            a.Gesamtzeit = binder.BindFrom_Double(tbGesamtzeit, new Binding.ErrorMaintenance(), new Binding.PositiveInputRule());
       }

        public void BindTo()         //erstellt ein neues Projekt aus den eingegebenen Daten...läd daten in die properties
        {
            binder.BindTo_TextBox(tbName, a.Name);
            binder.BindTo_TextBox(tbGesamtzeit, a.Gesamtzeit);
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
                    BusinessLogic.Instance.AddProjekt(a);
                }
                else
                {
                    BusinessLogic.Instance.UpdateProjekt(a);
                }
                this.GetLogger().Info(string.Format("Added new Projekt(ID={0},Name={1},Gesamtzeit={2}).", a.ID, a.Name, a.Gesamtzeit));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProjektDetail_Load(object sender, EventArgs e)
        {
            BindTo();
        }
    }
}