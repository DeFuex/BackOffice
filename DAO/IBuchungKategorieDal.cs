using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IBuchungKategorieDal
    {
        void Add(BuchungKategorie buchkat);
        void Update(BuchungKategorie buchkat);
        void Delete(Buchungszeile bz, Kategorie kat);

        List<BuchungKategorie> GetAll();
        BuchungKategorie GetByID(long id);
    }
}
