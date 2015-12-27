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
    public partial class RechnungszeileList : UserControl
    {
        public RechnungszeileList()
        {
            InitializeComponent();
        }

        private void RechnungszeileList_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        public string getSucheText()
        {
            return tbRechnungszeilen.Text;
        }

        public void BindTo()        //hier wird BindTo() verwendet um Daten aus der Datenbank zu lesen und anzuzeigen.
        {
            DataBinder binder = new DataBinder();
            binder.BindTo_ListView(lvRechnungszeilen, BusinessLogic.Instance.GetAllRechnungszeilen(), getSucheText());
        }

        private void btRechnungszeilenAdd_Click_1(object sender, EventArgs e)
        {
            using (var dialog = new RechnungszeileDetail())
            {
                dialog.ShowDialog(this);        //dialog.ShowDialog verhindert das man beim Aufruf des Hinzufügen Fensters in die main Applikation zurückgewechselt werden kann
            }                                   //und this sagt sozusagen, dass das main Fenster wo der button hinzufügen gedrückt wurde der parent von dem hinzufügen fenster ist.
            BindTo();       //wenn jetzt ein neues Rechnungszeile angelegt wird, wird mit BindTo automatisch der neue Eintrag im Fenster geupdated bzw. geladen und angezeigt.
        }

        private void btRechnungszeilenDelete_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvRechnungszeilen.SelectedItems)
            {
                Rechnungszeile Rechnungszeile = (Rechnungszeile)lvi.Tag;
                BusinessLogic.Instance.DeleteRechnungszeile(Rechnungszeile);
            }
            BindTo();
        }

        private void btRechnungszeilenEdit_Click_1(object sender, EventArgs e)
        {
            if (lvRechnungszeilen.SelectedItems.Count == 0)
                return;

            Rechnungszeile Rechnungszeile = (Rechnungszeile)lvRechnungszeilen.SelectedItems[0].Tag;     //hier holt man das aktuelle Angebot aus dem Tag des ersten SelectedItem

            using (var dialog = new RechnungszeileDetail(Rechnungszeile))
            {
                dialog.ShowDialog(this);
            }

            BindTo();
        }

        private void lvRechnungszeilen_KeyDown(object sender, KeyEventArgs e)  //lvRechnungszeilen_KeyDown wird in den Properties wie jede andere Methode hier vorbereitet angelegt.
        {
            if (e.KeyCode == Keys.Delete)
            {
                btRechnungszeilenDelete_Click_1(btRechnungszeilenDelete, new EventArgs());
            }
        }

        private void lvRechnungszeilen_MouseDoubleClick(object sender, MouseEventArgs e)       //im e parameter bekommt man detaildaten zum doppelklick
        {
            var lvi = lvRechnungszeilen.GetItemAt(e.X, e.Y);    //hier werden die x und y daten an der position des ausgeführten doppelklicks übergeben...     

            if (lvi == null)            //wenn nach dem doppelklick lvi null ist passiert nichts...wenn eine zeile in der Liste ausgewählt wird, wird das Rechnungszeile aus dem Tag ausgelesen und kann bearbeitet werden.
                return;

            Rechnungszeile Rechnungszeile = (Rechnungszeile)lvi.Tag;     //im Tag kommt die variable als object zurück und nicht als Rechnungszeile deswegen muss das Rechnungszeile explizit als (Rechnungszeile) getypecasted werden. 

            using (var dialog = new RechnungszeileDetail(Rechnungszeile))  //hier wird ein neuer Edit Dialog erstellt...das fenster welches gleich mit ShowDialog geöffnet wird
            {
                dialog.ShowDialog(this);        //hier wird das Fenster nun geöffnet.
            }

            BindTo();       //mit BindTo lädt die Daten neu aus der Datenbank und zeigt sie an. hier ist man in einer liste

        }

        private void tbRechnungszeilen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    //Im Suchfeld wird erst gesucht wenn ENTER gedrückt wird 
            {
                BindTo();           //im BindTo() wird die Suche aufgerufen.
            }
        }

        private void tbRechnungszeilen_TextChanged(object sender, EventArgs e)
        {
            BindTo();
        }
    }
}
