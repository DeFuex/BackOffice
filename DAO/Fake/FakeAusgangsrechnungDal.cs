using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL.Fake
{
    public class FakeAusgangsrechnungDal : IAusgangsrechnungDal
    {
        public List<Ausgangsrechnung> Ausgangsrechnungen { get; private set; }
        public long NextID { get; set; }

        public FakeAusgangsrechnungDal()
        {
            NextID = 0L;
            Ausgangsrechnungen = new List<Ausgangsrechnung>();

            Ausgangsrechnung ar = new Ausgangsrechnung();
            ar.Summe = 20.0;
            ar.Datum = new DateTime(2012, 3, 28);
            ar.Beschreibung = "Bezahlung Lieferant";
            ar.Gedruckt = true;
            ar.Offen = false;
            ar.ProjektID = 0;
            ar.KundenID = 0;
            Add(ar);

            ar = new Ausgangsrechnung();
            ar.Summe = 50.0;
            ar.Datum = new DateTime(2012, 9, 11);
            ar.Beschreibung = "Miete";
            ar.Gedruckt = false;
            ar.Offen = true;
            ar.ProjektID = 1;
            ar.KundenID = 1;
            Add(ar);
        }




        public void Add(Ausgangsrechnung ausgangsrechnung)
        {
            ausgangsrechnung.ID = NextID;
            NextID++;

            Ausgangsrechnungen.Add(ausgangsrechnung);
        }

        public void Update(Ausgangsrechnung ausgangsrechnung)
        {
            var oldAusgangsrechnung = Ausgangsrechnungen.Where(a => a.ID == ausgangsrechnung.ID).Single();

            oldAusgangsrechnung.KundenID = ausgangsrechnung.KundenID;
            oldAusgangsrechnung.ProjektID = ausgangsrechnung.ProjektID;
            oldAusgangsrechnung.Offen = ausgangsrechnung.Offen;
            oldAusgangsrechnung.Gedruckt = ausgangsrechnung.Gedruckt;
            oldAusgangsrechnung.Beschreibung = ausgangsrechnung.Beschreibung;
            oldAusgangsrechnung.Datum = ausgangsrechnung.Datum;
            oldAusgangsrechnung.Summe = ausgangsrechnung.Summe;
        }

        public void Delete(Ausgangsrechnung ausgangsrechnung)
        {
            Ausgangsrechnungen.Remove(ausgangsrechnung);
        }

        public List<Ausgangsrechnung> GetAll()
        {
            return new List<Ausgangsrechnung>(Ausgangsrechnungen);
        }

        public List<Ausgangsrechnung> GetAllByBuchung(long inputid)
        {
            DAL.Fake.FakeRechnungBuchungDal rbdal = new FakeRechnungBuchungDal();
            List<RechnungBuchung> rb = rbdal.GetAll();
            List<Ausgangsrechnung> liste = new List<Ausgangsrechnung>();

            foreach (var rechbuch in rb)
            {
                if (rechbuch.BuchungszeilenID == inputid && rechbuch.Rechnungstyp.Equals("Ausgang"))
                {
                    liste.Add(GetByID(rechbuch.ID));
                }
            }
            return liste;
        }

        public Ausgangsrechnung GetByID(long id)
        {
            foreach (var ar in Ausgangsrechnungen)
            {
                if (ar.ID == id)
                {
                    return ar;
                }
            }

            throw new Exception("ID not found");
        }


        public List<Ausgangsrechnung> Find(string suchtext)
        {
            suchtext = suchtext.ToLower();
            return Ausgangsrechnungen.Where(row => row.ID.ToString().ToLower().Contains(suchtext) ||
                                         row.Beschreibung.ToString().ToLower().Contains(suchtext) ||
                                         row.Summe.ToString().ToLower().Contains(suchtext) ||
                                         row.Datum.ToString("dd.MM.yyyy HH:mm:ss").ToLower().Contains(suchtext)
                                  ).ToList();
        }


    }
}
