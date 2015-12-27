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
    public partial class AusgangsrechnungList : UserControl
    {
        public AusgangsrechnungList()
        {
            InitializeComponent();
        }

        private void AusgangsrechnungList_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        public string getSucheText()
        {
            return tbAusgangsrechnungen.Text;
        }

        public void BindTo()        //hier wird BindTo() verwendet um Daten aus der Datenbank zu lesen und anzuzeigen.
        {
            DataBinder binder = new DataBinder();
            binder.BindTo_ListView(lvAusgangsrechnungen, BusinessLogic.Instance.GetAllAusgangsrechnungen(), getSucheText());
        }

        private void btAusgangsrechnungenAdd_Click(object sender, EventArgs e)
        {
            using (var dialog = new AusgangsrechnungDetail())
            {
                dialog.ShowDialog(this);        //dialog.ShowDialog verhindert das man beim Aufruf des Hinzufügen Fensters in die main Applikation zurückgewechselt werden kann
            }                                   //und this sagt sozusagen, dass das main Fenster wo der button hinzufügen gedrückt wurde der parent von dem hinzufügen fenster ist.
            BindTo();       //wenn jetzt ein neues Ausgangsrechnung angelegt wird, wird mit BindTo automatisch der neue Eintrag im Fenster geupdated bzw. geladen und angezeigt.
        }

        private void btAusgangsrechnungenDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvAusgangsrechnungen.SelectedItems)
            {
                Ausgangsrechnung Ausgangsrechnung = (Ausgangsrechnung)lvi.Tag;
                BusinessLogic.Instance.DeleteAusgangsrechnung(Ausgangsrechnung);
            }
            BindTo();
        }

        private void btAusgangsrechnungenEdit_Click(object sender, EventArgs e)
        {
            if (lvAusgangsrechnungen.SelectedItems.Count == 0)
                return;

            Ausgangsrechnung Ausgangsrechnung = (Ausgangsrechnung)lvAusgangsrechnungen.SelectedItems[0].Tag;     //hier holt man das aktuelle Ausgangsrechnung aus dem Tag des ersten SelectedItem

            using (var dialog = new AusgangsrechnungDetail(Ausgangsrechnung))
            {
                dialog.ShowDialog(this);
            }

            BindTo();
        }

        private void lvAusgangsrechnungen_KeyDown(object sender, KeyEventArgs e)  //lvAusgangsrechnungen_KeyDown wird in den Properties wie jede andere Methode hier vorbereitet angelegt.
        {
            if (e.KeyCode == Keys.Delete)
            {
                btAusgangsrechnungenDelete_Click(btAusgangsrechnungenDelete, new EventArgs());
            }
        }

        private void lvAusgangsrechnungen_MouseDoubleClick(object sender, MouseEventArgs e)       //im e parameter bekommt man detaildaten zum doppelklick
        {
            var lvi = lvAusgangsrechnungen.GetItemAt(e.X, e.Y);    //hier werden die x und y daten an der position des ausgeführten doppelklicks übergeben...     

            if (lvi == null)            //wenn nach dem doppelklick lvi null ist passiert nichts...wenn eine zeile in der Liste ausgewählt wird, wird das Ausgangsrechnung aus dem Tag ausgelesen und kann bearbeitet werden.
                return;

            Ausgangsrechnung Ausgangsrechnung = (Ausgangsrechnung)lvi.Tag;     //im Tag kommt die variable als object zurück und nicht als Ausgangsrechnung deswegen muss das Ausgangsrechnung explizit als (Ausgangsrechnung) getypecasted werden. 

            using (var dialog = new AusgangsrechnungDetail(Ausgangsrechnung))  //hier wird ein neuer Edit Dialog erstellt...das fenster welches gleich mit ShowDialog geöffnet wird
            {
                dialog.ShowDialog(this);        //hier wird das Fenster nun geöffnet.
            }

            BindTo();       //mit BindTo lädt die Daten neu aus der Datenbank und zeigt sie an. hier ist man in einer liste

        }

        private void tbAusgangsrechnungen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    //Im Suchfeld wird erst gesucht wenn ENTER gedrückt wird 
            {
                BindTo();           //im BindTo() wird die Suche aufgerufen.
            }
        }

        private void tbAusgangsrechnungen_TextChanged(object sender, EventArgs e)
        {
            BindTo();
        }
    }
}
