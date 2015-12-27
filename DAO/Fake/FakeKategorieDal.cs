using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL.Fake
{
    public class FakeKategorieDal : IKategorieDal
    {
        public List<Kategorie> Kategorien { get; private set; }
        public long NextID { get; set; }

        public FakeKategorieDal()
        {
            NextID = 0L;
            Kategorien = new List<Kategorie>();

            Kategorie kat = new Kategorie();
            kat.KategorieTyp = "Eingang";
            Add(kat);

            kat = new Kategorie();
            kat.KategorieTyp = "Ausgang";
            Add(kat);
        }




        public void Add(Kategorie kategorie)
        {
            kategorie.ID = NextID;
            NextID++;

            Kategorien.Add(kategorie);
        }

        public void Update(Kategorie kategorie)
        {
            var oldKategorie = Kategorien.Where(a => a.ID == kategorie.ID).Single();

            oldKategorie.KategorieTyp = kategorie.KategorieTyp;

        }

        public void Delete(Kategorie kategorie)
        {
            Kategorien.Remove(kategorie);
        }

        public List<Kategorie> GetAll()
        {
            return new List<Kategorie>(Kategorien);
        }

        public List<Kategorie> GetAllByBuchung(long inputid)
        {
            DAL.Fake.FakeBuchungKategorieDal bkdal = new FakeBuchungKategorieDal();
            List<BuchungKategorie> bk = bkdal.GetAll();
            List<Kategorie> liste = new List<Kategorie>();

            foreach (var buchkat in bk)
            {
                if (buchkat.BuchungszeilenID == inputid)
                {
                    liste.Add(GetByID(buchkat.ID));
                }
            }
            return liste;
        }

        public Kategorie GetByID(long id)
        {
            foreach (var kat in Kategorien)
            {
                if (kat.ID == id)
                {
                    return kat;
                }
            }

            throw new Exception("ID not found");
        }


        public List<Kategorie> Find(string suchtext)
        {
            suchtext = suchtext.ToLower();
            return Kategorien.Where(row => row.ID.ToString().ToLower().Contains(suchtext) ||
                                         row.KategorieTyp.ToString().ToLower().Contains(suchtext)
                                  ).ToList();
        }


    }
}
