using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL.Fake
{
    public class FakeAngebotDal : IAngebotDal
    {
        public List<Angebot> Angebote { get; private set; }
        public long NextID { get; set; }

        public FakeAngebotDal() 
        {
            NextID = 0L;
            Angebote = new List<Angebot>();

            Angebot ang = new Angebot();
            ang.Datum = new DateTime(2012, 3, 27);
            ang.Summe = 1.0;
            ang.Dauer = 5;
            ang.Chance = 0.231f;
            ang.ProjektID = 0;
            ang.KundenID = 0;
            Add(ang);

            ang = new Angebot();
            ang.Datum = new DateTime(2013, 2, 17);
            ang.Summe = 20.000;
            ang.Dauer = 400;
            ang.Chance = 0.245f;
            ang.ProjektID = 1;
            ang.KundenID = 1;
            Add(ang);
        }




        public void Add(Angebot angebot)
        {
            angebot.ID = NextID; 
            NextID++;

            Angebote.Add(angebot);
        }

        public void Update(Angebot angebot)
        {
            var oldAngebot = Angebote.Where(a => a.ID == angebot.ID).Single();

            oldAngebot.KundenID = angebot.KundenID;
            oldAngebot.ProjektID = angebot.ProjektID;
            oldAngebot.Summe = angebot.Summe;
            oldAngebot.Dauer = angebot.Dauer;
            oldAngebot.Datum = angebot.Datum;
            oldAngebot.Chance = angebot.Chance;
        }

        public void Delete(Angebot angebot)
        {
            Angebote.Remove(angebot);
        }

        public List<Angebot> GetAll()
        {
            return new List<Angebot>(Angebote);
        }

        public Angebot GetByID(long id)
        {
            foreach (var ang in Angebote)
            {
                if (ang.ID == id)
                {
                    return ang;
                }
            }

            throw new Exception("ID not found");
        }


        public List<Angebot> Find(string suchtext) 
        {
            suchtext = suchtext.ToLower();
            return Angebote.Where(row => row.Chance.ToString().ToLower().Contains(suchtext) ||
                                         row.ID.ToString().ToLower().Contains(suchtext) ||
                                         row.Dauer.ToString().ToLower().Contains(suchtext) ||
                                         row.Summe.ToString().ToLower().Contains(suchtext) ||
                                         row.Datum.ToString("dd.MM.yyyy HH:mm:ss").ToLower().Contains(suchtext)
                                  ).ToList();
        }


    }
}
