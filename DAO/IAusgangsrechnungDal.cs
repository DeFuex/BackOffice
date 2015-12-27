using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IAusgangsrechnungDal
    {
        void Add(Ausgangsrechnung ausgangsrechnung);
        void Update(Ausgangsrechnung ausgangsrechnung);
        void Delete(Ausgangsrechnung ausgangsrechnung);
        List<Ausgangsrechnung> Find(String searchstring);

        List<Ausgangsrechnung> GetAll();
        List<Ausgangsrechnung> GetAllByBuchung(long inputid);
        Ausgangsrechnung GetByID(long id);
    }
}
