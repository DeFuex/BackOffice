using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IBuchungszeileDal
    {
        void Add(Buchungszeile buchungszeile);
        void Update(Buchungszeile buchungszeile);
        void Delete(Buchungszeile buchungszeile);
        List<Buchungszeile> Find(string searchstring);

        List<Buchungszeile> GetAll();
        List<Buchungszeile> GetAllByRechnung(long inputid, String type);
        Buchungszeile GetByID(long id);
    }
}
