using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL.Fake
{
    public class FakeBuchungKategorieDal : IBuchungKategorieDal
    {
        public List<BuchungKategorie> BuchungKategorien { get; private set; }
        public long NextID { get; set; }

        public FakeBuchungKategorieDal()
        {
            NextID = 0L;
            BuchungKategorien = new List<BuchungKategorie>();

            BuchungKategorie bk = new BuchungKategorie();
            bk.BuchungszeilenID = 1;
            bk.KategorieID = 1;
            Add(bk);

            bk = new BuchungKategorie();
            bk.BuchungszeilenID = 2;
            bk.KategorieID = 2;
            Add(bk);
        }




        public void Add(BuchungKategorie buchungkategorie)
        {
            buchungkategorie.ID = NextID;
            NextID++;

            BuchungKategorien.Add(buchungkategorie);
        }

        public void Update(BuchungKategorie buchungkategorie)
        {
            var oldBuchungKategorie = BuchungKategorien.Where(a => a.ID == buchungkategorie.ID).Single();

            oldBuchungKategorie.BuchungszeilenID = buchungkategorie.BuchungszeilenID;
            oldBuchungKategorie.KategorieID = buchungkategorie.KategorieID;
        }

        public void Delete(Buchungszeile bz, Kategorie kat)
        {
            foreach (var bk in BuchungKategorien)
            {
                if (bk.BuchungszeilenID == bz.ID && bk.KategorieID == kat.ID)
                {
                    BuchungKategorien.Remove(bk);
                    return;
                }
            }
        }

        public List<BuchungKategorie> GetAll()
        {
            return new List<BuchungKategorie>(BuchungKategorien);
        }

        public BuchungKategorie GetByID(long id)
        {
            foreach (var bk in BuchungKategorien)
            {
                if (bk.ID == id)
                {
                    return bk;
                }
            }

            throw new Exception("ID not found");
        }

    }
}
