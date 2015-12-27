using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IEingangsrechnungDal
    {
        void Add(Eingangsrechnung eingangsrechnung);
        void Update(Eingangsrechnung eingangsrechnung);
        void Delete(Eingangsrechnung eingangsrechnung);
        List<Eingangsrechnung> Find(string searchstring);

        List<Eingangsrechnung> GetAll();
        List<Eingangsrechnung> GetAllByBuchung(long inputid);
        Eingangsrechnung GetByID(long id);
    }
}
