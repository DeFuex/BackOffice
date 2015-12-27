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
    public partial class EingangsrechnungList : UserControl
    {
        public EingangsrechnungList()
        {
            InitializeComponent();
        }

        private void EingangsrechnungList_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        public string getSucheText()
        {
            return tbEingangsrechnungen.Text;
        }

        public void BindTo()        //hier wird BindTo() verwendet um Daten aus der Datenbank zu lesen und anzuzeigen.
        {
            DataBinder binder = new DataBinder();
            binder.BindTo_ListView(lvEingangsrechnungen, BusinessLogic.Instance.GetAllEingangsrechnungen(), getSucheText());
        }

        private void btEingangsrechnungenAdd_Click(object sender, EventArgs e)
        {
            using (var dialog = new EingangsrechnungDetail())
            {
                dialog.ShowDialog(this);        //dialog.ShowDialog verhindert das man beim Aufruf des Hinzufügen Fensters in die main Applikation zurückgewechselt werden kann
            }                                   //und this sagt sozusagen, dass das main Fenster wo der button hinzufügen gedrückt wurde der parent von dem hinzufügen fenster ist.
            BindTo();       //wenn jetzt ein neues Eingangsrechnung angelegt wird, wird mit BindTo automatisch der neue Eintrag im Fenster geupdated bzw. geladen und angezeigt.
        }

        private void btEingangsrechnungenDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvEingangsrechnungen.SelectedItems)
            {
                Eingangsrechnung Eingangsrechnung = (Eingangsrechnung)lvi.Tag;
                BusinessLogic.Instance.DeleteEingangsrechnung(Eingangsrechnung);
            }
            BindTo();
        }

        private void btEingangsrechnungenEdit_Click(object sender, EventArgs e)
        {
            if (lvEingangsrechnungen.SelectedItems.Count == 0)
                return;

            Eingangsrechnung Eingangsrechnung = (Eingangsrechnung)lvEingangsrechnungen.SelectedItems[0].Tag;     //hier holt man das aktuelle Eingangsrechnung aus dem Tag des ersten SelectedItem

            using (var dialog = new EingangsrechnungDetail(Eingangsrechnung))
            {
                dialog.ShowDialog(this);
            }

            BindTo();
        }

        private void lvEingangsrechnungen_KeyDown(object sender, KeyEventArgs e)  //lvEingangsrechnungen_KeyDown wird in den Properties wie jede andere Methode hier vorbereitet angelegt.
        {
            if (e.KeyCode == Keys.Delete)
            {
                btEingangsrechnungenDelete_Click(btEingangsrechnungenDelete, new EventArgs());
            }
        }

        private void lvEingangsrechnungen_MouseDoubleClick(object sender, MouseEventArgs e)       //im e parameter bekommt man detaildaten zum doppelklick
        {
            var lvi = lvEingangsrechnungen.GetItemAt(e.X, e.Y);    //hier werden die x und y daten an der position des ausgeführten doppelklicks übergeben...     

            if (lvi == null)            //wenn nach dem doppelklick lvi null ist passiert nichts...wenn eine zeile in der Liste ausgewählt wird, wird das Eingangsrechnung aus dem Tag ausgelesen und kann bearbeitet werden.
                return;

            Eingangsrechnung Eingangsrechnung = (Eingangsrechnung)lvi.Tag;     //im Tag kommt die variable als object zurück und nicht als Eingangsrechnung deswegen muss das Eingangsrechnung explizit als (Eingangsrechnung) getypecasted werden. 

            using (var dialog = new EingangsrechnungDetail(Eingangsrechnung))  //hier wird ein neuer Edit Dialog erstellt...das fenster welches gleich mit ShowDialog geöffnet wird
            {
                dialog.ShowDialog(this);        //hier wird das Fenster nun geöffnet.
            }

            BindTo();       //mit BindTo lädt die Daten neu aus der Datenbank und zeigt sie an. hier ist man in einer liste

        }

        private void tbEingangsrechnungen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    //Im Suchfeld wird erst gesucht wenn ENTER gedrückt wird 
            {
                BindTo();           //im BindTo() wird die Suche aufgerufen.
            }
        }

        private void tbEingangsrechnungen_TextChanged(object sender, EventArgs e)
        {
            BindTo();
        }
    }
}
