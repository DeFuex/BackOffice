using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IRechnungszeileDal
    {
        void Add(Rechnungszeile rechnungszeile);
        void Update(Rechnungszeile rechnungszeile);
        void Delete(Rechnungszeile rechnungszeile);
        List<Rechnungszeile> Find(string searchstring);

        List<Rechnungszeile> GetAll();
        Rechnungszeile GetByID(long id);
    }
}
