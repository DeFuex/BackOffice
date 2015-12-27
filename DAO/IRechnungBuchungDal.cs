using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IRechnungBuchungDal
    {
        void Add(RechnungBuchung rechbuch);
        void Update(RechnungBuchung rechbuch);
        void DeleteAR(Ausgangsrechnung ar, Buchungszeile bz);
        void DeleteER(Eingangsrechnung er, Buchungszeile bz);

        List<RechnungBuchung> GetAll();
        RechnungBuchung GetByID(long id);
    }
}
