using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IKundeDal
    {
        void Add(Kunde kunde);
        void Update(Kunde kunde);
        void Delete(Kunde kunde);
        List<Kunde> Find(String searchtext);

        List<Kunde> GetAll();
        Kunde GetByID(long id);
    }
}
