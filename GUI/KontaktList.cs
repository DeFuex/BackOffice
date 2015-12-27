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
    public partial class KontaktList : UserControl
    {
        public KontaktList()
        {
            InitializeComponent();
        }

        private void KontaktList_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        public string getSucheText()
        {
            return tbKontakte.Text;
        }

        public void BindTo()        //hier wird BindTo() verwendet um Daten aus der Datenbank zu lesen und anzuzeigen.
        {
            DataBinder binder = new DataBinder();
            binder.BindTo_ListView(lvKontakte, BusinessLogic.Instance.GetAllKontakte(), getSucheText());
        }

        private void btKontakteAdd_Click_1(object sender, EventArgs e)
        {
            using (var dialog = new KontaktDetail())
            {
                dialog.ShowDialog(this);        //dialog.ShowDialog verhindert das man beim Aufruf des Hinzufügen Fensters in die main Applikation zurückgewechselt werden kann
            }                                   //und this sagt sozusagen, dass das main Fenster wo der button hinzufügen gedrückt wurde der parent von dem hinzufügen fenster ist.
            BindTo();       //wenn jetzt ein neues Kontakt angelegt wird, wird mit BindTo automatisch der neue Eintrag im Fenster geupdated bzw. geladen und angezeigt.
        }

        private void btKontakteDelete_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvKontakte.SelectedItems)
            {
                Kontakt Kontakt = (Kontakt)lvi.Tag;
                BusinessLogic.Instance.DeleteKontakt(Kontakt);
            }
            BindTo();
        }

        private void btKontakteEdit_Click_1(object sender, EventArgs e)
        {
            if (lvKontakte.SelectedItems.Count == 0)
                return;

            Kontakt Kontakt = (Kontakt)lvKontakte.SelectedItems[0].Tag;     //hier holt man das aktuelle Angebot aus dem Tag des ersten SelectedItem

            using (var dialog = new KontaktDetail(Kontakt))
            {
                dialog.ShowDialog(this);
            }

            BindTo();
        }

        private void lvKontakte_KeyDown(object sender, KeyEventArgs e)  //lvKontakte_KeyDown wird in den Properties wie jede andere Methode hier vorbereitet angelegt.
        {
            if (e.KeyCode == Keys.Delete)
            {
                btKontakteDelete_Click_1(btKontakteDelete, new EventArgs());
            }
        }

        private void lvKontakte_MouseDoubleClick(object sender, MouseEventArgs e)       //im e parameter bekommt man detaildaten zum doppelklick
        {
            var lvi = lvKontakte.GetItemAt(e.X, e.Y);    //hier werden die x und y daten an der position des ausgeführten doppelklicks übergeben...     

            if (lvi == null)            //wenn nach dem doppelklick lvi null ist passiert nichts...wenn eine zeile in der Liste ausgewählt wird, wird das Kontakt aus dem Tag ausgelesen und kann bearbeitet werden.
                return;

            Kontakt Kontakt = (Kontakt)lvi.Tag;     //im Tag kommt die variable als object zurück und nicht als Kontakt deswegen muss das Kontakt explizit als (Kontakt) getypecasted werden. 

            using (var dialog = new KontaktDetail(Kontakt))  //hier wird ein neuer Edit Dialog erstellt...das fenster welches gleich mit ShowDialog geöffnet wird
            {
                dialog.ShowDialog(this);        //hier wird das Fenster nun geöffnet.
            }

            BindTo();       //mit BindTo lädt die Daten neu aus der Datenbank und zeigt sie an. hier ist man in einer liste

        }

        private void tbKontakte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    //Im Suchfeld wird erst gesucht wenn ENTER gedrückt wird 
            {
                BindTo();           //im BindTo() wird die Suche aufgerufen.
            }
        }

        private void tbKontakte_TextChanged(object sender, EventArgs e)
        {
            BindTo();
        }
    }
}
