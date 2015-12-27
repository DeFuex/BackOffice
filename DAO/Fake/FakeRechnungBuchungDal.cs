using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL.Fake
{
    public class FakeRechnungBuchungDal : IRechnungBuchungDal
    {
        public List<RechnungBuchung> RechnungBuchungen { get; private set; }
        public long NextID { get; set; }

        public FakeRechnungBuchungDal()
        {
            NextID = 0L;
            RechnungBuchungen = new List<RechnungBuchung>();

            RechnungBuchung rb = new RechnungBuchung();
            rb.BuchungszeilenID = 1;
            rb.RechnungsID = 1;
            rb.Rechnungstyp = "Eingang";
            Add(rb);

            rb = new RechnungBuchung();
            rb.BuchungszeilenID = 1;
            rb.RechnungsID = 1;
            rb.Rechnungstyp = "Ausgang";
            Add(rb);
        }




        public void Add(RechnungBuchung rechnungbuchung)
        {
            rechnungbuchung.ID = NextID;
            NextID++;

            RechnungBuchungen.Add(rechnungbuchung);
        }

        public void Update(RechnungBuchung rechnungbuchung)
        {
            var oldRechnungBuchung = RechnungBuchungen.Where(a => a.ID == rechnungbuchung.ID).Single();

            oldRechnungBuchung.BuchungszeilenID = rechnungbuchung.BuchungszeilenID;
            oldRechnungBuchung.RechnungsID = rechnungbuchung.RechnungsID;
            oldRechnungBuchung.Rechnungstyp = rechnungbuchung.Rechnungstyp;
        }

        public void DeleteAR(Ausgangsrechnung ar, Buchungszeile bz)
        {
            foreach (var rb in RechnungBuchungen)
            {
                if (rb.BuchungszeilenID == bz.ID && rb.RechnungsID == ar.ID && rb.Rechnungstyp == "Ausgang")
                {
                    RechnungBuchungen.Remove(rb);
                    return;
                }
            }
        }

        public void DeleteER(Eingangsrechnung er, Buchungszeile bz)
        {
            foreach (var rb in RechnungBuchungen)
            {
                if (rb.BuchungszeilenID == bz.ID && rb.RechnungsID == er.ID && rb.Rechnungstyp == "Eingang")
                {
                    RechnungBuchungen.Remove(rb);
                }
            }
        }

        public List<RechnungBuchung> GetAll()
        {
            return new List<RechnungBuchung>(RechnungBuchungen);
        }

        public RechnungBuchung GetByID(long id)
        {
            foreach (var rb in RechnungBuchungen)
            {
                if (rb.ID == id)
                {
                    return rb;
                }
            }

            throw new Exception("ID not found");
        }

    }
}
