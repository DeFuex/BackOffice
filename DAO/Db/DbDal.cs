using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;

namespace DAL.Db
{
    public class DbDal : IDal
    {
        
        public SqlConnection DbConnection { get; private set; }
        public IAngebotDal AngebotDal { get; private set; }
        public IAusgangsrechnungDal AusgangsrechnungDal { get; private set; }
        public IBuchungKategorieDal BuchungKategorieDal { get; private set; }
        public IBuchungszeileDal BuchungszeileDal { get; private set; }
        public IEingangsrechnungDal EingangsrechnungDal { get; private set; }
        public IKategorieDal KategorieDal { get; private set; }
        public IKontaktDal KontaktDal { get; private set; }
        public IKundeDal KundeDal { get; private set; }
        public IProjektDal ProjektDal { get; private set; }
        public IRechnungBuchungDal RechnungBuchungDal { get; private set; }
        public IRechnungszeileDal RechnungszeileDal { get; private set; }

        public int ConnectionUserCount { get; set; }


        public DbDal() 
        {
            CreateConnection();

            AngebotDal = new DbAngebotDal(this);
            AusgangsrechnungDal = new DbAusgangsrechnungDal(this);
            BuchungKategorieDal = new DbBuchungKategorieDal(this);
            BuchungszeileDal = new DbBuchungszeileDal(this);
            EingangsrechnungDal = new DbEingangsrechnungDal(this);
            KategorieDal = new DbKategorieDal(this);
            KontaktDal = new DbKontaktDal(this);
            KundeDal = new DbKundeDal(this);
            ProjektDal = new DbProjektDal(this);
            RechnungBuchungDal = new DbRechnungBuchungDal(this);
            RechnungszeileDal = new DbRechnungszeileDal(this);
        }

        private void CreateConnection()
        {
            ConnectionUserCount = 0;
            DbConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"" + Path.GetFullPath("Db\\BackOfficeDb.mdf") + "\";Integrated Security=True;User Instance=True"); //gibt den absoluten pfad des connection strings zurück
        }

        public void UseConnection() 
        {
            if (ConnectionUserCount == 0)
                DbConnection.Open();

            ConnectionUserCount++;
        }

        public void UnuseConnection() 
        {
            ConnectionUserCount--;

            if (ConnectionUserCount == 0)
                DbConnection.Close();       
        }

    }
}
