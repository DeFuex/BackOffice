using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IKontaktDal
    {
        void Add(Kontakt kontakt);
        void Update(Kontakt kontakt);
        void Delete(Kontakt kontakt);
        List<Kontakt> Find(String searchstring);

        List<Kontakt> GetAll();
        Kontakt GetByID(long id);
    }
}
