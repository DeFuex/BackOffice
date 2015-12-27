using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using BL;
using Domain;
using Domain.Utils;

namespace GUI.Binding
{
    class DataBinder : UserControl
    {
        bool haserrors;

        public void StartBindFrom()
        {
            haserrors = false;
        }

        #region BindFrom
        public string BindFrom_String(Control ctrl, ErrorMaintenance errctrl, IRule rule)
        {
            ctrl.BackColor = Color.Empty;
            errctrl.clearError();

            string result = ctrl.Text;

            if (rule != null)
            {
                if (!rule.Eval(result, errctrl))
                {
                    haserrors = true;
                    ctrl.BackColor = Color.Red;
                }
            }

            return result;
        }

        public Boolean BindFrom_Checkbox(CheckBox chkbox, ErrorMaintenance errctrl, IRule rule)
        {
            chkbox.BackColor = Color.Empty;
            errctrl.clearError();

            Boolean result = chkbox.Checked;

            if (rule != null)
            {
                if (!rule.Eval(result, errctrl))
                {
                    haserrors = true;
                    chkbox.BackColor = Color.Red;
                }
            }

            return result;
        }

        public int BindFrom_Int(Control ctrl, ErrorMaintenance errctrl, IRule rule)
        {
            ctrl.BackColor = Color.Empty;
            errctrl.clearError();

            int result = 0;
            if (!int.TryParse(ctrl.Text, out result))
            {
                haserrors = true;
                ctrl.BackColor = Color.Red;
                errctrl.setError("Der Wert muss eine Zahl sein!");
            }

            if (rule != null)
            {
                if (!rule.Eval(result, errctrl))
                {
                    haserrors = true;
                    ctrl.BackColor = Color.Red;
                }
            }

            return result;
        }

        public double BindFrom_Double(Control ctrl, ErrorMaintenance errctrl, IRule rule)
        {
            ctrl.BackColor = Color.Empty;
            errctrl.clearError();

            double result = 0;
            if (!double.TryParse(ctrl.Text, out result))
            {
                haserrors = true;
                ctrl.BackColor = Color.Red;
                errctrl.setError("Der Wert muss eine Zahl sein!");
            }

            if (rule != null)
            {
                if (!rule.Eval(result, errctrl))
                {
                    haserrors = true;
                    ctrl.BackColor = Color.Red;
                }
            }

            return result;
        }

        public DateTime BindFrom_DateTime(Control ctrl, ErrorMaintenance errctrl, IRule rule)
        {
            ctrl.BackColor = Color.Empty;
            errctrl.clearError();

            DateTime result = DateTime.Today;

            if (ctrl is DateTimePicker)
            {
                result = ((DateTimePicker)ctrl).Value;
            }

            if (rule != null)
            {
                if (!rule.Eval(result, errctrl))
                {
                    haserrors = true;
                    ctrl.BackColor = Color.Red;
                }
            }

            return result;
        }

        public long BindFrom_ComboBox_Long(ComboBox cb, ErrorMaintenance errctrl, IRule rule)
        {
            cb.BackColor = Color.Empty;
            errctrl.clearError();

            long result = 0;
            object selected = cb.SelectedItem;

            if (selected != null)
            {
                result = ((BaseObject)selected).ID;
            }

            if (rule != null)
            {
                if (!rule.Eval(selected, errctrl))
                {
                    haserrors = true;
                    cb.BackColor = Color.Red;
                }
            }

            return result;
        }
        #endregion

        #region BindTo
        public void BindTo_TextBox(Control ctrl, object value)
        {
            if (value != null)
            {
                ctrl.Text = value.ToString();
            }
        }

        public void BindTo_CheckBox(CheckBox chkbox, Boolean value)
        {
            chkbox.Checked = value;
        }

        public void BindTo_DateTimePicker(DateTimePicker ctrl, object value)
        {
            if (value != null)
            {
                ctrl.Value = (DateTime)value;
            }
        }

        public void BindTo_ListView(ListView lv, IList values, String search)
        {
            lv.BeginUpdate();
            lv.Items.Clear();
            lv.Columns.Clear();
            lv.GridLines = true;
            lv.FullRowSelect = true;
            lv.View = View.Details;

            if (typeof(IList<Angebot>).IsInstanceOfType(values))
            {
                //lv.BeginUpdate();               //mit BeginUpdate und EndUpdate werden nicht sofort neue Bilder gezeichnet(geladen) wenn man Einträge ändert...sondern erst wenn EndUpdate aufgerufen wurde..also wenn ein anderer Button gedrückt wird(zum beispiel, ein anderes form geöffnet wird)...Perfomance besser!

                ////Reste Columns & Items
                //lv.Columns.Clear();             //eventuell später nützlich falls man eine f5 refresh funktion einbaut, da durch refresh eben noch dateneinträge vorhanden sein können...deswegen lieber clear verwenden.
                //lv.Items.Clear();

                lv.Columns.Add("ID");
                lv.Columns.Add("Datum");
                lv.Columns.Add("Dauer");
                lv.Columns.Add("Summe");
                lv.Columns.Add("Chance");
                lv.Columns.Add("Projekt");
                lv.Columns.Add("Kunde");

                //List<Angebot> suchlist = null;

                if (string.IsNullOrEmpty(search))
                {
                    values = BusinessLogic.Instance.GetAllAngebote();
                }
                else
                {
                    values = BusinessLogic.Instance.FindAngebote(search);
                }

                foreach (var item in values)
                {
                    var tmp = (Angebot)item;

                    ListViewItem i = lv.Items.Add(tmp.ID.ToString());
                    i.Tag = tmp;
                    i.SubItems.Add(tmp.Datum.ToString());
                    i.SubItems.Add(tmp.Dauer.ToString());
                    i.SubItems.Add(tmp.Summe.ToString() + " Euro");
                    i.SubItems.Add(tmp.Chance.ToString() + "%");
                    i.SubItems.Add(BusinessLogic.Instance.GetProjektByID(tmp.ProjektID).Name);
                    i.SubItems.Add(BusinessLogic.Instance.GetKundeByID(tmp.KundenID).Vorname + " " + BusinessLogic.Instance.GetKundeByID(tmp.KundenID).Nachname);
                }
            }
            else if (typeof(IList<Ausgangsrechnung>).IsInstanceOfType(values))
            {
                //lv.BeginUpdate();               //mit BeginUpdate und EndUpdate werden nicht sofort neue Bilder gezeichnet(geladen) wenn man Einträge ändert...sondern erst wenn EndUpdate aufgerufen wurde..also wenn ein anderer Button gedrückt wird(zum beispiel, ein anderes form geöffnet wird)...Perfomance besser!

                ////Reste Columns & Items
                //lv.Columns.Clear();             //eventuell später nützlich falls man eine f5 refresh funktion einbaut, da durch refresh eben noch dateneinträge vorhanden sein können...deswegen lieber clear verwenden.
                //lv.Items.Clear();

                lv.Columns.Add("ID");
                lv.Columns.Add("Summe");
                lv.Columns.Add("Datum");
                lv.Columns.Add("Beschreibung");
                lv.Columns.Add("Gedruckt");
                lv.Columns.Add("Offen");
                lv.Columns.Add("Projekt");
                lv.Columns.Add("Kunde");

                if (string.IsNullOrEmpty(search))
                {
                    values = BusinessLogic.Instance.GetAllAusgangsrechnungen();
                }
                else
                {
                    values = BusinessLogic.Instance.FindAusgangsrechnungen(search);
                }

                foreach (var item in values)
                {
                    var tmp = (Ausgangsrechnung)item;

                    ListViewItem i = lv.Items.Add(tmp.ID.ToString());
                    i.Tag = tmp;
                    i.SubItems.Add(tmp.Summe.ToString() + " Euro");
                    i.SubItems.Add(tmp.Datum.ToShortDateString());
                    i.SubItems.Add(tmp.Beschreibung);
                    i.SubItems.Add(tmp.Gedruckt.ToString());
                    i.SubItems.Add(tmp.Offen.ToString());
                    i.SubItems.Add(BusinessLogic.Instance.GetProjektByID(tmp.ProjektID).Name);
                    i.SubItems.Add(BusinessLogic.Instance.GetKundeByID(tmp.KundenID).Vorname + " " + BusinessLogic.Instance.GetKundeByID(tmp.KundenID).Nachname);

                }
            }
            else if (typeof(IList<Kunde>).IsInstanceOfType(values))
            {
                //lv.BeginUpdate();               //mit BeginUpdate und EndUpdate werden nicht sofort neue Bilder gezeichnet(geladen) wenn man Einträge ändert...sondern erst wenn EndUpdate aufgerufen wurde..also wenn ein anderer Button gedrückt wird(zum beispiel, ein anderes form geöffnet wird)...Perfomance besser!

                ////Reste Columns & Items
                //lv.Columns.Clear();             //eventuell später nützlich falls man eine f5 refresh funktion einbaut, da durch refresh eben noch dateneinträge vorhanden sein können...deswegen lieber clear verwenden.
                //lv.Items.Clear();

                lv.Columns.Add("ID");
                lv.Columns.Add("Nachname");
                lv.Columns.Add("Vorname");
                lv.Columns.Add("Adresse");
                lv.Columns.Add("Ort");
                lv.Columns.Add("PLZ");
                lv.Columns.Add("Telefon");
                lv.Columns.Add("E-Mail");
                lv.Columns.Add("Bemerkungen");

                if (string.IsNullOrEmpty(search))
                {
                    values = BusinessLogic.Instance.GetAllKunden();
                }
                else
                {
                    values = BusinessLogic.Instance.FindKunden(search);
                }

                foreach (var item in values)
                {
                    var tmp = (Kunde)item;

                    ListViewItem i = lv.Items.Add(tmp.ID.ToString());
                    i.Tag = tmp;
                    i.SubItems.Add(tmp.Nachname);
                    i.SubItems.Add(tmp.Vorname);
                    i.SubItems.Add(tmp.Adresse);
                    i.SubItems.Add(tmp.Ort);
                    i.SubItems.Add(tmp.Plz.ToString());
                    i.SubItems.Add(tmp.Telefon);
                    i.SubItems.Add(tmp.Email);
                    i.SubItems.Add(tmp.Bemerkungen);
                }
            }
            else if (typeof(IList<Kontakt>).IsInstanceOfType(values))
            {
                //lv.BeginUpdate();               //mit BeginUpdate und EndUpdate werden nicht sofort neue Bilder gezeichnet(geladen) wenn man Einträge ändert...sondern erst wenn EndUpdate aufgerufen wurde..also wenn ein anderer Button gedrückt wird(zum beispiel, ein anderes form geöffnet wird)...Perfomance besser!

                ////Reste Columns & Items
                //lv.Columns.Clear();             //eventuell später nützlich falls man eine f5 refresh funktion einbaut, da durch refresh eben noch dateneinträge vorhanden sein können...deswegen lieber clear verwenden.
                //lv.Items.Clear();

                lv.Columns.Add("ID");
                lv.Columns.Add("Nachname");
                lv.Columns.Add("Vorname");
                lv.Columns.Add("Adresse");
                lv.Columns.Add("Ort");
                lv.Columns.Add("PLZ");
                lv.Columns.Add("Telefon");
                lv.Columns.Add("Email");
                lv.Columns.Add("Firmenname");
                lv.Columns.Add("Bemerkungen");

                if (string.IsNullOrEmpty(search))
                {
                    values = BusinessLogic.Instance.GetAllKontakte();
                }
                else
                {
                    values = BusinessLogic.Instance.FindKontakte(search);
                }

                foreach (var item in values)
                {
                    var tmp = (Kontakt)item;

                    ListViewItem i = lv.Items.Add(tmp.ID.ToString());

                    i.Tag = tmp;
                    i.SubItems.Add(tmp.Nachname);
                    i.SubItems.Add(tmp.Vorname);
                    i.SubItems.Add(tmp.Adresse);
                    i.SubItems.Add(tmp.Ort);
                    i.SubItems.Add(tmp.Plz.ToString());
                    i.SubItems.Add(tmp.Telefon);
                    i.SubItems.Add(tmp.Email);
                    i.SubItems.Add(tmp.Firmenname);
                    i.SubItems.Add(tmp.Bemerkungen);
                }
            }
            else if (typeof(IList<Eingangsrechnung>).IsInstanceOfType(values))
            {
                //lv.BeginUpdate();               //mit BeginUpdate und EndUpdate werden nicht sofort neue Bilder gezeichnet(geladen) wenn man Einträge ändert...sondern erst wenn EndUpdate aufgerufen wurde..also wenn ein anderer Button gedrückt wird(zum beispiel, ein anderes form geöffnet wird)...Perfomance besser!

                ////Reste Columns & Items
                //lv.Columns.Clear();             //eventuell später nützlich falls man eine f5 refresh funktion einbaut, da durch refresh eben noch dateneinträge vorhanden sein können...deswegen lieber clear verwenden.
                //lv.Items.Clear();

                lv.Columns.Add("ID");
                lv.Columns.Add("Summe");
                lv.Columns.Add("Datum");
                lv.Columns.Add("Beschreibung");
                lv.Columns.Add("Offen");
                lv.Columns.Add("Kontakt");

                if (string.IsNullOrEmpty(search))
                {
                    values = BusinessLogic.Instance.GetAllEingangsrechnungen();
                }
                else
                {
                    values = BusinessLogic.Instance.FindEingangsrechnungen(search);
                }

                foreach (var item in values)
                {
                    var tmp = (Eingangsrechnung)item;

                    ListViewItem i = lv.Items.Add(tmp.ID.ToString());
                    i.Tag = tmp;
                    i.SubItems.Add(tmp.Summe.ToString() + " Euro");
                    i.SubItems.Add(tmp.Datum.ToString());
                    i.SubItems.Add(tmp.Beschreibung);
                    i.SubItems.Add(tmp.Offen.ToString());
                    i.SubItems.Add(BusinessLogic.Instance.GetKontaktByID(tmp.KontaktID).Vorname + " " + BusinessLogic.Instance.GetKontaktByID(tmp.KontaktID).Nachname);

                }
            }
            //else if (typeof(IList<RechnungBuchung>).IsInstanceOfType(values))
            //{
            //    //lv.BeginUpdate();               //mit BeginUpdate und EndUpdate werden nicht sofort neue Bilder gezeichnet(geladen) wenn man Einträge ändert...sondern erst wenn EndUpdate aufgerufen wurde..also wenn ein anderer Button gedrückt wird(zum beispiel, ein anderes form geöffnet wird)...Perfomance besser!

            //    ////Reste Columns & Items
            //    //lv.Columns.Clear();             //eventuell später nützlich falls man eine f5 refresh funktion einbaut, da durch refresh eben noch dateneinträge vorhanden sein können...deswegen lieber clear verwenden.
            //    //lv.Items.Clear();

            //    lv.Columns.Add("ID");
            //    lv.Columns.Add("Rechnungstyp");

            //    RechnungBuchungList a = new RechnungBuchungList();

            //    if (string.IsNullOrEmpty(search))
            //    {
            //        values = BusinessLogic.Instance.GetAllAngebote();
            //    }
            //    else
            //    {
            //        values = BusinessLogic.Instance.FindAngebote(search);
            //    }

            //    foreach (var item in values)
            //    {
            //        var tmp = (RechnungBuchung)item;

            //        ListViewItem i = lv.Items.Add(tmp.ID.ToString());
            //        i.Tag = tmp;
            //        i.SubItems.Add(tmp.Rechnungstyp);
            //    }
            //}
            else if (typeof(IList<Rechnungszeile>).IsInstanceOfType(values))
            {
                //lv.BeginUpdate();               //mit BeginUpdate und EndUpdate werden nicht sofort neue Bilder gezeichnet(geladen) wenn man Einträge ändert...sondern erst wenn EndUpdate aufgerufen wurde..also wenn ein anderer Button gedrückt wird(zum beispiel, ein anderes form geöffnet wird)...Perfomance besser!

                ////Reste Columns & Items
                //lv.Columns.Clear();             //eventuell später nützlich falls man eine f5 refresh funktion einbaut, da durch refresh eben noch dateneinträge vorhanden sein können...deswegen lieber clear verwenden.
                //lv.Items.Clear();

                lv.Columns.Add("ID");
                lv.Columns.Add("Bezeichnung");
                lv.Columns.Add("Betrag");
                lv.Columns.Add("Angebot");
                lv.Columns.Add("Ausgangsrechnung");

                if (string.IsNullOrEmpty(search))
                {
                    values = BusinessLogic.Instance.GetAllRechnungszeilen();
                }
                else
                {
                    values = BusinessLogic.Instance.FindRechnungszeilen(search);
                }

                foreach (var item in values)
                {
                    var tmp = (Rechnungszeile)item;

                    ListViewItem i = lv.Items.Add(tmp.ID.ToString());
                    i.Tag = tmp;
                    i.SubItems.Add(tmp.Bezeichnung);
                    i.SubItems.Add(tmp.Betrag.ToString() + " Euro");
                    i.SubItems.Add(tmp.AngebotID.ToString());
                    i.SubItems.Add(tmp.AusgangsrechnungID.ToString());
                }
            }
            //else if (typeof(IList<BuchungKategorie>).IsInstanceOfType(values))
            //{
            //    //lv.BeginUpdate();               //mit BeginUpdate und EndUpdate werden nicht sofort neue Bilder gezeichnet(geladen) wenn man Einträge ändert...sondern erst wenn EndUpdate aufgerufen wurde..also wenn ein anderer Button gedrückt wird(zum beispiel, ein anderes form geöffnet wird)...Perfomance besser!

            //    ////Reste Columns & Items
            //    //lv.Columns.Clear();             //eventuell später nützlich falls man eine f5 refresh funktion einbaut, da durch refresh eben noch dateneinträge vorhanden sein können...deswegen lieber clear verwenden.
            //    //lv.Items.Clear();

            //    lv.Columns.Add("ID");

            //    BuchungKategorieList a= new BuchungKategorieList();

            //    if (string.IsNullOrEmpty(search))
            //    {
            //        values = BusinessLogic.Instance.GetAllAngebote();
            //    }
            //    else
            //    {
            //        values = BusinessLogic.Instance.FindAngebote(search);
            //    }

            //    foreach (var item in values)
            //    {
            //        var tmp = (BuchungKategorie)item;

            //        ListViewItem i = lv.Items.Add(tmp.ID.ToString());
            //        i.Tag = tmp;
            //        //i.SubItems.Add(tmp.);
            //        //i.SubItems.Add(tmp.Betrag.ToString("#0.00") + " Euro");
            //        //i.SubItems.Add(BL.getRechnung(tmp.Rechnungid).Bezeichnung);
            //        //i.SubItems.Add(BL.getBuchungsKategorie(tmp.Kategorie).Bezeichung);
            //    }
            //}
            else if (typeof(IList<Buchungszeile>).IsInstanceOfType(values))
            {
                //lv.BeginUpdate();               //mit BeginUpdate und EndUpdate werden nicht sofort neue Bilder gezeichnet(geladen) wenn man Einträge ändert...sondern erst wenn EndUpdate aufgerufen wurde..also wenn ein anderer Button gedrückt wird(zum beispiel, ein anderes form geöffnet wird)...Perfomance besser!

                ////Reste Columns & Items
                //lv.Columns.Clear();             //eventuell später nützlich falls man eine f5 refresh funktion einbaut, da durch refresh eben noch dateneinträge vorhanden sein können...deswegen lieber clear verwenden.
                //lv.Items.Clear();

                lv.Columns.Add("ID");
                lv.Columns.Add("Bankkonto");
                lv.Columns.Add("Rechnungssumme");
                lv.Columns.Add("Umsatzsteuer");

                if (!string.IsNullOrEmpty(search))
                {
                    values = BusinessLogic.Instance.FindBuchungszeilen(search);
                }

                foreach (var item in values)
                {
                    var tmp = (Buchungszeile)item;

                    ListViewItem i = lv.Items.Add(tmp.ID.ToString());
                    i.Tag = tmp;
                    i.SubItems.Add(tmp.Bankkonto);
                    i.SubItems.Add(tmp.Rechnungssumme.ToString() + " Euro");
                    i.SubItems.Add(tmp.Ust + "%");
                }
            }
            else if (typeof(IList<Projekt>).IsInstanceOfType(values))
            {
                //lv.BeginUpdate();               //mit BeginUpdate und EndUpdate werden nicht sofort neue Bilder gezeichnet(geladen) wenn man Einträge ändert...sondern erst wenn EndUpdate aufgerufen wurde..also wenn ein anderer Button gedrückt wird(zum beispiel, ein anderes form geöffnet wird)...Perfomance besser!

                ////Reste Columns & Items
                //lv.Columns.Clear();             //eventuell später nützlich falls man eine f5 refresh funktion einbaut, da durch refresh eben noch dateneinträge vorhanden sein können...deswegen lieber clear verwenden.
                //lv.Items.Clear();

                lv.Columns.Add("ID");
                lv.Columns.Add("Name");
                lv.Columns.Add("Gesamtzeit");

                if (string.IsNullOrEmpty(search))
                {
                    values = BusinessLogic.Instance.GetAllProjekte();
                }
                else
                {
                    values = BusinessLogic.Instance.FindProjekte(search);
                }

                foreach (var item in values)
                {
                    var tmp = (Projekt)item;

                    ListViewItem i = lv.Items.Add(tmp.ID.ToString());
                    i.Tag = tmp;
                    i.SubItems.Add(tmp.Name);
                    i.SubItems.Add(tmp.Gesamtzeit.ToString());


                }
            }
            //else if (typeof(IList<Stunden>).IsInstanceOfType(values))
            //{
            //    //lv.BeginUpdate();               //mit BeginUpdate und EndUpdate werden nicht sofort neue Bilder gezeichnet(geladen) wenn man Einträge ändert...sondern erst wenn EndUpdate aufgerufen wurde..also wenn ein anderer Button gedrückt wird(zum beispiel, ein anderes form geöffnet wird)...Perfomance besser!

            //    ////Reste Columns & Items
            //    //lv.Columns.Clear();             //eventuell später nützlich falls man eine f5 refresh funktion einbaut, da durch refresh eben noch dateneinträge vorhanden sein können...deswegen lieber clear verwenden.
            //    //lv.Items.Clear();

            //    lv.Columns.Add("Name");
            //    lv.Columns.Add("Mitarbeiter");
            //    lv.Columns.Add("Stunden");
            //    lv.Columns.Add("Datum");

            //    AngebotList an = new AngebotList();

            //    if (string.IsNullOrEmpty(an.getSucheText()))
            //    {
            //        values = BusinessLogic.Instance.GetAllAngebote();
            //    }
            //    else
            //    {
            //        values = BusinessLogic.Instance.FindAngebote(an.getSucheText());
            //    }

            //    foreach (var item in values)
            //    {
            //        var tmp = (Stunden)item;

            //        ListViewItem i = lv.Items.Add(tmp.Projektname);
            //        i.Tag = tmp;
            //        i.SubItems.Add(tmp.Mitarbeiter);
            //        i.SubItems.Add(tmp.Stundenanz.ToString());
            //        i.SubItems.Add(tmp.Datum.ToShortDateString());
            //    }
            //}

            else if (typeof(IList<Kategorie>).IsInstanceOfType(values))
            {
                //lv.BeginUpdate();               //mit BeginUpdate und EndUpdate werden nicht sofort neue Bilder gezeichnet(geladen) wenn man Einträge ändert...sondern erst wenn EndUpdate aufgerufen wurde..also wenn ein anderer Button gedrückt wird(zum beispiel, ein anderes form geöffnet wird)...Perfomance besser!

                ////Reste Columns & Items
                //lv.Columns.Clear();             //eventuell später nützlich falls man eine f5 refresh funktion einbaut, da durch refresh eben noch dateneinträge vorhanden sein können...deswegen lieber clear verwenden.
                //lv.Items.Clear();

                lv.Columns.Add("ID");
                lv.Columns.Add("KategorieTyp");

                if (!string.IsNullOrEmpty(search))
                {
                    //values = BusinessLogic.Instance.FindKategorie(search);
                }

                foreach (var item in values)
                {
                    var tmp = (Kategorie)item;

                    ListViewItem i = lv.Items.Add(tmp.ID.ToString());
                    i.Tag = tmp;
                    i.SubItems.Add(tmp.KategorieTyp);
                }
            }

            lv.EndUpdate();
        }

        public void BindTo_ComboBox(ComboBox cb, IEnumerable<BaseObject> values, long id)
        {
            cb.Items.Clear();

            foreach (var item in values)
            {
                cb.Items.Add(item);
                if (item.ID == id)
                {
                    cb.SelectedItem = item;
                }
            }
        }

        public void BindTo_ComboBox2(ComboBox cb, IList values, object o)
        {
            cb.Items.Clear();

            if (typeof(IList<Buchungszeile>).IsInstanceOfType(values))
            {
                List<Buchungszeile> list = new List<Buchungszeile>();
                foreach (var item in values)
                {
                    cb.Items.Add(item);
                    if (o is Ausgangsrechnung)
                    {
                        list = BusinessLogic.Instance.GetBuchungszeileByRechnung(((Ausgangsrechnung)o).ID, "Ausgang");
                    }
                    if (o is Eingangsrechnung)
                    {
                        list = BusinessLogic.Instance.GetBuchungszeileByRechnung(((Eingangsrechnung)o).ID, "Eingang");
                    }
                    foreach (var item2 in list)
                    {
                        if (item2.ID == ((Buchungszeile)item).ID)
                        {
                            cb.Items.Remove(item);
                        }
                    }
                }
            }
            else if (typeof(IList<Kategorie>).IsInstanceOfType(values))
            {
                List<Kategorie> list = new List<Kategorie>();
                foreach (var item in values)
                {
                    cb.Items.Add(item);
                    if (o is Buchungszeile)
                    {
                        list = BusinessLogic.Instance.GetKategorieByBuchung(((Buchungszeile)o).ID);
                    }
                    foreach (var item2 in list)
                    {
                        if (item2.ID == ((Kategorie)item).ID)
                        {
                            cb.Items.Remove(item);
                        }
                    }
                }
            }
        }
        #endregion

        public bool HasErrors
        {
            get { return haserrors; }
        }

    }
}
