using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL.Fake
{
    public class FakeKundeDal : IKundeDal
    {
        public List<Kunde> Kunden { get; private set; }
        public long NextID { get; set; }

        public FakeKundeDal()
        {
            NextID = 0L;
            Kunden = new List<Kunde>();

            Kunde kun = new Kunde();
            kun.Vorname = "Marie";
            kun.Nachname = "Pilat";
            kun.Email = "marie.pilat@gmx.at";
            kun.Adresse = "Donaustadtstrasse 45";
            kun.Plz = 1220;
            kun.Ort = "Wien";
            kun.Telefon = "066400238z2";
            kun.Bemerkungen = "";
            Add(kun);

            kun = new Kunde();
            kun.Vorname = "Daniel";
            kun.Nachname = "Hausner";
            kun.Email = "daniel.hausner@gmx.at";
            kun.Adresse = "Kleinbaugasse 4";
            kun.Plz = 1120;
            kun.Ort = "Wien";
            kun.Telefon = "067633816100";
            kun.Bemerkungen = "";
            Add(kun);
        }




        public void Add(Kunde kunde)
        {
            kunde.ID = NextID;
            NextID++;

            Kunden.Add(kunde);
        }

        public void Update(Kunde kunde)
        {
            var oldKunde = Kunden.Where(a => a.ID == kunde.ID).Single();

            oldKunde.Vorname = kunde.Vorname;
            oldKunde.Nachname = kunde.Nachname;
            oldKunde.Email = kunde.Email;
            oldKunde.Adresse = kunde.Adresse;
            oldKunde.Plz = kunde.Plz;
            oldKunde.Ort = kunde.Ort;
            oldKunde.Telefon = kunde.Telefon;
            oldKunde.Bemerkungen = kunde.Bemerkungen;

        }

        public void Delete(Kunde kunde)
        {
            Kunden.Remove(kunde);
        }

        public List<Kunde> GetAll()
        {
            return new List<Kunde>(Kunden);
        }

        public Kunde GetByID(long id)
        {
            foreach (var kun in Kunden)
            {
                if (kun.ID == id)
                {
                    return kun;
                }
            }

            throw new Exception("ID not found");
        }


        public List<Kunde> Find(string suchtext)
        {
            suchtext = suchtext.ToLower();
            return Kunden.Where(row => row.ID.ToString().ToLower().Contains(suchtext) ||
                                         row.Vorname.ToString().ToLower().Contains(suchtext) ||
                                         row.Nachname.ToString().ToLower().Contains(suchtext) ||
                                         row.Email.ToString().ToLower().Contains(suchtext) ||
                                         row.Adresse.ToString().ToLower().Contains(suchtext) ||
                                         row.Plz.ToString().ToLower().Contains(suchtext) ||
                                         row.Ort.ToString().ToLower().Contains(suchtext) ||
                                         row.Telefon.ToString().ToLower().Contains(suchtext) ||
                                         row.Bemerkungen.ToString().ToLower().Contains(suchtext)
                                  ).ToList();
        }


    }
}
