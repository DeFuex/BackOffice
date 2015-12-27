using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL.Fake
{
    public class FakeKontaktDal : IKontaktDal
    {
        public List<Kontakt> Kontakte { get; private set; }
        public long NextID { get; set; }

        public FakeKontaktDal()
        {
            NextID = 0L;
            Kontakte = new List<Kontakt>();

            Kontakt kon = new Kontakt();
            kon.Vorname = "Stefan";
            kon.Nachname = "Seidel";
            kon.Email = "stefanseidel@chello.at";
            kon.Firmenname = "UPC";
            kon.Adresse = "Rennbahnweg 4";
            kon.Plz = 1220;
            kon.Ort = "Wien";
            kon.Telefon = "066434338362";
            kon.Bemerkungen = "Techniker";
            Add(kon);

            kon = new Kontakt();
            kon.Vorname = "Michael";
            kon.Nachname = "Bonaus";
            kon.Email = "michaelbonaus@gmx.at";
            kon.Firmenname = "Bank Austria";
            kon.Adresse = "Floridsdorfer Hauptstrasse 33";
            kon.Plz = 1210;
            kon.Ort = "Wien";
            kon.Telefon = "07632382662";
            kon.Bemerkungen = "Berater";
            Add(kon);
        }




        public void Add(Kontakt kontakt)
        {
            kontakt.ID = NextID;
            NextID++;

            Kontakte.Add(kontakt);
        }

        public void Update(Kontakt kontakt)
        {
            var oldKontakt = Kontakte.Where(a => a.ID == kontakt.ID).Single();

            oldKontakt.Vorname = kontakt.Vorname;
            oldKontakt.Nachname = kontakt.Nachname;
            oldKontakt.Email = kontakt.Email;
            oldKontakt.Firmenname = kontakt.Firmenname;
            oldKontakt.Adresse = kontakt.Adresse;
            oldKontakt.Plz = kontakt.Plz;
            oldKontakt.Ort = kontakt.Ort;
            oldKontakt.Telefon = kontakt.Telefon;
            oldKontakt.Bemerkungen = kontakt.Bemerkungen;

        }

        public void Delete(Kontakt kontakt)
        {
            Kontakte.Remove(kontakt);
        }

        public List<Kontakt> GetAll()
        {
            return new List<Kontakt>(Kontakte);
        }

        public Kontakt GetByID(long id)
        {
            foreach (var kon in Kontakte)
            {
                if (kon.ID == id)
                {
                    return kon;
                }
            }

            throw new Exception("ID not found");
        }


        public List<Kontakt> Find(string suchtext)
        {
            suchtext = suchtext.ToLower();
            return Kontakte.Where(row => row.ID.ToString().ToLower().Contains(suchtext) ||
                                         row.Vorname.ToString().ToLower().Contains(suchtext) ||
                                         row.Nachname.ToString().ToLower().Contains(suchtext) ||
                                         row.Email.ToString().ToLower().Contains(suchtext) ||
                                         row.Firmenname.ToString().ToLower().Contains(suchtext) ||
                                         row.Adresse.ToString().ToLower().Contains(suchtext) ||
                                         row.Plz.ToString().ToLower().Contains(suchtext) ||
                                         row.Ort.ToString().ToLower().Contains(suchtext) ||
                                         row.Telefon.ToString().ToLower().Contains(suchtext) ||
                                         row.Bemerkungen.ToString().ToLower().Contains(suchtext)
                                  ).ToList();
        }


    }
}
