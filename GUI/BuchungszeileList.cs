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
    public partial class BuchungszeileList : UserControl
    {
        public BuchungszeileList()
        {
            InitializeComponent();
        }

        private void BuchungszeileList_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        public string getSucheText()
        {
            return tbBuchungszeilen.Text;
        }

        public void BindTo()        //hier wird BindTo() verwendet um Daten aus der Datenbank zu lesen und anzuzeigen.
        {
            DataBinder binder = new DataBinder();
            binder.BindTo_ListView(lvBuchungszeilen, BusinessLogic.Instance.GetAllBuchungszeilen(), getSucheText());
        }

        private void btBuchungszeilenAdd_Click(object sender, EventArgs e)
        {
            using (var dialog = new BuchungszeileDetail())
            {
                dialog.ShowDialog(this);        //dialog.ShowDialog verhindert das man beim Aufruf des Hinzufügen Fensters in die main Applikation zurückgewechselt werden kann
            }                                   //und this sagt sozusagen, dass das main Fenster wo der button hinzufügen gedrückt wurde der parent von dem hinzufügen fenster ist.
            BindTo();       //wenn jetzt ein neues Buchungszeile angelegt wird, wird mit BindTo automatisch der neue Eintrag im Fenster geupdated bzw. geladen und angezeigt.
        }

        private void btBuchungszeilenDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvBuchungszeilen.SelectedItems)
            {
                Buchungszeile Buchungszeile = (Buchungszeile)lvi.Tag;
                BusinessLogic.Instance.DeleteBuchungszeile(Buchungszeile);
            }
            BindTo();
        }

        private void btBuchungszeilenEdit_Click(object sender, EventArgs e)
        {
            if (lvBuchungszeilen.SelectedItems.Count == 0)
                return;

            Buchungszeile Buchungszeile = (Buchungszeile)lvBuchungszeilen.SelectedItems[0].Tag;     //hier holt man das aktuelle Buchungszeile aus dem Tag des ersten SelectedItem

            using (var dialog = new BuchungszeileDetail(Buchungszeile))
            {
                dialog.ShowDialog(this);
            }

            BindTo();
        }

        private void lvBuchungszeilen_KeyDown(object sender, KeyEventArgs e)  //lvBuchungszeilen_KeyDown wird in den Properties wie jede andere Methode hier vorbereitet angelegt.
        {
            if (e.KeyCode == Keys.Delete)
            {
                btBuchungszeilenDelete_Click(btBuchungszeilenDelete, new EventArgs());
            }
        }

        private void lvBuchungszeilen_MouseDoubleClick(object sender, MouseEventArgs e)       //im e parameter bekommt man detaildaten zum doppelklick
        {
            var lvi = lvBuchungszeilen.GetItemAt(e.X, e.Y);    //hier werden die x und y daten an der position des ausgeführten doppelklicks übergeben...     

            if (lvi == null)            //wenn nach dem doppelklick lvi null ist passiert nichts...wenn eine zeile in der Liste ausgewählt wird, wird das Buchungszeile aus dem Tag ausgelesen und kann bearbeitet werden.
                return;

            Buchungszeile Buchungszeile = (Buchungszeile)lvi.Tag;     //im Tag kommt die variable als object zurück und nicht als Buchungszeile deswegen muss das Buchungszeile explizit als (Buchungszeile) getypecasted werden. 

            using (var dialog = new BuchungszeileDetail(Buchungszeile))  //hier wird ein neuer Edit Dialog erstellt...das fenster welches gleich mit ShowDialog geöffnet wird
            {
                dialog.ShowDialog(this);        //hier wird das Fenster nun geöffnet.
            }

            BindTo();       //mit BindTo lädt die Daten neu aus der Datenbank und zeigt sie an. hier ist man in einer liste

        }

        private void tbBuchungszeilen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    //Im Suchfeld wird erst gesucht wenn ENTER gedrückt wird 
            {
                BindTo();           //im BindTo() wird die Suche aufgerufen.
            }
        }

        private void tbBuchungszeilen_TextChanged(object sender, EventArgs e)
        {
            BindTo();
        }
    }
}
