using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL.Fake
{
    public class FakeEingangsrechnungDal : IEingangsrechnungDal
    {
        public List<Eingangsrechnung> Eingangsrechnungen { get; private set; }
        public long NextID { get; set; }

        public FakeEingangsrechnungDal()
        {
            NextID = 0L;
            Eingangsrechnungen = new List<Eingangsrechnung>();

            Eingangsrechnung er = new Eingangsrechnung();
            er.Summe = 20.0;
            er.Datum = new DateTime(2012, 2, 4);
            er.Beschreibung = "Einnahmen";
            er.Offen = false;
            er.KontaktID = 0;
            Add(er);

            er = new Eingangsrechnung();
            er.Summe = 500.0;
            er.Datum = new DateTime(2012, 8, 13);
            er.Beschreibung = "Kreditrückzahlung";
            er.Offen = true;
            er.KontaktID = 1;
            Add(er);
        }




        public void Add(Eingangsrechnung eingangsrechnung)
        {
            eingangsrechnung.ID = NextID;
            NextID++;

            Eingangsrechnungen.Add(eingangsrechnung);
        }

        public void Update(Eingangsrechnung eingangsrechnung)
        {
            var oldEingangsrechnung = Eingangsrechnungen.Where(a => a.ID == eingangsrechnung.ID).Single();

            oldEingangsrechnung.Summe = eingangsrechnung.Summe;
            oldEingangsrechnung.Datum = eingangsrechnung.Datum;
            oldEingangsrechnung.Beschreibung = eingangsrechnung.Beschreibung;
            oldEingangsrechnung.Offen = eingangsrechnung.Offen;
            oldEingangsrechnung.KontaktID = eingangsrechnung.KontaktID;

        }

        public void Delete(Eingangsrechnung eingangsrechnung)
        {
            Eingangsrechnungen.Remove(eingangsrechnung);
        }

        public List<Eingangsrechnung> GetAll()
        {
            return new List<Eingangsrechnung>(Eingangsrechnungen);
        }

        public List<Eingangsrechnung> GetAllByBuchung(long inputid)
        {
            DAL.Fake.FakeRechnungBuchungDal rbdal = new FakeRechnungBuchungDal();
            List<RechnungBuchung> rb = rbdal.GetAll();
            List<Eingangsrechnung> liste = new List<Eingangsrechnung>();

            foreach (var rechbuch in rb)
            {
                if (rechbuch.BuchungszeilenID == inputid && rechbuch.Rechnungstyp.Equals("Eingang"))
                {
                    liste.Add(GetByID(rechbuch.ID));
                }
            }
            return liste;
        }

        public Eingangsrechnung GetByID(long id)
        {
            foreach (var er in Eingangsrechnungen)
            {
                if (er.ID == id)
                {
                    return er;
                }
            }

            throw new Exception("ID not found");
        }


        public List<Eingangsrechnung> Find(string suchtext)
        {
            suchtext = suchtext.ToLower();
            return Eingangsrechnungen.Where(row => row.ID.ToString().ToLower().Contains(suchtext) ||
                                         row.Summe.ToString().ToLower().Contains(suchtext) ||
                                         row.Datum.ToString().ToLower().Contains(suchtext) ||
                                         row.Beschreibung.ToString().ToLower().Contains(suchtext)
                                  ).ToList();
        }


    }
}
