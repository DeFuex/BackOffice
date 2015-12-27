using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL.Fake
{
    public class FakeProjektDal : IProjektDal
    {

        public List<Projekt> Projekte { get; private set; }
        public long NextID { get; set; }

        public FakeProjektDal() 
        {
            NextID = 0L;
            Projekte = new List<Projekt>();

            Projekt proj = new Projekt();
            proj.Name = "Timo's Projekt";
            proj.Gesamtzeit = 1.0;
            Add(proj);

            proj = new Projekt();
            proj.Name = "Flo's Projekt";
            proj.Gesamtzeit = 2.0;
            Add(proj);
        }




        public void Add(Projekt projekt)
        {
            projekt.ID = NextID;
            NextID++;

            Projekte.Add(projekt);
        }

        public void Update(Projekt projekt)
        {
            var oldProjekt = Projekte.Where(a => a.ID == projekt.ID).Single();

            oldProjekt.Name = projekt.Name;
            oldProjekt.Gesamtzeit = projekt.Gesamtzeit;

        }

        public void Delete(Projekt projekt)
        {
            Projekte.Remove(projekt);
        }

        public List<Projekt> GetAll()
        {
            return new List<Projekt>(Projekte);
        }

        public Projekt GetByID(long id)
        {
            foreach (var proj in Projekte)
            {
                if (proj.ID == id)
                {
                    return proj;
                }
            }

            throw new Exception("ID not found");
        }


        public List<Projekt> Find(string suchtext)
        {
            suchtext = suchtext.ToLower();
            return Projekte.Where(row => row.ID.ToString().ToLower().Contains(suchtext) ||
                                         row.Name.ToString().ToLower().Contains(suchtext) ||
                                         row.Gesamtzeit.ToString().ToLower().Contains(suchtext)
                                  ).ToList();
        }


    }
}
