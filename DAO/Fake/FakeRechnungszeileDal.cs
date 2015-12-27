using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL.Fake
{
    public class FakeRechnungszeileDal : IRechnungszeileDal
    {
        public List<Rechnungszeile> Rechnungszeilen { get; private set; }
        public long NextID { get; set; }

        public FakeRechnungszeileDal()
        {
            NextID = 0L;
            Rechnungszeilen = new List<Rechnungszeile>();

            Rechnungszeile rz = new Rechnungszeile();
            rz.AngebotID = 0;
            rz.AusgangsrechnungID = 0;
            rz.Betrag = 100.0;
            rz.Bezeichnung = "Eins";
            Add(rz);

            rz = new Rechnungszeile();
            rz.AngebotID = 1;
            rz.AusgangsrechnungID = 1;
            rz.Betrag = 150.0;
            rz.Bezeichnung = "Zwei";
            Add(rz);
        }




        public void Add(Rechnungszeile rechnungszeile)
        {
            rechnungszeile.ID = NextID;
            NextID++;

            Rechnungszeilen.Add(rechnungszeile);
        }

        public void Update(Rechnungszeile rechnungszeile)
        {
            var oldRechnungszeile = Rechnungszeilen.Where(a => a.ID == rechnungszeile.ID).Single();

            oldRechnungszeile.AngebotID = rechnungszeile.AngebotID;
            oldRechnungszeile.AusgangsrechnungID = rechnungszeile.AusgangsrechnungID;
            oldRechnungszeile.Bezeichnung = rechnungszeile.Bezeichnung;
            oldRechnungszeile.Betrag = rechnungszeile.Betrag;
        }

        public void Delete(Rechnungszeile rechnungszeile)
        {
            Rechnungszeilen.Remove(rechnungszeile);
        }

        public List<Rechnungszeile> GetAll()
        {
            return new List<Rechnungszeile>(Rechnungszeilen);
        }

        public Rechnungszeile GetByID(long id)
        {
            foreach (var rz in Rechnungszeilen)
            {
                if (rz.ID == id)
                {
                    return rz;
                }
            }

            throw new Exception("ID not found");
        }


        public List<Rechnungszeile> Find(string suchtext)
        {
            suchtext = suchtext.ToLower();
            return Rechnungszeilen.Where(row => row.ID.ToString().ToLower().Contains(suchtext) ||
                                         row.Bezeichnung.ToString().ToLower().Contains(suchtext) ||
                                         row.Betrag.ToString().ToLower().Contains(suchtext)
                                  ).ToList();
        }


    }
}
