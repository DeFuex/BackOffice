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
    public partial class AngebotList : UserControl
    {
        public AngebotList()
        {
            InitializeComponent();
        }

        private void AngebotList_Load(object sender, EventArgs e)
        {
            BindTo();
        }

        public string getSucheText()
        {
            return tbAngebote.Text;
        }

        public void BindTo()        //hier wird BindTo() verwendet um Daten aus der Datenbank zu lesen und anzuzeigen.
        {
            DataBinder binder = new DataBinder();
            binder.BindTo_ListView(lvAngebote, BusinessLogic.Instance.GetAllAngebote(), getSucheText());      
        }

        private void btAngeboteAdd_Click(object sender, EventArgs e)
        {
            using (var dialog = new AngebotDetail())
            {
                dialog.ShowDialog(this);        //dialog.ShowDialog verhindert das man beim Aufruf des Hinzufügen Fensters in die main Applikation zurückgewechselt werden kann
            }                                   //und this sagt sozusagen, dass das main Fenster wo der button hinzufügen gedrückt wurde der parent von dem hinzufügen fenster ist.
            BindTo();       //wenn jetzt ein neues Angebot angelegt wird, wird mit BindTo automatisch der neue Eintrag im Fenster geupdated bzw. geladen und angezeigt.
        }

        private void btAngeboteDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvAngebote.SelectedItems)
            {
                Angebot angebot = (Angebot)lvi.Tag;
                BusinessLogic.Instance.DeleteAngebot(angebot);
            }
            BindTo();
        }

        private void btAngeboteEdit_Click(object sender, EventArgs e)
        {
            if (lvAngebote.SelectedItems.Count == 0)
                return;

            Angebot angebot = (Angebot)lvAngebote.SelectedItems[0].Tag;     //hier holt man das aktuelle Angebot aus dem Tag des ersten SelectedItem

            using (var dialog = new AngebotDetail(angebot))
            {
                dialog.ShowDialog(this);
            }             
              
            BindTo();
        }

        private void lvAngebote_KeyDown(object sender, KeyEventArgs e)  //lvAngebote_KeyDown wird in den Properties wie jede andere Methode hier vorbereitet angelegt.
        {
            if (e.KeyCode == Keys.Delete)
            {
                btAngeboteDelete_Click(btAngeboteDelete, new EventArgs());
            }
        }

        private void lvAngebote_MouseDoubleClick(object sender, MouseEventArgs e)       //im e parameter bekommt man detaildaten zum doppelklick
        {
            var lvi = lvAngebote.GetItemAt(e.X, e.Y);    //hier werden die x und y daten an der position des ausgeführten doppelklicks übergeben...     

            if (lvi == null)            //wenn nach dem doppelklick lvi null ist passiert nichts...wenn eine zeile in der Liste ausgewählt wird, wird das Angebot aus dem Tag ausgelesen und kann bearbeitet werden.
                return;

            Angebot angebot = (Angebot)lvi.Tag;     //im Tag kommt die variable als object zurück und nicht als angebot deswegen muss das Angebot explizit als (Angebot) getypecasted werden. 

            using (var dialog = new AngebotDetail(angebot))  //hier wird ein neuer Edit Dialog erstellt...das fenster welches gleich mit ShowDialog geöffnet wird
            {
                dialog.ShowDialog(this);        //hier wird das Fenster nun geöffnet.
            }

            BindTo();       //mit BindTo lädt die Daten neu aus der Datenbank und zeigt sie an. hier ist man in einer liste
            
        }

        private void tbAngebote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    //Im Suchfeld wird erst gesucht wenn ENTER gedrückt wird 
            {
                BindTo();           //im BindTo() wird die Suche aufgerufen.
            }
        }

        private void tbAngebote_TextChanged(object sender, EventArgs e)
        {
            BindTo();
        }
    }
}
