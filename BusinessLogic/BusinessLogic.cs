using System.Collections.Generic;
using DAL;
using Domain;

namespace BL
{
    public class BusinessLogic
    {
        #region Singelton

        static BusinessLogic _Instance = null;
        public static BusinessLogic Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BusinessLogic();    //Business Logic greift auf DAL zu und stellt sie der GUI zur Verfügung.

                return _Instance;
            }
        }

        #endregion
        
        protected IDal Dal{ get; private set; }

        private BusinessLogic()
        {
            Dal = DalGenerator.Create();    //wird der DAL erstellt
            
        }

        #region Projekt

        public List<Projekt> FindProjekte(string suchtext)
        {
            return Dal.ProjektDal.Find(suchtext);
        }
        public List<Projekt> GetAllProjekte()
        {
            return Dal.ProjektDal.GetAll();     //da werden alle Daten von der DAL genommen...je nachdem ob die FAKE Datenbank(nicht wirklich eine datenbank) oder ob die DBDao (die richtige Datenbank mit Zugriff per sql befehle), in der app.config, gesetzt ist.
        }
        public Projekt GetProjektByID(long id)
        {
            return Dal.ProjektDal.GetByID(id);
        }
        public void AddProjekt(Projekt pro)     //ruft das hinzufügen vom DAL auf
        {
            Dal.ProjektDal.Add(pro);
        }
        public void DeleteProjekt(Projekt pro)      //ruft das delete vom DAL auf
        {
            Dal.ProjektDal.Delete(pro);
        }
        public void UpdateProjekt(Projekt pro)      //ruft das update vom DAL auf
        {
            Dal.ProjektDal.Update(pro);
        }

        #endregion
        #region Rechnungszeile

        public List<Rechnungszeile> FindRechnungszeilen(string suchtext)
        {
            return Dal.RechnungszeileDal.Find(suchtext);
        }
        public List<Rechnungszeile> GetAllRechnungszeilen()
        {
            return Dal.RechnungszeileDal.GetAll();     //da werden alle Daten von der DAL genommen...je nachdem ob die FAKE Datenbank(nicht wirklich eine datenbank) oder ob die DBDao (die richtige Datenbank mit Zugriff per sql befehle), in der app.config, gesetzt ist.
        }
        public Rechnungszeile GetRechnungszeileByID(long id)
        {
            return Dal.RechnungszeileDal.GetByID(id);
        }
        public void AddRechnungszeile(Rechnungszeile pro)     //ruft das hinzufügen vom DAL auf
        {
            Dal.RechnungszeileDal.Add(pro);
        }
        public void DeleteRechnungszeile(Rechnungszeile pro)      //ruft das delete vom DAL auf
        {
            Dal.RechnungszeileDal.Delete(pro);
        }
        public void UpdateRechnungszeile(Rechnungszeile pro)      //ruft das update vom DAL auf
        {
            Dal.RechnungszeileDal.Update(pro);
        }

        #endregion
        #region Angebot

        public List<Angebot> FindAngebote(string suchtext) 
        {
            return Dal.AngebotDal.Find(suchtext);
        }
        public List<Angebot> GetAllAngebote()
        {
            return Dal.AngebotDal.GetAll();     //da werden alle Daten von der DAL genommen...je nachdem ob die FAKE Datenbank(nicht wirklich eine datenbank) oder ob die DBDao (die richtige Datenbank mit Zugriff per sql befehle), in der app.config, gesetzt ist.
        }
        public Angebot GetAngebotByID(long id)
        {
            return Dal.AngebotDal.GetByID(id);
        }
        public void AddAngebot(Angebot ang)     //ruft das hinzufügen vom DAL auf
        {
            Dal.AngebotDal.Add(ang);
        }
        public void DeleteAngebot(Angebot ang)      //ruft das delete vom DAL auf
        {
            Dal.AngebotDal.Delete(ang);
        }
        public void UpdateAngebot(Angebot ang)      //ruft das update vom DAL auf
        {
            Dal.AngebotDal.Update(ang);
        }

        #endregion
        #region Kunde

        public List<Kunde> FindKunden(string suchtext)
        {
            return Dal.KundeDal.Find(suchtext);
        }
        public List<Kunde> GetAllKunden()
        {
            return Dal.KundeDal.GetAll();     //da werden alle Daten von der DAL genommen...je nachdem ob die FAKE Datenbank(nicht wirklich eine datenbank) oder ob die DBDao (die richtige Datenbank mit Zugriff per sql befehle), in der app.config, gesetzt ist.
        }
        public Kunde GetKundeByID(long id)
        {
            return Dal.KundeDal.GetByID(id);
        }
        public void AddKunde(Kunde pro)     //ruft das hinzufügen vom DAL auf
        {
            Dal.KundeDal.Add(pro);
        }
        public void DeleteKunde(Kunde pro)      //ruft das delete vom DAL auf
        {
            Dal.KundeDal.Delete(pro);
        }
        public void UpdateKunde(Kunde pro)      //ruft das update vom DAL auf
        {
            Dal.KundeDal.Update(pro);
        }

        #endregion
        #region Kontakt

        public List<Kontakt> FindKontakte(string suchtext)
        {
            return Dal.KontaktDal.Find(suchtext);
        }
        public List<Kontakt> GetAllKontakte()
        {
            return Dal.KontaktDal.GetAll();     //da werden alle Daten von der DAL genommen...je nachdem ob die FAKE Datenbank(nicht wirklich eine datenbank) oder ob die DBDao (die richtige Datenbank mit Zugriff per sql befehle), in der app.config, gesetzt ist.
        }
        public Kontakt GetKontaktByID(long id)
        {
            return Dal.KontaktDal.GetByID(id);
        }
        public void AddKontakt(Kontakt pro)     //ruft das hinzufügen vom DAL auf
        {
            Dal.KontaktDal.Add(pro);
        }
        public void DeleteKontakt(Kontakt pro)      //ruft das delete vom DAL auf
        {
            Dal.KontaktDal.Delete(pro);
        }
        public void UpdateKontakt(Kontakt pro)      //ruft das update vom DAL auf
        {
            Dal.KontaktDal.Update(pro);
        }

        #endregion
        #region Ausgangsrechnung

        public List<Ausgangsrechnung> FindAusgangsrechnungen(string suchtext)
        {
            return Dal.AusgangsrechnungDal.Find(suchtext);
        }
        public List<Ausgangsrechnung> GetAllAusgangsrechnungen()
        {
            return Dal.AusgangsrechnungDal.GetAll();     //da werden alle Daten von der DAL genommen...je nachdem ob die FAKE Datenbank(nicht wirklich eine datenbank) oder ob die DBDao (die richtige Datenbank mit Zugriff per sql befehle), in der app.config, gesetzt ist.
        }
        public Ausgangsrechnung GetAusgangsrechnungByID(long id)
        {
            return Dal.AusgangsrechnungDal.GetByID(id);
        }
        public List<Ausgangsrechnung> GetAusgangsrechnungByBuchung(long id)
        {
            return Dal.AusgangsrechnungDal.GetAllByBuchung(id);
        }
        public void AddAusgangsrechnung(Ausgangsrechnung pro)     //ruft das hinzufügen vom DAL auf
        {
            Dal.AusgangsrechnungDal.Add(pro);
        }
        public void DeleteAusgangsrechnung(Ausgangsrechnung pro)      //ruft das delete vom DAL auf
        {
            Dal.AusgangsrechnungDal.Delete(pro);
        }
        public void UpdateAusgangsrechnung(Ausgangsrechnung pro)      //ruft das update vom DAL auf
        {
            Dal.AusgangsrechnungDal.Update(pro);
        }

        #endregion
        #region Eingangsrechnung

        public List<Eingangsrechnung> FindEingangsrechnungen(string suchtext)
        {
            return Dal.EingangsrechnungDal.Find(suchtext);
        }
        public List<Eingangsrechnung> GetAllEingangsrechnungen()
        {
            return Dal.EingangsrechnungDal.GetAll();     //da werden alle Daten von der DAL genommen...je nachdem ob die FAKE Datenbank(nicht wirklich eine datenbank) oder ob die DBDao (die richtige Datenbank mit Zugriff per sql befehle), in der app.config, gesetzt ist.
        }
        public Eingangsrechnung GetEingangsrechnungByID(long id)
        {
            return Dal.EingangsrechnungDal.GetByID(id);
        }
        public List<Eingangsrechnung> GetEingangsrechnungByBuchung(long id)
        {
            return Dal.EingangsrechnungDal.GetAllByBuchung(id);
        }
        public void AddEingangsrechnung(Eingangsrechnung pro)     //ruft das hinzufügen vom DAL auf
        {
            Dal.EingangsrechnungDal.Add(pro);
        }
        public void DeleteEingangsrechnung(Eingangsrechnung pro)      //ruft das delete vom DAL auf
        {
            Dal.EingangsrechnungDal.Delete(pro);
        }
        public void UpdateEingangsrechnung(Eingangsrechnung pro)      //ruft das update vom DAL auf
        {
            Dal.EingangsrechnungDal.Update(pro);
        }

        #endregion
        #region Buchungszeile

        public List<Buchungszeile> FindBuchungszeilen(string suchtext)
        {
            return Dal.BuchungszeileDal.Find(suchtext);
        }
        public List<Buchungszeile> GetAllBuchungszeilen()
        {
            return Dal.BuchungszeileDal.GetAll();     //da werden alle Daten von der DAL genommen...je nachdem ob die FAKE Datenbank(nicht wirklich eine datenbank) oder ob die DBDao (die richtige Datenbank mit Zugriff per sql befehle), in der app.config, gesetzt ist.
        }
        public Buchungszeile GetBuchungszeileByID(long id)
        {
            return Dal.BuchungszeileDal.GetByID(id);
        }
        public List<Buchungszeile> GetBuchungszeileByRechnung(long id, string type)
        {
            return Dal.BuchungszeileDal.GetAllByRechnung(id, type);
        }
        public void AddBuchungszeile(Buchungszeile pro)     //ruft das hinzufügen vom DAL auf
        {
            Dal.BuchungszeileDal.Add(pro);
        }
        public void DeleteBuchungszeile(Buchungszeile pro)      //ruft das delete vom DAL auf
        {
            Dal.BuchungszeileDal.Delete(pro);
        }
        public void UpdateBuchungszeile(Buchungszeile pro)      //ruft das update vom DAL auf
        {
            Dal.BuchungszeileDal.Update(pro);
        }

        #endregion
        #region Kategorie

        public List<Kategorie> GetAllKategorien()
        {
            return Dal.KategorieDal.GetAll();     //da werden alle Daten von der DAL genommen...je nachdem ob die FAKE Datenbank(nicht wirklich eine datenbank) oder ob die DBDao (die richtige Datenbank mit Zugriff per sql befehle), in der app.config, gesetzt ist.
        }
        public Kategorie GetKategorieByID(long id)
        {
            return Dal.KategorieDal.GetByID(id);
        }
        public List<Kategorie> GetKategorieByBuchung(long id)
        {
            return Dal.KategorieDal.GetAllByBuchung(id);
        }
        public void AddKategorie(Kategorie pro)     //ruft das hinzufügen vom DAL auf
        {
            Dal.KategorieDal.Add(pro);
        }
        public void DeleteKategorie(Kategorie pro)      //ruft das delete vom DAL auf
        {
            Dal.KategorieDal.Delete(pro);
        }
        public void UpdateKategorie(Kategorie pro)      //ruft das update vom DAL auf
        {
            Dal.KategorieDal.Update(pro);
        }

        #endregion
        #region RechnungBuchung

        public List<RechnungBuchung> GetAllRechnungBuchung()
        {
            return Dal.RechnungBuchungDal.GetAll();     //da werden alle Daten von der DAL genommen...je nachdem ob die FAKE Datenbank(nicht wirklich eine datenbank) oder ob die DBDao (die richtige Datenbank mit Zugriff per sql befehle), in der app.config, gesetzt ist.
        }
        public RechnungBuchung GetRechnungBuchungByID(long id)
        {
            return Dal.RechnungBuchungDal.GetByID(id);
        }
        public void AddRechnungBuchung(RechnungBuchung pro)     //ruft das hinzufügen vom DAL auf
        {
            Dal.RechnungBuchungDal.Add(pro);
        }
        public void DeleteRechnungBuchungAR(Ausgangsrechnung ar, Buchungszeile bz)      //ruft das delete vom DAL auf
        {
            Dal.RechnungBuchungDal.DeleteAR(ar, bz);
        }
        public void DeleteRechnungBuchungER(Eingangsrechnung er, Buchungszeile bz)      //ruft das delete vom DAL auf
        {
            Dal.RechnungBuchungDal.DeleteER(er, bz);
        }
        public void UpdateRechnungBuchung(RechnungBuchung pro)      //ruft das update vom DAL auf
        {
            Dal.RechnungBuchungDal.Update(pro);
        }

        #endregion
        #region BuchungKategorie

        public List<BuchungKategorie> GetAllBuchungKategorie()
        {
            return Dal.BuchungKategorieDal.GetAll();     //da werden alle Daten von der DAL genommen...je nachdem ob die FAKE Datenbank(nicht wirklich eine datenbank) oder ob die DBDao (die richtige Datenbank mit Zugriff per sql befehle), in der app.config, gesetzt ist.
        }
        public BuchungKategorie GetBuchungKategorieByID(long id)
        {
            return Dal.BuchungKategorieDal.GetByID(id);
        }
        public void AddBuchungKategorie(BuchungKategorie pro)     //ruft das hinzufügen vom DAL auf
        {
            Dal.BuchungKategorieDal.Add(pro);
        }
        public void DeleteBuchungKategorie(Buchungszeile bz, Kategorie kat)
        {
            Dal.BuchungKategorieDal.Delete(bz, kat);
        }
        public void UpdateBuchungKategorie(BuchungKategorie pro)      //ruft das update vom DAL auf
        {
            Dal.BuchungKategorieDal.Update(pro);
        }

        #endregion

    }
}
