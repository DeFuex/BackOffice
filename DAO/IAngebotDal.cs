using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IAngebotDal
    {
        void Add(Angebot angebot);
        void Update(Angebot angebot);
        void Delete(Angebot angebot);
        List<Angebot> Find(string suchtext);

        List<Angebot> GetAll();
        Angebot GetByID(long id);
    }
}
