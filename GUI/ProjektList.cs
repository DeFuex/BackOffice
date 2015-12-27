using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GUI.Binding;
using BL;
using Domain;

namespace GUI
{
    public partial class ProjektList : UserControl
    {
        public ProjektList()
        {
            InitializeComponent();
        }

        private void ProjektList_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        public string getSucheText()
        {
            return tbProjekte.Text;
        }

        public void BindTo()        //hier wird BindTo() verwendet um Daten aus der Datenbank zu lesen und anzuzeigen.
        {
            DataBinder binder = new DataBinder();
            binder.BindTo_ListView(lvProjekte, BusinessLogic.Instance.GetAllProjekte(), getSucheText());
        }

        private void btProjekteAdd_Click_1(object sender, EventArgs e)
        {
            using (var dialog = new ProjektDetail())
            {
                dialog.ShowDialog(this);        //dialog.ShowDialog verhindert das man beim Aufruf des Hinzufügen Fensters in die main Applikation zurückgewechselt werden kann
            }                                   //und this sagt sozusagen, dass das main Fenster wo der button hinzufügen gedrückt wurde der parent von dem hinzufügen fenster ist.
            BindTo();       //wenn jetzt ein neues Projekt angelegt wird, wird mit BindTo automatisch der neue Eintrag im Fenster geupdated bzw. geladen und angezeigt.
        }

        private void btProjekteDelete_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvProjekte.SelectedItems)
            {
                Projekt Projekt = (Projekt)lvi.Tag;
                BusinessLogic.Instance.DeleteProjekt(Projekt);
            }
            BindTo();
        }

        private void btProjekteEdit_Click_1(object sender, EventArgs e)
        {
            if (lvProjekte.SelectedItems.Count == 0)
                return;

            Projekt projekt = (Projekt)lvProjekte.SelectedItems[0].Tag;     //hier holt man das aktuelle Angebot aus dem Tag des ersten SelectedItem

            using (var dialog = new ProjektDetail(projekt))
            {
                dialog.ShowDialog(this);
            }

            BindTo();
        }

        private void lvProjekte_KeyDown(object sender, KeyEventArgs e)  //lvProjekte_KeyDown wird in den Properties wie jede andere Methode hier vorbereitet angelegt.
        {
            if (e.KeyCode == Keys.Delete)
            {
                btProjekteDelete_Click_1(btProjekteDelete, new EventArgs());
            }
        }

        private void lvProjekte_MouseDoubleClick(object sender, MouseEventArgs e)       //im e parameter bekommt man detaildaten zum doppelklick
        {
            var lvi = lvProjekte.GetItemAt(e.X, e.Y);    //hier werden die x und y daten an der position des ausgeführten doppelklicks übergeben...     

            if (lvi == null)            //wenn nach dem doppelklick lvi null ist passiert nichts...wenn eine zeile in der Liste ausgewählt wird, wird das Projekt aus dem Tag ausgelesen und kann bearbeitet werden.
                return;

            Projekt Projekt = (Projekt)lvi.Tag;     //im Tag kommt die variable als object zurück und nicht als Projekt deswegen muss das Projekt explizit als (Projekt) getypecasted werden. 

            using (var dialog = new ProjektDetail(Projekt))  //hier wird ein neuer Edit Dialog erstellt...das fenster welches gleich mit ShowDialog geöffnet wird
            {
                dialog.ShowDialog(this);        //hier wird das Fenster nun geöffnet.
            }

            BindTo();       //mit BindTo lädt die Daten neu aus der Datenbank und zeigt sie an. hier ist man in einer liste

        }

        private void tbProjekte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    //Im Suchfeld wird erst gesucht wenn ENTER gedrückt wird 
            {
                BindTo();           //im BindTo() wird die Suche aufgerufen.
            }
        }

        private void tbProjekte_TextChanged(object sender, EventArgs e)
        {
            BindTo();
        }
    }
}
