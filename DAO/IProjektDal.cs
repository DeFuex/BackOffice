using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IProjektDal
    {
        void Add(Projekt projekt);
        void Update(Projekt projekt);
        void Delete(Projekt projekt);
        List<Projekt> Find(string suchtext);

        List<Projekt> GetAll();
        Projekt GetByID(long id);

    }
}
