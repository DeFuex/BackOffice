using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL.Fake
{
    public class FakeBuchungszeileDal : IBuchungszeileDal
    {
        public List<Buchungszeile> Buchungszeilen { get; private set; }
        public long NextID { get; set; }

        public FakeBuchungszeileDal()
        {
            NextID = 0L;
            Buchungszeilen = new List<Buchungszeile>();

            Buchungszeile bz = new Buchungszeile();
            bz.Bankkonto = "2362";
            bz.Rechnungssumme = 100.0;
            bz.Ust = 20.0;
            Add(bz);

            bz = new Buchungszeile();
            bz.Bankkonto = "19027";
            bz.Rechnungssumme = 50.0;
            bz.Ust = 10.0;
            Add(bz);
        }




        public void Add(Buchungszeile buchungszeile)
        {
            buchungszeile.ID = NextID;
            NextID++;

            Buchungszeilen.Add(buchungszeile);
        }

        public void Update(Buchungszeile buchungszeile)
        {
            var oldBuchungszeile = Buchungszeilen.Where(a => a.ID == buchungszeile.ID).Single();

            oldBuchungszeile.Bankkonto = buchungszeile.Bankkonto;
            oldBuchungszeile.Rechnungssumme = buchungszeile.Rechnungssumme;
            oldBuchungszeile.Ust = buchungszeile.Ust;
        }

        public void Delete(Buchungszeile buchungszeile)
        {
            Buchungszeilen.Remove(buchungszeile);
        }

        public List<Buchungszeile> GetAll()
        {
            return new List<Buchungszeile>(Buchungszeilen);
        }

        public List<Buchungszeile> GetAllByRechnung(long inputid, String type)
        {
            DAL.Fake.FakeRechnungBuchungDal rbdal = new FakeRechnungBuchungDal();
            List<RechnungBuchung> rb = rbdal.GetAll();
            List<Buchungszeile> liste = new List<Buchungszeile>();

            foreach (var rechbuch in rb)
            {
                if (rechbuch.RechnungsID == inputid && rechbuch.Rechnungstyp == type)
                {
                    liste.Add(GetByID(rechbuch.ID));
                }
            }
            return liste;
        }

        public Buchungszeile GetByID(long id)
        {
            foreach (var bz in Buchungszeilen)
            {
                if (bz.ID == id)
                {
                    return bz;
                }
            }

            throw new Exception("ID not found");
        }


        public List<Buchungszeile> Find(string suchtext)
        {
            suchtext = suchtext.ToLower();
            return Buchungszeilen.Where(row => row.ID.ToString().ToLower().Contains(suchtext) ||
                                         row.Bankkonto.ToString().ToLower().Contains(suchtext) ||
                                         row.Rechnungssumme.ToString().ToLower().Contains(suchtext) ||
                                         row.Ust.ToString().ToLower().Contains(suchtext)
                                  ).ToList();
        }


    }
}
