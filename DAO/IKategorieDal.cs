using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IKategorieDal
    {
        void Add(Kategorie kategorie);
        void Update(Kategorie kategorie);
        void Delete(Kategorie kategorie);

        List<Kategorie> GetAll();
        List<Kategorie> GetAllByBuchung(long inputid);
        Kategorie GetByID(long id);
    }
}
